using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelReservationSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBTravel;Integrated Security=True");
        private void login_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Passengers where ID=@p1 and Password=@p2", conn);
            cmd.Parameters.AddWithValue("@p1",id_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2",password_txtbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.id = dr[3].ToString();
                this.Hide();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid ID or password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                id_txtbox.Text = "";
                password_txtbox.Text = "";
                id_txtbox.Focus();
            }
            conn.Close();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void signup_lbl_MouseEnter(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.DarkKhaki;
        }

        private void signup_lbl_MouseLeave(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.Transparent;
        }

        private void signup_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPassenger fr = new NewPassenger();
            this.Hide();
            fr.ShowDialog();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            BNGSTravel fr = new BNGSTravel();
            this.Close();
            fr.Show();
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkKhaki;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }
    }
}
