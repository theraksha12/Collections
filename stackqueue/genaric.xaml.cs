using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace stackqueue
{

    /// <summary>
    /// Interaction logic for employee.xaml
    /// </summary>
    public partial class employee : Window
    {
        List<Employee> Listemployee = new List<Employee>();
        public employee()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.names = name.Text;
            employee.id = Convert.ToInt16(id.Text);
            employee.number = Convert.ToInt16(number.Text);
            employee.age = Convert.ToInt16(age.Text);
            employee.salary = Convert.ToInt16(sal.Text);
            Listemployee.Add(employee);
            cmb.ItemsSource = null;
            cmb.DisplayMemberPath = "names";
            cmb.ItemsSource = Listemployee;
        }
    }
    public class Employee
    {
        public string names { get; set; }
        public int id { get; set; }
        public int number { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
    }
}