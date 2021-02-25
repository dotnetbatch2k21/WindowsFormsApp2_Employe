using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Employe
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form4()
        {
            InitializeComponent();
        }

        private void GetAllEmployee_Click(object sender, EventArgs e)
        {

            try
            {
                string constring = ConfigurationManager.ConnectionStrings["c"].ToString();
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select * from Employee", con);
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Employee");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
