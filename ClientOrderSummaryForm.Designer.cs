namespace Quick_Byte
{
    partial class ClientOrderSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientOrderSummaryForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            flowLayoutOrderSummary = new FlowLayoutPanel();
            label4 = new Label();
            lblTotalAmount = new Label();
            btnCancel = new Button();
            btnProceed = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(716, 171);
            label1.Name = "label1";
            label1.Size = new Size(324, 55);
            label1.TabIndex = 10;
            label1.Text = "QUICK BYTE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(729, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(849, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 42F);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(636, 251);
            label2.Name = "label2";
            label2.Size = new Size(463, 65);
            label2.TabIndex = 13;
            label2.Text = "Order Summary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(296, 313);
            label3.Name = "label3";
            label3.Size = new Size(127, 43);
            label3.TabIndex = 14;
            label3.Text = "Verda";
            // 
            // flowLayoutOrderSummary
            // 
            flowLayoutOrderSummary.AutoScroll = true;
            flowLayoutOrderSummary.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutOrderSummary.Location = new Point(285, 368);
            flowLayoutOrderSummary.Name = "flowLayoutOrderSummary";
            flowLayoutOrderSummary.Size = new Size(1174, 307);
            flowLayoutOrderSummary.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(1328, 690);
            label4.Name = "label4";
            label4.Size = new Size(109, 43);
            label4.TabIndex = 16;
            label4.Text = "Total";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.LightCoral;
            lblTotalAmount.Location = new Point(1328, 747);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(41, 43);
            lblTotalAmount.TabIndex = 17;
            lblTotalAmount.Text = "0";
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(374, 825);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(398, 127);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Back to Menu";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Transparent;
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(869, 825);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(398, 127);
            btnProceed.TabIndex = 20;
            btnProceed.Text = "Proceed to Checkout";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            btnProceed.Paint += btnProceed_Paint;
            // 
            // ClientOrderSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1746, 977);
            Controls.Add(btnProceed);
            Controls.Add(btnCancel);
            Controls.Add(lblTotalAmount);
            Controls.Add(label4);
            Controls.Add(flowLayoutOrderSummary);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientOrderSummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientOrderSummaryForm";
            WindowState = FormWindowState.Maximized;
            Load += ClientOrderSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutOrderSummary;
        private Label label4;
        private Label lblTotalAmount;
        private Button btnCancel;
        private Button btnProceed;
    }
}