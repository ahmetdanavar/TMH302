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
    public partial class ikiliGoruntu : Form
    {
        Bitmap kaynak, kaynak2, islem;

        private void aÇ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                kaynak2 = new Bitmap(openFileDialog1.FileName);
                kaynakBox2.Image = kaynak2;
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel1 = kaynak.GetPixel(x, y);
                    Color piksel2 = kaynak2.GetPixel(x, y);
                    red = piksel1.R + piksel2.R;
                    green = piksel1.G + piksel2.G;
                    blue = piksel1.B + piksel2.B;

                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;

                    Color yeniPiksel = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniPiksel);
                }
            }
            işlemBox.Image = islem;

        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel1 = kaynak.GetPixel(x, y);
                    Color piksel2 = kaynak2.GetPixel(x, y);
                    red = piksel1.R - piksel2.R;
                    green = piksel1.G - piksel2.G;
                    blue = piksel1.B - piksel2.B;

                    if (red < 0) red = 0;
                    if (green < 0) green = 0;
                    if (blue < 0) blue = 0;

                    Color yeniPiksel = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniPiksel);

                }
            }
            işlemBox.Image = islem;

        }

        private void intersectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel1 = kaynak.GetPixel(x, y);
                    Color piksel2 = kaynak2.GetPixel(x, y);
                    if (piksel1.R < piksel2.R) red = piksel1.R;
                    else red = piksel2.R;

                    if (piksel1.G < piksel2.G) green = piksel1.G;
                    else green = piksel2.G;

                    if (piksel1.B < piksel2.B) blue = piksel1.B;
                    else blue = piksel2.B;


                    Color yeniPiksel = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniPiksel);

                }
            }
            işlemBox.Image = islem;
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel1 = kaynak.GetPixel(x, y);
                    Color piksel2 = kaynak2.GetPixel(x, y);
                    if (piksel1.R > piksel2.R) red = piksel1.R;
                    else red = piksel2.R;

                    if (piksel1.G > piksel2.G) green = piksel1.G;
                    else green = piksel2.G;

                    if (piksel1.B > piksel2.B) blue = piksel1.B;
                    else blue = piksel2.B;


                    Color yeniPiksel = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniPiksel);
                }
            }
            işlemBox.Image = islem;
        }

        private void differenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel1 = kaynak.GetPixel(x, y);
                    Color piksel2 = kaynak2.GetPixel(x, y);
                    red = Math.Abs(piksel1.R - piksel2.R);
                    green = Math.Abs(piksel1.G - piksel2.G);
                    blue = Math.Abs(piksel1.B - piksel2.B);



                    Color yeniPiksel = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniPiksel);
                }
            }
            işlemBox.Image = islem;
        }

        public ikiliGoruntu()
        {
            InitializeComponent();
        }

        private void aÇ1ToolStripMenuItem_Click(object sender, EventArgs e)
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
