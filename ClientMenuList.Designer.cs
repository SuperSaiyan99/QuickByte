namespace Quick_Byte
{
    partial class ClientMenuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMenuList));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnBeverages = new Button();
            btnSnacks = new Button();
            btnRice = new Button();
            btnViand = new Button();
            btnStudentMeal = new Button();
            btnViewOrder = new Button();
            textTotalSum = new TextBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            flowLayoutMenuList = new FlowLayoutPanel();
            panel2 = new Panel();
            flowLayoutItemList = new FlowLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(500, 114);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 7;
            label1.Text = "QUICK BYTE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(500, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(602, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnBeverages);
            panel1.Controls.Add(btnSnacks);
            panel1.Controls.Add(btnRice);
            panel1.Controls.Add(btnViand);
            panel1.Controls.Add(btnStudentMeal);
            panel1.Controls.Add(btnViewOrder);
            panel1.Controls.Add(textTotalSum);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 1000);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.icons8_back_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(11, 11);
            button1.Name = "button1";
            button1.Size = new Size(69, 52);
            button1.TabIndex = 22;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBeverages
            // 
            btnBeverages.FlatStyle = FlatStyle.Flat;
            btnBeverages.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeverages.ForeColor = SystemColors.ActiveCaptionText;
            btnBeverages.Image = (Image)resources.GetObject("btnBeverages.Image");
            btnBeverages.ImageAlign = ContentAlignment.MiddleLeft;
            btnBeverages.Location = new Point(-1, 592);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(424, 71);
            btnBeverages.TabIndex = 21;
            btnBeverages.Text = "      Beverages";
            btnBeverages.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeverages.UseVisualStyleBackColor = true;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // btnSnacks
            // 
            btnSnacks.FlatStyle = FlatStyle.Flat;
            btnSnacks.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSnacks.ForeColor = SystemColors.ActiveCaptionText;
            btnSnacks.Image = (Image)resources.GetObject("btnSnacks.Image");
            btnSnacks.ImageAlign = ContentAlignment.MiddleLeft;
            btnSnacks.Location = new Point(-1, 512);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(424, 71);
            btnSnacks.TabIndex = 20;
            btnSnacks.Text = "      Snacks";
            btnSnacks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSnacks.UseVisualStyleBackColor = true;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnRice
            // 
            btnRice.FlatStyle = FlatStyle.Flat;
            btnRice.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRice.ForeColor = SystemColors.ActiveCaptionText;
            btnRice.Image = (Image)resources.GetObject("btnRice.Image");
            btnRice.ImageAlign = ContentAlignment.MiddleLeft;
            btnRice.Location = new Point(-1, 434);
            btnRice.Name = "btnRice";
            btnRice.Size = new Size(424, 71);
            btnRice.TabIndex = 19;
            btnRice.Text = "      Rice";
            btnRice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRice.UseVisualStyleBackColor = true;
            btnRice.Click += btnRice_Click;
            // 
            // btnViand
            // 
            btnViand.FlatStyle = FlatStyle.Flat;
            btnViand.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViand.ForeColor = SystemColors.ActiveCaptionText;
            btnViand.Image = (Image)resources.GetObject("btnViand.Image");
            btnViand.ImageAlign = ContentAlignment.MiddleLeft;
            btnViand.Location = new Point(-1, 357);
            btnViand.Name = "btnViand";
            btnViand.Size = new Size(424, 71);
            btnViand.TabIndex = 18;
            btnViand.Text = "      Viand";
            btnViand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViand.UseVisualStyleBackColor = true;
            btnViand.Click += btnViand_Click;
            // 
            // btnStudentMeal
            // 
            btnStudentMeal.FlatStyle = FlatStyle.Flat;
            btnStudentMeal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentMeal.ForeColor = SystemColors.ActiveCaptionText;
            btnStudentMeal.Image = (Image)resources.GetObject("btnStudentMeal.Image");
            btnStudentMeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentMeal.Location = new Point(-1, 278);
            btnStudentMeal.Name = "btnStudentMeal";
            btnStudentMeal.Size = new Size(424, 71);
            btnStudentMeal.TabIndex = 17;
            btnStudentMeal.Text = "      Student Meal";
            btnStudentMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudentMeal.UseVisualStyleBackColor = true;
            btnStudentMeal.Click += btnStudentMeal_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.BackColor = Color.Transparent;
            btnViewOrder.FlatAppearance.BorderSize = 0;
            btnViewOrder.ForeColor = SystemColors.ActiveCaptionText;
            btnViewOrder.Location = new Point(39, 830);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(233, 84);
            btnViewOrder.TabIndex = 16;
            btnViewOrder.Text = "View Order";
            btnViewOrder.UseVisualStyleBackColor = false;
            btnViewOrder.Click += btnViewOrder_Click;
            btnViewOrder.Paint += button1_Paint;
            // 
            // textTotalSum
            // 
            textTotalSum.Enabled = false;
            textTotalSum.Location = new Point(29, 766);
            textTotalSum.Name = "textTotalSum";
            textTotalSum.Size = new Size(260, 23);
            textTotalSum.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(114, 699);
            label3.Name = "label3";
            label3.Size = new Size(95, 37);
            label3.TabIndex = 14;
            label3.Text = "Total";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.verde_logo;
            pictureBox3.Location = new Point(57, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(528, 188);
            label2.Name = "label2";
            label2.Size = new Size(221, 40);
            label2.TabIndex = 12;
            label2.Text = "Verda Menu";
            // 
            // flowLayoutMenuList
            // 
            flowLayoutMenuList.AutoScroll = true;
            flowLayoutMenuList.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutMenuList.Location = new Point(363, 257);
            flowLayoutMenuList.Name = "flowLayoutMenuList";
            flowLayoutMenuList.Size = new Size(565, 693);
            flowLayoutMenuList.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(flowLayoutItemList);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(961, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 1000);
            panel2.TabIndex = 14;
            // 
            // flowLayoutItemList
            // 
            flowLayoutItemList.AutoScroll = true;
            flowLayoutItemList.Location = new Point(0, 143);
            flowLayoutItemList.Name = "flowLayoutItemList";
            flowLayoutItemList.Size = new Size(382, 933);
            flowLayoutItemList.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(28, 89);
            label4.Name = "label4";
            label4.Size = new Size(122, 40);
            label4.TabIndex = 15;
            label4.Text = "Items:";
            // 
            // ClientMenuList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 1000);
            Controls.Add(panel2);
            Controls.Add(flowLayoutMenuList);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientMenuList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientMenuList";
            Load += ClientMenuList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private FlowLayoutPanel flowLayoutMenuList;
        private PictureBox pictureBox3;
        private Button btnViewOrder;
        private TextBox textTotalSum;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private FlowLayoutPanel flowLayoutItemList;
        private Button btnBeverages;
        private Button btnSnacks;
        private Button btnRice;
        private Button btnViand;
        private Button btnStudentMeal;
        private Button button1;
    }
}