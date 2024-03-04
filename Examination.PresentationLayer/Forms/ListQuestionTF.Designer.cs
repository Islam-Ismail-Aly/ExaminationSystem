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
            txtQuestionContent = new TextBox();
            radioT = new RadioButton();
            radioF = new RadioButton();
            labelTrue = new Label();
            labelFalse = new Label();
            SuspendLayout();
            // 
            // txtQuestionContent
            // 
            txtQuestionContent.BackColor = Color.PaleTurquoise;
            txtQuestionContent.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtQuestionContent.Location = new Point(11, 3);
            txtQuestionContent.Multiline = true;
            txtQuestionContent.Name = "txtQuestionContent";
            txtQuestionContent.ReadOnly = true;
            txtQuestionContent.Size = new Size(389, 43);
            txtQuestionContent.TabIndex = 2;
            // 
            // radioT
            // 
            radioT.AutoSize = true;
            radioT.Font = new Font("Segoe UI", 10.5F);
            radioT.Location = new Point(11, 63);
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
            radioF.Location = new Point(11, 90);
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
            // ListQuestionTF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioF);
            Controls.Add(radioT);
            Controls.Add(labelFalse);
            Controls.Add(labelTrue);
            Controls.Add(txtQuestionContent);
            Name = "ListQuestionTF";
            Size = new Size(411, 113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtQuestionContent;
        public RadioButton? radioT;
        public RadioButton? radioF;
        private Label labelTrue;
        private Label labelFalse;
    }
}
