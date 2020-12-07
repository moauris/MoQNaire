using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MoQNaire.Models;

namespace MoQNaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            /* Testing for the implementation of QuestionSet: IList<Question>
            QuestionSet newSet = new QuestionSet
            {
                new Question("My Question 1"),
                new Question("My Question 2"),
                new Question("My third Question"),
                new Question("我的第四个问题")
            };

            newSet.Insert(2, new Question("插入index 2 的问题"));
            newSet.Insert(2, new Question("再次插入index 2 的问题"));

            Question insertedQuestion = new Question("预备删除的问题");

            newSet.Insert(4, insertedQuestion);
            Debug.WriteLine("预备删除的问题的序号是： " + newSet.IndexOf(insertedQuestion));

            newSet.RemoveAt(6);
            newSet.Remove(insertedQuestion);
            int itemCount = 0;
            foreach (Question item in newSet)
            {
                Debug.WriteLine($"{itemCount}. {item}");
                itemCount++;
            }
            */

            AnswerSet aSet = new AnswerSet()
            {
                new Answer("Big Fish", false),
                new Answer("Big Cat", true),
                new Answer("Small Mouse", false),
                new Answer("Cute Dog", false),
                new Answer("Huge Cat", false),
            };

            Debug.WriteLine(aSet);
        }
    }
}
