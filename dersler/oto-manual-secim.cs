using System;
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
    public partial class oto_manual_secim : MaterialSkin.Controls.MaterialForm
    {
        public oto_manual_secim()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SınıflarOto f = new SınıflarOto();
            f.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SınıflarManual f = new SınıflarManual();
            f.Show();
        }
    }
}
