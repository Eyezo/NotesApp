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
    /// Interaction logic for CreateBudget.xaml
    /// </summary>
    public partial class CreateBudget : Window
    {
        private List<Budget> budgetList = null;
        private Budget[] budgets = null;
        private Budget budget = null;
        private BudgetDetail budgetDetail = null;
        private CuteAppServiceClient myBudgetProxy = null;


        public CreateBudget()
        {
            InitializeComponent();
            myBudgetProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
            LoadData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource budgetViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("budgetViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // budgetViewSource.Source = [generic data source]
        }
        private void LoadData()
        {
            //Method Name   : LoadData()
            //Purpose       : loads data grid with database information
            //Input         : none 
            //Output        : database information
            budgets = myBudgetProxy.ListBudgets();
            budgetDataGrid.ItemsSource = budgets;
            DataContext = budgetDataGrid;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSave_Click
            //Purpose       : calls for method SaveBudget()
            //Input         : none 
            //Output        : save infomation about budget
             bool hasValues = HasValues();
             if (hasValues)
             {
                 bool isBdgtId = IsBudgetId();
                 if (isBdgtId)
                 {
                     bool isStId = IsStudentId();
                     if (isStId)
                     {
                         budget = new Budget();
                         string budgetId = txtBudgetId.Text;
                         string budgetItem = txtBudgetItem.Text;
                         int budgetItemPrice = Convert.ToInt32(txtBudgetItemPrice.Text);
                         int studentId = Convert.ToInt32(txtStudentId.Text);
                         bool good = myBudgetProxy.SaveBudget(budgetId, budgetItem, budgetItemPrice, studentId);
                          if (good == true)
                        {
                         MessageBox.Show("budget added Successfully ");
                        }
                          else
                          {
                              MessageBox.Show("budget already axists!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                          }
                     }
                     else
                     {
                         MessageBox.Show("make sure student number is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                     }

                 }
                 else
                 {
                     MessageBox.Show("make sure budget ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                 }

             }
             else
             {
                 MessageBox.Show("Please enter all values.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
             }
             clearFields();
             LoadData();

        }
        private bool HasValues()
        {
            //Method Name   : HasValues()
            //Purpose       : checks if text is inputed
            //Input         : none 
            //Output        : notification about text
            bool hasValues = true;
            if (txtBudgetId.Text == string.Empty
                || txtBudgetItem.Text == string.Empty
                || txtBudgetItemPrice.Text == string.Empty
                || txtStudentId.Text == string.Empty)
            {
                hasValues = false;
            }
            return hasValues;

        }
        private bool IsBudgetId()
        {
            //Method Name   : IsBudhetId()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isBdgtId = true;

            try
            {
                int bdgtId = Convert.ToInt32(txtBudgetId.Text);

                isBdgtId = true;

            }
            catch
            {
                isBdgtId = false;
            }
            return isBdgtId;
        }
        private bool IsStudentId()
        {
            //Method Name   : IsStudentId()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isStId = true;

            try
            {
                int stId = Convert.ToInt32(txtStudentId.Text);

                isStId = true;

            }
            catch
            {
                isStId = false;
            }
            return isStId;
        }
        public void clearFields()
        {
            //Method Name   : clearFields()
            //Purpose       : clears text boxes
            //Input         : none 
            //Output        : none

            txtBudgetId.Clear();
            txtBudgetItem.Clear();
            txtBudgetItemPrice.Clear();
            txtStudentId.Clear();
        }
    }
}
