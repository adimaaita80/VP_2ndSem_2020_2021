using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture11_Lesson1
{
    public partial class frmStudentEnrollment : Form
    {
        private Student student; // = new Student();

        public frmStudentEnrollment()
        {
            InitializeComponent();
        }

        private void frmStudentEnrollment_Load(object sender, EventArgs e)
        {
            student = new Student();
        }

        /* The btnSubmit_Click method is executed when the btnSubmit button is clicked (it is the Click event handler). */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            student.StudentId = 1;
            student.StudentFirstName = txtFirstName.Text;
            student.StudentSecondName = txtSecondName.Text;
            student.StudentThirdName = txtThirdName.Text;
            student.StudentLastName = txtLastName.Text;
            student.StudentDateOfBirth = dateTimePickerDOB.Value;
            if (rbMale.Checked)
                student.StudentGender = "Male";
            else if (rbMale.Checked)
                student.StudentGender = "Female";
            // Add your code here (1)

            // I created this part for testing. This will show you if the data was
            // entered and stored in the object successfully.
            string studentInformationReport = $"Student ID: {student.StudentId} \n" +
                $"Student First Name: {student.StudentFirstName} \n" +
                $"Student Second Name: {student.StudentSecondName} \n" +
                $"Student Third Name: {student.StudentThirdName} \n" +
                $"Student Last Name: {student.StudentLastName} \n" +
                $"Student Date of Birth: {student.StudentDateOfBirth} \n" +
                $"Student Gender: {student.StudentGender} \n";
            // Add your code here (2)



            MessageBox.Show(studentInformationReport);
        }

    }
}
