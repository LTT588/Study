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
    public partial class Test : Form
    {
        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;
        public Test()
        {
            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";
            InitializeComponent();
            label1.Text = Properties.Settings.Default.username;
            ReadIni();
            open1 = DateTime.Now;
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            panel8.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel10.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
















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
             //       MessageBox.Show("该用户首次登录");

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
        private void panel12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();
        }

        private void Test_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 1;
            Properties.Settings.Default.Save();

           this.Dispose();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 2;
            Properties.Settings.Default.Save();
            this.Dispose();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
           

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 3;
            Properties.Settings.Default.Save();
            this.Dispose();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 4;
            Properties.Settings.Default.Save();
           this.Dispose();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 5;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 6;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 7;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 8;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 9;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 10;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();

        }

        private void panel11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numtitle = 11;
            Properties.Settings.Default.Save();
            this.Hide();
            TestTitle tet = new TestTitle();
            tet.ShowDialog();
            this.Dispose();
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
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
