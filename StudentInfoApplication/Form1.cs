using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class StudentInfo : Form
    {
        List<StudentNamespace.StudentInfo> students = new List<StudentNamespace.StudentInfo>();

        public StudentInfo()
        {
            InitializeComponent();
        }



        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            StudentNamespace.StudentInfo student = new StudentNamespace.StudentInfo(
       TextLastName.Text, 
       TextFirstName.Text,  
       TextStudentId.Text  
   );

            students.Add(student);

           
            TextStudentId.Clear();
            TextFirstName.Clear();
            TextLastName.Clear();

            
            ListStudentId.Items.Add(student.StudentID);
            ListLastName.Items.Add(student.StudentLName);
            ListFirstName.Items.Add(student.StudentFName);
        }
    }
}

namespace StudentNamespace
{
    class StudentInfo
    {
        private string studentFName;
        private string studentLName;
        private string studentID;

        
        public StudentInfo(string studentFName, string studentLName, string studentID)
        {
            this.studentFName = studentFName;
            this.studentLName = studentLName;
            this.studentID = studentID;
        }


        public StudentInfo() : this("", "", "") { }


        public string StudentFName
        {
            get { return studentFName; }
            set { studentFName = value; }
        }


        public string StudentLName
        {
            get { return studentLName; }
            set { studentLName = value; }
        }


        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
}