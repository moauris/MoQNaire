using System;
using System.Collections.Generic;
using System.Text;

namespace MoQNaire.Models
{
    class Question
    {
        public Question(string name)
        {
            question_name = name;
        }
        private string question_name;
        public string QuestionName
        {

            get => question_name;
        }

        public override string ToString()
        {
            return $"{QuestionName}";
        }
    }
}
