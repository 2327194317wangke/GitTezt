using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SQL温度风速测试器
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (!ckb_humidity.Checked && ckb_manner.Checked && ckb_humidity.Checked&&ckb_oxygen.Checked)
            {
                MessageBox.Show("必须勾选一个");
                return;
            }

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //if (!socket.Connected)
            //{
                if (ckb_temperature.Checked)
                {
                    chart1.Series.Add("温度");
                    chart1.Series["温度"].ChartType = SeriesChartType.Spline;
                }
                if (ckb_oxygen.Checked)
                {
                    chart1.Series.Add("氧气");
                    chart1.Series["氧气"].ChartType = SeriesChartType.Spline;
                }

                if (ckb_humidity.Checked)
                {
                    chart1.Series.Add("湿度");
                    chart1.Series["湿度"].ChartType = SeriesChartType.Spline;
                }

                if (ckb_manner.Checked)
                {
                    chart1.Series.Add("风速");
                    chart1.Series["风速"].ChartType = SeriesChartType.Spline;
                }


                //socket.Connect("192.168.124.180", 8016);

                //btn_stop.ForeColor = Color.Red;
  

                timer1.Interval = 1000;
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            //}
            //else
            //{
            //    socket.Close();
            //    btn_stop.ForeColor = Color.White;
            //}


        }
        List<string> list = new List<string>();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int num = random.Next(1, 100);
            string dateTime = DateTime.Now.ToString("HH时mm分ss秒");
            list.Add(dateTime);


            int num1 = random.Next(1, 100); 
            int num2 = random.Next(1, 100);
            int num3 = random.Next(1, 100);
            int num4 = random.Next(1, 100);


            if (ckb_temperature.Checked)
            {
                data.Add(num+num1);
                
                chart1.Series["温度"].Points.DataBindXY(list, data);
                if (data.Count >= 6)
                {
                     data.RemoveAt(0);
                    list.RemoveAt(0);
                }
            }
            if (ckb_oxygen.Checked)
            {
                Oxygrnlidt.Add(num+num2);
                chart1.Series["氧气"].Points.DataBindY(Oxygrnlidt);
                if (Oxygrnlidt.Count >= 6)
                {
                    Oxygrnlidt.RemoveAt(0);
                }
            }

            if (ckb_humidity.Checked)
            {
                humidity.Add(num+num3);
                chart1.Series["湿度"].Points.DataBindY(humidity);
                if (humidity.Count >= 6)
                {
                    humidity.RemoveAt(0);
                }
           }

            if (ckb_manner.Checked)
            {
                mannerList.Add(num +num4);
                chart1.Series["风速"].Points.DataBindY(mannerList);
                if (mannerList.Count >= 6)
                {
                    mannerList.RemoveAt(0);
                }
            }

            //if (data.Count >= 6 || mannerList.Count>=6|| humidity.Count>=6|| Oxygrnlidt.Count>=6) { 
            //    
            //    mannerList.RemoveAt(0);
            //    humidity.RemoveAt(0);
            //    Oxygrnlidt.RemoveAt(0);

            //    list.RemoveAt(0);
            //}

           

           
        }
        Random random = new Random();
        List<double> data = new List<double>();
        List<double> mannerList = new List<double>();
        List<double> humidity = new List<double>();
        List<double> Oxygrnlidt = new List<double>();
        

        private void btn_Settime_Click(object sender, EventArgs e)
        {
           
            timer1.Interval = Convert.ToInt32(ipt_time.Text);

           



        }

        // 你要知道这世上有一种东西是不能从众的，那就是人的良心
        // 昔我往矣，杨柳依依。今我来思，雨雪霏霏。
        // 人生十之八九不如意，不想八九，常思一二，事事如意
        // 你当想鸟飞向你的山
        // 拜水都江堰，问道青城山。
        // 当时年少春衫薄，骑马倚斜桥，满楼红袖招
        // 金风玉露一相逢，便胜却人间无数
        //  


         

    }
}
