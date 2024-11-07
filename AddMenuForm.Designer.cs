namespace Quick_Byte
{
    partial class AddMenuForm
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
            label1 = new Label();
            txtTitle = new TextBox();
            txtAmount = new TextBox();
            label2 = new Label();
            pictureBoxMenuImage = new PictureBox();
            panel1 = new Panel();
            btnBrowseImage = new Button();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            button4 = new Button();
            label3 = new Label();
            comboBoxCategory = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenuImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label1.Location = new Point(61, 302);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Menu Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(155, 302);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(244, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(154, 344);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(244, 23);
            txtAmount.TabIndex = 3;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.Location = new Point(61, 344);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // pictureBoxMenuImage
            // 
            pictureBoxMenuImage.Location = new Point(24, 17);
            pictureBoxMenuImage.Name = "pictureBoxMenuImage";
            pictureBoxMenuImage.Size = new Size(186, 122);
            pictureBoxMenuImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenuImage.TabIndex = 6;
            pictureBoxMenuImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBrowseImage);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBoxMenuImage);
            panel1.Location = new Point(114, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 179);
            panel1.TabIndex = 7;
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
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(84, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 61);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(241, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 61);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button4
            // 
            button4.Location = new Point(256, 503);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 27);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 13;
            label3.Text = "Add New Menu";
            label3.Click += label3_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "student_meal", "viand", "rice", "snacks", "beverages" });
            comboBoxCategory.Location = new Point(154, 383);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(244, 23);
            comboBoxCategory.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.Location = new Point(61, 383);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 15;
            label5.Text = "Category";
            // 
            // AddMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 549);
            Controls.Add(label5);
            Controls.Add(comboBoxCategory);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMenuForm";
            Load += AddMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenuImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private TextBox txtAmount;
        private Label label2;
        private PictureBox pictureBoxMenuImage;
        private Panel panel1;
        private Label label4;
        private Button btnBrowseImage;
        private Button btnSave;
        private Button btnCancel;
        private Button button4;
        private Label label3;
        private ComboBox comboBoxCategory;
        private Label label5;
    }
}