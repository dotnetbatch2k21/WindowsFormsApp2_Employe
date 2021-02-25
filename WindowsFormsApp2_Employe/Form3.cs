using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp2_Employe
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string constring = ConfigurationManager.ConnectionStrings["c"].ToString();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
              
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select empid from Employee", con);
                con.Open();
                IDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int i = 0;
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[i].ToString());
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

              
                con = new SqlConnection(constring);
                String  query = "select * from Employee;select deptname,Location from dept"+ comboBox1.SelectedText;

                cmd = new SqlCommand(query,con);
                con.Open();
                IDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //bool i = true;
                while (dr.Read())
                {
                    textBox1.Text = dr["empid"].ToString();
                    txt_name.Text = dr["empname"].ToString();
                    txt_salary.Text = dr["salary"].ToString();
                    txt_Designation.Text = dr["designation"].ToString();
                    txt_deptid.Text = dr["deptid"].ToString();
                    txt_age.Text = dr["age"].ToString();
                }

                dr.NextResult();
                while (dr.Read())
                    {

                        
                        textBox2.Text = dr["deptname"].ToString();
                        textBox3.Text = dr["Location"].ToString();
                    }
                   
                



              

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
