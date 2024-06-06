using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF3
{
        public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Employee[] emps = new Employee[10];
        public static int count = 0;


        private void addEmployee_Click(object senderic, RoutedEventArgs eventArg)
        {
            if (textboxName.Text == "" || textboxSalary.Text == "")
            {
                emps[count] = new Employee();
                listbox.Items.Add(emps[count]);
                textboxName.Text = textboxSalary.Text = "";
                datePicker1.SelectedDate = null;
            }

            else if (datePicker1.SelectedDate == null)
            {
                emps[count] = new Employee(textboxName.Text, Convert.ToInt32(textboxSalary.Text));
                listbox.Items.Add(emps[count]);
                textboxName.Text = textboxSalary.Text = "";
                datePicker1.SelectedDate = null;
            }
            else
            {
                emps[count] = new Employee(textboxName.Text, Convert.ToInt32(textboxSalary.Text), datePicker1.SelectedDate.Value.Day, datePicker1.SelectedDate.Value.Month, datePicker1.SelectedDate.Value.Year);
                listbox.Items.Add(emps[count]);
                textboxName.Text = textboxSalary.Text = "";
                datePicker1.SelectedDate = null;
            }
        }

        private void increaseSalary_Click(object a, RoutedEventArgs b)
        {
            
            /*foreach (var employee in emps)
            {
                
                employee.IncreaseSalary(30);
                listbox.Items.Clear();
                listbox.Items.Add(employee);
            }*/
            //emps[0].IncreaseSalary(20);
            //listbox.Items.Add(emps[0]);
        }
    }
}