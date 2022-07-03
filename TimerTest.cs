using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{

    public partial class Form1 : Form
    {
        System.Timers.Timer Timer;
        int hours;
        int minutes;
        int seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += OnTimeEvent;

        }
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Timer.Stop();
            Application.DoEvents();

        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                seconds+= 1;
                if(seconds==60)
                {
                    seconds = 0;
                    minutes += 1;
                }
                if(minutes==60)
                {
                    minutes = 0;
                    hours += 1;
                }
                text.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2,'0'));

            }));
        }
    }
}
