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
namespace HMSTutorial
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WIN_10\Documents\HMSdb.mdf;Integrated Security = True; Connect Timeout = 30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Enter a UserName And Password");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='" + DocNameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                    {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }  
               else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }
    }
}
