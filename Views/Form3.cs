using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace call.Views
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public Form3()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBoxCamera.Items.Add(info.Name);
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBoxCamera.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(cam != null && cam.IsRunning)
            {
                cam.Stop();
            }

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Users\\Admin\\Desktop\\Example";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
