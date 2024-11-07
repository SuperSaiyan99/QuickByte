namespace Quick_Byte
{
    partial class StalluserControlForm
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
            label1 = new Label();
            flowLayoutPanelStalls = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 40);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 4;
            label1.Text = "Stall List";
            // 
            // flowLayoutPanelStalls
            // 
            flowLayoutPanelStalls.Location = new Point(52, 90);
            flowLayoutPanelStalls.Name = "flowLayoutPanelStalls";
            flowLayoutPanelStalls.Size = new Size(776, 524);
            flowLayoutPanelStalls.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(650, 34);
            button1.Name = "button1";
            button1.Size = new Size(178, 34);
            button1.TabIndex = 6;
            button1.Text = "Add New Stall";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StalluserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelStalls);
            Controls.Add(label1);
            Name = "StalluserControlForm";
            Size = new Size(886, 670);
            Load += StalluserControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanelStalls;
        private Button button1;
    }
}
