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
    public partial class invert : Form
    {
        Bitmap kaynak, islem;
        public invert()
        {
            InitializeComponent();
        }

        private void uyglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    Color yeniPiksel = Color.FromArgb(255 - piksel.R, 255 - piksel.G, 255 - piksel.B);
                    islem.SetPixel(x, y, yeniPiksel);
                }
            }
            işlemBox.Image = islem;

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
    }
}