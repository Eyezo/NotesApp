using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ServiceModel;
using MyCuteClientApp.CuteService;

namespace MyCuteClientApp
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        private List<Project> projectList = null;
        private Project[] projects = null;
        private Project project = null;
        private ProjectDetails projectDetails = null;
        private ProjectDetails[] pro = null;
        private CuteAppServiceClient myProjectProxy = null;


        public Info()
        {
            InitializeComponent();
            myProjectProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
            LoadData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource projectDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("projectDetailsViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // projectDetailsViewSource.Source = [generic data source]
        }
        private void LoadData()
        {

            projects = myProjectProxy.ListProjectData();
            projectDetailsDataGrid.ItemsSource = projects;
            DataContext = projectDetailsDataGrid;

        }
    }
}
