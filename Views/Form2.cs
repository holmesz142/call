using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call.Views
{
    public partial class Form2 : Form
    {
        Image image;
        Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult resuls = open.ShowDialog();
            if(resuls == DialogResult.OK)
            {
                image = Image.FromFile(open.FileName);
                bitmap = (Bitmap)image;
                pictureBox1.Image = bitmap;
            }
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.GetImage = pictureBox1.Image;
            frm.ShowDialog();
            pictureBox1.Image = frm.GetImage;

        }
    }
}
