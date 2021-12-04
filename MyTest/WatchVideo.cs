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
    public partial class WatchVideo : Form
    {
        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;
        public WatchVideo()
        {
            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";


            InitializeComponent();
            ReadIni();


            open1 = DateTime.Now;



            label1.Text = Properties.Settings.Default.username;

            panel1.BackColor = Color.Transparent;

            String path_1=Properties.Settings.Default.videos;
            if (File.Exists(path_1))
                axWindowsMediaPlayer1.URL = path_1;
             else
             {
               //  Properties.Settings.Default.videos = "";
                 label2.Visible = true;


             }





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
                   // MessageBox.Show("该用户首次登录");

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

        private void WatchVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Videojs video = new Videojs();
            this.Dispose();
            video.ShowDialog();
        }

   

    }
}
