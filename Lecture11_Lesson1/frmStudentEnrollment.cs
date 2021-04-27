using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture11_Lesson1
{
    public partial class frmStudentEnrollment : Form
    {
        private StudentsTable studentTable;

        private Student student; // = new Student();
        private Validator validator;

        private int studentIdCounter = 1;

        public frmStudentEnrollment()
        {
            InitializeComponent();
        }

        private void frmStudentEnrollment_Load(object sender, EventArgs e)
        {
            
            studentTable = new StudentsTable();

            txtFirstName.Focus();
        }

        /* The btnSubmit_Click method is executed when the btnSubmit button is clicked (it is the Click event handler). */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ReadFormData();

            if(validator.ErrorExists)
            {
                MessageBox.Show(validator.ErrorMessage);
            }
            else
            {
                studentTable.Students.Add(student);
                studentIdCounter++;

                PrintStudentReport(student);

                DisplayStudentRecords();

                ClearForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogImages.Title = "Browse Images";
            openFileDialogImages.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialogImages.CheckFileExists = true;
            openFileDialogImages.CheckPathExists = true;
            openFileDialogImages.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            openFileDialogImages.ReadOnlyChecked = true;
            openFileDialogImages.ShowReadOnly = true;
            openFileDialogImages.FileName = "";

            if(openFileDialogImages.ShowDialog() == DialogResult.OK)
            {
                string photoFileName = openFileDialogImages.FileName;

                Bitmap studentImage = new Bitmap(photoFileName);

                pictureBoxStudentPicture.Image = studentImage;

                student.StudentPhoto = photoFileName;
            }     
        }
        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"You have clicked cell no: {e.ColumnIndex} in row {e.RowIndex}");

            txtFirstName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[5].Value.ToString();
        }


        #region UserGeneratedMethods
        private void ReadFormData()
        {
            student = new Student();

            validator = new Validator();

            student.StudentId = studentIdCounter;

            if (!string.IsNullOrEmpty(txtFirstName.Text))
                student.StudentFirstName = txtFirstName.Text;
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please enter first name \n";
            }

            student.StudentSecondName = txtSecondName.Text;

            student.StudentThirdName = txtThirdName.Text;

            if (!string.IsNullOrEmpty(txtLastName.Text))
                student.StudentLastName = txtLastName.Text;
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please enter Last name \n";
            }

            if (!(dateTimePickerDOB.Value.Year > (DateTime.Now.Year - 18)))
                student.StudentDateOfBirth = dateTimePickerDOB.Value;
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please make sure the student's age is at least 18 \n";
            }

            if (rbMale.Checked)
                student.StudentGender = "Male";
            else if (rbFemale.Checked)
                student.StudentGender = "Female";
            else
                student.StudentGender = "Not Selected";

            if (cbCountryOfBirth.SelectedItem != null)
                student.StudentCountryOfBirth = cbCountryOfBirth.SelectedItem.ToString();
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please choose country of birth \n";
            }

            if (cbCityOfBirth.SelectedItem != null)
                student.StudentCityOfBirth = cbCityOfBirth.SelectedItem.ToString();
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please choose city of birth \n";
            }

            if (cbNationality.SelectedItem != null)
                student.StudentNationality = cbNationality.SelectedItem.ToString();
            else
            {
                validator.ErrorExists = true;
                validator.ErrorMessage += "Please choose nationality \n";
            }

            student.StudentEmail = txtEmail.Text;
            student.StudentPhone = txtPhone.Text;
            student.StudentMobile = txtMobile.Text;
            // Add your code here (1)
        }

        private void PrintStudentReport(Student student)
        {
            string studentInformationReport = $"Student ID: {student.StudentId} \n" +
                   $"Student First Name: {student.StudentFirstName} \n" +
                   $"Student Second Name: {student.StudentSecondName} \n" +
                   $"Student Third Name: {student.StudentThirdName} \n" +
                   $"Student Last Name: {student.StudentLastName} \n" +
                   $"Student Date of Birth: {student.StudentDateOfBirth} \n" +
                   $"Student Gender: {student.StudentGender} \n" +
                   $"Student Nationality: {student.StudentNationality} \n" +
                   $"Student Country of Birth: {student.StudentCountryOfBirth} \n" +
                   $"Student City of Birth: {student.StudentCityOfBirth} \n" +
                   $"Student Photo Path: {student.StudentPhoto} \n" +
                   $"Student Email: {student.StudentEmail} \n" +
                   $"Student Phone: {student.StudentPhone} \n" +
                   $"Student Mobile: {student.StudentMobile}";
            // Add your code here (2)

            MessageBox.Show(studentInformationReport);
        }

        private void DisplayStudentRecords()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = studentTable.Students;
            dataGridViewStudents.DataSource = bindingSource;
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dateTimePickerDOB.Value = DateTime.Now;
            cbCountryOfBirth.SelectedIndex = -1;
            cbCityOfBirth.SelectedIndex = -1;
            cbNationality.SelectedIndex = -1;

            rbMale.Checked = false;
            rbFemale.Checked = false;

            txtEmail.Text = string.Empty;

            txtFirstName.Focus();
        }
        #endregion

        
    }
}
