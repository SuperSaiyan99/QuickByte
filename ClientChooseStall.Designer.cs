﻿namespace Quick_Byte
{
    partial class ClientChooseStall
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutStall = new FlowLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(375, 203);
            label1.Name = "label1";
            label1.Size = new Size(324, 55);
            label1.TabIndex = 4;
            label1.Text = "QUICK BYTE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.mapua_logo;
            pictureBox2.Location = new Point(283, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_complete;
            pictureBox1.Location = new Point(488, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutStall
            // 
            flowLayoutStall.AutoScroll = true;
            flowLayoutStall.Location = new Point(145, 419);
            flowLayoutStall.Name = "flowLayoutStall";
            flowLayoutStall.Size = new Size(859, 581);
            flowLayoutStall.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(271, 313);
            label2.Name = "label2";
            label2.Size = new Size(585, 75);
            label2.TabIndex = 8;
            label2.Text = "Choose Your Stall";
            // 
            // ClientChooseStall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1118, 1000);
            Controls.Add(label2);
            Controls.Add(flowLayoutStall);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientChooseStall";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientChooseStall";
            Load += ClientChooseStall_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutStall;
        private Label label2;
    }
}