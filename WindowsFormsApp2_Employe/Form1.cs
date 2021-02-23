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
    }
}
