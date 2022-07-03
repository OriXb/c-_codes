using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherBox.Text = "enter cords";

            WebClient client = new WebClient();
            WeatherBox.Text = "Please Enter Cords-";
            WeatherBox.BackColor = Color.Blue;
            WeatherBox.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string Info = EnterBox.Text;
            string Info2 = EnterBox2.Text;
            String str = client.DownloadString("https://api.openweathermap.org/data/2.5/weather?lat=" + Info + "&lon=" + Info2 + "&appid=958e2e63abd430a9e1eded10bad04bff");
            WeatherBox.Text = "Entered cords- " + str.Substring(16,Info2.Length) + " - " + str.Substring(16+Info.Length+5, Info.Length)+ "| Weather info of the cords: " + str;
        }
    }
}
