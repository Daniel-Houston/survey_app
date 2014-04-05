namespace SurveyApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.studentIDText = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.beginSurveyBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Survey";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(62, 76);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(139, 20);
            this.nameText.TabIndex = 1;
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(63, 50);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(123, 13);
            this.EnterNameLabel.TabIndex = 2;
            this.EnterNameLabel.Text = "Please Enter Your Name";
            // 
            // studentIDText
            // 
            this.studentIDText.Location = new System.Drawing.Point(62, 177);
            this.studentIDText.Name = "studentIDText";
            this.studentIDText.Size = new System.Drawing.Size(139, 20);
            this.studentIDText.TabIndex = 3;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(59, 151);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(146, 13);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Please Enter Your Student ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.beginSurveyBtn);
            this.panel1.Controls.Add(this.studentIDText);
            this.panel1.Controls.Add(this.EnterNameLabel);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Location = new System.Drawing.Point(84, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 344);
            this.panel1.TabIndex = 5;
            // 
            // beginSurveyBtn
            // 
            this.beginSurveyBtn.Location = new System.Drawing.Point(371, 126);
            this.beginSurveyBtn.Name = "beginSurveyBtn";
            this.beginSurveyBtn.Size = new System.Drawing.Size(100, 45);
            this.beginSurveyBtn.TabIndex = 5;
            this.beginSurveyBtn.Text = "Begin Survey";
            this.beginSurveyBtn.UseVisualStyleBackColor = true;
            this.beginSurveyBtn.Click += new System.EventHandler(this.beginSurveyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(84, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 344);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save and Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Great! You are finished!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.TextBox studentIDText;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button beginSurveyBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

