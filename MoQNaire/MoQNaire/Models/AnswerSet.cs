using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MoQNaire.Models
{
    class AnswerSet : IEnumerable<Answer>
    {
        private Answer[] ans = new Answer[5];
        int _count = 0;

        public Answer this[int index]
        {
            get
            {
                return ans[index];
            }
        }
        public void Add(Answer item)
        {

            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i] == null)
                {
                    ans[i] = item;
                    _count++;
                    break;
                }
            }
        }
        public IEnumerator<Answer> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return ans[i];
            }
        }
        public override string ToString()
        {
            StringBuilder resultsb = new StringBuilder();
            foreach (Answer answer in this)
            {
                resultsb.AppendLine(answer.ToString());
            }
            return resultsb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
