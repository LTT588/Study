using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyTest
{
    public partial class Videojs : Form
    {
        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;
        
        String[] Time_videos = { "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00" };
        List<string> videoname = new List<string> { "大连理工大学警示案例1", "大连理工大学警示案例2", "大连理工大学警示案例3", "大连理工大学警示案例4", "大连理工大学警示案例5", "大连理工大学警示案例6", "大连理工大学警示案例7" };
        public Videojs()
        {
            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";

            InitializeComponent();
            label1.Text = temuser;

            ReadIni();
            readtime3();
            AddList4();

            open1 = DateTime.Now;
            panel1.BackColor = Color.Transparent;





        }


        void wrTime3()
        {
            String path2 = @".\data\time3.txt";
            StreamWriter wt1 = new StreamWriter(path2);
            for (int i = 0; i <= 6; i++)
                wt1.WriteLine(Time_videos[i]);

            wt1.Close();
        }
        void readtime3()
        {
            String path1 = @".\data\time3.txt";

            string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
            for (int i = 0; i <7; i++)
                Time_videos[i] = ReadText[i].ToString();
        
        }



        private void ReadIni() // 读取ini文件
        {
            try
            {
                if (File.Exists(addr))
                {
                    //存在文件
                    StreamReader sr = new StreamReader(addr);

                    temtime = sr.ReadLine();
                    Console.WriteLine(temtime);

                    sr.Close();        //关闭当前的StreamReader对象和基础流
                }
                else
                {
                    //不存在文件
                    //File.Create(addr);//创建该文件
                  //  MessageBox.Show("该用户首次登录");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void WriteIni(string stime) // 写入ini文件
        {
            try
            {
                StreamWriter s = new StreamWriter(addr, false);//定义一个以一种特定的编码向流中写入数据对象
                s.WriteLine(stime);
                s.Flush(); //清理当前编写器的所有缓冲区，并使所有缓冲数据写入基础流
                s.Close(); //关闭当前的StreamWriter对象和基础流
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Videojs_FormClosed(object sender, FormClosedEventArgs e)
        {
            wrTime3();
            to_time = Convert.ToDouble(temtime);
            close1 = DateTime.Now;
            string sspt = (close1 - open1).TotalMinutes.ToString();
            int count_time = sspt.LastIndexOf(".");
            sspt = sspt.Substring(0, count_time + 3);
            to_time += Convert.ToDouble(sspt);

            WriteIni(to_time.ToString());
            Properties.Settings.Default.total_time = to_time.ToString();
            Properties.Settings.Default.Save();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                //警示案例
                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[0] + "                                    " + Time_videos[0])
                {

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[0] = currentTime.ToString();
  
                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[0] = ReadText[0].ToString();

                    Properties.Settings.Default.videos = @".\data\1.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();

                }
                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[1] + "                                    " + Time_videos[1])
                {

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[1] = currentTime.ToString();
           
                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[1] = ReadText[1].ToString();
                    Properties.Settings.Default.videos = @".\data\2.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();



                }

                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[2] + "                                    " + Time_videos[2])
                {
             
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[3] = currentTime.ToString();

                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[3] = ReadText[3].ToString();
                    Properties.Settings.Default.videos = @".\data\3.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();



                }
                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[3] + "                                    " + Time_videos[3])
                {
                   
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[4] = currentTime.ToString();

                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[4] = ReadText[4].ToString();
                    Properties.Settings.Default.videos = @".\data\4.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();



                }

                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[4] + "                                    " + Time_videos[4])
                {
               
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[4] = currentTime.ToString();

                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[4] = ReadText[4].ToString();
                    Properties.Settings.Default.videos = @".\data\5.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();


                }



                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[5] + "                                    " + Time_videos[5])
                {
            
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[5] = currentTime.ToString();

                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[5] = ReadText[5].ToString();
                    Properties.Settings.Default.videos = @".\data\6.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();



                }
                if (this.listBox1.SelectedItem.ToString() == "·" + videoname[6] + "                                    " + Time_videos[6])
                {

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_videos[6] = currentTime.ToString();
               
                    String path1 = @".\data\time3.txt";
                    wrTime3();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_videos[6] = ReadText[6].ToString();
                    Properties.Settings.Default.videos = @".\data\7.MP4";
                    Properties.Settings.Default.Save();
                    this.Close();
                    WatchVideo wavideo = new WatchVideo();
                    this.Dispose();
                    wavideo.ShowDialog();



                }






            }


        }




        void AddList4()
        {//警示案例

            listBox1.Items.Clear();

            this.listBox1.Items.Add("·" + videoname[0] + "                                    " + Time_videos[0]);
            this.listBox1.Items.Add("·" + videoname[1] + "                                    " + Time_videos[1]);
            this.listBox1.Items.Add("·" + videoname[2] + "                                    " + Time_videos[2]);
            this.listBox1.Items.Add("·" + videoname[3] + "                                    " + Time_videos[3]);
            this.listBox1.Items.Add("·" + videoname[4] + "                                    " + Time_videos[4]);
            this.listBox1.Items.Add("·" + videoname[5] + "                                    " + Time_videos[5]);
            this.listBox1.Items.Add("·" + videoname[6] + "                                    " + Time_videos[6]);



        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Learn lea1 = new Learn();
            lea1.ShowDialog();

        }






    }
}
