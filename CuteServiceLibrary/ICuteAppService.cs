using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CuteServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICuteAppService
    {
       [OperationContract]
        List<Student> ListStudents();
        [OperationContract]
        StudentDetail GetStudentDetail(string studentId);
        [OperationContract]
        bool SaveStudent(int studentId,string studentName, string studentPassword);
        [OperationContract]
        bool upDateStudent(int studentId, string studentName, string studentPassword);
        [OperationContract]
        bool DeleteStudent(int studentId);

        [OperationContract]
        List<Note> ListNotes();
        [OperationContract]
        NoteDetail GetNoteDetail(string noteId);
        [OperationContract]
        bool SaveNote(string noteId, string noteContent, int studentId);
        [OperationContract]
        bool upDateNote(int noteId, string noteContent, int studentId);
       

        [OperationContract]
        List<Budget> ListBudgets();
        [OperationContract]
        BudgetDetail GetBudgetDetail(string budgetId);
        [OperationContract]
        bool SaveBudget(string budgetId, string budgetItem, int budgetItemPrice, int studentId);
        [OperationContract]
        bool upDateBudget(int budgetId, string budgetItem, int budgetItemPrice, int studentId);
        

        [OperationContract]
        List<Project> ListProjectData();
        [OperationContract]
        ProjectDetails GetProjectDetails(int projectId);
        [OperationContract]
        bool InsertProjectData(int projectId, string projectName, string projectDesc, string groupName, int studentNumber);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class Student
    {
        [DataMember]
        public int studentId { get; set; }

        [DataMember]
        public string StudentName { get; set; }

        [DataMember]
        public string StudentPassword { get; set; }
       
    }
    [DataContract]
    public class StudentDetail
    {
        [DataMember]
        public int studentId { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string StudentPassword { get; set; }
       
    }

    [DataContract]
    public class Note
    {
        [DataMember]
        public int noteId { get; set; }
        [DataMember]
        public string noteContent { get; set; }
        [DataMember]
        public int studentId { get; set; }
    }
    public class NoteDetail
    {
        [DataMember]
        public int noteId { get; set; }
        [DataMember]
        public string noteContent { get; set; }
        [DataMember]
        public int studentId { get; set; }
    }
    [DataContract]
    public class Budget
    {
        [DataMember]
        public int budgetId { get; set; }
        [DataMember]
        public string budgetItem { get; set; }
        [DataMember]
        public int budgetPrice { get; set; }
        [DataMember]
        public int studentId { get; set; }
    }
    [DataContract]
    public class BudgetDetail
    {
        [DataMember]
        public int budgetId { get; set; }
        [DataMember]
        public string budgetItem { get; set; }
        [DataMember]
        public int budgetPrice { get; set; }
        [DataMember]
        public int studentId { get; set; }
    

    }

    [DataContract]
    public class Project
    {
        

        [DataMember]
        public int projectId { get; set; }
        [DataMember]
        public string projectName { get; set; }
       

    }
    [DataContract]
    public class ProjectDetails
    {
        [DataMember]
        public int projectId { get; set; }
        [DataMember]
        public string projectName { get; set; }
        [DataMember]
        public string projectDesc { get; set; }
        [DataMember]
        public string groupName { get; set; }
        [DataMember]
        public int studentNumber { get; set; }
    }
}
