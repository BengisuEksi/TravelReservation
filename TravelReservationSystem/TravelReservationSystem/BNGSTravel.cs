using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelReservationSystem
{
    public partial class BNGSTravel : Form
    {
        public BNGSTravel()
        {
            InitializeComponent();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSlateBlue;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void userentry_lbl_MouseEnter(object sender, EventArgs e)
        {
            userentry_lbl.BackColor = Color.DarkSlateBlue;
        }

        private void userentry_lbl_MouseLeave(object sender, EventArgs e)
        {
            userentry_lbl.BackColor = Color.Transparent;
        }

        private void adminentry_lbl_MouseEnter(object sender, EventArgs e)
        {
            adminentry_lbl.BackColor = Color.DarkSlateBlue;
        }

        private void adminentry_lbl_MouseLeave(object sender, EventArgs e)
        {
            adminentry_lbl.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userentry_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn fr = new LogIn();
            this.Hide();
            fr.Show();

        }

        private void adminentry_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogIn fr = new AdminLogIn();
            this.Hide();
            fr.Show();
        }
    }
}
