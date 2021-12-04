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
    public partial class laws : Form
    {
        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;

        public laws()
        {

            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";

            InitializeComponent();

            ReadIni();


            open1 = DateTime.Now;





            label1.Text = temuser;

            panel1.BackColor = Color.Transparent;
            Retime();
            AddList();
           // Retime3();

            webBrowser1.ScriptErrorsSuppressed = true;


        }
        String[] Time_laws = { "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00" };
        List<string> laws2 = new List<string> { "中华人民共和国档案法", "中华人民共和国公职人员政务处分法", "中华人民共和国密码法", "中华人民共和国政府信息公开条例", "干部人事档案工作条例", "中华人民共和国刑事诉讼法", "中国共产党纪律处分条例", "中华人民共和国保守国家秘密法", "中华人民共和国国家安全法", "中华人民共和国反间谍法", "中华人民共和国国家情报法", "中华人民共和国英雄烈士保护法", "中华人民共和国国防动员法", "中华人民共和国反恐怖主义法", "中华人民共和国监察法" };

        String[] Time_videos = { "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00" };
        List<string> videoname = new List<string> { "大连理工大学警示案例1", "大连理工大学警示案例2", "大连理工大学警示案例3", "大连理工大学警示案例4", "大连理工大学警示案例5", "大连理工大学警示案例6", "大连理工大学警示案例7" };



        void wrTime()
        {
            String path1 = @".\data\time1.txt";
            StreamWriter wt1 = new StreamWriter(path1);
            for (int i = 0; i <= 14; i++)
                wt1.WriteLine(Time_laws[i]);

            wt1.Close();

        }
        void Retime()
        {

            String path1 = @".\data\time1.txt";

            string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
            for (int i = 0; i <= 14; i++)
                Time_laws[i] = ReadText[i].ToString();


        }

        /*void Retime3()
        {
            String path1 = @".\data\time3.txt";

            string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
            for (int i = 0; i <= 6; i++)
                Time_videos[i] = ReadText[i].ToString();
        }*/
        void AddList()
        {
            listBox1.Items.Clear();
            this.listBox1.Items.Add("·" + laws2[0] + "                                      " + Time_laws[0]);
            this.listBox1.Items.Add("·" + laws2[1] + "                          " + Time_laws[1]);
            this.listBox1.Items.Add("·" + laws2[2] + "                                      " + Time_laws[2]);
            this.listBox1.Items.Add("·" + laws2[3] + "                            " + Time_laws[3]);
            this.listBox1.Items.Add("·" + laws2[4] + "                                      " + Time_laws[4]);
            this.listBox1.Items.Add("·" + laws2[5] + "                                  " + Time_laws[5]);
            this.listBox1.Items.Add("·" + laws2[6] + "                                    " + Time_laws[6]);
            this.listBox1.Items.Add("·" + laws2[7] + "                              " + Time_laws[7]);
            this.listBox1.Items.Add("·" + laws2[8] + "                                  " + Time_laws[8]);
            this.listBox1.Items.Add("·" + laws2[9] + "                                    " + Time_laws[9]);
            this.listBox1.Items.Add("·" + laws2[10] + "                                  " + Time_laws[10]);
            this.listBox1.Items.Add("·" + laws2[11] + "                              " + Time_laws[11]);
            this.listBox1.Items.Add("·" + laws2[12] + "                                  " + Time_laws[12]);
            this.listBox1.Items.Add("·" + laws2[13] + "                                " + Time_laws[13]);
            this.listBox1.Items.Add("·" + laws2[14] + "                                      " + Time_laws[14]);

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {


                //法律法规
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[0] + "                                      " + Time_laws[0])//1
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    // webBrowser1.Navigate(Application.StartupPath + @"\daf1.html");

                    string rd = @".\data\测试1.txt";
                    File.ReadAllText(rd);

                    webBrowser1.DocumentText = File.ReadAllText(rd);

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[0] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[0] = ReadText[0].ToString();



                }


                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[1] + "                          " + Time_laws[1])//2
                {



                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[1] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[1] = ReadText[1].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[2] + "                                      " + Time_laws[2])//3
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[2] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[2] = ReadText[2].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[3] + "                            " + Time_laws[3])//4
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[3] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[3] = ReadText[3].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[4] + "                                      " + Time_laws[4])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[4] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[4] = ReadText[4].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[5] + "                                  " + Time_laws[5])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[5] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[5] = ReadText[5].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[6] + "                                    " + Time_laws[6])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[6] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[6] = ReadText[6].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[7] + "                              " + Time_laws[7])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[7] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[7] = ReadText[7].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[8] + "                                  " + Time_laws[8])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[8] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[8] = ReadText[8].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[9] + "                                    " + Time_laws[9])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[9] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[9] = ReadText[9].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[10] + "                                  " + Time_laws[10])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[10] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[10] = ReadText[10].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[11] + "                              " + Time_laws[11])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[11] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[11] = ReadText[11].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[12] + "                                  " + Time_laws[12])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[12] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[12] = ReadText[12].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[13] + "                                " + Time_laws[13])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[13] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[13] = ReadText[13].ToString();


                }
                if (this.listBox1.SelectedItem.ToString() == "·" + laws2[14] + "                                      " + Time_laws[14])
                {

                    webBrowser1.BringToFront();
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(Application.StartupPath + @".\data\zw2.html");

                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Time_laws[14] = currentTime.ToString();

                    String path1 = @".\data\time1.txt";
                    wrTime();
                    //读取
                    string[] ReadText = File.ReadAllLines(path1, Encoding.Default);
                    Time_laws[14] = ReadText[14].ToString();



                }

            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Learn learn1 = new Learn();
            learn1.ShowDialog();
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

        private void laws_FormClosed(object sender, FormClosedEventArgs e)
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








    }
}
