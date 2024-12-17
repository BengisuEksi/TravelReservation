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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBTravel;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void clear_driver()
        {
            driverid_txtbox.Text = "";
            driver_fullname_txtbox.Text = "";
            driver_phone_txtbox.Text = "";
        }
        private void clear_bttn_Click(object sender, EventArgs e)
        {
            clear_driver();
        }
        public int GenerateUniqueDriverNumber(SqlConnection conn)
        {
            Random rnd = new Random();
            int randomNumber;
            bool isUnique = false;

            do
            {
                randomNumber = rnd.Next(1000, 10000);

                string query = "SELECT COUNT(*) FROM Tbl_Driver WHERE DriverNumber = @p1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", randomNumber);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }
            } while (!isUnique);
            return randomNumber;
        }
        void view_drivers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Driver",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            driver_dataGridView.DataSource = dt;
        }
        private void adddriver_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int driver_no = GenerateUniqueDriverNumber(conn);
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Driver (DriverNumber,FullName,Phone) values (@p1,@p2,@p3)", conn);
            cmd.Parameters.AddWithValue("@p1", driver_no);
            driverid_txtbox.Text = driver_no.ToString();
            cmd.Parameters.AddWithValue("@p2", driver_fullname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", driver_phone_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New driver is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            view_drivers();
            clear_driver();
        }

        private void viewdrivers_bttn_Click(object sender, EventArgs e)
        {
            view_drivers();
        }

        private void deletedriver_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Driver where DriverNumber=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", driverid_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Driver is deleted.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            view_drivers();
            clear_driver();
        }

        private void driver_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = driver_dataGridView.SelectedCells[0].RowIndex;
            driverid_txtbox.Text = driver_dataGridView.Rows[no].Cells[1].Value.ToString();
            driver_fullname_txtbox.Text = driver_dataGridView.Rows[no].Cells[2].Value.ToString();
            driver_phone_txtbox.Text = driver_dataGridView.Rows[no].Cells[3].Value.ToString();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to sign out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                AdminLogIn fr = new AdminLogIn();
                this.Close();
                fr.Show();
            }
            else {;}
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void addroute_bttn_MouseEnter(object sender, EventArgs e)
        {
            addroute_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void addroute_bttn_MouseLeave(object sender, EventArgs e)
        {
            addroute_bttn.BackColor = Color.Transparent;
        }

        private void update_route_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_route_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void update_route_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_route_bttn.BackColor = Color.Transparent;
        }

        private void delete_route_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_route_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void delete_route_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_route_bttn.BackColor = Color.Transparent;
        }

        private void view_routes_bttn_MouseEnter(object sender, EventArgs e)
        {
            view_routes_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void view_routes_bttn_MouseLeave(object sender, EventArgs e)
        {
            view_routes_bttn.BackColor = Color.Transparent;
        }

        private void clear_route_bttn_MouseEnter(object sender, EventArgs e)
        {
            clear_route_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void clear_route_bttn_MouseLeave(object sender, EventArgs e)
        {
            clear_route_bttn.BackColor = Color.Transparent;
        }

        private void adddriver_bttn_MouseEnter(object sender, EventArgs e)
        {
            adddriver_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void adddriver_bttn_MouseLeave(object sender, EventArgs e)
        {
            adddriver_bttn.BackColor = Color.Transparent;
        }

        private void deletedriver_bttn_MouseEnter(object sender, EventArgs e)
        {
            deletedriver_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void deletedriver_bttn_MouseLeave(object sender, EventArgs e)
        {
            deletedriver_bttn.BackColor = Color.Transparent;
        }

        private void viewdrivers_bttn_MouseEnter(object sender, EventArgs e)
        {
            viewdrivers_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void viewdrivers_bttn_MouseLeave(object sender, EventArgs e)
        {
            viewdrivers_bttn.BackColor = Color.Transparent;
        }

        private void clear_bttn_MouseEnter(object sender, EventArgs e)
        {
            clear_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void clear_bttn_MouseLeave(object sender, EventArgs e)
        {
            clear_bttn.BackColor = Color.Transparent;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            driver_dataGridView.TabStop = false;
            routes_dataGridView.TabStop = false;
        }

        private void update_driver_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_driver_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void update_driver_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_driver_bttn.BackColor = Color.Transparent;
        }

        private void update_driver_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Driver set FullName=@p1,Phone=@p2 where DriverNumber=@p3", conn);
            cmd.Parameters.AddWithValue("@p1", driver_fullname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", driver_phone_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", driverid_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Driver information is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            view_drivers();
            clear_driver();
        }
        void view_routes()
        {
            SqlDataAdapter da = new SqlDataAdapter("select TravelNo,Departure,Arrival,Date,Time,Tbl_Driver.FullName as Driver,Price from Tbl_Ticket\r\ninner join Tbl_Driver\r\non Tbl_Ticket.Driver = Tbl_Driver.DriverNumber", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            routes_dataGridView.DataSource = dt;
        }
        void clear_routes()
        {
            travel_id_txtbox.Text = "";
            departure_txtbox.Text = "";
            arrival_txtbox.Text = "";
            date_txtbox.Text = "";
            time_txtbox.Text = "";
            driver_txtbox.Text = "";
            price_txtbox.Text = "";
        }
        private void view_routes_bttn_Click(object sender, EventArgs e)
        {
            view_routes();
        }

        private void routes_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = routes_dataGridView.SelectedCells[0].RowIndex;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select DriverNumber from Tbl_Driver where FullName=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", routes_dataGridView.Rows[no].Cells[5].Value.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                driver_txtbox.Text = dr[0].ToString();
            }
            conn.Close();
            travel_id_txtbox.Text = routes_dataGridView.Rows[no].Cells[0].Value.ToString();
            departure_txtbox.Text = routes_dataGridView.Rows[no].Cells[1].Value.ToString();
            arrival_txtbox.Text = routes_dataGridView.Rows[no].Cells[2].Value.ToString();
            date_txtbox.Text = routes_dataGridView.Rows[no].Cells[3].Value.ToString();
            time_txtbox.Text = routes_dataGridView.Rows[no].Cells[4].Value.ToString();
            price_txtbox.Text = routes_dataGridView.Rows[no].Cells[6].Value.ToString();
        }

        private void addroute_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Ticket (Departure,Arrival,Date,Time,Driver,Price) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", departure_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", arrival_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", date_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", time_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", driver_txtbox.Text);
            cmd.Parameters.AddWithValue("@p6", price_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New route is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            view_routes();
            clear_routes();
        }

        private void clear_route_bttn_Click(object sender, EventArgs e)
        {
            clear_routes();
        }

        private void update_route_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Ticket set Departure=@p1,Arrival=@p2,Date=@p3,Time=@p4,Driver=@p5,Price=@p6 where TravelNo=@p7", conn);
            cmd.Parameters.AddWithValue("@p1", departure_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", arrival_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", date_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", time_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", driver_txtbox.Text);
            cmd.Parameters.AddWithValue("@p6", price_txtbox.Text);
            cmd.Parameters.AddWithValue("@p7", travel_id_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Route is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            view_routes();
            clear_routes();
        }

        private void delete_route_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this route?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_Ticket where TravelNo=@p1",conn);
                cmd.Parameters.AddWithValue("@p1", travel_id_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Route is deleted.","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                view_routes();
                clear_routes();
            }
            else {; }
        }
    }
}
