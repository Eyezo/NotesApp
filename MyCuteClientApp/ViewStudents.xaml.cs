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
using System.Net.Mail;
using System.Net;
using System.Windows.Threading;
using System.IO;


namespace MyCuteClientApp
{
    /// <summary>
    /// Interaction logic for ViewStudents.xaml
    /// </summary>
    public partial class ViewStudents : Window
    {
        private Student student = null;
        private Student[] students = null;
        private List<Student> studentList = null;
        private StudentDetail studentDetail = null;
        private CuteAppServiceClient myStudentProxy = null;
        public ViewStudents()
        {
            InitializeComponent();
            myStudentProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentDetailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentDetailViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // studentDetailViewSource.Source = [generic data source]
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSearch_Click
            //Purpose       : calls for method GetStudentDetail() to check if student exists
            //Input         : studentId 
            //Output        : student
             bool hasValues = HasValues();
             if (hasValues)
             {
                
                bool isNum = IsNumber();
                if (isNum)
                {
                    students = myStudentProxy.ListStudents();
                    string studentId = txtStudentId.Text;
                    studentDetail = myStudentProxy.GetStudentDetail(studentId);
                    if (studentDetail != null)
                    {
                        txtStudentName.Text = studentDetail.StudentName.ToString();
                        txtStudentPassword.Text = studentDetail.StudentPassword.ToString();
                    }
                    else
                    {
                        MessageBox.Show("student does not exist", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("make sure student ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                }

             }
             else
             {
                 MessageBox.Show("Please enter Id.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
             }
             txtStudentName.IsEnabled = true;
             txtStudentPassword.IsEnabled = true;
             txtStudentId.IsEnabled = false;

        }
        private bool HasValues()
        {
            //Method Name   : HasValues()
            //Purpose       : checks if text is inputed
            //Input         : none 
            //Output        : notification about text
            bool hasValues = true;
            if (txtStudentId.Text == string.Empty)
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
                int stNum = Convert.ToInt16(txtStudentId.Text);
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
            //Purpose       : calls for method upDateStudent()
            //Input         : new student values 
            //Output        : none
             bool hasValues = HasValues();
             if (hasValues)
             {
                 int stdntId = Convert.ToInt32(txtStudentId.Text);
                 string stdntName = txtStudentName.Text;
                 string stdntPass = txtStudentPassword.Text;

                 bool val = myStudentProxy.upDateStudent(stdntId, stdntName, stdntPass);
                 if (val == true)
                 {
                     MessageBox.Show("Student updated Successfully", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                 }
                 else
                 {
                     MessageBox.Show("Student update not Successfully", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                 }
             }
             else
             {
                 MessageBox.Show("Please enter all values.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
             }
             clearFields();
             txtStudentId.IsEnabled = true;

        }
        public void clearFields()
        {
            //Method Name   : clearFields()
            //Purpose       : clears text boxes
            //Input         : none 
            //Output        : none
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtStudentPassword.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnDelete_Click
            //Purpose       : calls for method DeleteStdent() 
            //Input         : studentId 
            //Output        : none
            bool hasValues = HasValues();
            if (hasValues)
            {
                int stdntId = Convert.ToInt32(txtStudentId.Text);
                bool val = myStudentProxy.DeleteStudent(stdntId);
                if (val == true)
                {
                    MessageBox.Show("Student deleted Successfully", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Student not deleted", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            else
            {
                MessageBox.Show("Please enter all values.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            clearFields();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   :  btnSend_Click
            //Purpose       : send sms to desired number 
            //Input         : number and message 
            //Output        : none
         
            try
            {
                WebClient user = new WebClient();
              
                string to, msg;
                to = txtNumber.Text;
                msg = txtMessage.Text;
                string adhoc = "http://api.clickatell.com/http/sendmsg?api_id=3508819&user=creater&password=FJWejbYQgVUWDX&to='" + to + "'&text='" + msg + "'";

                user.OpenRead(adhoc);

                MessageBox.Show("good");
            }
            catch(Exception ex)
            {
                MessageBox.Show("", ex.Message);
            }
        }

       
        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   :  btnSendEmail_Click
            //Purpose       : send email to desired address 
            //Input         : address and email 
            //Output        : none
           try
           {
               MailMessage mail = new MailMessage();
               SmtpClient smptServer = new SmtpClient("smtp.gmail.com");
               mail.From = new MailAddress("andilemngqibisa2@gmail.com");
               mail.To.Add(txtEmailAdd.Text);
               mail.Subject = "Rendom message";
               mail.Body = "testing app resources";
               smptServer.Port = 25;
               smptServer.Credentials = new System.Net.NetworkCredential("//email", "\\password");
               smptServer.EnableSsl = true;
               smptServer.Send(mail);
               MessageBox.Show("Email sent");
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
            try
            {
                WebClient user = new WebClient();
                 user.Headers.Add("user:agent" + "Mozilla/4.0(compatible; MSIE 6.0; windows NT 5.2; .NET CLR 1.0.3705;)");
                  string code = "27";
                  user.QueryString.Add("user", "creater");
                  user.QueryString.Add("password", "FJWejbYQgVUWDX");
                  user.QueryString.Add("api_id", "3508819");
                  user.QueryString.Add("to", code + txtEmailAdd.Text.ToString());
                  user.QueryString.Add("text", code + txtEmail.Text.ToString());
                  string adhoc = "http:api.clickatell.com/http/sendmsg";
                  Stream data = user.OpenRead(adhoc);
                  StreamReader read = new StreamReader(data);
                  string s = read.ReadToEnd();
                  data.Close();
                  read.Close();
                
                user.OpenRead(adhoc);

                MessageBox.Show("good");
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.Message);
            }

        }
    }
}
