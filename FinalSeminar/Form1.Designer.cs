
namespace FinalSeminar
{
    partial class Form1
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
            FinalSeminar.MulQuestion mulQuestion1 = new FinalSeminar.MulQuestion();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionDatabase1 = new FinalSeminar.QuestionDatabase();
            this.questionCtrl1 = new FinalSeminar.QuestionCtrl();
            this.SuspendLayout();
            // 
            // questionDatabase1
            // 
            this.questionDatabase1.Location = new System.Drawing.Point(661, 32);
            this.questionDatabase1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionDatabase1.Name = "questionDatabase1";
            this.questionDatabase1.Size = new System.Drawing.Size(343, 428);
            this.questionDatabase1.TabIndex = 1;
            // 
            // questionCtrl1
            // 
            mulQuestion1.Ans = ((System.Collections.Generic.List<string>)(resources.GetObject("mulQuestion1.Ans")));
            mulQuestion1.CorrectAnswer = null;
            mulQuestion1.Ques = "";
            mulQuestion1.Topic = "";
            this.questionCtrl1.Content = mulQuestion1;
            this.questionCtrl1.Location = new System.Drawing.Point(-7, -1);
            this.questionCtrl1.Name = "questionCtrl1";
            this.questionCtrl1.Question = "";
            this.questionCtrl1.Size = new System.Drawing.Size(729, 644);
            this.questionCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 471);
            this.Controls.Add(this.questionDatabase1);
            this.Controls.Add(this.questionCtrl1);
            this.Name = "Form1";
            this.Text = "Question Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private QuestionCtrl questionCtrl1;
        private QuestionDatabase questionDatabase1;
    }
}

