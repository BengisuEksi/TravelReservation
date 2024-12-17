namespace TravelReservationSystem
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_route_bttn = new System.Windows.Forms.Button();
            this.delete_route_bttn = new System.Windows.Forms.Button();
            this.update_route_bttn = new System.Windows.Forms.Button();
            this.view_routes_bttn = new System.Windows.Forms.Button();
            this.addroute_bttn = new System.Windows.Forms.Button();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.driver_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.time_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.date_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.arrival_txtbox = new System.Windows.Forms.TextBox();
            this.departure_txtbox = new System.Windows.Forms.TextBox();
            this.travel_id_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deletedriver_bttn = new System.Windows.Forms.Button();
            this.viewdrivers_bttn = new System.Windows.Forms.Button();
            this.driver_dataGridView = new System.Windows.Forms.DataGridView();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.adddriver_bttn = new System.Windows.Forms.Button();
            this.driver_phone_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.driver_fullname_txtbox = new System.Windows.Forms.TextBox();
            this.driverid_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.routes_dataGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.back_bttn = new System.Windows.Forms.Button();
            this.update_driver_bttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driver_dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(914, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 3;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.clear_route_bttn);
            this.groupBox1.Controls.Add(this.delete_route_bttn);
            this.groupBox1.Controls.Add(this.update_route_bttn);
            this.groupBox1.Controls.Add(this.view_routes_bttn);
            this.groupBox1.Controls.Add(this.addroute_bttn);
            this.groupBox1.Controls.Add(this.price_txtbox);
            this.groupBox1.Controls.Add(this.driver_txtbox);
            this.groupBox1.Controls.Add(this.time_txtbox);
            this.groupBox1.Controls.Add(this.date_txtbox);
            this.groupBox1.Controls.Add(this.arrival_txtbox);
            this.groupBox1.Controls.Add(this.departure_txtbox);
            this.groupBox1.Controls.Add(this.travel_id_txtbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Route";
            // 
            // clear_route_bttn
            // 
            this.clear_route_bttn.BackColor = System.Drawing.Color.Transparent;
            this.clear_route_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_route_bttn.Location = new System.Drawing.Point(263, 231);
            this.clear_route_bttn.Name = "clear_route_bttn";
            this.clear_route_bttn.Size = new System.Drawing.Size(125, 29);
            this.clear_route_bttn.TabIndex = 11;
            this.clear_route_bttn.Text = "Clear";
            this.clear_route_bttn.UseVisualStyleBackColor = false;
            this.clear_route_bttn.Click += new System.EventHandler(this.clear_route_bttn_Click);
            this.clear_route_bttn.MouseEnter += new System.EventHandler(this.clear_route_bttn_MouseEnter);
            this.clear_route_bttn.MouseLeave += new System.EventHandler(this.clear_route_bttn_MouseLeave);
            // 
            // delete_route_bttn
            // 
            this.delete_route_bttn.BackColor = System.Drawing.Color.Transparent;
            this.delete_route_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_route_bttn.Location = new System.Drawing.Point(263, 162);
            this.delete_route_bttn.Name = "delete_route_bttn";
            this.delete_route_bttn.Size = new System.Drawing.Size(125, 29);
            this.delete_route_bttn.TabIndex = 9;
            this.delete_route_bttn.Text = "Delete Route";
            this.delete_route_bttn.UseVisualStyleBackColor = false;
            this.delete_route_bttn.Click += new System.EventHandler(this.delete_route_bttn_Click);
            this.delete_route_bttn.MouseEnter += new System.EventHandler(this.delete_route_bttn_MouseEnter);
            this.delete_route_bttn.MouseLeave += new System.EventHandler(this.delete_route_bttn_MouseLeave);
            // 
            // update_route_bttn
            // 
            this.update_route_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_route_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_route_bttn.Location = new System.Drawing.Point(263, 127);
            this.update_route_bttn.Name = "update_route_bttn";
            this.update_route_bttn.Size = new System.Drawing.Size(125, 29);
            this.update_route_bttn.TabIndex = 8;
            this.update_route_bttn.Text = "Update Route";
            this.update_route_bttn.UseVisualStyleBackColor = false;
            this.update_route_bttn.Click += new System.EventHandler(this.update_route_bttn_Click);
            this.update_route_bttn.MouseEnter += new System.EventHandler(this.update_route_bttn_MouseEnter);
            this.update_route_bttn.MouseLeave += new System.EventHandler(this.update_route_bttn_MouseLeave);
            // 
            // view_routes_bttn
            // 
            this.view_routes_bttn.BackColor = System.Drawing.Color.Transparent;
            this.view_routes_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_routes_bttn.Location = new System.Drawing.Point(263, 196);
            this.view_routes_bttn.Name = "view_routes_bttn";
            this.view_routes_bttn.Size = new System.Drawing.Size(125, 29);
            this.view_routes_bttn.TabIndex = 10;
            this.view_routes_bttn.Text = "View Routes";
            this.view_routes_bttn.UseVisualStyleBackColor = false;
            this.view_routes_bttn.Click += new System.EventHandler(this.view_routes_bttn_Click);
            this.view_routes_bttn.MouseEnter += new System.EventHandler(this.view_routes_bttn_MouseEnter);
            this.view_routes_bttn.MouseLeave += new System.EventHandler(this.view_routes_bttn_MouseLeave);
            // 
            // addroute_bttn
            // 
            this.addroute_bttn.BackColor = System.Drawing.Color.Transparent;
            this.addroute_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addroute_bttn.Location = new System.Drawing.Point(263, 92);
            this.addroute_bttn.Name = "addroute_bttn";
            this.addroute_bttn.Size = new System.Drawing.Size(125, 29);
            this.addroute_bttn.TabIndex = 7;
            this.addroute_bttn.Text = "Add Route";
            this.addroute_bttn.UseVisualStyleBackColor = false;
            this.addroute_bttn.Click += new System.EventHandler(this.addroute_bttn_Click);
            this.addroute_bttn.MouseEnter += new System.EventHandler(this.addroute_bttn_MouseEnter);
            this.addroute_bttn.MouseLeave += new System.EventHandler(this.addroute_bttn_MouseLeave);
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(105, 277);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(141, 27);
            this.price_txtbox.TabIndex = 6;
            // 
            // driver_txtbox
            // 
            this.driver_txtbox.Location = new System.Drawing.Point(105, 239);
            this.driver_txtbox.Mask = "0000";
            this.driver_txtbox.Name = "driver_txtbox";
            this.driver_txtbox.Size = new System.Drawing.Size(141, 27);
            this.driver_txtbox.TabIndex = 5;
            // 
            // time_txtbox
            // 
            this.time_txtbox.Location = new System.Drawing.Point(105, 200);
            this.time_txtbox.Mask = "00:00";
            this.time_txtbox.Name = "time_txtbox";
            this.time_txtbox.Size = new System.Drawing.Size(141, 27);
            this.time_txtbox.TabIndex = 4;
            this.time_txtbox.ValidatingType = typeof(System.DateTime);
            // 
            // date_txtbox
            // 
            this.date_txtbox.Location = new System.Drawing.Point(105, 161);
            this.date_txtbox.Mask = "00/00/0000";
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.Size = new System.Drawing.Size(141, 27);
            this.date_txtbox.TabIndex = 3;
            this.date_txtbox.ValidatingType = typeof(System.DateTime);
            // 
            // arrival_txtbox
            // 
            this.arrival_txtbox.Location = new System.Drawing.Point(105, 123);
            this.arrival_txtbox.Name = "arrival_txtbox";
            this.arrival_txtbox.Size = new System.Drawing.Size(141, 27);
            this.arrival_txtbox.TabIndex = 2;
            // 
            // departure_txtbox
            // 
            this.departure_txtbox.Location = new System.Drawing.Point(105, 85);
            this.departure_txtbox.Name = "departure_txtbox";
            this.departure_txtbox.Size = new System.Drawing.Size(141, 27);
            this.departure_txtbox.TabIndex = 1;
            // 
            // travel_id_txtbox
            // 
            this.travel_id_txtbox.Enabled = false;
            this.travel_id_txtbox.Location = new System.Drawing.Point(105, 47);
            this.travel_id_txtbox.Name = "travel_id_txtbox";
            this.travel_id_txtbox.Size = new System.Drawing.Size(141, 27);
            this.travel_id_txtbox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(44, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(37, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Driver: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(47, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Time: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(49, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(34, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arrival: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Departure: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Travel No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.update_driver_bttn);
            this.groupBox2.Controls.Add(this.deletedriver_bttn);
            this.groupBox2.Controls.Add(this.viewdrivers_bttn);
            this.groupBox2.Controls.Add(this.driver_dataGridView);
            this.groupBox2.Controls.Add(this.clear_bttn);
            this.groupBox2.Controls.Add(this.adddriver_bttn);
            this.groupBox2.Controls.Add(this.driver_phone_txtbox);
            this.groupBox2.Controls.Add(this.driver_fullname_txtbox);
            this.groupBox2.Controls.Add(this.driverid_txtbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(425, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Driver";
            // 
            // deletedriver_bttn
            // 
            this.deletedriver_bttn.BackColor = System.Drawing.Color.Transparent;
            this.deletedriver_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletedriver_bttn.Location = new System.Drawing.Point(311, 45);
            this.deletedriver_bttn.Name = "deletedriver_bttn";
            this.deletedriver_bttn.Size = new System.Drawing.Size(165, 29);
            this.deletedriver_bttn.TabIndex = 4;
            this.deletedriver_bttn.Text = "Delete Driver";
            this.deletedriver_bttn.UseVisualStyleBackColor = false;
            this.deletedriver_bttn.Click += new System.EventHandler(this.deletedriver_bttn_Click);
            this.deletedriver_bttn.MouseEnter += new System.EventHandler(this.deletedriver_bttn_MouseEnter);
            this.deletedriver_bttn.MouseLeave += new System.EventHandler(this.deletedriver_bttn_MouseLeave);
            // 
            // viewdrivers_bttn
            // 
            this.viewdrivers_bttn.BackColor = System.Drawing.Color.Transparent;
            this.viewdrivers_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewdrivers_bttn.Location = new System.Drawing.Point(311, 115);
            this.viewdrivers_bttn.Name = "viewdrivers_bttn";
            this.viewdrivers_bttn.Size = new System.Drawing.Size(165, 29);
            this.viewdrivers_bttn.TabIndex = 5;
            this.viewdrivers_bttn.Text = "View Drivers";
            this.viewdrivers_bttn.UseVisualStyleBackColor = false;
            this.viewdrivers_bttn.Click += new System.EventHandler(this.viewdrivers_bttn_Click);
            this.viewdrivers_bttn.MouseEnter += new System.EventHandler(this.viewdrivers_bttn_MouseEnter);
            this.viewdrivers_bttn.MouseLeave += new System.EventHandler(this.viewdrivers_bttn_MouseLeave);
            // 
            // driver_dataGridView
            // 
            this.driver_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driver_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driver_dataGridView.Location = new System.Drawing.Point(6, 203);
            this.driver_dataGridView.Name = "driver_dataGridView";
            this.driver_dataGridView.RowHeadersWidth = 51;
            this.driver_dataGridView.RowTemplate.Height = 24;
            this.driver_dataGridView.Size = new System.Drawing.Size(494, 134);
            this.driver_dataGridView.TabIndex = 19;
            this.driver_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driver_dataGridView_CellDoubleClick);
            // 
            // clear_bttn
            // 
            this.clear_bttn.BackColor = System.Drawing.Color.Transparent;
            this.clear_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_bttn.Location = new System.Drawing.Point(311, 150);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(165, 29);
            this.clear_bttn.TabIndex = 6;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = false;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            this.clear_bttn.MouseEnter += new System.EventHandler(this.clear_bttn_MouseEnter);
            this.clear_bttn.MouseLeave += new System.EventHandler(this.clear_bttn_MouseLeave);
            // 
            // adddriver_bttn
            // 
            this.adddriver_bttn.BackColor = System.Drawing.Color.Transparent;
            this.adddriver_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddriver_bttn.Location = new System.Drawing.Point(144, 157);
            this.adddriver_bttn.Name = "adddriver_bttn";
            this.adddriver_bttn.Size = new System.Drawing.Size(149, 29);
            this.adddriver_bttn.TabIndex = 3;
            this.adddriver_bttn.Text = "Add Driver";
            this.adddriver_bttn.UseVisualStyleBackColor = false;
            this.adddriver_bttn.Click += new System.EventHandler(this.adddriver_bttn_Click);
            this.adddriver_bttn.MouseEnter += new System.EventHandler(this.adddriver_bttn_MouseEnter);
            this.adddriver_bttn.MouseLeave += new System.EventHandler(this.adddriver_bttn_MouseLeave);
            // 
            // driver_phone_txtbox
            // 
            this.driver_phone_txtbox.Location = new System.Drawing.Point(144, 119);
            this.driver_phone_txtbox.Mask = "(999) 000-0000";
            this.driver_phone_txtbox.Name = "driver_phone_txtbox";
            this.driver_phone_txtbox.Size = new System.Drawing.Size(149, 27);
            this.driver_phone_txtbox.TabIndex = 2;
            // 
            // driver_fullname_txtbox
            // 
            this.driver_fullname_txtbox.Location = new System.Drawing.Point(144, 82);
            this.driver_fullname_txtbox.Name = "driver_fullname_txtbox";
            this.driver_fullname_txtbox.Size = new System.Drawing.Size(149, 27);
            this.driver_fullname_txtbox.TabIndex = 1;
            // 
            // driverid_txtbox
            // 
            this.driverid_txtbox.Enabled = false;
            this.driverid_txtbox.Location = new System.Drawing.Point(144, 44);
            this.driverid_txtbox.Name = "driverid_txtbox";
            this.driverid_txtbox.Size = new System.Drawing.Size(149, 27);
            this.driverid_txtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(77, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(49, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Full Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Driver Number:  ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.routes_dataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 242);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Routes";
            // 
            // routes_dataGridView
            // 
            this.routes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routes_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routes_dataGridView.Location = new System.Drawing.Point(3, 23);
            this.routes_dataGridView.Name = "routes_dataGridView";
            this.routes_dataGridView.RowHeadersWidth = 51;
            this.routes_dataGridView.RowTemplate.Height = 24;
            this.routes_dataGridView.Size = new System.Drawing.Size(913, 216);
            this.routes_dataGridView.TabIndex = 0;
            this.routes_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routes_dataGridView_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(302, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(341, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "BNGS Travel Management System";
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Transparent;
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bttn.Location = new System.Drawing.Point(881, 0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 2;
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            this.back_bttn.MouseEnter += new System.EventHandler(this.back_bttn_MouseEnter);
            this.back_bttn.MouseLeave += new System.EventHandler(this.back_bttn_MouseLeave);
            // 
            // update_driver_bttn
            // 
            this.update_driver_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_driver_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_driver_bttn.Location = new System.Drawing.Point(311, 80);
            this.update_driver_bttn.Name = "update_driver_bttn";
            this.update_driver_bttn.Size = new System.Drawing.Size(165, 29);
            this.update_driver_bttn.TabIndex = 20;
            this.update_driver_bttn.Text = "Update Driver";
            this.update_driver_bttn.UseVisualStyleBackColor = false;
            this.update_driver_bttn.Click += new System.EventHandler(this.update_driver_bttn_Click);
            this.update_driver_bttn.MouseEnter += new System.EventHandler(this.update_driver_bttn_MouseEnter);
            this.update_driver_bttn.MouseLeave += new System.EventHandler(this.update_driver_bttn_MouseLeave);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 671);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driver_dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routes_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.MaskedTextBox driver_txtbox;
        private System.Windows.Forms.MaskedTextBox time_txtbox;
        private System.Windows.Forms.MaskedTextBox date_txtbox;
        private System.Windows.Forms.TextBox arrival_txtbox;
        private System.Windows.Forms.TextBox departure_txtbox;
        private System.Windows.Forms.TextBox travel_id_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Button adddriver_bttn;
        private System.Windows.Forms.MaskedTextBox driver_phone_txtbox;
        private System.Windows.Forms.TextBox driver_fullname_txtbox;
        private System.Windows.Forms.TextBox driverid_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView driver_dataGridView;
        private System.Windows.Forms.Button viewdrivers_bttn;
        private System.Windows.Forms.Button deletedriver_bttn;
        private System.Windows.Forms.Button addroute_bttn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView routes_dataGridView;
        private System.Windows.Forms.Button view_routes_bttn;
        private System.Windows.Forms.Button clear_route_bttn;
        private System.Windows.Forms.Button delete_route_bttn;
        private System.Windows.Forms.Button update_route_bttn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Button update_driver_bttn;
    }
}