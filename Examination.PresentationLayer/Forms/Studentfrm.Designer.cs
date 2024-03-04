namespace Examination.PresentationLayer.Forms
{
    partial class Studentfrm
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
            ProfileTab = new TabPage();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CreateExamTab = new TabPage();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            tabControl2 = new TabControl();
            tabProfile = new TabPage();
            txtBranch = new TextBox();
            txtDepartment = new TextBox();
            txtSupervisor = new TextBox();
            txtUsername = new TextBox();
            txtStudentName = new TextBox();
            dataGridCourses = new DataGridView();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            tabCreateExam = new TabPage();
            btnGetQuestion = new Button();
            panelQuestion = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            comboCourse = new ComboBox();
            label6 = new Label();
            btnSubmit = new Button();
            ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CreateExamTab.SuspendLayout();
            tabControl2.SuspendLayout();
            tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCourses).BeginInit();
            tabCreateExam.SuspendLayout();
            panelQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // ProfileTab
            // 
            ProfileTab.BackColor = Color.AliceBlue;
            ProfileTab.Controls.Add(dataGridView1);
            ProfileTab.Controls.Add(textBox1);
            ProfileTab.Controls.Add(label2);
            ProfileTab.Controls.Add(label1);
            ProfileTab.Location = new Point(4, 24);
            ProfileTab.Name = "ProfileTab";
            ProfileTab.Padding = new Padding(3);
            ProfileTab.Size = new Size(771, 379);
            ProfileTab.TabIndex = 0;
            ProfileTab.Text = "Profile";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(251, 121);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PowderBlue;
            textBox1.Location = new Point(64, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Courses:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // CreateExamTab
            // 
            CreateExamTab.BackColor = Color.MintCream;
            CreateExamTab.Controls.Add(label3);
            CreateExamTab.Controls.Add(comboBox1);
            CreateExamTab.Controls.Add(button1);
            CreateExamTab.Location = new Point(4, 24);
            CreateExamTab.Name = "CreateExamTab";
            CreateExamTab.Padding = new Padding(3);
            CreateExamTab.Size = new Size(771, 379);
            CreateExamTab.TabIndex = 1;
            CreateExamTab.Text = "Create Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 30);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Course Name:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(17, 97);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 0;
            button1.Text = "Create Exam";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabProfile);
            tabControl2.Controls.Add(tabCreateExam);
            tabControl2.Location = new Point(12, 12);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(779, 562);
            tabControl2.TabIndex = 0;
            // 
            // tabProfile
            // 
            tabProfile.Controls.Add(txtBranch);
            tabProfile.Controls.Add(txtDepartment);
            tabProfile.Controls.Add(txtSupervisor);
            tabProfile.Controls.Add(txtUsername);
            tabProfile.Controls.Add(txtStudentName);
            tabProfile.Controls.Add(dataGridCourses);
            tabProfile.Controls.Add(label9);
            tabProfile.Controls.Add(label5);
            tabProfile.Controls.Add(label8);
            tabProfile.Controls.Add(label10);
            tabProfile.Controls.Add(label7);
            tabProfile.Controls.Add(label4);
            tabProfile.Location = new Point(4, 24);
            tabProfile.Name = "tabProfile";
            tabProfile.Padding = new Padding(3);
            tabProfile.Size = new Size(771, 481);
            tabProfile.TabIndex = 0;
            tabProfile.Text = "Profile";
            tabProfile.UseVisualStyleBackColor = true;
            // 
            // txtBranch
            // 
            txtBranch.BackColor = Color.PowderBlue;
            txtBranch.Location = new Point(452, 17);
            txtBranch.Name = "txtBranch";
            txtBranch.ReadOnly = true;
            txtBranch.Size = new Size(153, 23);
            txtBranch.TabIndex = 2;
            txtBranch.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.PowderBlue;
            txtDepartment.Location = new Point(452, 59);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(153, 23);
            txtDepartment.TabIndex = 2;
            txtDepartment.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSupervisor
            // 
            txtSupervisor.BackColor = Color.PowderBlue;
            txtSupervisor.Location = new Point(103, 102);
            txtSupervisor.Name = "txtSupervisor";
            txtSupervisor.ReadOnly = true;
            txtSupervisor.Size = new Size(153, 23);
            txtSupervisor.TabIndex = 2;
            txtSupervisor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.PowderBlue;
            txtUsername.Location = new Point(103, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(153, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.PowderBlue;
            txtStudentName.Location = new Point(103, 18);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(153, 23);
            txtStudentName.TabIndex = 2;
            txtStudentName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridCourses
            // 
            dataGridCourses.BackgroundColor = Color.PowderBlue;
            dataGridCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCourses.Location = new Point(452, 106);
            dataGridCourses.Name = "dataGridCourses";
            dataGridCourses.Size = new Size(153, 82);
            dataGridCourses.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(354, 17);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 0;
            label9.Text = "Branch :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(355, 106);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 0;
            label5.Text = "Courses :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(354, 59);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 0;
            label8.Text = "Department :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(6, 105);
            label10.Name = "label10";
            label10.Size = new Size(80, 19);
            label10.TabIndex = 0;
            label10.Text = "Supervisor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 0;
            label7.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 0;
            label4.Text = "Name :";
            // 
            // tabCreateExam
            // 
            tabCreateExam.Controls.Add(btnSubmit);
            tabCreateExam.Controls.Add(btnGetQuestion);
            tabCreateExam.Controls.Add(panelQuestion);
            tabCreateExam.Controls.Add(comboCourse);
            tabCreateExam.Controls.Add(label6);
            tabCreateExam.Location = new Point(4, 24);
            tabCreateExam.Name = "tabCreateExam";
            tabCreateExam.Padding = new Padding(3);
            tabCreateExam.Size = new Size(771, 534);
            tabCreateExam.TabIndex = 1;
            tabCreateExam.Text = "Create Exam";
            tabCreateExam.UseVisualStyleBackColor = true;
            // 
            // btnGetQuestion
            // 
            btnGetQuestion.Font = new Font("Segoe UI", 10F);
            btnGetQuestion.Location = new Point(272, 14);
            btnGetQuestion.Name = "btnGetQuestion";
            btnGetQuestion.Size = new Size(118, 35);
            btnGetQuestion.TabIndex = 4;
            btnGetQuestion.Text = "Get Question";
            btnGetQuestion.UseVisualStyleBackColor = true;
            btnGetQuestion.Click += btnGetQuestion_Click;
            // 
            // panelQuestion
            // 
            panelQuestion.Controls.Add(flowLayoutPanel);
            panelQuestion.Location = new Point(6, 62);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(759, 413);
            panelQuestion.TabIndex = 3;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(759, 413);
            flowLayoutPanel.TabIndex = 0;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(95, 21);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(121, 23);
            comboCourse.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 0;
            label6.Text = "Course Name:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(17, 488);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(109, 40);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Studentfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(803, 579);
            Controls.Add(tabControl2);
            Name = "Studentfrm";
            ShowIcon = false;
            Text = "Student";
            Load += Studentfrm_Load;
            ProfileTab.ResumeLayout(false);
            ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CreateExamTab.ResumeLayout(false);
            CreateExamTab.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCourses).EndInit();
            tabCreateExam.ResumeLayout(false);
            tabCreateExam.PerformLayout();
            panelQuestion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Profile;
        private TabControl tabControl1;
        private TabPage ProfileTab;
        private TabPage CreateExamTab;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private TabControl tabControl2;
        private TabPage tabProfile;
        private Label label5;
        private Label label4;
        private TabPage tabCreateExam;
        private TextBox txtStudentName;
        private DataGridView dataGridCourses;
        private ComboBox comboCourse;
        private Label label6;
        private TextBox txtUsername;
        private Label label7;
        private TextBox txtDepartment;
        private Label label8;
        private TextBox txtBranch;
        private Label label9;
        private TextBox txtSupervisor;
        private Label label10;
        private Panel panelQuestion;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnGetQuestion;
        private Button btnSubmit;
    }
}