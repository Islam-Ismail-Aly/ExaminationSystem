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
        public static string questionType;
        public ListQuestionTF()
        {
            InitializeComponent();
            labelQuestionNo.Text = questionType;
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
