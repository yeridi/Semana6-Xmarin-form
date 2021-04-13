using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            Employees.Add(new Employee { DisplayName = "Bob Finnerty" });
            Employees.Add(new Employee { DisplayName = "Bib Wrestler" });
            Employees.Add(new Employee { DisplayName = "Dr. Geri-Betch Hooper" });
            Employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            Employees.Add(new Employee { DisplayName = "HUAMAN TAQUIRE YERIDI CRHIS" });
            Employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }
    }
}