using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Queueing_System.Main_Form;

namespace Queueing_System
{
    public partial class Main_Form : Form
    {

        private Simulation simulation;
        public Main_Form()
        {
            InitializeComponent();
            simulation = new Simulation();
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            simulation.Initialize();
            UpdateStatsOnGUI();
        }

        private void UpdateStatsOnGUI()
        {
            server_stats_box.Text = " " + simulation.ServerStatus;

            num_in_q_box.Text = " " + simulation.NumInQ;


            // queue boxes 

            if (simulation.NumInQ == 0)
            {
                time_arv_one.Text = "";
                time_arv_two.Text = "";
                time_arv_three.Text = "";
                time_arv_four.Text = "";
            }

             else if (simulation.NumInQ==1)
                {
                    time_arv_one.Text = "" + Math.Round(simulation._timeArrival[1],2);
                    time_arv_two.Text = "";
                    time_arv_three.Text = "";
                    time_arv_four.Text = "";
                }
               else if (simulation.NumInQ==2)
                {
                    time_arv_one.Text = "" + Math.Round(simulation._timeArrival[1],2);
                    time_arv_two.Text = "" + Math.Round(simulation._timeArrival[2],2);
                    time_arv_three.Text = "";
                    time_arv_four.Text = "";
                }
                else if (simulation.NumInQ == 3)
                {
                    time_arv_one.Text = "" + Math.Round(simulation._timeArrival[1], 2);
                    time_arv_two.Text = "" + Math.Round(simulation._timeArrival[2], 2);
                    time_arv_three.Text = "" + Math.Round(simulation._timeArrival[3], 2);
                    time_arv_four.Text = "";
                }

               else if (simulation.NumInQ <= 4)
                {
                    time_arv_one.Text = "" + Math.Round(simulation._timeArrival[1], 2);
                    time_arv_two.Text = "" + Math.Round(simulation._timeArrival[2], 2);
                    time_arv_three.Text = "" + Math.Round(simulation._timeArrival[3], 2);
                    time_arv_four.Text = "" + Math.Round(simulation._timeArrival[4], 2);
                }

    

            time_of_last_event_box.Text = "" + Math.Round(simulation.SimTime, 2);

            clock_box.Text = "" + Math.Round(simulation.SimTime, 2);

            arrival_box.Text = "" + Math.Round(simulation._timeNextEvent[1],2);

            departure_box.Text = "" + Math.Round(simulation._timeNextEvent[2],2);


            number_delayed_box.Text = "" + simulation.NumCustsDelayed;

            total_delay_box.Text = "" + Math.Round(simulation.TotalOfDelays, 2);

            area_under_qt_box.Text = "" + Math.Round(simulation.AreaNumInQ, 2);

            area_under_bt_box.Text = "" + Math.Round(simulation.AreaServerStatus, 2);
        }

        public class Simulation
        {
            private const int QueueSize = 32000;
            private const double MeanInterarrival = 1;
            private const double MeanService = 0.5;

            public int NumDelaysRequired { get; } = 1000;
            public int NextEventType { get; private set; }
            public int NumCustsDelayed { get; private set; }
            public int NumInQ { get; private set; }
            public int ServerStatus { get; private set; }
            public double AreaNumInQ { get; private set; }
            public double AreaServerStatus { get; private set; }
            public double TotalOfDelays { get; private set; }
            public double SimTime { get; private set; }
            public double TimeLastEvent { get; set; }

            public readonly double[] _timeArrival = new double[QueueSize];
            public readonly double[] _timeNextEvent = new double[3];
            private readonly Random _random = new Random();

            public void Initialize()
            {
                SimTime = 0;
                ServerStatus = 0;
                NumInQ = 0;
                TimeLastEvent = 0;
                NumCustsDelayed = 0;
                TotalOfDelays = 0;
                AreaNumInQ = 0;
                AreaServerStatus = 0;
                _timeNextEvent[1] = SimTime + Expon(MeanInterarrival);
                _timeNextEvent[2] = double.MaxValue;
            }

            public void Timing()
            {
                NextEventType = _timeNextEvent[1] < _timeNextEvent[2] ? 1 : 2;
                SimTime = _timeNextEvent[NextEventType];

            }

            public void UpdateTimeAvgStats()
            {
                var lag = SimTime - TimeLastEvent;
                AreaNumInQ += NumInQ * lag;
                AreaServerStatus += ServerStatus * lag;
            }

            public void Arrive()
            {
                _timeNextEvent[1] = SimTime + Expon(MeanInterarrival);

                if (ServerStatus == 1)
                {
                    NumInQ++;
                    _timeArrival[NumInQ] = SimTime;
                }
                else
                {
                    var delay = 0.0;
                    TotalOfDelays += delay;
                    NumCustsDelayed++;
                    ServerStatus = 1;
                    _timeNextEvent[2] = SimTime + Expon(MeanService);
                }
            }

            public void Depart()
            {
                if (NumInQ == 0)
                {
                    ServerStatus = 0;
                    _timeNextEvent[2] = double.MaxValue;
                }
                else
                {
                    NumInQ--;
                    var delay = SimTime - _timeArrival[1];
                    TotalOfDelays += delay;
                    NumCustsDelayed++;
                    _timeNextEvent[2] = SimTime + Expon(MeanService);

                    for (var i = 1; i <= NumInQ; i++)
                    {
                        _timeArrival[i] = _timeArrival[i + 1];
                    }
                }
            }

            private double Expon(double mean)
            {
                return -mean * Math.Log(_random.NextDouble());
            }
        }

        private void count_btn_Click(object sender, EventArgs e)
        {
            simulation.Timing();
            simulation.UpdateTimeAvgStats();
            UpdateStatsOnGUI();


            switch (simulation.NextEventType)
            {
                case 1:
                    simulation.Arrive();
                    break;
                case 2:
                    simulation.Depart();
                    break;
            }



        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
