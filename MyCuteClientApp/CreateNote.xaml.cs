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
    /// Interaction logic for CreateNote.xaml
    /// </summary>
    public partial class CreateNote : Window
    {
        private List<Note> notesList = null;
        private Note[] notes = null;
        private Note note = null;
        private NoteDetail noteDetail = null;
        private CuteAppServiceClient myNoteProxy = null;

        public CreateNote()
        {
            InitializeComponent();
            myNoteProxy = new CuteAppServiceClient("WSHttpBinding_ICuteAppService");
            LoadData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource noteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("noteViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // noteViewSource.Source = [generic data source]
        }
        private void LoadData()
        {
            //Method Name   : LoadData()
            //Purpose       : loads data grid with database information
            //Input         : none 
            //Output        : database information

            notes = myNoteProxy.ListNotes();
            noteDataGrid.ItemsSource = notes;
            DataContext = noteDataGrid;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Button Name   : btnSave_Click
            //Purpose       : calls for method SaveNote()
            //Input         : none 
            //Output        : save infomation about note
            bool hasValues = HasValues();
            if (hasValues)
            {
                bool isNteId = IsNoteId();
                if (isNteId)
                {
                    bool isStId = IsStudentId();
                    if (isStId)
                    {
                        note = new Note();
                        string noteId = txtNoteId.Text;
                        string noteContent = txtNoteContent.Text;
                        int studentId = Convert.ToInt32(txtStudentId.Text);
                        bool good =  myNoteProxy.SaveNote(noteId, noteContent, studentId);
                        if (good == true)
                        {
                            MessageBox.Show("note added Successfully ");
                        }
                        else
                        {
                            MessageBox.Show("note already axists!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("make sure student number is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                else
                {
                    MessageBox.Show("make sure note ID is a number!", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);

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
            if (txtNoteId.Text == string.Empty
                || txtNoteContent.Text == string.Empty
                || txtStudentId.Text == string.Empty)
            {
                hasValues = false;
            }
            return hasValues;

        }
        private bool IsNoteId()
        {
            //Method Name   : IsNoteId()
            //Purpose       : checks if text is int value
            //Input         : none 
            //Output        : notification about text
            bool isNteId = true;

            try
            {
                int ntId = Convert.ToInt32(txtNoteId.Text);

                isNteId = true;

            }
            catch
            {
                isNteId = false;
            }
            return isNteId;
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

            txtNoteId.Clear();
            txtNoteContent.Clear();
            txtStudentId.Clear();
        }
    }
}
