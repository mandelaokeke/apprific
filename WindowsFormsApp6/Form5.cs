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
    public partial class Form5 : Form
    {
      
        public Form5()
        {
            InitializeComponent();
            txtWithdraw.MaxLength = 6;
        }
        public Form5(object me)
        {
            InitializeComponent();
        }
        public class Person
        {
            public string Balance { get; set; }

        }


        private void button8_Click(object sender, EventArgs e)
        {

           
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void btn1k_Click(object sender, EventArgs e)
        {
        }


        private void button7_Click(object sender, EventArgs e)
        {
            var acNo = Form2.UniqueIdentity;
            decimal dbBalance = 0M;
            decimal returnedBalance = 0M;
            try {

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
                        dbBalance = (decimal)dr["Balance"];
                    }
                    var amount = Convert.ToDecimal(txtWithdraw.Text);
                    if (dbBalance > amount)
                    {
                        returnedBalance = dbBalance - amount;
                        InsertWithdrawal(returnedBalance, amount, acNo);
                    }
                    else
                    {
                        MessageBox.Show("You have Insufficient Funds");
                        new Form2().Show();
                        this.Hide();
                    }


                    if (string.IsNullOrWhiteSpace(txtWithdraw.Text))
                    {
                        MessageBox.Show("Please Insert a Value");
                    }

                }
               

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void InsertWithdrawal(decimal newBalance, decimal withdrawalAmount, string acNo)
        {
            try
            {
                myDBconnection myDBCon = new myDBconnection();
                SqlConnection sqlConnection = new SqlConnection(myDBCon.conStr);
               

                string query = "SELECT * FROM NewAtmTable WHERE AccountNumber = @AccountNumber";

                SqlCommand myCommand = new SqlCommand(query, sqlConnection);
              

                myCommand.CommandText = ("UPDATE NewAtmTable SET Balance=@Balance,Withdrawal=@Withdrawal WHERE AccountNumber = @AccountNumber");
                sqlConnection.Open();
               

                myCommand.Parameters.AddWithValue("@AccountNumber", acNo);
                myCommand.Parameters.AddWithValue("@Balance", newBalance);
                myCommand.Parameters.AddWithValue("@Withdrawal", withdrawalAmount);
               

                myCommand.ExecuteNonQuery();

                new Form6().Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtWithdraw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

