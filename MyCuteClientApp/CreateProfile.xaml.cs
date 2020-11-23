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
    /// Interaction logic for CreateProfile.xaml
    /// </summary>
    public partial class CreateProfile : Window
    {
        private Student student = null;
        private Student[] students = null;
        private List<Student> studentList = null;
        private StudentDetail studentDetail = null;
        private CuteAppServiceClient myStudentProxy = null;

        public CreateProfile()
        {
            InitializeComponent();
            myStudentProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
            LoadData();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSave_Click
            //Purpose       : calls for method SaveStudent()
            //Input         : none 
            //Output        : save infomation about student



            bool hasValues = HasValues();
            if (hasValues)
            {
                
                student = new Student();
                bool isNum = IsNumber();
                if (isNum)
                {
                  
                        int studentId = Convert.ToInt32(txtstudentNumber.Text);

                        students = myStudentProxy.ListStudents();

                        string studentName = txtEnterStudentName.Text;
                        string studentPassword = txtStudentPassword.Text;

                      bool good =  myStudentProxy.SaveStudent(studentId, studentName, studentPassword);
                        if(good == true)
                        {
                        MessageBox.Show(studentName + " " + "added Successfully ");
                        var showMenu = new MenueScreen();
                        showMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show( "student already exists!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("make sure student number is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            else
            {
                MessageBox.Show("Please enter all values.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            clearFields();
            LoadData();
           

        }

        private void LoadData()
        {
            //Method Name   : LoadData()
            //Purpose       : loads data grid with database information
            //Input         : none 
            //Output        : database information
            
            students = myStudentProxy.ListStudents();
            studentDataGrid.ItemsSource = students;
            DataContext = studentDataGrid;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // studentViewSource1.Source = [generic data source]
        }
        private bool HasValues()
        {
            //Method Name   : HasValues()
            //Purpose       : checks if text is inputed
            //Input         : none 
            //Output        : notification about text

            bool hasValues = true;
            if (txtEnterStudentName.Text == string.Empty
                || txtEnterStudentName.Text == string.Empty
                || txtStudentPassword.Text == string.Empty)
            {
                hasValues = false;
            }
            return hasValues;
            
        }
        private bool IsNumber()
        {
            //Method Name   : IsNumber()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isNum = true;
            try
            {
                int stNum = Convert.ToInt16(txtstudentNumber.Text);
                isNum = true;  
            }
            catch
            {
                isNum = false;
            }
            return isNum;
        }
       
        public void clearFields()
        {
            //Method Name   : clearFields()
            //Purpose       : clears text boxes
            //Input         : none 
            //Output        : none
            txtstudentNumber.Clear();
            txtEnterStudentName.Clear();
            txtStudentPassword.Clear();
        }

    }
}
