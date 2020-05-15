using System;
using System.IO;
using System.Diagnostics;
using static dersler.dersid10a;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace dersler
{


    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaunchZoom(turk, "4040");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaunchZoom(matematik, "4040");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaunchZoom(fizik, "429553");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LaunchZoom(biyoloji, "4040");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaunchZoom(kimya, "4040");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LaunchZoom(tarih, "4040");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LaunchZoom(cografya, "4040");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LaunchZoom(felsefe, "4040");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LaunchZoom(ingilizce, "4040");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LaunchZoom(almanca, "4040");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LaunchZoom(native, "4040");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LaunchZoom(din, "4040");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LaunchZoom(string confno, string pwd)
        {
            string zoompath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Zoom\bin\Zoom.exe");
            Process.Start("cmd.exe", "/c start \"" + zoompath + "\" \"zoommtg://zoom.us/join?confno=" + confno + "&pwd=" + pwd + "\"");
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
