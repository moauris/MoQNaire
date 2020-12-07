using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MoQNaire.Models
{
    class QuestionSet : IList<Question>
    {
        private Question[] _content = new Question[0];
        private int _count = 0;
        public Question this[int index] 
        {
            get
            {
                return _content[index];
            }
            set
            {
                _content[index] = value;
            }
        }

        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(Question item)
        {

            Question[] new_content = new Question[_count + 1];
            _content.CopyTo(new_content, 0);
            new_content[_count] = item;
            _content = new_content;
            _count++;
        }

        public void Clear()
        {
            _content = new Question[0];
            _count = 0;
        }

        public bool Contains(Question item)
        {
            for (int i = 0; i < _content.Length; i++)
            {
                if (_content[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(Question[] array, int arrayIndex)
        {
            int j = 0;
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = _content[j];
                j++;
                if (j + 1 > _count) return;
            }
        }

        public IEnumerator<Question> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _content[i];
            }
        }

        public int IndexOf(Question item)
        {
            for (int i = 0; i < _content.Length; i++)
            {
                if (_content[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, Question item)
        {
            Question[] new_content = new Question[_count + 1];
            _content.CopyTo(new_content, 0);
            for (int i = new_content.Length - 1; i > index; i--)
            {
                new_content[i] = new_content[i - 1];
            }
            new_content[index] = item;
            _content = new_content;
            _count++;
        }

        public bool Remove(Question item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }
            else
            {
                RemoveAt(index);
                return true;
            }

        }

        public void RemoveAt(int index)
        {
            Question[] new_content = new Question[_count - 1];
            for (int i = index; i < new_content.Length; i++)
            {
                new_content[i] = _content[i + 1];
            }
            for (int i = index - 1; i >= 0; i--)
            {
                new_content[i] = _content[i];
            }
            _count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
