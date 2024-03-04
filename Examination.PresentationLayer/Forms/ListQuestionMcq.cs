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
        public static string questionType;
        public ListQuestionMcq()
        {
            InitializeComponent();
            labelQuestionNo.Text = questionType;
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
