using System;
using System.Collections.Generic;
using System.Text;

namespace MoQNaire.Models
{
    class ExamSession
    {
        private ExamName examName;

        public ExamName Name
        {
            get { return examName; }
            set { examName = value; }
        }

        private TimeSpan duration;

        public TimeSpan SessionDuration
        {
            get { return duration; }
            set { duration = value; }
        }

        private QuestionSet questions;

        public QuestionSet SessionQuestionSets
        {
            get { return questions; }
            set { questions = value; }
        }


    }

    public struct ExamName
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private string maintitle;

        public string MainTitle
        {
            get { return maintitle; }
            set { maintitle = value; }
        }
        private string subtitle;

        public string SubTitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        public override string ToString()
        {
            return $"{Subject} - {MainTitle} - {SubTitle}";
        }
    }
    public enum MyEnum
    {
        NotSet = 0,
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Extreme = 4
    }
}
