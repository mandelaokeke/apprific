using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var acNo = Form2.UniqueIdentity;

            using (SqlConnection connection = new SqlConnection())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUJDJS9;Initial Catalog=atmApp;Integrated Security=True");
                string sql = "SELECT * FROM NewAtmTable WHERE AccountNumber=@AccountNumber";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@AccountNumber", acNo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["Balance"].ToString();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var acNo = Form2.UniqueIdentity;

            using (SqlConnection connection = new SqlConnection())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUJDJS9;Initial Catalog=atmApp;Integrated Security=True");
                string sql = "SELECT * FROM NewAtmTable WHERE AccountNumber=@AccountNumber";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@AccountNumber", acNo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["Withdrawal"].ToString();
                }

                

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var acNo = Form2.UniqueIdentity;

            using (SqlConnection connection = new SqlConnection())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUJDJS9;Initial Catalog=atmApp;Integrated Security=True");
                string sql = "SELECT * FROM NewAtmTable WHERE AccountNumber=@AccountNumber";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@AccountNumber", acNo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox3.Text = dr["Deposit"].ToString();
                }

            }
        }
    }
}
