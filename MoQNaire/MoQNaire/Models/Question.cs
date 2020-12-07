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

        private string question_statement;

        public string QuestionStatement
        {
            get { return question_statement; }
            set { question_statement = value; }
        }

        private AnswerSet ans;

        public AnswerSet Answers
        {
            get { return ans; }
            set { ans = value; }
        }



        public override string ToString()
        {
            return $"{QuestionName}";
        }
    }
}
