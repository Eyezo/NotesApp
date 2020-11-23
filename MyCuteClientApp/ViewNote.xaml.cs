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
    /// Interaction logic for ViewNote.xaml
    /// </summary>
    public partial class ViewNote : Window
    {
        private Note note = null;
        private Note[] notes = null;
        private List<Note> noteList = null;
        private NoteDetail noteDetail = null;
        private CuteAppServiceClient myNoteProxy = null;

        public ViewNote()
        {
            InitializeComponent();
            myNoteProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource noteDetailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("noteDetailViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // noteDetailViewSource.Source = [generic data source]
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSearch_Click
            //Purpose       : calls for method GetNoteDetail() to check if note exists
            //Input         : noteId 
            //Output        : note
             bool hasValues = HasValues();
             if (hasValues)
             {
                  bool isNum = IsNumber();
                  if (isNum)
                  {
                      bool isStNum = IsStudentNum();
                      if (isNum)
                      {
                          
                          string noteId = txtNoteId.Text;
                          noteDetail = myNoteProxy.GetNoteDetail(noteId);
                          if (noteDetail != null)
                          {
                              txtNoteContent.Text = noteDetail.noteContent.ToString();
                              txtStudentId.Text = noteDetail.studentId.ToString();
                          }
                          else
                          {
                              MessageBox.Show("note does not exist", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                          }
                      }
                      else
                      {
                          MessageBox.Show("make sure note ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                      }

                  }
                  else
                  {
                      MessageBox.Show("make sure note ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                  }

             }
             else
             {
                 MessageBox.Show("Please enter Id.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
             }
             txtNoteContent.IsEnabled = true;
             txtNoteId.IsEnabled = false;
             txtStudentId.IsEnabled = false;

        }
        private bool HasValues()
        {
            //Method Name   : HasValues()
            //Purpose       : checks if text is inputed
            //Input         : none 
            //Output        : notification about text
            bool hasValues = true;
            if (txtNoteId.Text == string.Empty)
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
                int stNum = Convert.ToInt16(txtNoteId.Text);
                isNum = true;
            }
            catch
            {
                isNum = false;
            }
            return isNum;
        }
        private bool IsStudentNum()
        {
            //Method Name   :  IsStudentNum()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isStNum = true;
            try
            {
                int stNum = Convert.ToInt16(txtNoteId.Text);
                isStNum = true;
            }
            catch
            {
                isStNum = false;
            }
            return isStNum;
        }
        public void clearFields()
        {
            //Method Name   : clearFields()
            //Purpose       : clears text boxes
            //Input         : none 
            //Output        : none
            txtNoteId.Clear();
            txtNoteContent.Clear();
            txtStudentId.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSave_Click
            //Purpose       : calls for method upDateNote()
            //Input         : new note values 
            //Output        : none
            bool hasValues = HasValues();
            if (hasValues)
            {
                int noteId = Convert.ToInt32(txtNoteId.Text);
                string noteContent = txtNoteContent.Text;
                int studentId = Convert.ToInt32(txtStudentId.Text);
                

                bool val = myNoteProxy.upDateNote(noteId, noteContent, studentId);
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
            txtNoteId.IsEnabled = true;
        }
    }
}
