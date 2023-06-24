using Microsoft.Data.SqlClient;
using STU.Model;
using System.Data;
using static Azure.Core.HttpHeader;

namespace STU.DataAccess
{
    public class SqlServerClass
    {


        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public SqlServerClass() { }

        public int AddStudent(Student student)
        {
           
            SqlConnection objSqlConnection = new SqlConnection(ConnectionString);

          
            objSqlConnection.Open();

            string query = $"INSERT INTO StudentTable (StudentId,FirstName,LastName,Email,Age) VALUES('{student.StudentId}','{student.FirstName}','{student.LastName}','{student.Email}','{student.Age}')";


            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);
          
            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int result = objSqlCommand.ExecuteNonQuery();

            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                // 4. Close the connection:
                objSqlConnection.Close();
            }

            return result;
        }


        public DataTable FetchStudent()
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnectionString);
            objSqlConnection.Open();

            string query = "select StudentId,FirstName,LastName,Email,Age from StudentTable";

            SqlCommand sqlCommand = new SqlCommand(query, objSqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataSet ds = new DataSet("StudentDataSet");

            adapter.Fill(ds);

            return ds.Tables[0];
        }



        public int DeleteStudent(int studentId)
        {
            SqlConnection objSqlConnection = new SqlConnection(ConnectionString);
            objSqlConnection.Open();

            string query = $"delete from StudentTable where StudentId='{studentId}'";

            SqlCommand sqlCommand = new SqlCommand(query, objSqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.Text;

            int result = sqlCommand.ExecuteNonQuery();

            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                // 4. Close the connection:
                objSqlConnection.Close();
            }

            return result;



        }


        public int UpdateSaveStudent(Student student)
        {

            SqlConnection objSqlConnection = new SqlConnection(ConnectionString);


            objSqlConnection.Open();

            string query = $"update StudentTable set FirstName='{student.FirstName}',LastName='{student.LastName}',Email='{student.Email}',Age='{student.Age}' where StudentId='{student.StudentId}'";


            SqlCommand objSqlCommand = new SqlCommand(query, objSqlConnection);

            objSqlCommand.CommandType = System.Data.CommandType.Text;

            int result = objSqlCommand.ExecuteNonQuery();

            if (objSqlConnection.State == System.Data.ConnectionState.Open)
            {
                // 4. Close the connection:
                objSqlConnection.Close();
            }

            return result;
        }






    }
}