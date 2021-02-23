using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2_Employe
{
   public class SqlHelper
    {
        SqlConnection con;
        SqlCommand cmd;
        public SqlHelper()
        {

        }


        string s = ConfigurationManager.ConnectionStrings["c"].ToString();
        public bool AddEmployee(Employee emp)
        {
            try 
            {

                con = new SqlConnection(s);
                con.Open();
                string insertquery = "insert into Employee values(@empid,@empname,@salary,@designation,@age,@deptid)";
                cmd = new SqlCommand(insertquery, con);
                cmd.Parameters.AddWithValue("@empid", emp.EmpId);
                cmd.Parameters.AddWithValue("@empname", emp.EmpName);
                cmd.Parameters.AddWithValue("@salary", emp.salary);
                cmd.Parameters.AddWithValue("@designation", emp.designation);
                cmd.Parameters.AddWithValue("@age", emp.age);
                cmd.Parameters.AddWithValue("@deptid", emp.deptid);


                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            } 
            catch (SqlException ex)
            {

                throw  ex;
            }

            catch (Exception ex)
            {

                throw ex;
            }
           
            
        }

    }
}
