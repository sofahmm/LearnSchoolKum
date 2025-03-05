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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LearnSchoolKum.Db;

namespace LearnSchoolKum.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public static List<Service> Services { get; set; }
        public ServicePage()
        {
            InitializeComponent();
            Services = new List<Service>(DbConnection.learnSchool.Service.ToList());
            this.DataContext = this;

        }
    }
}
