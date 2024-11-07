using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;


public class Database : IDisposable
{
    private MySqlConnection connection;
    private string connectionString = "Server=localhost;User ID=root;Password=;";


    public Database()
    {
        connection = new MySqlConnection(connectionString);
        InitializeDatabase();
        EnsureDefaultAdminUser(); // Call this method to ensure the default user is added
    }

    // Implement IDisposable to allow using the 'using' statement
    public void Dispose()
    {
        if (connection != null)
        {
            connection.Dispose();
            connection = null;
        }
    }

    public DataTable GetMenuItems()
    {
        DataTable menuTable = new DataTable();

        try
        {
            connection.Open();

            string query = "SELECT menu_id, title, amount, picture FROM menu_list";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(menuTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }

        return menuTable;
    }


    private void EnsureDefaultAdminUser()
    {
        OpenConnection();

        // Check if the "admin" user already exists
        string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = 'admin'";
        using (MySqlCommand cmd = new MySqlCommand(checkUserQuery, connection))
        {
            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (userCount == 0)
            {

                string defaultUsername = "admin";
                string defaultPassword = HashPassword("superadmin123"); // Hash the default password
                string defaultRole = "administrator";

                string insertUserQuery = @"
                    INSERT INTO users (username, password_hash, role)
                    VALUES (@username, @password, @role)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertUserQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@username", defaultUsername);
                    insertCmd.Parameters.AddWithValue("@password", defaultPassword);
                    insertCmd.Parameters.AddWithValue("@role", defaultRole);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        CloseConnection();
    }

    // Helper method to hash passwords using SHA-256
    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }


    public MySqlConnection GetConnection()
    {
        return connection;
    }

    // Method to open the database connection
    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    // Method to close the database connection
    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Method to ensure the database and table exist
    public void InitializeDatabase()
    {
        // Check if database exists, create it if it doesn't
        using (var tempConnection = new MySqlConnection(connectionString))
        {
            tempConnection.Open();

            // Create the database if it doesn't exist
            string createDbQuery = "CREATE DATABASE IF NOT EXISTS quick_byte";
            using (MySqlCommand cmd = new MySqlCommand(createDbQuery, tempConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        // Update connection string to use the database
        connectionString = "Server=localhost;Database=quick_byte;User ID=root;Password=;";
        connection = new MySqlConnection(connectionString);
        OpenConnection();

        // Check if the users table exists, create it if it doesn't
        string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS users (
                id INT AUTO_INCREMENT PRIMARY KEY,
                username VARCHAR(50) NOT NULL UNIQUE,
                password_hash VARCHAR(255) NOT NULL,
                role VARCHAR(50) NOT NULL
            )";

        using (MySqlCommand cmd = new MySqlCommand(createTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        // Check if the transactions table exists, create it if it doesn't
        string createTransactionsTableQuery = @"
        CREATE TABLE IF NOT EXISTS transactions (
            transaction_id INT AUTO_INCREMENT PRIMARY KEY,
            customer_receipt_code VARCHAR(50) NOT NULL UNIQUE,
            amount DECIMAL(10, 2) NOT NULL,
            transaction_date DATETIME DEFAULT CURRENT_TIMESTAMP
        )";

        using (MySqlCommand cmd = new MySqlCommand(createTransactionsTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        // Check if the menu_list table exists, create it if it doesn't
        string createMenuListTableQuery = @"
        CREATE TABLE IF NOT EXISTS menu_list (
            menu_id INT AUTO_INCREMENT PRIMARY KEY,
            title VARCHAR(100) NOT NULL,
            amount DECIMAL(10, 2) NOT NULL,
            category ENUM('student_meal', 'viand', 'rice', 'snacks', 'beverages'),
            picture VARCHAR(100) NOT NULL
        )";

        using (MySqlCommand cmd = new MySqlCommand(createMenuListTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        // Check if the stall_list table exists, create it if it doesn't
        string createStallListTableQuery = @"
        CREATE TABLE IF NOT EXISTS stall_list (
            stall_id INT AUTO_INCREMENT PRIMARY KEY,
            name VARCHAR(100) NOT NULL,
            logo_path VARCHAR(100) NOT NULL
        )";

        using (MySqlCommand cmd = new MySqlCommand(createStallListTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        string createPurchasedItemsTableQuery = @"
        CREATE TABLE IF NOT EXISTS purchased_items (
            purchase_id INT AUTO_INCREMENT PRIMARY KEY,
            transaction_id INT NOT NULL,
            item_id INT NOT NULL,
            quantity INT NOT NULL,
            price DECIMAL(10, 2) NOT NULL,
            FOREIGN KEY (transaction_id) REFERENCES transactions(transaction_id) ON DELETE CASCADE,
            FOREIGN KEY (item_id) REFERENCES menu_list(menu_id) ON DELETE CASCADE
        )";
        using (MySqlCommand cmd = new MySqlCommand(createPurchasedItemsTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }



        CloseConnection();
    }

    public DataTable GetAllMenuItems()
    {
        DataTable menuTable = new DataTable();

        try
        {
            OpenConnection();

            string query = "SELECT menu_id, name, price, image_path, category FROM menu_list";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(menuTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while retrieving menu items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            CloseConnection();
        }

        return menuTable;
    }


    public DataTable GetMenuItemsByCategory(string category)
    {
        DataTable menuTable = new DataTable();

        try
        {
            OpenConnection();

            string query = "SELECT menu_id, title, amount, picture, category FROM menu_list WHERE category = @category";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@category", category);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(menuTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while retrieving menu items by category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            CloseConnection();
        }

        return menuTable;
    }



    public DataTable GetLatestTransactions()
    {
        DataTable table = new DataTable();

        try
        {
            connection.Open();

            string query = "SELECT * FROM transactions ORDER BY transaction_date DESC LIMIT 5";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(table);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }

        return table;
    }

    public decimal GetTotalSales()
    {
        decimal totalSales = 0;

        try
        {
            connection.Open();

            string query = "SELECT SUM(amount) as Total FROM transactions";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Execute the command and get the result
            object result = cmd.ExecuteScalar();

            // Check if result is not null and parse it to decimal
            if (result != DBNull.Value)
            {
                totalSales = Convert.ToDecimal(result);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }

        return totalSales;
    }

    public decimal GetTotalMenuAvailable()
    {
        int totalMenus = 0;

        try
        {
            connection.Open();

            string query = "SELECT COUNT(menu_id) as Total FROM menu_list"; // Use COUNT to get the number of items
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Execute the command and get the result
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                totalMenus = Convert.ToInt32(result); // Convert to int (32-bit integer)
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }

        return totalMenus;
    }

    public DataTable GetStalls()
    {
        DataTable stallTable = new DataTable();

        try
        {
            connection.Open();

            string query = "SELECT stall_id, name, logo_path FROM stall_list";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(stallTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }

        return stallTable;
    }




}
