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

namespace MyCuteClientApp
{
    /// <summary>
    /// Interaction logic for MenueScreen.xaml
    /// </summary>
    public partial class MenueScreen : Window
    {
        public MenueScreen()
        {
            InitializeComponent();
        }

        private void btnBudgets_Click(object sender, RoutedEventArgs e)
        {
            var showBudgets = new CreateBudget();
            showBudgets.Show();
        }

        private void Notes_Click(object sender, RoutedEventArgs e)
        {
            var showNotes = new CreateNote();
            showNotes.Show();
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            var showStudents = new ViewStudents();
            showStudents.Show();
        }

        private void btnViewNote_Click(object sender, RoutedEventArgs e)
        {
            var showNotes = new ViewNote();
            showNotes.Show();
        }

        private void btnViewBudget_Click(object sender, RoutedEventArgs e)
        {
            var showBudget = new ViewBudget();
            showBudget.Show();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var showInfo = new Info();
            showInfo.Show();
        }
    }
}
