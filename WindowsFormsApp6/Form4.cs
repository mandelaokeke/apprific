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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnbal_Click(object sender, EventArgs e)
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
                    textBox1.Text = dr["Balance"].ToString();
                }

            }
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
