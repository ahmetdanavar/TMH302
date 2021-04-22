using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görüntü_işleme_TMH306
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pikselAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piksel pikselFormu = new piksel();
            pikselFormu.ShowDialog();

        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invert invertFormu = new invert();
            invertFormu.ShowDialog();

        }

        private void parlaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parlaklık parlaklikFormu = new parlaklık();
            parlaklikFormu.ShowDialog();

        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gri griFormu = new gri();
            griFormu.ShowDialog();

        }

        private void thersholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            threshold thresholdFormu = new threshold();
            thresholdFormu.ShowDialog();

        }

        private void ikiGörüntüIşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ikiliGoruntu ikiliGoruntuFormu = new ikiliGoruntu();
            ikiliGoruntuFormu.ShowDialog();

        }
    }
}
