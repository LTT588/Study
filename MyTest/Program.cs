﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 f2 = new Form2();
         
            //Application.Run(new Form2());
            if (f2.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
         //   Application.Run(new Form1());
        }
    }
}
