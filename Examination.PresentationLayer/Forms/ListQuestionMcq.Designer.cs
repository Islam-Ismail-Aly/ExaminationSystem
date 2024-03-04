namespace Examination.PresentationLayer.Forms
{
    partial class ListQuestionMcq
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
            txtQuestionContent = new TextBox();
            labelA = new Label();
            labelB = new Label();
            labelD = new Label();
            radioA = new RadioButton();
            radioB = new RadioButton();
            radioD = new RadioButton();
            labelC = new Label();
            radioC = new RadioButton();
            label2 = new Label();
            labelQuestionNo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtQuestionContent
            // 
            txtQuestionContent.BackColor = Color.PaleTurquoise;
            txtQuestionContent.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtQuestionContent.Location = new Point(158, 13);
            txtQuestionContent.Multiline = true;
            txtQuestionContent.Name = "txtQuestionContent";
            txtQuestionContent.ReadOnly = true;
            txtQuestionContent.Size = new Size(345, 43);
            txtQuestionContent.TabIndex = 0;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 10.5F);
            labelA.Location = new Point(66, 76);
            labelA.Name = "labelA";
            labelA.Size = new Size(30, 19);
            labelA.TabIndex = 1;
            labelA.Text = "(A) ";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 10.5F);
            labelB.Location = new Point(66, 121);
            labelB.Name = "labelB";
            labelB.Size = new Size(25, 19);
            labelB.TabIndex = 1;
            labelB.Text = "(B)";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Segoe UI", 10.5F);
            labelD.Location = new Point(66, 216);
            labelD.Name = "labelD";
            labelD.Size = new Size(27, 19);
            labelD.TabIndex = 1;
            labelD.Text = "(D)";
            // 
            // radioA
            // 
            radioA.AutoSize = true;
            radioA.Font = new Font("Segoe UI", 10.5F);
            radioA.Location = new Point(11, 74);
            radioA.Name = "radioA";
            radioA.Size = new Size(44, 23);
            radioA.TabIndex = 2;
            radioA.TabStop = true;
            radioA.Text = "(A)";
            radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            radioB.AutoSize = true;
            radioB.Font = new Font("Segoe UI", 10.5F);
            radioB.Location = new Point(11, 119);
            radioB.Name = "radioB";
            radioB.Size = new Size(43, 23);
            radioB.TabIndex = 2;
            radioB.TabStop = true;
            radioB.Text = "(B)";
            radioB.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            radioD.AutoSize = true;
            radioD.Font = new Font("Segoe UI", 10.5F);
            radioD.Location = new Point(11, 214);
            radioD.Name = "radioD";
            radioD.Size = new Size(45, 23);
            radioD.TabIndex = 2;
            radioD.TabStop = true;
            radioD.Text = "(D)";
            radioD.UseVisualStyleBackColor = true;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Segoe UI", 10.5F);
            labelC.Location = new Point(66, 169);
            labelC.Name = "labelC";
            labelC.Size = new Size(26, 19);
            labelC.TabIndex = 1;
            labelC.Text = "(C)";
            // 
            // radioC
            // 
            radioC.AutoSize = true;
            radioC.Font = new Font("Segoe UI", 10.5F);
            radioC.Location = new Point(11, 167);
            radioC.Name = "radioC";
            radioC.Size = new Size(44, 23);
            radioC.TabIndex = 2;
            radioC.TabStop = true;
            radioC.Text = "(C)";
            radioC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.Location = new Point(126, 16);
            label2.Name = "label2";
            label2.Size = new Size(14, 19);
            label2.TabIndex = 6;
            label2.Text = ")";
            // 
            // labelQuestionNo
            // 
            labelQuestionNo.AutoSize = true;
            labelQuestionNo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            labelQuestionNo.Location = new Point(80, 16);
            labelQuestionNo.Name = "labelQuestionNo";
            labelQuestionNo.Size = new Size(13, 19);
            labelQuestionNo.TabIndex = 7;
            labelQuestionNo.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 8;
            label1.Text = "Question";
            // 
            // ListQuestionMcq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(labelQuestionNo);
            Controls.Add(label1);
            Controls.Add(radioD);
            Controls.Add(radioC);
            Controls.Add(radioB);
            Controls.Add(radioA);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(txtQuestionContent);
            Name = "ListQuestionMcq";
            Size = new Size(518, 246);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestionContent;
        private Label labelA;
        private Label labelB;
        private Label labelD;
        private RadioButton radioA;
        private RadioButton radioB;
        private RadioButton radioButton3;
        private RadioButton radioD;
        private Label labelC;
        private RadioButton radioC;
        private Label label2;
        private Label labelQuestionNo;
        private Label label1;
    }
}
