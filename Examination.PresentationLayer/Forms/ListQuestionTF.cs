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
    public partial class ListQuestionTF : UserControl
    {
        public List<RadioButton>? RadioButtons { get; set; }
        //public List<Answer> Answers { get; set; }

        //public Answer SelectedAnswer { get; set; }
        public List<AnswerViewModel> Answers { get; set; }
        public AnswerViewModel SelectedAnswer { get; set; }

        public ListQuestionTF()
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
        private string _answerT;
        private string _answerF;

        [Category("Custom Props")]
        public string? QuestionContent
        {
            get { return _questionContent; }
            set { txtQuestionContent.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerT
        {
            get { return _answerT; }
            set { _answerT = value; labelTrue.Text = value; }
        }

        [Category("Custom Props")]
        public string AnswerF
        {
            get { return _answerF; }
            set { _answerF = value; labelFalse.Text = value; }
        }
    }
}
