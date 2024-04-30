namespace Queueing_System
{
    partial class Main_Form
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
            this.main_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.System_Stats = new System.Windows.Forms.Label();
            this.server_stats_box = new System.Windows.Forms.TextBox();
            this.num_in_q_box = new System.Windows.Forms.TextBox();
            this.time_arv_four = new System.Windows.Forms.TextBox();
            this.time_arv_three = new System.Windows.Forms.TextBox();
            this.time_arv_two = new System.Windows.Forms.TextBox();
            this.time_arv_one = new System.Windows.Forms.TextBox();
            this.time_of_last_event_box = new System.Windows.Forms.TextBox();
            this.server_status = new System.Windows.Forms.Label();
            this.number_in_q = new System.Windows.Forms.Label();
            this.time_of_arrival = new System.Windows.Forms.Label();
            this.Time_of_last_event = new System.Windows.Forms.Label();
            this.clock_box = new System.Windows.Forms.TextBox();
            this.arrival_box = new System.Windows.Forms.TextBox();
            this.departure_box = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.Label();
            this.Event_List = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.number_delayed_box = new System.Windows.Forms.TextBox();
            this.total_delay_box = new System.Windows.Forms.TextBox();
            this.area_under_qt_box = new System.Windows.Forms.TextBox();
            this.area_under_bt_box = new System.Windows.Forms.TextBox();
            this.number_delay = new System.Windows.Forms.Label();
            this.total_delay = new System.Windows.Forms.Label();
            this.area_under_qt = new System.Windows.Forms.Label();
            this.area_under_bt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statistical_counters = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.count_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.Font = new System.Drawing.Font("GE SS Two Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.main_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.main_label.Location = new System.Drawing.Point(10, 12);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(347, 53);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "Queueing System";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("GE SS Two Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.exit_button.Location = new System.Drawing.Point(1191, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(47, 45);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // System_Stats
            // 
            this.System_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.System_Stats.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.System_Stats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.System_Stats.Location = new System.Drawing.Point(249, 95);
            this.System_Stats.Name = "System_Stats";
            this.System_Stats.Size = new System.Drawing.Size(216, 42);
            this.System_Stats.TabIndex = 2;
            this.System_Stats.Text = "System Stats";
            // 
            // server_stats_box
            // 
            this.server_stats_box.Location = new System.Drawing.Point(43, 287);
            this.server_stats_box.Multiline = true;
            this.server_stats_box.Name = "server_stats_box";
            this.server_stats_box.Size = new System.Drawing.Size(127, 96);
            this.server_stats_box.TabIndex = 3;
            // 
            // num_in_q_box
            // 
            this.num_in_q_box.Location = new System.Drawing.Point(200, 287);
            this.num_in_q_box.Multiline = true;
            this.num_in_q_box.Name = "num_in_q_box";
            this.num_in_q_box.Size = new System.Drawing.Size(127, 96);
            this.num_in_q_box.TabIndex = 4;
            // 
            // time_arv_four
            // 
            this.time_arv_four.Location = new System.Drawing.Point(348, 376);
            this.time_arv_four.Multiline = true;
            this.time_arv_four.Name = "time_arv_four";
            this.time_arv_four.Size = new System.Drawing.Size(127, 54);
            this.time_arv_four.TabIndex = 5;
            // 
            // time_arv_three
            // 
            this.time_arv_three.Location = new System.Drawing.Point(348, 307);
            this.time_arv_three.Multiline = true;
            this.time_arv_three.Name = "time_arv_three";
            this.time_arv_three.Size = new System.Drawing.Size(127, 54);
            this.time_arv_three.TabIndex = 6;
            // 
            // time_arv_two
            // 
            this.time_arv_two.Location = new System.Drawing.Point(348, 237);
            this.time_arv_two.Multiline = true;
            this.time_arv_two.Name = "time_arv_two";
            this.time_arv_two.Size = new System.Drawing.Size(127, 54);
            this.time_arv_two.TabIndex = 7;
            // 
            // time_arv_one
            // 
            this.time_arv_one.Location = new System.Drawing.Point(348, 167);
            this.time_arv_one.Multiline = true;
            this.time_arv_one.Name = "time_arv_one";
            this.time_arv_one.Size = new System.Drawing.Size(127, 54);
            this.time_arv_one.TabIndex = 8;
            // 
            // time_of_last_event_box
            // 
            this.time_of_last_event_box.Location = new System.Drawing.Point(498, 287);
            this.time_of_last_event_box.Multiline = true;
            this.time_of_last_event_box.Name = "time_of_last_event_box";
            this.time_of_last_event_box.Size = new System.Drawing.Size(127, 96);
            this.time_of_last_event_box.TabIndex = 9;
            // 
            // server_status
            // 
            this.server_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.server_status.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.server_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.server_status.Location = new System.Drawing.Point(59, 403);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(96, 80);
            this.server_status.TabIndex = 10;
            this.server_status.Text = "Server Status";
            // 
            // number_in_q
            // 
            this.number_in_q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.number_in_q.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.number_in_q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.number_in_q.Location = new System.Drawing.Point(213, 401);
            this.number_in_q.Name = "number_in_q";
            this.number_in_q.Size = new System.Drawing.Size(114, 82);
            this.number_in_q.TabIndex = 11;
            this.number_in_q.Text = "Number in Queue";
            // 
            // time_of_arrival
            // 
            this.time_of_arrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.time_of_arrival.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.time_of_arrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.time_of_arrival.Location = new System.Drawing.Point(365, 450);
            this.time_of_arrival.Name = "time_of_arrival";
            this.time_of_arrival.Size = new System.Drawing.Size(96, 103);
            this.time_of_arrival.TabIndex = 12;
            this.time_of_arrival.Text = "Times of Arrival";
            // 
            // Time_of_last_event
            // 
            this.Time_of_last_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.Time_of_last_event.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Time_of_last_event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.Time_of_last_event.Location = new System.Drawing.Point(514, 401);
            this.Time_of_last_event.Name = "Time_of_last_event";
            this.Time_of_last_event.Size = new System.Drawing.Size(96, 103);
            this.Time_of_last_event.TabIndex = 13;
            this.Time_of_last_event.Text = "Time of last event";
            // 
            // clock_box
            // 
            this.clock_box.Location = new System.Drawing.Point(764, 98);
            this.clock_box.Multiline = true;
            this.clock_box.Name = "clock_box";
            this.clock_box.Size = new System.Drawing.Size(127, 96);
            this.clock_box.TabIndex = 14;
            // 
            // arrival_box
            // 
            this.arrival_box.Location = new System.Drawing.Point(980, 98);
            this.arrival_box.Multiline = true;
            this.arrival_box.Name = "arrival_box";
            this.arrival_box.Size = new System.Drawing.Size(127, 54);
            this.arrival_box.TabIndex = 15;
            // 
            // departure_box
            // 
            this.departure_box.Location = new System.Drawing.Point(980, 170);
            this.departure_box.Multiline = true;
            this.departure_box.Name = "departure_box";
            this.departure_box.Size = new System.Drawing.Size(127, 54);
            this.departure_box.TabIndex = 16;
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clock.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.clock.Location = new System.Drawing.Point(791, 213);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(109, 54);
            this.clock.TabIndex = 17;
            this.clock.Text = "Clock";
            // 
            // Event_List
            // 
            this.Event_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.Event_List.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Event_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.Event_List.Location = new System.Drawing.Point(989, 248);
            this.Event_List.Name = "Event_List";
            this.Event_List.Size = new System.Drawing.Size(130, 34);
            this.Event_List.TabIndex = 18;
            this.Event_List.Text = "Event List";
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.A.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.A.Location = new System.Drawing.Point(939, 113);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(38, 36);
            this.A.TabIndex = 19;
            this.A.Text = "A";
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.D.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.D.Location = new System.Drawing.Point(939, 184);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(35, 36);
            this.D.TabIndex = 20;
            this.D.Text = "D";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.panel1.Location = new System.Drawing.Point(19, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 497);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.panel2.Location = new System.Drawing.Point(675, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 214);
            this.panel2.TabIndex = 22;
            // 
            // number_delayed_box
            // 
            this.number_delayed_box.Location = new System.Drawing.Point(705, 364);
            this.number_delayed_box.Multiline = true;
            this.number_delayed_box.Name = "number_delayed_box";
            this.number_delayed_box.Size = new System.Drawing.Size(92, 96);
            this.number_delayed_box.TabIndex = 23;
            // 
            // total_delay_box
            // 
            this.total_delay_box.Location = new System.Drawing.Point(843, 364);
            this.total_delay_box.Multiline = true;
            this.total_delay_box.Name = "total_delay_box";
            this.total_delay_box.Size = new System.Drawing.Size(92, 96);
            this.total_delay_box.TabIndex = 24;
            // 
            // area_under_qt_box
            // 
            this.area_under_qt_box.Location = new System.Drawing.Point(978, 364);
            this.area_under_qt_box.Multiline = true;
            this.area_under_qt_box.Name = "area_under_qt_box";
            this.area_under_qt_box.Size = new System.Drawing.Size(92, 96);
            this.area_under_qt_box.TabIndex = 25;
            // 
            // area_under_bt_box
            // 
            this.area_under_bt_box.Location = new System.Drawing.Point(1105, 364);
            this.area_under_bt_box.Multiline = true;
            this.area_under_bt_box.Name = "area_under_bt_box";
            this.area_under_bt_box.Size = new System.Drawing.Size(92, 96);
            this.area_under_bt_box.TabIndex = 26;
            // 
            // number_delay
            // 
            this.number_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.number_delay.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.number_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.number_delay.Location = new System.Drawing.Point(710, 479);
            this.number_delay.Name = "number_delay";
            this.number_delay.Size = new System.Drawing.Size(107, 65);
            this.number_delay.TabIndex = 27;
            this.number_delay.Text = "Number Delayed";
            // 
            // total_delay
            // 
            this.total_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.total_delay.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.total_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.total_delay.Location = new System.Drawing.Point(846, 479);
            this.total_delay.Name = "total_delay";
            this.total_delay.Size = new System.Drawing.Size(107, 65);
            this.total_delay.TabIndex = 28;
            this.total_delay.Text = "Total Delay";
            // 
            // area_under_qt
            // 
            this.area_under_qt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.area_under_qt.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.area_under_qt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.area_under_qt.Location = new System.Drawing.Point(986, 473);
            this.area_under_qt.Name = "area_under_qt";
            this.area_under_qt.Size = new System.Drawing.Size(83, 94);
            this.area_under_qt.TabIndex = 29;
            this.area_under_qt.Text = "Area Under Q(t)";
            // 
            // area_under_bt
            // 
            this.area_under_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.area_under_bt.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.area_under_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.area_under_bt.Location = new System.Drawing.Point(1113, 471);
            this.area_under_bt.Name = "area_under_bt";
            this.area_under_bt.Size = new System.Drawing.Size(83, 96);
            this.area_under_bt.TabIndex = 30;
            this.area_under_bt.Text = "Area Under B(t)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.statistical_counters);
            this.panel3.Location = new System.Drawing.Point(675, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 267);
            this.panel3.TabIndex = 31;
            // 
            // statistical_counters
            // 
            this.statistical_counters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.statistical_counters.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statistical_counters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.statistical_counters.Location = new System.Drawing.Point(144, 9);
            this.statistical_counters.Name = "statistical_counters";
            this.statistical_counters.Size = new System.Drawing.Size(306, 39);
            this.statistical_counters.TabIndex = 32;
            this.statistical_counters.Text = "Statistical Counters";
            // 
            // Calculate_button
            // 
            this.Calculate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.Calculate_button.FlatAppearance.BorderSize = 0;
            this.Calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate_button.Font = new System.Drawing.Font("GE SS Two Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Calculate_button.ForeColor = System.Drawing.Color.White;
            this.Calculate_button.Location = new System.Drawing.Point(65, 606);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(221, 62);
            this.Calculate_button.TabIndex = 32;
            this.Calculate_button.Text = "Start";
            this.Calculate_button.UseVisualStyleBackColor = false;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // count_btn
            // 
            this.count_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.count_btn.FlatAppearance.BorderSize = 0;
            this.count_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count_btn.Font = new System.Drawing.Font("GE SS Two Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.count_btn.ForeColor = System.Drawing.Color.White;
            this.count_btn.Location = new System.Drawing.Point(348, 606);
            this.count_btn.Name = "count_btn";
            this.count_btn.Size = new System.Drawing.Size(221, 62);
            this.count_btn.TabIndex = 33;
            this.count_btn.Text = "Count";
            this.count_btn.UseVisualStyleBackColor = false;
            this.count_btn.Click += new System.EventHandler(this.count_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1244, 695);
            this.Controls.Add(this.count_btn);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.area_under_bt);
            this.Controls.Add(this.area_under_qt);
            this.Controls.Add(this.total_delay);
            this.Controls.Add(this.number_delay);
            this.Controls.Add(this.area_under_bt_box);
            this.Controls.Add(this.area_under_qt_box);
            this.Controls.Add(this.total_delay_box);
            this.Controls.Add(this.number_delayed_box);
            this.Controls.Add(this.D);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Event_List);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.departure_box);
            this.Controls.Add(this.arrival_box);
            this.Controls.Add(this.clock_box);
            this.Controls.Add(this.Time_of_last_event);
            this.Controls.Add(this.time_of_arrival);
            this.Controls.Add(this.number_in_q);
            this.Controls.Add(this.server_status);
            this.Controls.Add(this.time_of_last_event_box);
            this.Controls.Add(this.time_arv_one);
            this.Controls.Add(this.time_arv_two);
            this.Controls.Add(this.time_arv_three);
            this.Controls.Add(this.time_arv_four);
            this.Controls.Add(this.num_in_q_box);
            this.Controls.Add(this.server_stats_box);
            this.Controls.Add(this.System_Stats);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label System_Stats;
        private System.Windows.Forms.TextBox server_stats_box;
        private System.Windows.Forms.TextBox num_in_q_box;
        private System.Windows.Forms.TextBox time_arv_four;
        private System.Windows.Forms.TextBox time_arv_three;
        private System.Windows.Forms.TextBox time_arv_two;
        private System.Windows.Forms.TextBox time_arv_one;
        private System.Windows.Forms.TextBox time_of_last_event_box;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.Label number_in_q;
        private System.Windows.Forms.Label time_of_arrival;
        private System.Windows.Forms.Label Time_of_last_event;
        private System.Windows.Forms.TextBox clock_box;
        private System.Windows.Forms.TextBox arrival_box;
        private System.Windows.Forms.TextBox departure_box;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label Event_List;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox number_delayed_box;
        private System.Windows.Forms.TextBox total_delay_box;
        private System.Windows.Forms.TextBox area_under_qt_box;
        private System.Windows.Forms.TextBox area_under_bt_box;
        private System.Windows.Forms.Label number_delay;
        private System.Windows.Forms.Label total_delay;
        private System.Windows.Forms.Label area_under_qt;
        private System.Windows.Forms.Label area_under_bt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statistical_counters;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button count_btn;
    }
}

