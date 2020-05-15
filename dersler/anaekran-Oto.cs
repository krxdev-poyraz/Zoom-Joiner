using System;
using MaterialSkin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersler
{
    public partial class SınıflarOto : MaterialSkin.Controls.MaterialForm
    {
        public SınıflarOto()
        {
            InitializeComponent();
        }

        private void anaekran_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }


        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}
