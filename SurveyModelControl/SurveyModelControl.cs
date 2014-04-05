using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Survey
{

    public class SurveyModelControl
    {
        StringBuilder answers;

        public SurveyModelControl()
        {
            answers = new StringBuilder();
        }

        public void addAnswer(String nextAnswer)
        {
            answers.Append(nextAnswer + ",");
        }

        public void saveFile(String filename)
        {
            File.WriteAllText(filename, answers.ToString().Substring(0, answers.Length - 1));
        }

    }
}