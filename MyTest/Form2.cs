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
    public partial class Form2 : Form
    {
        public Form2()
        {
          
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.username;
            panel1.BackColor = Color.Transparent;
 
        }

 
        private void panel1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("请输入用户名"); }
            else
            {
                Properties.Settings.Default.username = textBox1.Text;

                this.DialogResult = DialogResult.OK;
                Properties.Settings.Default.Save();

                string addr = Application.StartupPath + "\\data\\" + textBox1.Text + ".ini";
                if (File.Exists(addr))
                {
                    StreamReader sr = new StreamReader(addr);
                    string temtime = sr.ReadLine();
                    sr.Close();        //关闭当前的StreamReader对象和基础流

                    MessageBox.Show("登录成功，欢迎进入系统！\n 用户已学习时间:" + temtime + "分钟", "系统提示"); }
                else
                {
                     MessageBox.Show("该用户首次登录");

                }
                this.Close();
            }
        }





       



       
    }
}
