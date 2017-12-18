namespace Auto_Shutdown_Timer_Windows_C_Sharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txt_hour = new System.Windows.Forms.TextBox();
            this.Txt_min = new System.Windows.Forms.TextBox();
            this.Txt_sec = new System.Windows.Forms.TextBox();
            this.lb_Hour = new System.Windows.Forms.Label();
            this.lb_Mins = new System.Windows.Forms.Label();
            this.lb_Sec = new System.Windows.Forms.Label();
            this.Btn_shutdown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_restart = new System.Windows.Forms.Button();
            this.Timer_restart = new System.Windows.Forms.Timer(this.components);
            this.Btn_sleep = new System.Windows.Forms.Button();
            this.Timer_sleep = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Txt_hour
            // 
            this.Txt_hour.Location = new System.Drawing.Point(30, 68);
            this.Txt_hour.Name = "Txt_hour";
            this.Txt_hour.Size = new System.Drawing.Size(43, 20);
            this.Txt_hour.TabIndex = 0;
            this.Txt_hour.Text = "0";
            this.Txt_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_hour.TextChanged += new System.EventHandler(this.Txt_hour_TextChanged);
            // 
            // Txt_min
            // 
            this.Txt_min.Location = new System.Drawing.Point(79, 68);
            this.Txt_min.Name = "Txt_min";
            this.Txt_min.Size = new System.Drawing.Size(43, 20);
            this.Txt_min.TabIndex = 1;
            this.Txt_min.Text = "0";
            this.Txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_min.TextChanged += new System.EventHandler(this.Txt_min_TextChanged);
            // 
            // Txt_sec
            // 
            this.Txt_sec.Location = new System.Drawing.Point(128, 68);
            this.Txt_sec.Name = "Txt_sec";
            this.Txt_sec.Size = new System.Drawing.Size(43, 20);
            this.Txt_sec.TabIndex = 2;
            this.Txt_sec.Text = "0";
            this.Txt_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_sec.TextChanged += new System.EventHandler(this.Txt_sec_TextChanged);
            // 
            // lb_Hour
            // 
            this.lb_Hour.AutoSize = true;
            this.lb_Hour.Location = new System.Drawing.Point(30, 49);
            this.lb_Hour.Name = "lb_Hour";
            this.lb_Hour.Size = new System.Drawing.Size(35, 13);
            this.lb_Hour.TabIndex = 3;
            this.lb_Hour.Text = "Hours";
            // 
            // lb_Mins
            // 
            this.lb_Mins.AutoSize = true;
            this.lb_Mins.Location = new System.Drawing.Point(76, 49);
            this.lb_Mins.Name = "lb_Mins";
            this.lb_Mins.Size = new System.Drawing.Size(29, 13);
            this.lb_Mins.TabIndex = 4;
            this.lb_Mins.Text = "Mins";
            // 
            // lb_Sec
            // 
            this.lb_Sec.AutoSize = true;
            this.lb_Sec.Location = new System.Drawing.Point(125, 49);
            this.lb_Sec.Name = "lb_Sec";
            this.lb_Sec.Size = new System.Drawing.Size(49, 13);
            this.lb_Sec.TabIndex = 5;
            this.lb_Sec.Text = "Seconds";
            // 
            // Btn_shutdown
            // 
            this.Btn_shutdown.Location = new System.Drawing.Point(12, 111);
            this.Btn_shutdown.Name = "Btn_shutdown";
            this.Btn_shutdown.Size = new System.Drawing.Size(92, 43);
            this.Btn_shutdown.TabIndex = 6;
            this.Btn_shutdown.Text = "Shutdown Countdown";
            this.Btn_shutdown.UseVisualStyleBackColor = true;
            this.Btn_shutdown.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_restart
            // 
            this.Btn_restart.Location = new System.Drawing.Point(103, 111);
            this.Btn_restart.Name = "Btn_restart";
            this.Btn_restart.Size = new System.Drawing.Size(92, 43);
            this.Btn_restart.TabIndex = 7;
            this.Btn_restart.Text = "Restart Countdown";
            this.Btn_restart.UseVisualStyleBackColor = true;
            this.Btn_restart.Click += new System.EventHandler(this.Btn_restart_Click);
            // 
            // Timer_restart
            // 
            this.Timer_restart.Interval = 1000;
            this.Timer_restart.Tick += new System.EventHandler(this.Timer_restart_Tick);
            // 
            // Btn_sleep
            // 
            this.Btn_sleep.Location = new System.Drawing.Point(61, 160);
            this.Btn_sleep.Name = "Btn_sleep";
            this.Btn_sleep.Size = new System.Drawing.Size(92, 43);
            this.Btn_sleep.TabIndex = 8;
            this.Btn_sleep.Text = "Sleep Countdown";
            this.Btn_sleep.UseVisualStyleBackColor = true;
            this.Btn_sleep.Click += new System.EventHandler(this.Btn_sleep_Click);
            // 
            // Timer_sleep
            // 
            this.Timer_sleep.Interval = 1000;
            this.Timer_sleep.Tick += new System.EventHandler(this.Timer_sleep_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(207, 233);
            this.Controls.Add(this.Btn_sleep);
            this.Controls.Add(this.Btn_restart);
            this.Controls.Add(this.Btn_shutdown);
            this.Controls.Add(this.lb_Sec);
            this.Controls.Add(this.lb_Mins);
            this.Controls.Add(this.lb_Hour);
            this.Controls.Add(this.Txt_sec);
            this.Controls.Add(this.Txt_min);
            this.Controls.Add(this.Txt_hour);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoDown ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_hour;
        private System.Windows.Forms.TextBox Txt_min;
        private System.Windows.Forms.TextBox Txt_sec;
        private System.Windows.Forms.Label lb_Hour;
        private System.Windows.Forms.Label lb_Mins;
        private System.Windows.Forms.Label lb_Sec;
        private System.Windows.Forms.Button Btn_shutdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_restart;
        private System.Windows.Forms.Timer Timer_restart;
        private System.Windows.Forms.Button Btn_sleep;
        private System.Windows.Forms.Timer Timer_sleep;
    }
}

