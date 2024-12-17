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
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            BNGSTravel fr = new BNGSTravel();
            this.Close();
            fr.Show();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_bttn_Click(object sender, EventArgs e)
        {
            if(username_txtbox.Text == "user" && password_txtbox.Text == "password")
            {
                Admin fr = new Admin();
                this.Close();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid user name or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txtbox.Text = "";
                password_txtbox.Text = "";
                username_txtbox.Focus();
            }
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkKhaki;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkKhaki;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void login_bttn_MouseEnter(object sender, EventArgs e)
        {
            login_bttn.BackColor = Color.DarkKhaki;
        }

        private void login_bttn_MouseLeave(object sender, EventArgs e)
        {
            login_bttn.BackColor = Color.Transparent;
        }
    }
}
