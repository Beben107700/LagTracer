﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagTracer
{
    public partial class Form1 : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ph = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = ph;
            System.Diagnostics.Process.Start(path + "\\LagTracer.bat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String lines = System.IO.File.ReadAllText(path + "\\LagTracerOutput.txt");
                Clipboard.SetText(lines);
            }
            catch (Exception edsqf)
            {
                label2.Text = "You have to open the lagtracer first!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.minecraftpvp.com/t/tool-lag-tracer-help-squash-the-server-lag/39364/");
        }
    }
}
