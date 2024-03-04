namespace Examination.PresentationLayer.Forms
{
    partial class ListQuestionTF
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
            txtQuestionContent = new TextBox();
            radioT = new RadioButton();
            radioF = new RadioButton();
            labelTrue = new Label();
            labelFalse = new Label();
            labelQuestionNo = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 5;
            label1.Text = "Question";
            // 
            // txtQuestionContent
            // 
            txtQuestionContent.BackColor = Color.PaleTurquoise;
            txtQuestionContent.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtQuestionContent.Location = new Point(136, 12);
            txtQuestionContent.Multiline = true;
            txtQuestionContent.Name = "txtQuestionContent";
            txtQuestionContent.ReadOnly = true;
            txtQuestionContent.Size = new Size(349, 43);
            txtQuestionContent.TabIndex = 2;
            // 
            // radioT
            // 
            radioT.AutoSize = true;
            radioT.Font = new Font("Segoe UI", 10.5F);
            radioT.Location = new Point(11, 60);
            radioT.Name = "radioT";
            radioT.Size = new Size(14, 13);
            radioT.TabIndex = 6;
            radioT.TabStop = true;
            radioT.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Font = new Font("Segoe UI", 10.5F);
            radioF.Location = new Point(11, 89);
            radioF.Name = "radioF";
            radioF.Size = new Size(14, 13);
            radioF.TabIndex = 6;
            radioF.TabStop = true;
            radioF.UseVisualStyleBackColor = true;
            // 
            // labelTrue
            // 
            labelTrue.AutoSize = true;
            labelTrue.Font = new Font("Segoe UI", 10.5F);
            labelTrue.Location = new Point(31, 59);
            labelTrue.Name = "labelTrue";
            labelTrue.Size = new Size(35, 19);
            labelTrue.TabIndex = 5;
            labelTrue.Text = "True";
            // 
            // labelFalse
            // 
            labelFalse.AutoSize = true;
            labelFalse.Font = new Font("Segoe UI", 10.5F);
            labelFalse.Location = new Point(31, 87);
            labelFalse.Name = "labelFalse";
            labelFalse.Size = new Size(39, 19);
            labelFalse.TabIndex = 5;
            labelFalse.Text = "False";
            // 
            // labelQuestionNo
            // 
            labelQuestionNo.AutoSize = true;
            labelQuestionNo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            labelQuestionNo.Location = new Point(80, 12);
            labelQuestionNo.Name = "labelQuestionNo";
            labelQuestionNo.Size = new Size(13, 19);
            labelQuestionNo.TabIndex = 5;
            labelQuestionNo.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.Location = new Point(112, 12);
            label2.Name = "label2";
            label2.Size = new Size(14, 19);
            label2.TabIndex = 5;
            label2.Text = ")";
            // 
            // ListQuestionTF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioF);
            Controls.Add(radioT);
            Controls.Add(labelFalse);
            Controls.Add(labelTrue);
            Controls.Add(label2);
            Controls.Add(labelQuestionNo);
            Controls.Add(label1);
            Controls.Add(txtQuestionContent);
            Name = "ListQuestionTF";
            Size = new Size(503, 113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtQuestionContent;
        private RadioButton radioT;
        private RadioButton radioF;
        private Label labelTrue;
        private Label labelFalse;
        private Label labelQuestionNo;
        private Label label2;
    }
}
