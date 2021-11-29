
namespace FinalSeminar
{
    partial class QuestionCtrl
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
            this.btnPlusAns = new System.Windows.Forms.Button();
            this.txtQues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCorrectAns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTopic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPlusAns
            // 
            this.btnPlusAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusAns.Location = new System.Drawing.Point(250, 374);
            this.btnPlusAns.Name = "btnPlusAns";
            this.btnPlusAns.Size = new System.Drawing.Size(188, 30);
            this.btnPlusAns.TabIndex = 22;
            this.btnPlusAns.Text = "+";
            this.btnPlusAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusAns.UseVisualStyleBackColor = true;
            this.btnPlusAns.Click += new System.EventHandler(this.btnPlusAns_Click);
            // 
            // txtQues
            // 
            this.txtQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQues.Location = new System.Drawing.Point(97, 22);
            this.txtQues.Name = "txtQues";
            this.txtQues.Size = new System.Drawing.Size(424, 23);
            this.txtQues.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Question: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Topic:";
            // 
            // cbxCorrectAns
            // 
            this.cbxCorrectAns.FormattingEnabled = true;
            this.cbxCorrectAns.Location = new System.Drawing.Point(382, 68);
            this.cbxCorrectAns.Name = "cbxCorrectAns";
            this.cbxCorrectAns.Size = new System.Drawing.Size(121, 24);
            this.cbxCorrectAns.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Correct answer:";
            // 
            // cbxTopic
            // 
            this.cbxTopic.FormattingEnabled = true;
            this.cbxTopic.Location = new System.Drawing.Point(68, 68);
            this.cbxTopic.Name = "cbxTopic";
            this.cbxTopic.Size = new System.Drawing.Size(174, 24);
            this.cbxTopic.TabIndex = 32;
            // 
            // QuestionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCorrectAns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPlusAns);
            this.Controls.Add(this.txtQues);
            this.Controls.Add(this.label1);
            this.Name = "QuestionCtrl";
            this.Size = new System.Drawing.Size(729, 641);
            this.Load += new System.EventHandler(this.QuestionCtrl_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.QuestionCtrl_ControlRemoved);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlusAns;
        private System.Windows.Forms.TextBox txtQues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCorrectAns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTopic;
    }
}
