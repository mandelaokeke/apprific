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
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPin.MaxLength = 4;
        }
        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var lbAccNum = txtAccName;
            var lbPin = txtPin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var acName = txtAccName.Text;
                myDBconnection AccNum = new myDBconnection();
                var acNo = AccNum.AccountNumber();
                var acPin = txtPin;
                //string query = "INSERT INTO NewAtmTable (AccountNumber,AccountName,Pin)";
                //query += "VALUES(@AccountNumber,@AccountName,@Pin)";
                string query = "INSERT INTO NewAtmTable (AccountNumber,AccountName,Pin,Balance) VALUES (@AccountNumber,@AccountName,@Pin,@Balance)";
                myDBconnection myDBCon = new myDBconnection();
                SqlConnection sqlConnection = new SqlConnection(myDBCon.conStr);
                SqlCommand myCommand = new SqlCommand(query, sqlConnection);


                myCommand.Parameters.AddWithValue("@AccountNumber", acNo);
                myCommand.Parameters.AddWithValue("@AccountName", txtAccName.Text);
                myCommand.Parameters.AddWithValue("@pin", txtPin.Text);
                myCommand.Parameters.AddWithValue("@Balance", 10000);
                sqlConnection.Open();


                myCommand.ExecuteNonQuery();

                if (string.IsNullOrEmpty(txtAccName.Text) || string.IsNullOrEmpty(txtPin.Text))
                {
                    MessageBox.Show("Please Fill in The Spaces");
                }
                else
                {
                    MessageBox.Show("You have successfully Created an account");
                    new Form2().Show();
                    this.Hide();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnlgin_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void txtAccName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
