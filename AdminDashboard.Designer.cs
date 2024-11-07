namespace Quick_Byte
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            homeUserControlForm1 = new HomeUserControlForm();
            menuItemsUserControlForm1 = new MenuItemsUserControlForm();
            stalluserControlForm1 = new StalluserControlForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 702);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = Properties.Resources.home_logo1;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 339);
            button4.Name = "button4";
            button4.Size = new Size(188, 71);
            button4.TabIndex = 5;
            button4.Text = "      Stall List";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.home_logo1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 603);
            button2.Name = "button2";
            button2.Size = new Size(188, 71);
            button2.TabIndex = 4;
            button2.Text = "      Logout";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = Properties.Resources.home_logo1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 262);
            button3.Name = "button3";
            button3.Size = new Size(188, 71);
            button3.TabIndex = 3;
            button3.Text = "      Menu List";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.home_logo1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 185);
            button1.Name = "button1";
            button1.Size = new Size(192, 71);
            button1.TabIndex = 1;
            button1.Text = "      Home";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_complete;
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // homeUserControlForm1
            // 
            homeUserControlForm1.AutoSize = true;
            homeUserControlForm1.BackColor = Color.White;
            homeUserControlForm1.Location = new Point(202, 0);
            homeUserControlForm1.Name = "homeUserControlForm1";
            homeUserControlForm1.Size = new Size(863, 702);
            homeUserControlForm1.TabIndex = 2;
            // 
            // menuItemsUserControlForm1
            // 
            menuItemsUserControlForm1.Location = new Point(197, 0);
            menuItemsUserControlForm1.Name = "menuItemsUserControlForm1";
            menuItemsUserControlForm1.Size = new Size(868, 702);
            menuItemsUserControlForm1.TabIndex = 3;
            // 
            // stalluserControlForm1
            // 
            stalluserControlForm1.Location = new Point(202, 1);
            stalluserControlForm1.Name = "stalluserControlForm1";
            stalluserControlForm1.Size = new Size(863, 701);
            stalluserControlForm1.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 702);
            Controls.Add(homeUserControlForm1);
            Controls.Add(panel1);
            Controls.Add(menuItemsUserControlForm1);
            Controls.Add(stalluserControlForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private HomeUserControlForm homeUserControlForm1;
        private MenuItemsUserControlForm menuItemsUserControlForm1;
        private Button button2;
        private Button button4;
        private StalluserControlForm stalluserControlForm1;
    }
}