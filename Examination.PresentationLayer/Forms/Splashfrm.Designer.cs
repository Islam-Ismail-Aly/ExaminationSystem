namespace Examination.PresentationLayer.Forms
{
    partial class Splashfrm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashfrm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel_2 = new Panel();
            panel_1 = new Panel();
            timer_1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(101, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel_2
            // 
            panel_2.Location = new Point(1, 290);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(526, 18);
            panel_2.TabIndex = 2;
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.DarkTurquoise;
            panel_1.Location = new Point(1, 290);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(30, 18);
            panel_1.TabIndex = 2;
            // 
            // timer_1
            // 
            timer_1.Interval = 15;
            timer_1.Tick += timer_1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(120, 176);
            label1.Name = "label1";
            label1.Size = new Size(284, 74);
            label1.TabIndex = 3;
            label1.Text = "Examination System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Location = new Point(173, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 3);
            panel2.TabIndex = 4;
            // 
            // Splashfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 309);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel_1);
            Controls.Add(panel_2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splashfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splashfrm";
            Load += Splashfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel_2;
        private Panel panel_1;
        private System.Windows.Forms.Timer timer_1;
        private Label label1;
        private Panel panel2;
    }
}