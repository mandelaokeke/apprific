using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public static string UniqueIdentity;
        
        
       
       
        public Form2()
        {
            InitializeComponent();
            txtPin.PasswordChar = '*';
            txtPin.MaxLength = 4;
        }
        
        
        
        //public AccountUser(AccountModel accountModel)
        //{
        //    loginData = accountModel;
        //    InitializeComponent();
        //}
        private void btnEter_Click(object sender, EventArgs e)
        {


            //AccountModel accountModel = new AccountModel();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUJDJS9;Initial Catalog=atmApp;Integrated Security=True");
                    string sql = "SELECT * FROM NewAtmTable WHERE AccountNumber=@AccountNumber AND Pin = @Pin ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccNo.Text);
                    cmd.Parameters.AddWithValue("@Pin", txtPin.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {


                        Form3 frm3 = new Form3();
                        UniqueIdentity = dr["AccountNumber"].ToString();
                        new Form3().Show();


                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You have entered a wrong username or password");
                    }
                    if (string.IsNullOrWhiteSpace(txtAccNo.Text) || string.IsNullOrWhiteSpace(txtPin.Text))
                    {
                        MessageBox.Show("Please Fill Up The Spaces");
                    }

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
