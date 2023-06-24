using Microsoft.Data.SqlClient;
using STU.BusinessLayer;
using STU.Model;
using System.Data;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace STU.UI
{
    public partial class Form1 : Form
    {


        private BusinessClass objBusinessClass = new BusinessClass();

        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();


            if (string.IsNullOrEmpty(txtStudentId.Text.Trim()))
            {
                student.StudentId = 0;
            }
            else
            {
                student.StudentId = Convert.ToInt32(txtStudentId.Text.Trim());
            }

            student.FirstName = txtFirstName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();

            student.Email = txtEmail.Text.Trim();


            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                student.Age = 0;
            }
            else
            {
                student.Age = Convert.ToInt32(txtAge.Text.Trim());
            }






            bool status = objBusinessClass.AddStudent(student);

            if (status)
            {
                MessageBox.Show("Record Saved");
            }

            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            DataTable table = objBusinessClass.FetchStudent();
            dataGridView1.DataSource = table;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text.Trim());

            int state = objBusinessClass.DeleteStudent(student.StudentId);
            if (state >= 1)
            {
                MessageBox.Show("Record Deleted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text.Trim());


            SqlConnection objSqlConnection = new SqlConnection(ConnectionString);
            objSqlConnection.Open();

            string query = $"select FirstName,LastName,Email,Age from StudentTable where StudentId='{student.StudentId}'";

            SqlCommand sqlCommand = new SqlCommand(query, objSqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.Text;


            SqlDataReader DR1 = sqlCommand.ExecuteReader();
            if (DR1.Read())
            {
                txtFirstName.Text = DR1.GetValue(0).ToString();
                txtLastName.Text = DR1.GetValue(1).ToString();
                txtEmail.Text = DR1.GetValue(2).ToString();
                txtAge.Text = DR1.GetValue(3).ToString();

            }



            // objBusinessClass.ReadStudent(student.StudentId);


        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();


            if (string.IsNullOrEmpty(txtStudentId.Text.Trim()))
            {
                student.StudentId = 0;
            }
            else
            {
                student.StudentId = Convert.ToInt32(txtStudentId.Text.Trim());
            }

            student.FirstName = txtFirstName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();

            student.Email = txtEmail.Text.Trim();


            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                student.Age = 0;
            }
            else
            {
                student.Age = Convert.ToInt32(txtAge.Text.Trim());
            }






            bool status = objBusinessClass.UpdateSaveStudent(student);

            if (status)
            {
                MessageBox.Show("Record Updated");

            }

            ClearTextBoxes();
        }
    }
}