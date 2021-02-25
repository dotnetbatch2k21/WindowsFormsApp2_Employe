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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["c"].ToString();
                 con = new SqlConnection(constring);
                cmd = new SqlCommand("select empid from Employee", con);
                con.Open();
                IDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int i=0;
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[i].ToString());
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
    }
}
