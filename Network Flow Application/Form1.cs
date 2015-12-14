using Network_Flow_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Flow_Application
{
    public partial class Form1 : Form
    {
        Image save = Resources.save;
        Image open = Resources.open;
        Image pump = Resources.pump;
        Image sink = Resources.sink;
        Image pipe = Resources.Pipe;
        Image merger = Resources.merger;
        Image splitter = Resources.splitter;
        Image adjustableSplitter = Resources.adjustable;
        Image settings = Resources.settings;
        Image eraser = Resources.eraser;

        public Form1()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }
        public Bitmap ResizeMethod(Image img)
        {

            int a_Width = img.Width + ((img.Width * 8) / 100);
            int a_Height = img.Height + ((img.Height * 8) / 100);

            Bitmap a_1 = new Bitmap(a_Width, a_Height);
            Graphics g = Graphics.FromImage(a_1);
            g.DrawImage(img, new Rectangle(Point.Empty, a_1.Size));
            return a_1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = ResizeMethod(save);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = save;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = ResizeMethod(open);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = open;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = ResizeMethod(pump);

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = pump;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = ResizeMethod(sink);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = sink;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Image = ResizeMethod(pipe);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = pipe;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = ResizeMethod(merger);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = merger;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            //adjustable splitter
            pictureBox10.Image = ResizeMethod(adjustableSplitter);

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = adjustableSplitter;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            //splitter
            
            pictureBox9.Image = ResizeMethod(splitter);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = splitter;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            //settings
           
            pictureBox5.Image = ResizeMethod(settings);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = settings;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            //eraser
            
            pictureBox4.Image = ResizeMethod(eraser);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = eraser;
        }

        private void network_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Black);
            int numOfCells = 26;
            int cellSize = 104;

            for (int y = 0; y < numOfCells; y++)
            {
                gr.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; x++)
            {
                gr.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }
    }
}
