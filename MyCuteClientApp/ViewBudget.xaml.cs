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
    /// Interaction logic for ViewBudget.xaml
    /// </summary>
    public partial class ViewBudget : Window
    {
        private Budget note = null;
        private Budget[] budgets = null;
        private List<Budget> budgetList = null;
        private BudgetDetail budgetDetail = null;
        private CuteAppServiceClient myBudgetProxy = null;

        public ViewBudget()
        {
            InitializeComponent(); myBudgetProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource budgetDetailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("budgetDetailViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // budgetDetailViewSource.Source = [generic data source]
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSearch_Click
            //Purpose       : calls for method GetBudgetDetail() to check if budget exists
            //Input         : budgetId 
            //Output        : budget
              bool hasValues = HasValues();
              if (hasValues)
              {
                   bool isNum = IsNumber();
                   if (isNum)
                   {   
                            string budgetId = txtBudgetId.Text;
                            budgetDetail = myBudgetProxy.GetBudgetDetail(budgetId);
                            if (budgetDetail != null)
                            {
                                txtBudgetItem.Text = budgetDetail.budgetItem.ToString();
                                txtBudgetItemPrice.Text = budgetDetail.budgetPrice.ToString();
                                txtStudentId.Text = budgetDetail.studentId.ToString();
                            }
                            else
                            {
                                MessageBox.Show("note does not exist", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                      
                   }
                  else
                  {
                      MessageBox.Show("make sure budget ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                  }

              }
              else
              {
                  MessageBox.Show("Please enter Id.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
              }
              txtBudgetId.IsEnabled = false;
              txtBudgetItem.IsEnabled = true;
              txtBudgetItemPrice.IsEnabled = true;
              txtStudentId.IsEnabled = false;

        }
        private bool HasValues()
        {
            //Method Name   : HasValues()
            //Purpose       : checks if text is inputed
            //Input         : none 
            //Output        : notification about text
            bool hasValues = true;
            if (txtBudgetId.Text == string.Empty)
            {
                hasValues = false;
            }
            return hasValues;

        }
        private bool IsNumber()
        {
            //Method Name   :  IsStudentNum()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isNum = true;
            try
            {
                int stNum = Convert.ToInt16(txtBudgetId.Text);
                isNum = true;
            }
            catch
            {
                isNum = false;
            }
            return isNum;
        }
       
        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSave_Click
            //Purpose       : calls for method upDateBudget()
            //Input         : new budget values 
            //Output        : none
            {
                bool hasValues = HasValues();
                if (hasValues)
                {
                    int budgetId = Convert.ToInt32(txtBudgetId.Text);
                    string budgetItem = txtBudgetItem.Text;
                    int budgetItemPrice = Convert.ToInt32(txtBudgetItemPrice.Text);
                    int studentId = Convert.ToInt32(txtStudentId.Text);

                    bool val = myBudgetProxy.upDateBudget(budgetId, budgetItem, budgetItemPrice,studentId);
                    if (val == true)
                    {
                        MessageBox.Show("Note updated Successfully", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Note update not Successfully", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all values.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                clearFields();
                txtBudgetId.IsEnabled = true;
            }
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
