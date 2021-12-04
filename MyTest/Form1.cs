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
    public partial class Form1 : Form
    {


        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
         DateTime open1;
         DateTime close1;


        String[] FileName = { "大连理工大学工勤人员保密承诺书", "大连理工大学工勤人员保密审查表", "大连理工大学涉密岗位变更审批表", 
                                "大连理工大学涉密岗位审批表", "大连理工大学涉密人员变更审批表", "大连理工大学涉密人员复查审批表", 
                                "大连理工大学涉密人员年度考核表", "大连理工大学涉密人员审批表", "大连理工大学涉密人员重大事项报告表", 
                                "大连理工大学脱密期保密承诺书", "大连理工大学涉密人员校内脱密通知书", "大连理工大学涉密人员脱密期委托管理书",
                                "大连理工大学涉密人员脱离涉密岗位审批表", "大连理工大学涉密人员台账", "大连理工大学委托管理涉密人员基本信息表", 
                                "保密教育培训情况卡" };
        public Form1()
        {
            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";
            InitializeComponent();
            
            ReadIni();

        
            open1 = DateTime.Now;
            label1.Text = temuser;



            panel1.BackColor = Color.Transparent;//自学
            panel2.BackColor = Color.Transparent;//工作下载
            panel3.BackColor = Color.Transparent;
            // panel1.BringToFront();

            
          
        }

     
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
              to_time = Convert.ToDouble(temtime);
              close1 = DateTime.Now;
              string sspt = (close1 - open1).TotalMinutes.ToString();
              int count_time = sspt.LastIndexOf(".");
              sspt = sspt.Substring(0, count_time+ 3);
              to_time += Convert.ToDouble(sspt);  

              WriteIni(to_time.ToString());
              Properties.Settings.Default.total_time = to_time.ToString();
              Properties.Settings.Default.Save();


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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("你好");
        }

        private void panel2_Click(object sender, EventArgs e)//文件下载
        {
          
            this.Hide();
            Downloadfile down = new Downloadfile();
            down.ShowDialog();
            this.Dispose();



        }

        private void panel1_Click_1(object sender, EventArgs e)//自学
        {
            this.Hide();
            Learn lea = new Learn();
            lea.ShowDialog();
            this.Dispose();
        }

        private void panel3_Click(object sender, EventArgs e)//自测
        {
            this.Hide();
            Test test1 = new Test();
            test1.ShowDialog();

        

            this.Dispose();
        }

      


       



    }
}
