using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelReservationSystem
{
    public partial class NewPassenger : Form
    {
        public NewPassenger()
        {
            InitializeComponent();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            LogIn fr = new LogIn();
            this.Close();
            fr.Show();
        }

        private void signup_bttn_MouseEnter(object sender, EventArgs e)
        {
            signup_bttn.BackColor = SystemColors.ButtonFace;
        }

        private void signup_bttn_MouseLeave(object sender, EventArgs e)
        {
            signup_bttn.BackColor = Color.Transparent;
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = SystemColors.ButtonFace;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = SystemColors.ButtonFace;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBTravel;Integrated Security=True");

        private void signup_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Passengers (Name,Surname,ID,Phone,Gender,Mail,Password) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", id_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", phone_txtbox.Text);
            if(gender_combobox.SelectedItem == "Female")
            {
                cmd.Parameters.AddWithValue("@p5", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p5", false);
            }
            cmd.Parameters.AddWithValue("@p6", mail_txtbox.Text);
            cmd.Parameters.AddWithValue("@p7", password_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your account is created.","",MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

        private void NewPassenger_Load(object sender, EventArgs e)
        {
            gender_combobox.Items.Add("Female");
            gender_combobox.Items.Add("Male");
        }
    }
}
