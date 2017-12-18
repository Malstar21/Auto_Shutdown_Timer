using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Shutdown_Timer_Windows_C_Sharp
{
    public partial class Form1 : Form
    {

        private ulong timerSec = 0;
        private ulong timerMin = 0;
        private ulong timerHour = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Txt_hour_TextChanged(object sender, EventArgs e)
        {}

        private void Txt_min_TextChanged(object sender, EventArgs e)
        {}

        private void Txt_sec_TextChanged(object sender, EventArgs e)
        {}

        private void Btn_start_Click(object sender, EventArgs e)
        {
            timerSec = (ulong)Convert.ToDouble(Txt_sec.Text);
            timerMin = (ulong)Convert.ToDouble(Txt_min.Text);
            timerHour = (ulong)Convert.ToDouble(Txt_hour.Text);
            timer1.Start();
        }

        private void Btn_restart_Click(object sender, EventArgs e)
        {
            timerSec = (ulong)Convert.ToDouble(Txt_sec.Text);
            timerMin = (ulong)Convert.ToDouble(Txt_min.Text);
            timerHour = (ulong)Convert.ToDouble(Txt_hour.Text);
            Timer_restart.Start();
        }

        private void Btn_sleep_Click(object sender, EventArgs e)
        {
            timerSec = (ulong)Convert.ToDouble(Txt_sec.Text);
            timerMin = (ulong)Convert.ToDouble(Txt_min.Text);
            timerHour = (ulong)Convert.ToDouble(Txt_hour.Text);
            Timer_sleep.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerSec != 0)
            {
                timerSec--;
                Txt_sec.Text = timerSec.ToString();
            }

            if (timerSec == 0 && timerMin != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin--;
                Txt_min.Text = timerMin.ToString();
            }
            else if (timerSec == 0 && timerMin == 0 && timerHour != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin = 59;
                Txt_min.Text = timerMin.ToString();

                timerHour--;
                Txt_hour.Text = timerHour.ToString();
            }

            if (timerSec == 0 && timerMin == 0 && timerHour == 0)
            {
                timer1.Stop();
                Process.Start("shutdown.exe", "-s -t 0");
            }
        }

        private void Timer_restart_Tick(object sender, EventArgs e)
        {
            if (timerSec != 0)
            {
                timerSec--;
                Txt_sec.Text = timerSec.ToString();
            }

            if (timerSec == 0 && timerMin != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin--;
                Txt_min.Text = timerMin.ToString();
            }
            else if (timerSec == 0 && timerMin == 0 && timerHour != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin = 59;
                Txt_min.Text = timerMin.ToString();

                timerHour--;
                Txt_hour.Text = timerHour.ToString();
            }

            if (timerSec == 0 && timerMin == 0 && timerHour == 0)
            {
                Timer_restart.Stop();
                Process.Start("shutdown.exe", "-r -t 0");
            }
        }

        private void Timer_sleep_Tick(object sender, EventArgs e)
        {
            if (timerSec != 0)
            {
                timerSec--;
                Txt_sec.Text = timerSec.ToString();
            }

            if (timerSec == 0 && timerMin != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin--;
                Txt_min.Text = timerMin.ToString();
            }
            else if (timerSec == 0 && timerMin == 0 && timerHour != 0)
            {
                timerSec = 59;
                Txt_sec.Text = timerSec.ToString();

                timerMin = 59;
                Txt_min.Text = timerMin.ToString();

                timerHour--;
                Txt_hour.Text = timerHour.ToString();
            }

            if (timerSec == 0 && timerMin == 0 && timerHour == 0)
            {
                Timer_sleep.Stop();
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }
        }
    }
}