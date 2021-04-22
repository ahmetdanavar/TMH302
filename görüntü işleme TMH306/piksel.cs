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
    public partial class piksel : Form
    {
        Bitmap kaynak;
        public piksel()
        {
            InitializeComponent();
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Color renk = kaynak.GetPixel(x, y);

            pictureBox1.BackColor = renk;

            Console.WriteLine(renk.R + "-" + renk.G + "-" + renk.B);
        }

    }
}

