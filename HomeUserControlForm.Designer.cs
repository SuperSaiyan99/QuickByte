namespace Quick_Byte
{
    partial class HomeUserControlForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel4 = new Panel();
            label5 = new Label();
            labelMenuAvailable = new Label();
            panel2 = new Panel();
            label4 = new Label();
            labelTotalSales = new Label();
            dataGridView1 = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(labelMenuAvailable);
            panel4.Location = new Point(526, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 122);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 75);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(143, 25);
            label5.TabIndex = 2;
            label5.Text = "Menu Available";
            // 
            // labelMenuAvailable
            // 
            labelMenuAvailable.AutoSize = true;
            labelMenuAvailable.Font = new Font("Segoe UI", 18F);
            labelMenuAvailable.Location = new Point(77, 33);
            labelMenuAvailable.Name = "labelMenuAvailable";
            labelMenuAvailable.Size = new Size(27, 32);
            labelMenuAvailable.TabIndex = 0;
            labelMenuAvailable.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelTotalSales);
            panel2.Location = new Point(152, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 122);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 68);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(126, 32);
            label4.TabIndex = 1;
            label4.Text = "Total Sales";
            // 
            // labelTotalSales
            // 
            labelTotalSales.AutoSize = true;
            labelTotalSales.Cursor = Cursors.IBeam;
            labelTotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalSales.Location = new Point(96, 24);
            labelTotalSales.Name = "labelTotalSales";
            labelTotalSales.RightToLeft = RightToLeft.No;
            labelTotalSales.Size = new Size(27, 32);
            labelTotalSales.TabIndex = 0;
            labelTotalSales.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(726, 350);
            dataGridView1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // HomeUserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "HomeUserControlForm";
            Size = new Size(886, 670);
            Load += HomeUserControlForm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label5;
        private Label labelMenuAvailable;
        private Panel panel2;
        private Label label4;
        private Label labelTotalSales;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}
