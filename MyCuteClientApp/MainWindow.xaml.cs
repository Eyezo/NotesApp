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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using MyCuteClientApp.CuteService;
using System.Windows.Media.Animation;

namespace MyCuteClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student student = new Student();
        private Student[] students = null;
        private List<Student> studentList = null;
        private StudentDetail studentDetail = null;
        private CuteAppServiceClient myStudentProxy = null;
        

        public MainWindow()
        {
            InitializeComponent();
            myStudentProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // studentViewSource.Source = [generic data source]
        }
        private void LeftToRightMarquee()
        {
            double height = canMain.ActualHeight - tb.ActualHeight;
            tb.Margin = new Thickness(0, height / 2, 0, 0);
            DoubleAnimation an = new DoubleAnimation();
            an.From = tb.ActualWidth;
            an.To = canMain.ActualWidth;
            an.RepeatBehavior = RepeatBehavior.Forever;
            an.Duration = new Duration(TimeSpan.FromSeconds(_marqueeTimeInSeconds));
            tb.BeginAnimation(Canvas.LeftProperty, an);
        }
        private void StartTextAnimations(object sender, RoutedEventArgs e)
        {
            this.textBlockStudentId.TextEffects = new TextEffectCollection();
            Storyboard storyBoardRotation = new Storyboard();
            
            storyBoardRotation.RepeatBehavior = RepeatBehavior.Forever;
            storyBoardRotation.AutoReverse = true;
            for (int i = 0; i < this.textBlockStudentId.Text.Length; ++i)
            {
                
                this.AddRotationAnimation(storyBoardRotation, i);

            }
            Timeline pause =
                this.FindResource("Rotation")
                as Timeline;
            storyBoardRotation.Children.Add(pause);
            storyBoardRotation.Begin(this);
        }
        protected void AddRotationAnimation(Storyboard storyBoardRotation, int charIndex)
        {
            DoubleAnimation anim =
                this.FindResource("Rotaion")
                as DoubleAnimation;
            this.SetBeginTime(anim, charIndex);
            string path = String.Format("TextEffects[{0}].Transform.Children[1].Angle", charIndex);
            PropertyPath propPath = new PropertyPath(path);
            Storyboard.SetTargetProperty(anim, propPath);
            storyBoardRotation.Children.Add(anim);
        }
        private void SetBeginTime(Timeline anim, int charIndex)
        {
            double totalMs = anim.Duration.TimeSpan.TotalMilliseconds;
            double offset = totalMs / 10;
            double resolvedoffset = offset * charIndex;
            anim.BeginTime = TimeSpan.FromMilliseconds(resolvedoffset);
        }

        private void btnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnCreateProfile_Click()
            //Purpose       : calls createProfile window
            //Input         : none 
            //Output        : createProfile window
            var showCreate = new CreateProfile();
            showCreate.Show();
        }

        private void btnsignIn_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   :btnsignIn_Click()
            //Purpose       : calls metthod GetStudentDetails to check if exists and logs in
            //Input         : studentId 
            //Output        : MenuScreen window
             bool hasValues = HasValues();
             if (hasValues)
             {
                  bool isNum = IsNumber();
                  if (isNum)
                  {
                      string studentId = txtStudentId.Text;
                      string studentName = txtUserName.Text;
                      string studentPass = txtPassword.Text;
                      studentDetail = myStudentProxy.GetStudentDetail(studentId);
                      if (studentDetail != null)
                      {
                          

                              if (studentDetail.StudentName == studentName)
                              {
                                  if (studentDetail.StudentPassword == studentPass)
                                  {

                                      var showMenu = new MenueScreen();
                                      showMenu.Show();

                                  }
                                  else
                                  {
                                      MessageBox.Show("wrong password ", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                              }
                              else
                              {
                                  MessageBox.Show("wrong name ", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                              }
                          

                      }
                      else
                      {
                          MessageBox.Show("login fail", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
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

        public double _marqueeTimeInSeconds { get; set; }
    }
}
