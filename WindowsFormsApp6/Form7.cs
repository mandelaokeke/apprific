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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            txtdeposit.MaxLength = 7;
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

        private void btnCont_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnDepo_Click(object sender, EventArgs e)
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
                    var amount = Convert.ToDecimal(txtdeposit.Text);


                    returnedBalance = dbBalance + amount;
                    InsertDeposit(returnedBalance, amount, acNo);


                }


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void InsertDeposit(decimal newBalance, decimal DepositAmount, string acNo)
        {
            try
            {
                myDBconnection myDBCon = new myDBconnection();
                SqlConnection sqlConnection = new SqlConnection(myDBCon.conStr);


                string query = "SELECT * FROM NewAtmTable WHERE AccountNumber = @AccountNumber";

                SqlCommand myCommand = new SqlCommand(query, sqlConnection);


                myCommand.CommandText = ("UPDATE NewAtmTable SET Balance=@Balance,Deposit=@Deposit WHERE AccountNumber = @AccountNumber");
                sqlConnection.Open();


                myCommand.Parameters.AddWithValue("@AccountNumber", acNo);
                myCommand.Parameters.AddWithValue("@Balance", newBalance);
                myCommand.Parameters.AddWithValue("@Deposit", DepositAmount);


                myCommand.ExecuteNonQuery();

                new Form6().Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}



