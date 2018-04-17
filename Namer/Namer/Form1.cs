using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point start;
        
        private bool ifDrawRect;
        
        private Point currentPosition = new Point(0,0);
        private int fontSize = 10;
        private string fontFamily = "Arial";
        private FontStyle fs = FontStyle.Bold;
        private Color c = Color.White;
        private string imagePath;
        private Bitmap bitmap;

        private int clickNumber = 0;

       


        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                imagePath = path;
                bitmap = (Bitmap)Image.FromFile(path);
                pictureBox1.Image = bitmap.Clone() as Image;
            }

            //iniWidth = this.pictureBox1.Image.Width;
            //iniHeight = this.pictureBox1.Image.Height;
            //System.Reflection.PropertyInfo _ImageRectanglePropert = this.pictureBox1.GetType().GetProperty("ImageRectangle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            //Rectangle rect = (Rectangle)_ImageRectanglePropert.GetValue(pictureBox1, null);
            //nowWidth = rect.Width;
            //nowHeight = rect.Height;
            //pictureBoxSizeHeight = this.pictureBox1.Height;
            //pictureBoxSizeWidth = this.pictureBox1.Width;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ifDrawRect = false;
            
            fontSize = 15;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            ifDrawRect = true;
           
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (ifDrawRect)
            {
                
                currentPosition = e.Location;
                this.pictureBox1.Invalidate();

            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ifDrawRect = false;
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (currentPosition.X != 0 & currentPosition.Y != 0)
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                e.Graphics.DrawString("爱因斯坦", new Font(fontFamily, fontSize, fs), new SolidBrush(c), currentPosition.X, currentPosition.Y,sf);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontSize++;
            
            this.pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontSize--;
            if (fontSize == 3)
            {
                fontSize = 4;
            }
            this.pictureBox1.Invalidate();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.BackColor = colorDialog1.Color;
                c = colorDialog1.Color;
                this.pictureBox1.Invalidate();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fontFamily = fontDialog1.Font.Name;
                this.fs = fontDialog1.Font.Style;
                this.pictureBox1.Invalidate();


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void changeTran()
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Form f2 = new Form2(currentPosition,fontSize,fontFamily,fs,c,imagePath);
            f2.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clickNumber += 1;
            if (clickNumber == 4)
            {
                MessageBox.Show("老婆我爱你！");
                clickNumber = 0;
            }
        }
    }
}
