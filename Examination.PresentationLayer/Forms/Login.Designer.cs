﻿namespace Examination.PresentationLayer.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_Exit = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txt_Username = new TextBox();
            btn_Login = new CustomMaterialDesign.RButton();
            pictureBox4 = new PictureBox();
            txt_Password = new TextBox();
            radioStudent = new RadioButton();
            radioInstructor = new RadioButton();
            btn_Minimize = new PictureBox();
            btn_showPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 361);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Image = (Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new Point(273, 4);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(35, 28);
            btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Exit.TabIndex = 1;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Location = new Point(75, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Location = new Point(75, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 1);
            panel2.TabIndex = 3;
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Font = new Font("Segoe UI", 9.5F);
            txt_Username.Location = new Point(75, 291);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Enter your username..";
            txt_Username.Size = new Size(190, 17);
            txt_Username.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DarkTurquoise;
            btn_Login.BackgroundColor = Color.DarkTurquoise;
            btn_Login.BorderColor = Color.White;
            btn_Login.BorderRadius = 20;
            btn_Login.BorderSize = 0;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Gabriola", 14F);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(85, 448);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(142, 40);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.TextColor = Color.White;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(107, 503);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(89, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.BorderStyle = BorderStyle.None;
            txt_Password.Font = new Font("Segoe UI", 9.5F);
            txt_Password.Location = new Point(75, 366);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Enter your password..";
            txt_Password.Size = new Size(190, 17);
            txt_Password.TabIndex = 4;
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // radioStudent
            // 
            radioStudent.AutoSize = true;
            radioStudent.BackColor = Color.White;
            radioStudent.Font = new Font("Gabriola", 12F);
            radioStudent.Location = new Point(57, 406);
            radioStudent.Name = "radioStudent";
            radioStudent.Size = new Size(71, 33);
            radioStudent.TabIndex = 7;
            radioStudent.TabStop = true;
            radioStudent.Text = "Student";
            radioStudent.UseVisualStyleBackColor = false;
            // 
            // radioInstructor
            // 
            radioInstructor.AutoSize = true;
            radioInstructor.BackColor = Color.White;
            radioInstructor.Font = new Font("Gabriola", 12F);
            radioInstructor.Location = new Point(174, 406);
            radioInstructor.Name = "radioInstructor";
            radioInstructor.Size = new Size(82, 33);
            radioInstructor.TabIndex = 7;
            radioInstructor.TabStop = true;
            radioInstructor.Text = "Instructor";
            radioInstructor.UseVisualStyleBackColor = false;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Image = (Image)resources.GetObject("btn_Minimize.Image");
            btn_Minimize.Location = new Point(242, 6);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(30, 24);
            btn_Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Minimize.TabIndex = 8;
            btn_Minimize.TabStop = false;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // btn_showPassword
            // 
            btn_showPassword.Image = (Image)resources.GetObject("btn_showPassword.Image");
            btn_showPassword.Location = new Point(265, 365);
            btn_showPassword.Name = "btn_showPassword";
            btn_showPassword.Size = new Size(26, 20);
            btn_showPassword.SizeMode = PictureBoxSizeMode.Zoom;
            btn_showPassword.TabIndex = 1;
            btn_showPassword.TabStop = false;
            btn_showPassword.Click += btn_showPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 547);
            ControlBox = false;
            Controls.Add(btn_Minimize);
            Controls.Add(radioInstructor);
            Controls.Add(radioStudent);
            Controls.Add(pictureBox4);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_showPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox btn_Exit;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_Username;
        private CustomMaterialDesign.RButton btn_Login;
        private PictureBox pictureBox4;
        private TextBox txt_Password;
        private RadioButton radioStudent;
        private RadioButton radioInstructor;
        private PictureBox btn_Minimize;
        private PictureBox btn_showPassword;
    }
}