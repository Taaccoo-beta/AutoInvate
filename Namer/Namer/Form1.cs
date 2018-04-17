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
        private Color c = Color.Black;
        private string imagePath;
        private Bitmap bitmap;


        private int iniWidth;
        private int iniHeight;
        private int nowWidth;
        private int nowHeight;
        private int pictureBoxSizeWidth;
        private int pictureBoxSizeHeight;


        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                imagePath = path;
                bitmap = (Bitmap)Image.FromFile(path);
                pictureBox1.Image = bitmap.Clone() as Image;
            }

            iniWidth = this.pictureBox1.Image.Width;
            iniHeight = this.pictureBox1.Image.Height;
            System.Reflection.PropertyInfo _ImageRectanglePropert = this.pictureBox1.GetType().GetProperty("ImageRectangle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            Rectangle rect = (Rectangle)_ImageRectanglePropert.GetValue(pictureBox1, null);
            nowWidth = rect.Width;
            nowHeight = rect.Height;
            pictureBoxSizeHeight = this.pictureBox1.Height;
            pictureBoxSizeWidth = this.pictureBox1.Width;
            MessageBox.Show(iniWidth.ToString());
            MessageBox.Show(iniHeight.ToString());
            MessageBox.Show(nowWidth.ToString());
            MessageBox.Show(nowHeight.ToString());
            
            MessageBox.Show(pictureBoxSizeWidth.ToString());
            MessageBox.Show(pictureBoxSizeHeight.ToString());

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
            float x1 = currentPosition.X - (pictureBoxSizeWidth - nowWidth) / 2f;
            float y1 = currentPosition.Y - (pictureBoxSizeHeight - nowHeight) / 2f;
            float finalX = x1 * iniWidth / nowWidth;
            float finalY = y1 * iniHeight / nowHeight;
            int finalFontSize = ((fontSize) * iniWidth) / (nowWidth );
            PointF cp = new PointF(finalX, finalY);
            // f2 = new Form2(cp,finalFontSize,fontFamily,fs,c,imagePath);
            //f2.Show();
            Graphics g2 = Graphics.FromImage(this.bitmap);

       


            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            Font ft =  new Font(fontFamily, fontSize, fs);
            //MessageBox.Show(ft.Size.ToString());
            //SizeF sizeF = g2.MeasureString("爱因斯坦", ft);
            //MessageBox.Show(sizeF.Height.ToString());
            g2.DrawString("爱因斯坦",ft , new SolidBrush(c), finalX, finalY, sf);
            ////this.pictureBox1.Image = bitmap;
            ////this.pictureBox1.Image.Save(foldPath + "/" + "a" + imageFormat, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.bitmap.Save("g:/test/hello.jpg" , System.Drawing.Imaging.ImageFormat.Jpeg);

            //MessageBox.Show(rect.Width.ToString());
        }
    }
}
