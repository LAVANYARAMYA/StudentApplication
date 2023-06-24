using STU.DataAccess;
using STU.Model;
using System.Data;

namespace STU.BusinessLayer
{
    public class BusinessClass
    {

        private SqlServerClass objSqlServerAccess=new SqlServerClass();
        public BusinessClass() { }

        public bool AddStudent(Student student)
        {
      

            if (objSqlServerAccess.AddStudent(student) >= 1)
            {
                return true;
            }
            else
                return false;
        }


        public bool UpdateSaveStudent(Student student)
        {


            if (objSqlServerAccess.UpdateSaveStudent(student) >= 1)
            {
                return true;
            }
            else
                return false;
        }


        public DataTable FetchStudent()
        {
            DataTable dataTable = new DataTable();
            dataTable = objSqlServerAccess.FetchStudent();
            return dataTable;
        }



        public int DeleteStudent(int StudentId)
        {
            int res = objSqlServerAccess.DeleteStudent(StudentId);
            return res;
        }

       
    }
}