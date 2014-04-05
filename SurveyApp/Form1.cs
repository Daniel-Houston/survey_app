using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survey;

namespace SurveyApp
{
    public partial class Form1 : Form
    {
        SurveyModelControl surveyController;

        public Form1()
        {
            InitializeComponent();

            surveyController = new SurveyModelControl();
        }

        private void beginSurveyBtn_Click(object sender, EventArgs e)
        {
            String name = nameText.Text;
            String studentId = studentIDText.Text;

            surveyController.addAnswer(name);
            surveyController.addAnswer(studentId);

            panel1.Hide();
            panel2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            surveyController.saveFile(nameText.Text + ".csv");
            this.Close();
        }
    }
}
