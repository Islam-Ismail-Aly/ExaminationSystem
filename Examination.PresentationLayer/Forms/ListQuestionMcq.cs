using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination.PresentationLayer.Forms
{
    public partial class ListQuestionMcq : UserControl
    {
        public List<RadioButton>? RadioButtons { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
        //public List<Answer> Answers { get; set; }
        //public Answer SelectedAnswer { get; set; }
        public AnswerViewModel SelectedAnswer { get; set; }

        public ListQuestionMcq()
        {
            InitializeComponent();
            RadioButtons = new List<RadioButton>();
        }

        private void GetSelectedAnswer()
        {
            for (int i = 0; i < RadioButtons.Count; i++)
            {
                if (RadioButtons[i].Checked)
                {
                    SelectedAnswer = Answers[i];
                    return;
                }
            }
        }

        public int GetCorrection()
        {
            int gradeFlag = 1;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].Correction.Value != RadioButtons[i].Checked)
                {
                    gradeFlag = 0;
                    break;
                }
            }
            GetSelectedAnswer();
            return gradeFlag;
        }

        private string _questionContent;
        private string _answerA;
        private string _answerB;
        private string _answerC;
        private string _answerD;

        [Category("Custom Props")]
        public string QuestionContent
        {
            get { return _questionContent; }
            set { _questionContent = value;  txtQuestionContent.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerA
        {
            get { return _answerA; }
            set { _answerA = value; labelA.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerB
        {
            get { return _answerB; }
            set { _answerB = value; labelB.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerC
        {
            get { return _answerC; }
            set { _answerC = value; labelC.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerD
        {
            get { return _answerD; }
            set { _answerD = value; labelD.Text = value; }
        }
    }
}
