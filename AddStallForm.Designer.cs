namespace Quick_Byte
{
    partial class AddStallForm
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
            txtStallName = new TextBox();
            label1 = new Label();
            pictureBoxStallLogo = new PictureBox();
            panel1 = new Panel();
            btnBrowseImage = new Button();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStallLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtStallName
            // 
            txtStallName.Location = new Point(131, 304);
            txtStallName.Name = "txtStallName";
            txtStallName.Size = new Size(244, 23);
            txtStallName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 307);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // pictureBoxStallLogo
            // 
            pictureBoxStallLogo.Location = new Point(24, 17);
            pictureBoxStallLogo.Name = "pictureBoxStallLogo";
            pictureBoxStallLogo.Size = new Size(186, 122);
            pictureBoxStallLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStallLogo.TabIndex = 6;
            pictureBoxStallLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnBrowseImage);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBoxStallLogo);
            panel1.Location = new Point(115, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 179);
            panel1.TabIndex = 18;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = Color.Gold;
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Location = new Point(127, 147);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(75, 23);
            btnBrowseImage.TabIndex = 9;
            btnBrowseImage.Text = "Upload";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 151);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Upload Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 31);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 22;
            label3.Text = "Add New Stall List";
            // 
            // button4
            // 
            button4.Location = new Point(266, 512);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 21;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(242, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 61);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(85, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 61);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddStallForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(453, 492);
            Controls.Add(txtStallName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStallForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddStallForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStallLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStallName;
        private Label label1;
        private PictureBox pictureBoxStallLogo;
        private Panel panel1;
        private Button btnBrowseImage;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button btnCancel;
        private Button btnSave;
    }
}