using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace stackqueue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<student> students = new List<student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void vd_Click(object sender, RoutedEventArgs e)
        //{
        //    Queue queuevalue = new Queue();

        //    queuevalue.Enqueue("saran1");
        //    queuevalue.Enqueue("saran2");
        //    queuevalue.Enqueue("saran3");
        //    object val = queuevalue.Peek();
        //    queuevalue.Dequeue();
        //    foreach (var item in queuevalue)
        //    {
        //        MessageBox.Show(item.ToString());
        //    }

        //}



        private void reg_Click(object sender, RoutedEventArgs e)
        {
            var studentList = from List in students
                              where List.names == name.Text
                              select List;
            if (studentList == null)
            {
                Add.Text = studentList.FirstOrDefault().address;
            }
            student studentlist = new student();
            studentlist.names = name.Text;
            studentlist.age = Convert.ToUInt16(age.Text);
            studentlist.address = Add.Text;
            studentlist.city = city.Text;
            studentlist.state = state.Text;
            students.Add(studentlist);
            students.AddRange(students);
            students.Count();
            students.Remove(studentlist);
            cmb.ItemsSource = null;
            cmb.DisplayMemberPath = "city";
            cmb.ItemsSource = students;
            // students.Add(new student { name = "theraksha", age = 20, city = "coimbatore", state = "taminadu" });
            List<string> names = new List<string>();
            names.Add("sathiya");
            foreach (var item in students)
            {
                MessageBox.Show(item.ToString());
            }
            Stack stackvalue = new Stack();
            stackvalue.Push("sathiya1");
            stackvalue.Push("sathiya2");
            stackvalue.Push("sathiya3");
            object value = stackvalue.Peek();
            stackvalue.Pop();
            foreach (var item in stackvalue)
            {
                MessageBox.Show(item.ToString());
            }
            Queue queuevalue = new Queue();

            queuevalue.Enqueue("rupa1");
            queuevalue.Enqueue("rupa2");
            queuevalue.Enqueue("rupa3");
            object val = queuevalue.Peek();
            queuevalue.Dequeue();
            foreach (var item in queuevalue)
            {
                MessageBox.Show(item.ToString());
            }
        }


        public class student
        {
            public string names { get; set; }
            public int age { get; set; }
            public int phoneno { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }

        }
            //private void Medical_Click(object sender, RoutedEventArgs e)
            //{
            //    Stack stackvalue = new Stack();
            //    stackvalue.Push("theraksha1");
            //    stackvalue.Push("theraksha2");
            //    stackvalue.Push("theraksha3");
            //    object value = stackvalue.Peek();

            //    foreach (var item in stackvalue)
            //    {
            //        MessageBox.Show(item.ToString());
            //    }

            //}
    }
}
