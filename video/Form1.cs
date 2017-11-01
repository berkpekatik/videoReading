using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;

namespace video
{
    public partial class Form1 : Form
    {
        Capture _capture;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _capture = new Capture(openFileDialog1.FileName.ToString());
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mat m = new Mat();
            
            _capture.QueryFrame();
            _capture.Retrieve(m);
            pictureBox1.Image = m.ToImage<Bgr, byte>().Bitmap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
