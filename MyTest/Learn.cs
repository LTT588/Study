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
    public partial class Learn : Form
    {
        string temuser = "";
        string addr = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;
        public Learn()
        {

            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";


            InitializeComponent();
            ReadIni();


            open1 = DateTime.Now;



            label1.Text = Properties.Settings.Default.username;

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;

          
          
        }

        String[] Time_laws = { "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00" };
        List<string> laws2 = new List<string> { "中华人民共和国档案法", "中华人民共和国公职人员政务处分法", "中华人民共和国密码法", "中华人民共和国政府信息公开条例", "干部人事档案工作条例", "中华人民共和国刑事诉讼法", "中国共产党纪律处分条例", "中华人民共和国保守国家秘密法", "中华人民共和国国家安全法", "中华人民共和国反间谍法", "中华人民共和国国家情报法", "中华人民共和国英雄烈士保护法", "中华人民共和国国防动员法", "中华人民共和国反恐怖主义法", "中华人民共和国监察法" };

     
        
        private void panel1_Click(object sender, EventArgs e)//返回
        {
            this.Close();
            Form1 form1 = new Form1();
            this.Dispose();
            form1.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)//法律法规
        {
            this.Close();
            this.Dispose();
            laws law1 = new laws();
            law1.ShowDialog();
            
            
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
                 //   MessageBox.Show("该用户首次登录");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Learn_FormClosed(object sender, FormClosedEventArgs e)
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

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Videojs vid = new Videojs();
            vid.ShowDialog();

        }

    
        







    }
}
