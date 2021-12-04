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
    public partial class Downloadfile : Form
    {
        string temuser = "";
        string addr = "";
        string addr2 = "";
        string temtime = "0";
        double to_time;
        DateTime open1;
        DateTime close1;
        public Downloadfile()
        {
            temuser = Properties.Settings.Default.username;
            addr = Application.StartupPath + "\\data\\" + temuser + ".ini";
            addr2 = Application.StartupPath + "\\data\\" + temuser + "downtime.ini";
            InitializeComponent();
            label1.Text = Properties.Settings.Default.username;
            listBox1.BringToFront();
           // GetSize();
           
            ReadIni();

            ReadIni2();
            AddList3();
            open1 = DateTime.Now;

            panel2.BackColor = Color.Transparent;
        }

        String[] FileName = { "大连理工大学工勤人员保密承诺书", "大连理工大学工勤人员保密审查表", "大连理工大学涉密岗位变更审批表", 
                                "大连理工大学涉密岗位审批表", "大连理工大学涉密人员变更审批表", "大连理工大学涉密人员复查审批表", 
                                "大连理工大学涉密人员年度考核表", "大连理工大学涉密人员审批表", "大连理工大学涉密人员重大事项报告表", 
                                "大连理工大学脱密期保密承诺书", "大连理工大学涉密人员校内脱密通知书", "大连理工大学涉密人员脱密期委托管理书",
                                "大连理工大学涉密人员脱离涉密岗位审批表", "大连理工大学涉密人员台账", "大连理工大学委托管理涉密人员基本信息表", 
                                "保密教育培训情况卡" };
        String[] time1 = { "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00",
                             "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00",
                             "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00", "2021/00/00 00:00:00" };
        long[] getsize = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        long[] videosize = { 0, 0, 0, 0, 0, 0, 0 };
   /*     void GetSize()
        {
            string source = @".\data\大连理工大学工勤人员保密承诺书.docx";
            string source2 = @".\data\大连理工大学工勤人员保密审查表.docx";
            string source3 = @".\data\大连理工大学涉密岗位变更审批表.docx";
            string source4 = @".\data\大连理工大学涉密岗位审批表.docx";
            string source5 = @".\data\大连理工大学涉密人员变更审批表.docx";
            string source6 = @".\data\大连理工大学涉密人员复查审批表.docx";
            string source7 = @".\data\大连理工大学涉密人员年度考核表.docx";
            string source8 = @".\data\大连理工大学涉密人员审批表.docx";
            string source9 = @".\data\大连理工大学涉密人员重大事项报告表.docx";
            string source10 = @".\data\大连理工大学脱密期保密承诺书.docx";
            string source11 = @".\data\大连理工大学涉密人员校内脱密通知书.docx";
            string source12 = @".\data\大连理工大学涉密人员脱密期委托管理书.docx";
            string source13 = @".\data\大连理工大学涉密人员脱离涉密岗位审批表.docx";
            string source14 = @".\data\大连理工大学涉密人员台账.docx";
            string source15 = @".\data\大连理工大学委托管理涉密人员基本信息表.docx";
            string source16 = @".\data\保密教育培训情况卡.docx";


            FileInfo fileinfo = new FileInfo(source);
            getsize[0] = fileinfo.Length / 1000;
            FileInfo fileinfo2 = new FileInfo(source2);
            getsize[1] = fileinfo2.Length / 1000;
            FileInfo fileinfo3 = new FileInfo(source3);
            getsize[2] = fileinfo3.Length / 1000;
            FileInfo fileinfo4 = new FileInfo(source4);
            getsize[3] = fileinfo4.Length / 1000;
            FileInfo fileinfo5 = new FileInfo(source5);
            getsize[4] = fileinfo5.Length / 1000;
            FileInfo fileinfo6 = new FileInfo(source6);
            getsize[5] = fileinfo6.Length / 1000;
            FileInfo fileinfo7 = new FileInfo(source7);
            getsize[6] = fileinfo7.Length / 1000;
            FileInfo fileinfo8 = new FileInfo(source8);
            getsize[7] = fileinfo8.Length / 1000;
            FileInfo fileinfo9 = new FileInfo(source9);
            getsize[8] = fileinfo9.Length / 1000;
            FileInfo fileinfo10 = new FileInfo(source10);
            getsize[9] = fileinfo10.Length / 1000;
            FileInfo fileinfo11 = new FileInfo(source11);
            getsize[10] = fileinfo11.Length / 1000;
            FileInfo fileinfo12 = new FileInfo(source12);
            getsize[11] = fileinfo12.Length / 1000;
            FileInfo fileinfo13 = new FileInfo(source13);
            getsize[12] = fileinfo13.Length / 1000;
            FileInfo fileinfo14 = new FileInfo(source14);
            getsize[13] = fileinfo14.Length / 1000;
            FileInfo fileinfo15 = new FileInfo(source15);
            getsize[14] = fileinfo15.Length / 1000;
            FileInfo fileinfo16 = new FileInfo(source16);
            getsize[15] = fileinfo16.Length / 1000;



        }

        */
        void AddList3()//文件下载的名字
        {
            
            this.listBox1.Items.Add("·" + FileName[0] + "                           " +time1[0]);
            this.listBox1.Items.Add("·" + FileName[1] + "                           " + time1[1]);
            this.listBox1.Items.Add("·" + FileName[2] + "                           " + time1[2]);
            this.listBox1.Items.Add("·" + FileName[3] + "                               " + time1[3]);
            this.listBox1.Items.Add("·" + FileName[4] + "                           " + time1[4]);
            this.listBox1.Items.Add("·" + FileName[5] + "                           " + time1[5]);
            this.listBox1.Items.Add("·" + FileName[6] + "                           " + time1[6]);
            this.listBox1.Items.Add("·" + FileName[7] + "                               " + time1[7]);
            this.listBox1.Items.Add("·" + FileName[8] + "                       " + time1[8]);
            this.listBox1.Items.Add("·" + FileName[9] + "                             " + time1[9]);
            this.listBox1.Items.Add("·" + FileName[10] + "                       " + time1[10]);
            this.listBox1.Items.Add("·" + FileName[11] + "                     " + time1[11]);
            this.listBox1.Items.Add("·" + FileName[12] + "                   " + time1[12]);
            this.listBox1.Items.Add("·" + FileName[13] + "                                 " + time1[13]);
            this.listBox1.Items.Add("·" + FileName[14] + "                   " + time1[14]);
            this.listBox1.Items.Add("·" + FileName[15] + "                                       " + time1[15]);
        } 

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 25;

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
            //     strFmt.Alignment = StringAlignment.Center; //文本垂直居中
            strFmt.LineAlignment = StringAlignment.Center; //文本水平居中
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, strFmt);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {

                if (listBox1.SelectedItem.ToString() == "·" + FileName[0] + "                           " + time1[0])
                {
                    string source = @".\data\大连理工大学工勤人员保密承诺书.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学工勤人员保密承诺书";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        time1[0] = DateTime.Now.ToString();

                        
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }




                ///2222222

                if (listBox1.SelectedItem.ToString() == "·" + FileName[1] + "                           " + time1[1])
                {
                    string source = @".\data\大连理工大学工勤人员保密审查表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学工勤人员保密审查表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        time1[1] = DateTime.Now.ToString();
                       
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //3
                if (listBox1.SelectedItem.ToString() == "·" + FileName[2] + "                           " + time1[2])
                {
                    string source = @".\data\大连理工大学涉密岗位变更审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密岗位变更审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[2] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //4
                if (listBox1.SelectedItem.ToString() == "·" + FileName[3] + "                               " + time1[3])
                {
                    string source = @".\data\大连理工大学涉密岗位审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密岗位审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[3] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //5
                if (listBox1.SelectedItem.ToString() == "·" + FileName[4] + "                           " + time1[4])
                {
                    string source = @".\data\大连理工大学涉密人员变更审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员变更审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[4] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //6
                if (listBox1.SelectedItem.ToString() == "·" + FileName[5] + "                           " + time1[5])
                {
                    string source = @".\data\大连理工大学涉密人员复查审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员复查审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[5] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //7
                if (listBox1.SelectedItem.ToString() == "·" + FileName[6] + "                           " + time1[6])
                {
                    string source = @".\data\大连理工大学涉密人员年度考核表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员年度考核表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[6] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //8\
                if (listBox1.SelectedItem.ToString() == "·" + FileName[7] + "                               " + time1[7])
                {
                    string source = @".\data\大连理工大学涉密人员审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[7] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //9
                if (listBox1.SelectedItem.ToString() == "·" + FileName[8] + "                       " + time1[8])
                {
                    string source = @".\data\大连理工大学涉密人员重大事项报告表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员重大事项报告表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[8] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //10
                if (listBox1.SelectedItem.ToString() == "·" + FileName[9] + "                             " + time1[9])
                {
                    string source = @".\data\大连理工大学脱密期保密承诺书.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学脱密期保密承诺书";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[9] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //11
                if (listBox1.SelectedItem.ToString() == "·" + FileName[10] + "                       " + time1[10])
                {
                    string source = @".\data\大连理工大学涉密人员校内脱密通知书.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员校内脱密通知书";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[10] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //12
                if (listBox1.SelectedItem.ToString() == "·" + FileName[11] + "                     " + time1[11])
                {
                    string source = @".\data\大连理工大学涉密人员脱密期委托管理书.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员脱密期委托管理书";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[11] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //13
                if (listBox1.SelectedItem.ToString() == "·" + FileName[12] + "                   " + time1[12])
                {
                    string source = @".\data\大连理工大学涉密人员脱离涉密岗位审批表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员脱离涉密岗位审批表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[12] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //14  
                if (listBox1.SelectedItem.ToString() == "·" + FileName[13] + "                                 " + time1[13])
                {
                    string source = @".\data\大连理工大学涉密人员台账.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学涉密人员台账";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[13] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //15
                if (listBox1.SelectedItem.ToString() == "·" + FileName[14] + "                   " + time1[14])
                {
                    string source = @".\data\大连理工大学委托管理涉密人员基本信息表.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "大连理工大学委托管理涉密人员基本信息表";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[14] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }
                //16
                if (listBox1.SelectedItem.ToString() == "·" + FileName[15] + "                                       " + time1[15])
                {
                    string source = @".\data\保密教育培训情况卡.docx";
                    string target = "";

                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型
                    sfd.Filter = "Word Files (.docx)|.docx";
                    sfd.FileName = "保密教育培训情况卡";

                    //点了保存按钮进入
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        time1[15] = DateTime.Now.ToString();
                        target = sfd.FileName;

                        FileStream streamRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                        FileStream streamWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        //进行Copy
                        while (true)
                        {
                            //接受到的数据代读取到的数据量
                            int i = streamRead.Read(buffer, 0, buffer.Length);
                            //如果返回值是0证明读取完了
                            if (i == 0)
                            {
                                break;
                            }
                            streamWrite.Write(buffer, 0, i);
                        }
                        Console.WriteLine("复制完成!");
                        streamWrite.Close();
                        streamRead.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                    }
                }








            
            
            
            
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

        private void Downloadfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteIni2();
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

        private void panel2_Click(object sender, EventArgs e)//返回
        {
            WriteIni2();
            this.Dispose();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void ReadIni2() // 读取ini文件
        {
            try
            {
                if (File.Exists(addr2))
                {
                    //存在文件
                    StreamReader sr = new StreamReader(addr2);
                    for (int i = 0; i < 16; i++)
                    {
                        time1[i] = sr.ReadLine();
                    }
                    sr.Close();        //关闭当前的StreamReader对象和基础流
                }
                else
                {
                    //不存在文件
                    File.Create(addr2).Dispose();//创建该文件
                  //  MessageBox.Show("该用户首次登录");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void WriteIni2() // 写入ini文件
        {
            try
            {
                StreamWriter s = new StreamWriter(addr2, false);//定义一个以一种特定的编码向流中写入数据对象
                for (int i = 0; i < 16; i++)
                { 
                    s.WriteLine(time1[i]);
                }
                s.Flush(); //清理当前编写器的所有缓冲区，并使所有缓冲数据写入基础流
                s.Close(); //关闭当前的StreamWriter对象和基础流
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
