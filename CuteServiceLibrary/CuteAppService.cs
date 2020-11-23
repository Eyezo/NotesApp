using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CuteServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CuteAppService : ICuteAppService
    {
        private List<Student> students = null;
        private Student student = null;
        private StudentDetail studentDetail = null;
        private int iRowsUpdated = 0;

        private List<Note> notes = null;
        private Note note = null;
        private NoteDetail noteDetail = null;

        private List<Budget> budgets = null;
        private Budget budget = null;
        private BudgetDetail budgetDetail = null;

        private List<Project> projects = null;
        private Project project = null;
        private ProjectDetails projectDetails = null;
        private bool isvalid;

        public List<Student> ListStudents()
        {
            //Method Name   : ListStudents()
            //Purpose       : creates a list of students from the database
            //Input         : 
            //Output        : list of students
            students = new List<Student>();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                using (var cmd = new OleDbCommand("SELECT * FROM studentTable", conn))
                {
                    conn.Open();
                    using (OleDbDataReader studentRead = cmd.ExecuteReader())
                    {
                        while (studentRead.Read())
                        {
                            student = new Student();
                           
                            student.studentId = Convert.ToInt32(studentRead.GetValue(0));
                            student.StudentName = studentRead.GetString(1);
                            student.StudentPassword = studentRead.GetString(2);

                            students.Add(student);

                        }
                    }
                }
            }

            return students;
        }

        public StudentDetail GetStudentDetail(string studentId)
        {
            //Method Name   : GetStudentDetail()
            //Purpose       : searches for student by Id
            //Input         : studentId
            //Output        : student

            studentDetail = new StudentDetail();
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("SELECT studentId, studentName, studentPassword ");
                qryBuilder.Append(" FROM studentTable WHERE studentId = @studentId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@studentId", studentId));
                    conn.Open();
                    using (OleDbDataReader studentRead = cmd.ExecuteReader())
                    {
                        while (studentRead.Read())
                        {
                            studentDetail.studentId = Convert.ToInt32(studentRead.GetValue(0));
                            studentDetail.StudentName = studentRead.GetString(1);
                            studentDetail.StudentPassword = studentRead.GetString(2);

                        }
                    }
                }
                conn.Close();
                return studentDetail;
            }
        }

        public bool SaveStudent(int studentId, string studentName, string studentPassword)
        {
            //Method Name   : SaveStudent()
            //Purpose       : saves the values from the text to the data base
            //Input         : Student information 
            //Output        : none


            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                try
                {
                    using (var cmd = new OleDbCommand("INSERT INTO studentTable (studentId, studentName, studentPassword) VALUES (@studentId, @studentName, @studentPassword)", conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new OleDbParameter("@studentId", studentId));
                        cmd.Parameters.Add(new OleDbParameter("@studentName", studentName));
                        cmd.Parameters.Add(new OleDbParameter("@studentPassword", studentPassword));
                       
                            iRowsUpdated = (int)cmd.ExecuteNonQuery();

                            isvalid = true;
                        
                    }
                }
                catch
                {
                    iRowsUpdated = 0;
                    isvalid = false;
                }
                conn.Close();

            }
           // return (iRowsUpdated != 0);
            return isvalid;
        }

        public bool upDateStudent(int studentId, string studentName, string studentPassword)
        {
            //Method Name   : upDateStudent()
            //Purpose       : updates student with new values
            //Input         : new student values 
            //Output        : none
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("UPDATE studentTable SET studentName = @studentName, ");
                qryBuilder.Append("studentPassword = @studentPassword");
                qryBuilder.Append(" WHERE studentId = @studentId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    
                    cmd.Parameters.Add(new OleDbParameter("@studentName", studentName));
                    cmd.Parameters.Add(new OleDbParameter("@studentPassword", studentPassword));
                    cmd.Parameters.Add(new OleDbParameter("@studentId", studentId));
                    conn.Open();
                    
                    iRowsUpdated = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return (iRowsUpdated != 0);
        }

        public bool DeleteStudent(int studentId)
        {
            //Method Name   : DeleteStudent()
            //Purpose       : deletes student by studentId 
            //Input         : studentId 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                conn.Open();
                string dltQuery = string.Format("DELETE FROM studentTable WHERE studentId = {0} ", studentId);
               using (var cmd = new OleDbCommand(dltQuery, conn))
              {
                  iRowsUpdated = cmd.ExecuteNonQuery();
               }
                //var item = students.First(x => x.studentId == studentId);
               // students.Remove(item);
                conn.Close();
            }
            return true;
        }

        public List<Note> ListNotes()
        {
            //Method Name   : ListNote()
            //Purpose       : creates a list of notes from the database
            //Input         : 
            //Output        : list of notes
            notes = new List<Note>();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                using (var cmd = new OleDbCommand("SELECT * FROM noteTable", conn))
                {
                    conn.Open();
                    using (OleDbDataReader noteRead = cmd.ExecuteReader())
                    {
                        while (noteRead.Read())
                        {
                            note = new Note();
                          
                            note.noteId = Convert.ToInt32(noteRead.GetValue(0));
                            note.noteContent = noteRead.GetString(1);
                            note.studentId = Convert.ToInt32(noteRead.GetValue(2));
                            
                            notes.Add(note);

                        }
                    }
                }
            }

            return notes;
        }

        public NoteDetail GetNoteDetail(string noteId)
        {
            //Method Name   : GetNoteDetail()
            //Purpose       : searches for note by Id
            //Input         : noteId
            //Output        : note
            
            noteDetail = new NoteDetail();
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("SELECT noteId, noteContent, studentId ");
                qryBuilder.Append("FROM noteTable WHERE noteId = @noteId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@noteId", noteId));
                    conn.Open();
                    using (OleDbDataReader noteRead = cmd.ExecuteReader())
                    {
                        while (noteRead.Read())
                        {
                            noteDetail.noteId = Convert.ToInt32(noteRead.GetValue(0));
                            noteDetail.noteContent = noteRead.GetString(1);
                            noteDetail.studentId = Convert.ToInt32(noteRead.GetValue(2));

                        }
                    }
                }
                conn.Close();
                return noteDetail;
            }
        }

        public bool SaveNote(string noteId, string noteContent, int studentId)
        {
            //Method Name   : SaveNote()
            //Purpose       : saves the values from the text to the data base
            //Input         : Note information 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                try
                {
                    using (var cmd = new OleDbCommand("INSERT INTO noteTable (noteId, noteContent, studentId) VALUES (@noteId, @noteContent, @studentId)", conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new OleDbParameter("@noteId", noteId));
                        cmd.Parameters.Add(new OleDbParameter("@noteContent", noteContent));
                        cmd.Parameters.Add(new OleDbParameter("@studentId", studentId));
                       
                            iRowsUpdated = (int)cmd.ExecuteNonQuery();
                       
                        
                            iRowsUpdated = -1;
                            isvalid = true;
                       
                        
                    }
                }
                catch
                {
                    iRowsUpdated = 0;
                    isvalid = false;

                }
                conn.Close();
            }
            //return (iRowsUpdated != 0);
            return isvalid;
        }

        public bool upDateNote(int noteId, string noteContent, int studentId)
        {
            //Method Name   : upDateNote()
            //Purpose       : updates note with new values
            //Input         : new note values 
            //Output        : none

            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("UPDATE noteTable SET noteContent = @noteContent ");
                
                qryBuilder.Append(" WHERE noteId = @noteId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@noteContent", noteContent));
                    cmd.Parameters.Add(new OleDbParameter("@noteId", noteId));
                    conn.Open();
                    iRowsUpdated = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return (iRowsUpdated != 0);
        }

        public int DeleteNote(int noteId)
        {
            //Method Name   : DeleteNote()
            //Purpose       : delete note by Id
            //Input         : noteId 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                conn.Open();
                string dltQuery = string.Format("DELETE FROM noteTable WHERE noteId = {0} ", noteId);
                using (var cmd = new OleDbCommand(dltQuery, conn))
                {
                    iRowsUpdated = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return iRowsUpdated;
        }

        public List<Budget> ListBudgets()
        {
            //Method Name   : ListBudgets()
            //Purpose       : creates a list of budgets from the database
            //Input         : 
            //Output        : list of budgets
            budgets = new List<Budget>();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                using (var cmd = new OleDbCommand("SELECT * FROM budgetTable", conn))
                {
                    conn.Open();
                    using (OleDbDataReader budgetRead = cmd.ExecuteReader())
                    {
                        while (budgetRead.Read())
                        {
                            budget = new Budget();

                            budget.budgetId = Convert.ToInt32(budgetRead.GetValue(0));
                            budget.budgetItem = budgetRead.GetString(1);
                            budget.budgetPrice = Convert.ToInt32(budgetRead.GetValue(2));
                            budget.studentId = Convert.ToInt32(budgetRead.GetValue(3));
                            budgets.Add(budget);

                        }
                    }
                }
            }

            return budgets;
        }

        public BudgetDetail GetBudgetDetail(string budgetId)
        {
            //Method Name   : GetBudgetDetail()
            //Purpose       : searches for budget by Id
            //Input         : budgetId
            //Output        : budget
            budgetDetail = new BudgetDetail();
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("SELECT budgetId, budgetItem, budgetItemPrice, studentId ");
                qryBuilder.Append(" FROM budgetTable WHERE budgetId = @budgetId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@budgetId", budgetId));
                    conn.Open();
                    using (OleDbDataReader budgetRead = cmd.ExecuteReader())
                    {
                        while (budgetRead.Read())
                        {
                            budgetDetail.budgetId = Convert.ToInt32(budgetRead.GetValue(0));
                            budgetDetail.budgetItem = budgetRead.GetString(1);
                            budgetDetail.budgetPrice = Convert.ToInt32(budgetRead.GetValue(2));
                            budgetDetail.studentId = Convert.ToInt32(budgetRead.GetValue(3));

                        }
                    }
                }
                conn.Close();
                return budgetDetail;
            }
        }

        public bool SaveBudget(string budgetId, string budgetItem, int budgetItemPrice, int studentId)
        {
            //Method Name   : SaveBudget()
            //Purpose       : saves the values from the text to the data base
            //Input         : Budget information 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                try
                {

                    using (var cmd = new OleDbCommand("INSERT INTO budgetTable (budgetId, budgetItem, budgetItemPrice, studentId) VALUES (@budgetId, @budgetItem, @budgetItemPrice ,@studentId)", conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new OleDbParameter("@budgetId", budgetId));
                        cmd.Parameters.Add(new OleDbParameter("@budgetItem", budgetItem));
                        cmd.Parameters.Add(new OleDbParameter("@budgetItemPrice", budgetItemPrice));
                        cmd.Parameters.Add(new OleDbParameter("@studentId", studentId));
                       
                            iRowsUpdated = (int)cmd.ExecuteNonQuery();
                            iRowsUpdated = -1;
                            isvalid = true;

                       
                    }
                }
                catch
                {
                    iRowsUpdated = 0;
                    isvalid = false;
                }
                conn.Close();

            }
           
            return isvalid;
        }

        public bool upDateBudget(int budgetId, string budgetItem, int budgetItemPrice, int studentId)
        {
            //Method Name   : upDateBudget()
            //Purpose       : updates budget with new values
            //Input         : new budget values 
            //Output        : none
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("UPDATE budgetTable SET budgetItem = @budgetItem, ");
                qryBuilder.Append("budgetItemPrice = @budgetItemPrice");
                qryBuilder.Append(" WHERE budgetId = @budgetId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@budgetItem", budgetItem));
                    cmd.Parameters.Add(new OleDbParameter("@budgetItemPrice", budgetItemPrice));
                    cmd.Parameters.Add(new OleDbParameter("@budgetId", budgetId));
                    conn.Open();
                    iRowsUpdated = (int)cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return (iRowsUpdated != 0);
        }

        public int DeleteBudget(int budgetId)
        {
            //Method Name   : DeleteBudget()
            //Purpose       : delete budget by Id
            //Input         : budgetId 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                conn.Open();
                string dltQuery = string.Format("DELETE FROM budgetTable WHERE budgetId = {0} ", budgetId);
                using (var cmd = new OleDbCommand(dltQuery, conn))
                {
                    iRowsUpdated = (int)cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return iRowsUpdated;
        }
        

        public List<Project> ListProjectData()
        {
            //Method Name   : ListProjectData()
            //Purpose       : creates a list of projects from the database
            //Input         : 
            //Output        : list of projects
            projects = new List<Project>();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                using (var cmd = new OleDbCommand("SELECT * FROM projectTable", conn))
                {
                    conn.Open();
                    using (OleDbDataReader projectRead = cmd.ExecuteReader())
                    {
                        while (projectRead.Read())
                        {
                            project = new Project();

                            project.projectId = Convert.ToInt32(projectRead.GetValue(0));
                            project.projectName = projectRead.GetString(1);
                            
                           
                            projects.Add(project);

                        }
                    }
                }
            }

            return projects;
        }

        public ProjectDetails GetProjectDetails(int projectId)
        {
            //Method Name   : GetProjectDetail()
            //Purpose       : searches for project by Id
            //Input         : projectId
            //Output        : project
            projectDetails = new ProjectDetails();
            StringBuilder qryBuilder = new StringBuilder();
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                qryBuilder.Append("SELECT projectId, projectName, projectDesc, groupName, studentNumber ");
                qryBuilder.Append(" FROM projectTable WHERE projectId = @projectId");
                using (var cmd = new OleDbCommand(qryBuilder.ToString(), conn))
                {
                    cmd.Parameters.Add(new OleDbParameter("@projectId", projectId));
                    conn.Open();
                    using (OleDbDataReader projectRead = cmd.ExecuteReader())
                    {
                        while (projectRead.Read())
                        {
                            projectDetails.projectId = Convert.ToInt32(projectRead.GetValue(0));
                            projectDetails.projectName = projectRead.GetString(1);
                            projectDetails.projectDesc = projectRead.GetString(2);
                            projectDetails.groupName = projectRead.GetString(3);
                            projectDetails.studentNumber = Convert.ToInt32(projectRead.GetValue(4));

                        }
                    }
                }
                conn.Close();
                return projectDetails;
            }
        }

        public bool InsertProjectData(int projectId, string projectName, string projectDesc, string groupName, int studentNumber)
        {
            //Method Name   : InsertProjectData()
            //Purpose       : saves the values from the text to the data base
            //Input         : Project information 
            //Output        : none
            using (var conn = new OleDbConnection(Properties.Settings.Default.CuteConn))
            {
                using (var cmd = new OleDbCommand("INSERT INTO projectTable (projectId, projectName, projectDesc, groupName, studentNumber) VALUES (@projectId, @projectName, @projectDesc, @groupName ,@studentNumber)", conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new OleDbParameter("@projectId", projectId));
                    cmd.Parameters.Add(new OleDbParameter("@projectName", projectName));
                    cmd.Parameters.Add(new OleDbParameter("@projectDesc", projectDesc));
                    cmd.Parameters.Add(new OleDbParameter("@groupName", groupName));
                    cmd.Parameters.Add(new OleDbParameter("@studentNumber", studentNumber));
                    try
                    {
                        iRowsUpdated = (int)cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        iRowsUpdated = -1;
                    }
                    conn.Close();
                }

            }
            return (iRowsUpdated != 0);
        }
    }
}
