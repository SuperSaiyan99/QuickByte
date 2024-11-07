namespace Quick_Byte
{
    partial class ClientReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientReceipt));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutReceipt = new FlowLayoutPanel();
            label2 = new Label();
            lblTransactionCode = new Label();
            btnReceipt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(720, 159);
            label1.Name = "label1";
            label1.Size = new Size(324, 55);
            label1.TabIndex = 16;
            label1.Text = "QUICK BYTE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(732, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(852, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutReceipt
            // 
            flowLayoutReceipt.Location = new Point(601, 498);
            flowLayoutReceipt.Name = "flowLayoutReceipt";
            flowLayoutReceipt.Size = new Size(569, 331);
            flowLayoutReceipt.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(633, 255);
            label2.Name = "label2";
            label2.Size = new Size(462, 74);
            label2.TabIndex = 20;
            label2.Text = " We’re Preparing your order!\r\nPlease take your receipt";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransactionCode
            // 
            lblTransactionCode.AutoSize = true;
            lblTransactionCode.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionCode.ForeColor = Color.LightCoral;
            lblTransactionCode.Location = new Point(852, 383);
            lblTransactionCode.Name = "lblTransactionCode";
            lblTransactionCode.Size = new Size(36, 37);
            lblTransactionCode.TabIndex = 21;
            lblTransactionCode.Text = "0";
            lblTransactionCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.Transparent;
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(685, 859);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(398, 127);
            btnReceipt.TabIndex = 23;
            btnReceipt.Text = "Get Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            btnReceipt.Paint += btnReceipt_Paint;
            // 
            // ClientReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1724, 1100);
            Controls.Add(btnReceipt);
            Controls.Add(lblTransactionCode);
            Controls.Add(label2);
            Controls.Add(flowLayoutReceipt);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientReceipt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientReceipt";
            WindowState = FormWindowState.Maximized;
            Load += ClientReceipt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutReceipt;
        private Label label2;
        private Label lblTransactionCode;
        private Panel panel1;
        private Label lblTotalAmount;
        private Button btnReceipt;
    }
}