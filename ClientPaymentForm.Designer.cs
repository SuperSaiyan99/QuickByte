namespace Quick_Byte
{
    partial class ClientPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPaymentForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnCash = new Button();
            btcnCreditCard = new Button();
            btnGcash = new Button();
            btnReceipt = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(424, 163);
            label1.Name = "label1";
            label1.Size = new Size(324, 55);
            label1.TabIndex = 13;
            label1.Text = "QUICK BYTE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(436, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(556, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 42F);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(256, 240);
            label2.Name = "label2";
            label2.Size = new Size(667, 65);
            label2.TabIndex = 16;
            label2.Text = "Select Payment Method";
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.Navy;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCash.ForeColor = SystemColors.ControlLightLight;
            btnCash.Image = Properties.Resources.icons8_wallet_100;
            btnCash.ImageAlign = ContentAlignment.MiddleLeft;
            btnCash.Location = new Point(392, 328);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(356, 130);
            btnCash.TabIndex = 17;
            btnCash.Text = "    Cash (Pay At The Counter)";
            btnCash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // btcnCreditCard
            // 
            btcnCreditCard.BackColor = Color.Navy;
            btcnCreditCard.FlatAppearance.BorderSize = 0;
            btcnCreditCard.FlatStyle = FlatStyle.Flat;
            btcnCreditCard.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btcnCreditCard.ForeColor = SystemColors.ControlLightLight;
            btcnCreditCard.Image = Properties.Resources.icons8_credit_card_64;
            btcnCreditCard.ImageAlign = ContentAlignment.MiddleLeft;
            btcnCreditCard.Location = new Point(392, 482);
            btcnCreditCard.Name = "btcnCreditCard";
            btcnCreditCard.Size = new Size(356, 130);
            btcnCreditCard.TabIndex = 18;
            btcnCreditCard.Text = "    Debit/Credit Card";
            btcnCreditCard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btcnCreditCard.UseVisualStyleBackColor = false;
            btcnCreditCard.Click += btcnCreditCard_Click;
            // 
            // btnGcash
            // 
            btnGcash.BackColor = Color.Navy;
            btnGcash.FlatAppearance.BorderSize = 0;
            btnGcash.FlatStyle = FlatStyle.Flat;
            btnGcash.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGcash.ForeColor = SystemColors.ControlLightLight;
            btnGcash.Image = Properties.Resources.icons8_gcash_100;
            btnGcash.ImageAlign = ContentAlignment.MiddleLeft;
            btnGcash.Location = new Point(392, 641);
            btnGcash.Name = "btnGcash";
            btnGcash.Size = new Size(356, 130);
            btnGcash.TabIndex = 19;
            btnGcash.Text = "    Gcash";
            btnGcash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGcash.UseVisualStyleBackColor = false;
            btnGcash.Click += btnGcash_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.Transparent;
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(611, 820);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(398, 127);
            btnReceipt.TabIndex = 22;
            btnReceipt.Text = "Get Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            btnReceipt.Paint += btnProceed_Paint;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(133, 820);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(398, 127);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Back to Order Summary";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ClientPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 1000);
            Controls.Add(btnReceipt);
            Controls.Add(btnCancel);
            Controls.Add(btnGcash);
            Controls.Add(btcnCreditCard);
            Controls.Add(btnCash);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientPaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientPaymentForm";
            Load += ClientPaymentForm_Load;
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
        private Button btnCash;
        private Button btcnCreditCard;
        private Button btnGcash;
        private Button btnReceipt;
        private Button btnCancel;
    }
}