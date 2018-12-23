using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

            toolTip1.SetToolTip(btnOpenImage, "打开一张图");
            toolTip1.SetToolTip(btnBig, "放大字体");
            toolTip1.SetToolTip(btnSmall, "缩小字体");
            toolTip1.SetToolTip(btnChooseColor, "选择颜色");
            toolTip1.SetToolTip(btnFont, "选择字体");
            toolTip1.SetToolTip(btnStart, "设置完成并打开存储模块");
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
            this.lblFontSize.Text = fontSize.ToString();
            this.pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontSize--;
            if (fontSize == 3)
            {
                fontSize = 4;
            }
            this.lblFontSize.Text = fontSize.ToString();
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
        //private void DataSave()
        //{
        //    FileInfo myFile = new FileInfo(path);
        //    StreamWriter sW = myFile.CreateText();

        //    sW.WriteLine("ExpName: " + expName);
        //    sW.WriteLine("Date: " + dateTime);

        //    sW.Write("ExpOrder:  [");
        //    foreach (var item in expOrder)
        //    {
        //        sW.Write(item + ",");
        //    }
        //    sW.Write("]");

        //    sW.WriteLine();


        //    sW.WriteLine();
        //    sW.WriteLine();
        //    sW.Write("Position" + " " + "Torque");
        //    sW.WriteLine();

        //    for (int i = 1; i != 7; i++)
        //    {
        //        sW.Write("exp" + i);
        //        sW.WriteLine();
        //        int indexInside = positionData[i].Count;
        //        for (int j = 0; j != indexInside; j++)
        //        {
        //            sW.WriteLine(positionData[i][j].ToString("00.00") + "," + troqueData[i][j].ToString("00.00"));
        //        }

        //    }

        //    sW.Close();
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text != "NULL" & tbFileName.Text != "")
            {
                string path = this.lblFileName.Text +"\\" + tbFileName.Text + ".txt";
                FileInfo myFile = new FileInfo(path);
                StreamWriter sW = myFile.CreateText();

                try
                {
                    sW.WriteLine(fontSize);
                    sW.WriteLine(c.ToArgb());
                    sW.WriteLine(fontFamily);
                }
                catch
                {
                    MessageBox.Show("No config parameters");
                }
                sW.Close();
            }
            else
            {
                MessageBox.Show("Wrong!!");
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            string path = BrowDialog.SelectedPath;
            if (path != "")
            {
                lblFileName.Text = path;
            }
            else
            {
                MessageBox.Show("No path Choosed!");
            }
        }

        private void btnChooseConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();



            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                string fileName = path.Substring(path.LastIndexOf("\\") + 1);
                this.lblShowConfigFile.Text = fileName;
                StreamReader sR = File.OpenText(path);
                
                string strFontSize = sR.ReadLine();
                this.fontSize = int.Parse(strFontSize);
                this.lblFontSize.Text = fontSize.ToString();
                MessageBox.Show(fontSize.ToString());
                string strC = sR.ReadLine();
                this.c = Color.FromArgb(int.Parse(strC));
                this.pictureBox2.BackColor = c;
                MessageBox.Show(c.Name);
                string strFontFamily = sR.ReadLine();
                this.fontFamily = strFontFamily;
                MessageBox.Show(fontFamily.ToString());
                this.pictureBox1.Invalidate();

                sR.Close();
            }
        }
    }
}
