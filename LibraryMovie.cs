using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanLateFeeCalculator
{
    public partial class frmLibrary : Form
    {
        public frmLibrary()
        {
            InitializeComponent();
            txCurrent.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           System.Windows.Forms.Application.Exit();
        }

        
        private void movie_cal_Click(object sender, EventArgs e)
        {
            // Generate the current date
            DateTime dCurrent = DateTime.Now;
            // Generate the due date based on user entry in textbox txtDue
            DateTime dDue = DateTime.Parse(txtDue.Text);
            // Calculate the number of days late
            TimeSpan days = (dCurrent.Date - dDue.Date);
            double numberOfDays = days.TotalDays;
            // Display the number of days late in the textbox txtNum
            txtNum.Text = numberOfDays.ToString();
            // Calculate the late fee, the ‘2’ will change for each of the types of movie
            double lateFee = 2 * numberOfDays;
            // Display the late fee as currency in the textbox txtFee
            txtFee.Text = lateFee.ToString("c");
        }

        private void main_btn_Click_1(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            Main.Show();
            this.Close();

        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {

        }

        private void LateFee_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Due_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txCurrent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
