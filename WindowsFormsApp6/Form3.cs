using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(object me)
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Form4().Show();
            this.Hide();
        }

        private void txtAcNoHolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }
    }
}
