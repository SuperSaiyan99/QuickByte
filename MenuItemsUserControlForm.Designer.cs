namespace Quick_Byte
{
    partial class MenuItemsUserControlForm
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
            flowLayoutPanelMenu = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 28);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 3;
            label1.Text = "Menu List";
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.Location = new Point(22, 88);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(828, 554);
            flowLayoutPanelMenu.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(660, 29);
            button1.Name = "button1";
            button1.Size = new Size(178, 34);
            button1.TabIndex = 5;
            button1.Text = "Add New Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuItemsUserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelMenu);
            Controls.Add(label1);
            Name = "MenuItemsUserControlForm";
            Size = new Size(886, 670);
            Load += MenuItemsUserControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelMenu;
        private Button button1;
    }
}
