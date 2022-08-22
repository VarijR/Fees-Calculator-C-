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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNew NewRelease = new frmNew();
            NewRelease.ShowDialog();
            this.Close();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLibrary NewLibrary = new frmLibrary();
            NewLibrary.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKids NewKids = new frmKids();
            NewKids.ShowDialog();
            this.Close();
        }
    }
}
