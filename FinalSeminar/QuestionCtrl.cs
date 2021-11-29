using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSeminar
{
    public partial class QuestionCtrl : UserControl
    {
        //Attribute
        private List<string> lstAns;
        private MulQuestion content;
        private List<AnswerCtrl> lstAnsCtrl = new List<AnswerCtrl>();


        //Properties
        public MulQuestion Content 
        {
            get
            {
                if (!CheckEmptyBox())
                {
                    content = new MulQuestion();
                    //Question
                    content.Ques = txtQues.Text;
                    //Topic
                    content.Topic = cbxTopic.Text;

                    //Answer
                    lstAns = new List<string>();
                    foreach (var i in lstAnsCtrl)
                    {
                        lstAns.Add(i.Answer);
                    }
                    content.Ans = lstAns;
                    
                    //Correct answer
                    int index = cbxCorrectAns.SelectedIndex;
                    content.CorrectAnswer = lstAnsCtrl[index].Answer;
                }
                //else
                    //MessageBox.Show("Please fill out all the boxes!", "Error", MessageBoxButtons.OK);

                return content; 
            }
            set { content = new MulQuestion(value); }
        }
        public string Question 
        {
            get { return txtQues.Text; }
            set { txtQues.Text = value; }
        }

        public ComboBox Topic
        {
            get { return cbxTopic; }
            set { cbxTopic = value; }
        }

        public QuestionCtrl()
        {
            InitializeComponent();
        }

        private void btnPlusAns_Click(object sender, EventArgs e)
        {
            int i = lstAnsCtrl.Count;

            //Create new answer Control
            AnswerCtrl tmpAnsCtrl = new AnswerCtrl();
            tmpAnsCtrl.Location = new Point(15, 100 + i * 53);
            tmpAnsCtrl.Label = $"Answer {i + 1}";

            this.Controls.Add(tmpAnsCtrl);
            lstAnsCtrl.Add(tmpAnsCtrl);
            cbxCorrectAns.Items.Add($"Answer {lstAnsCtrl.Count}");

            //Update the BtnPlus
            UpdateBtnPlus();
        }

        private void QuestionCtrl_Load(object sender, EventArgs e)
        {
            //Default: 4 answer box and close button

            for (int i = 0; i < 4; ++i)
            {
                //Answer Control
                AnswerCtrl tmpAnsCtrl = new AnswerCtrl();
                tmpAnsCtrl.Location = new Point(15, 100 + i * 53);
                tmpAnsCtrl.Label = $"Answer {i + 1}";

                this.Controls.Add(tmpAnsCtrl);
                lstAnsCtrl.Add(tmpAnsCtrl);
                cbxCorrectAns.Items.Add($"Answer {i + 1}");
            }
        }

        public void UpdateAnswer()
        {
            //Check and delete AnsCtrl that are removed
            for (int i = 0; i < lstAnsCtrl.Count; ++i)
            {
                if (lstAnsCtrl[i].isClosed)
                {
                    lstAnsCtrl.RemoveAt(i);
                    cbxCorrectAns.Items.RemoveAt(cbxCorrectAns.Items.Count - 1);
                    --i;
                }
            }

            for (int i = 0; i < lstAnsCtrl.Count; ++i)
            {
                lstAnsCtrl[i].Location = new Point(15, 100 + i * 53);
                lstAnsCtrl[i].Label = $"Answer {i + 1}:";
            }

            UpdateBtnPlus();
        }

        private void UpdateBtnPlus()
        {
            btnPlusAns.Location = new Point(185, (100 + (lstAnsCtrl.Count - 2) * 53) + 100);
        }

        private void QuestionCtrl_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateAnswer();
        }

        public bool CheckEmptyBox()
        {
            //Check question
            if (String.IsNullOrEmpty(txtQues.Text))
                return true;

            //Check topic
            if (String.IsNullOrEmpty(cbxTopic.Text))
                return true;

            //Check answers
            foreach(var i in lstAnsCtrl)
            {
                if (String.IsNullOrEmpty(i.Answer))
                    return true;
            }

            //Check correct answer
            if (String.IsNullOrEmpty(cbxCorrectAns.Text))
                return true;

            return false;
        }
    }
}
