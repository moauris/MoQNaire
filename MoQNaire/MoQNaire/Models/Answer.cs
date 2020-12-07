using System;
using System.Collections.Generic;
using System.Text;

namespace MoQNaire.Models
{
    class Answer
    {
        public Answer() { }
        public Answer(string statement, bool iscorrect)
        {
            AnswerStatement = statement;
            IsCorrect = iscorrect;
        }
        private string answer_statement;

        public string AnswerStatement
        {
            get { return answer_statement; }
            set { answer_statement = value; }
        }
        private bool _iscorrenct;

        public bool IsCorrect
        {
            get { return _iscorrenct; }
            set { _iscorrenct = value; }
        }

        public override string ToString()
        {
            string correctness = IsCorrect ? "Correct" : "Wrong";
            return $"{AnswerStatement}, {correctness}";
        }
    }
}
