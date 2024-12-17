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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string id;
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBTravel;Integrated Security=True");
        void full_name()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name,Surname from Tbl_Passengers where ID=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name_surname_lbl.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            conn.Close();
        }
        void ticket()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ticket", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void seats_res()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select TravelNo,Seat,Tbl_Passengers.Gender from Tbl_Travel inner join Tbl_Passengers on Tbl_Travel.PassengerID = Tbl_Passengers.ID where Tbl_Travel.PassengerID = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", passengerid_txtbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (travel_id_combobox.SelectedItem.ToString() == dr[0].ToString())
                {
                    string seat = dr[1].ToString();
                    Control button = this.Controls.Find($"button{seat}", true).FirstOrDefault();
                    if (button != null && button is Button)
                    {
                        if (dr[2].ToString() == "True")
                        {
                            Button buttonseat = (Button)button;
                            buttonseat.BackColor = Color.Pink;
                            buttonseat.Enabled = false;
                        }
                        else
                        {
                            Button buttonseat = (Button)button;
                            buttonseat.BackColor = Color.Blue;
                            buttonseat.Enabled = false;
                        }
                    }
                }
            }
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load Genders
            gender_combobox.Items.Add("Female");
            gender_combobox.Items.Add("Male");

            // Load Full Name
            full_name();

            // Load Person Information
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Tbl_Passengers where ID=@p1", conn);
            cmd1.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                name_txtbox.Text = dr1[1].ToString();
                surname_txtbox.Text = dr1[2].ToString();
                id_txtbox.Text = dr1[3].ToString();
                phone_txtbox.Text = dr1[4].ToString();
                if (dr1[5].ToString() == "True")
                {
                    gender_combobox.SelectedItem = "Female";
                }
                else
                {
                    gender_combobox.SelectedItem = "Male";
                }
                mail_txtbox.Text = dr1[6].ToString();
                password_txtbox.Text = dr1[7].ToString();
            }
            conn.Close();

            passengerid_txtbox.Text = id.ToString();
            dataGridView1.TabStop = false;
            dataGridView2.TabStop = false;

            // Load Travel ID's
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Ticket", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                travel_id_combobox.Items.Add(dr[0].ToString());
            }
            conn.Close();
        }
        void view_travel()
        {
            SqlDataAdapter da = new SqlDataAdapter("select TravelNo, (Tbl_Passengers.Name + ' ' + Tbl_Passengers.Surname) as FullName, Seat from Tbl_Travel\r\ninner join Tbl_Passengers\r\non Tbl_Travel.PassengerID = Tbl_Passengers.ID\r\nwhere PassengerID = " + passengerid_txtbox.Text, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void complete_bttn_MouseEnter(object sender, EventArgs e)
        {
            complete_bttn.BackColor = Color.DarkRed;
        }
        private void complete_bttn_MouseLeave(object sender, EventArgs e)
        {
            complete_bttn.BackColor = Color.Transparent;
        }
        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkRed;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkRed;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkRed;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkRed;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkRed;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkRed;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkRed;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.DarkRed;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.DarkRed;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.DarkRed;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackColor = Color.DarkRed;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.DarkRed;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.DarkRed;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackColor = Color.DarkRed;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackColor = Color.DarkRed;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackColor = Color.DarkRed;
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            button19.BackColor = Color.DarkRed;
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            button20.BackColor = Color.DarkRed;
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            button21.BackColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Transparent;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Transparent;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.Transparent;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.Transparent;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.Transparent;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.Transparent;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.Transparent;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.Transparent;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = Color.Transparent;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = Color.Transparent;
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.Transparent;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.Transparent;
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.DarkRed;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void delete_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.DarkRed;
        }

        private void delete_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Transparent;
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Passengers set Name=@p1,Surname=@p2,Phone=@p3,Gender=@p4,Mail=@p5,Password=@p6 where ID=@p7", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", phone_txtbox.Text);
            if(gender_combobox.SelectedItem == "Female")
            {
                cmd.Parameters.AddWithValue("@p4", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p4", false);
            }
            cmd.Parameters.AddWithValue("@p5", mail_txtbox.Text);
            cmd.Parameters.AddWithValue("@p6", password_txtbox.Text);
            cmd.Parameters.AddWithValue("@p7", id_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your information is updated.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            full_name();
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete your account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_Passengers where ID=@p1", conn);
                cmd.Parameters.AddWithValue("@p1",id_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Tbl_Travel where PassengerID=@p1", conn);
                cmd1.Parameters.AddWithValue("@p1", id_txtbox.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your account is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LogIn fr = new LogIn();
                this.Close();
                fr.Show();
            }
            else
            {
                ;
            }
            
        }

        private void signout_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to sign out?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                LogIn fr = new LogIn();
                this.Close();
                fr.Show();
            }
            else
            {
                ;
            }
        }

        private void signout_bttn_MouseEnter(object sender, EventArgs e)
        {
            signout_bttn.BackColor = Color.DarkRed;
        }

        private void signout_bttn_MouseLeave(object sender, EventArgs e)
        {
            signout_bttn.BackColor = Color.Transparent;
        }

        private void complete_bttn_Click(object sender, EventArgs e)
        {
            if (seat_txtbox.Text == "Pick a bus seat.")
            {
                MessageBox.Show("Choose an empty seat.","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Travel (TravelNo,PassengerID,Seat) values (@p1,@p2,@p3)",conn);
                cmd.Parameters.AddWithValue("@p1", travel_id_combobox.SelectedItem);
                cmd.Parameters.AddWithValue("@p2", passengerid_txtbox.Text);
                cmd.Parameters.AddWithValue("@p3", seat_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                seats_res();
                MessageBox.Show("Your reservation is completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear_res();
            }
        }
        void clear_res()
        {
            travel_id_combobox.SelectedIndex = -1;
            seat_txtbox.Text = "Pick a bus seat.";
        }
        private void view_routes_bttn_MouseEnter(object sender, EventArgs e)
        {
            view_routes_bttn.BackColor = Color.DarkRed;
        }

        private void view_routes_bttn_MouseLeave(object sender, EventArgs e)
        {
            view_routes_bttn.BackColor = Color.Transparent;
        }

        private void view_routes_bttn_Click(object sender, EventArgs e)
        {
            ticket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "16";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "17";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "18";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "19";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "20";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            seat_txtbox.Text = "21";
        }

        private void view_tickets_bttn_MouseEnter(object sender, EventArgs e)
        {
            view_tickets_bttn.BackColor = Color.DarkRed;
        }

        private void view_tickets_bttn_MouseLeave(object sender, EventArgs e)
        {
            view_tickets_bttn.BackColor = Color.Transparent;
        }

        private void view_tickets_bttn_Click(object sender, EventArgs e)
        {
            view_travel();
        }
        void travel_seats()
        {
            if(travel_id_combobox.SelectedItem == null) {; }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Tbl_Passengers.Gender,Seat from Tbl_Travel inner join Tbl_Passengers on Tbl_Travel.PassengerID = Tbl_Passengers.ID where Tbl_Travel.TravelNo = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", travel_id_combobox.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string seat = dr[1].ToString();
                    Control button = this.Controls.Find($"button{seat}", true).FirstOrDefault();
                    if (button != null && button is Button)
                    {
                        if (dr[0].ToString() == "True")
                        {
                            Button buttonseat = (Button)button;
                            buttonseat.BackColor = Color.Pink;
                            buttonseat.Enabled = false;
                        }
                        else
                        {
                            Button buttonseat = (Button)button;
                            buttonseat.BackColor = Color.Blue;
                            buttonseat.Enabled = false;
                        }
                    }
                }
                conn.Close();
            }
        }
        void reset_seat_buttons()
        {
            for (int i = 1; i <= 21; i++)
            {
                Control button = this.Controls.Find($"button{i}", true).FirstOrDefault();
                if (button != null && button is Button)
                {
                    button.BackColor = Color.Transparent;
                    button.Enabled = true;
                }
            }
        }
        private void travel_id_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset_seat_buttons();
            travel_seats();
        }
    }
}
