using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2_Employe
{
    public partial class salary : Form
    {
        Employee ObjEmployee = new Employee();
        public salary()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ObjEmployee.EmpId = Convert.ToInt32(textBox1.Text);
                ObjEmployee.EmpName = txt_name.Text;
                ObjEmployee.salary = Convert.ToDouble(txt_salary.Text);
                ObjEmployee.designation = txt_Designation.Text;
                ObjEmployee.age = int.Parse(txt_age.Text);
                ObjEmployee.deptid = int.Parse(txt_deptid.Text);
                SqlHelper sh = new SqlHelper();
              bool t=  sh.AddEmployee(ObjEmployee);
                if (t)
                {
                    MessageBox.Show("Employee Added");
                }
                else
                {
                    MessageBox.Show("Employee NOTAdded");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=PENDORA;Initial Catalog=payrollmanagent_db;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee Where empid=@empid",con);
                cmd.Parameters.AddWithValue("@empid", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.HasRows)
                {
                    textBox1.Text = dr[0].ToString();
              
                    txt_name.Text= dr[1].ToString();
                    txt_salary.Text= dr[2].ToString();
                    txt_Designation.Text= dr[3].ToString();
                    txt_age.Text= dr[4].ToString();
                    txt_deptid.Text= dr[5].ToString();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
