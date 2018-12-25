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
        //private int fontSize = 10;
        //private string fontFamily = "Arial";
        //private FontStyle fs = FontStyle.Bold;
        //private Color c = Color.White;
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
            
            
            charList = new List<PropertyOfChar>();
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
                
                if (cbCharList.SelectedIndex == -1)
                {
                    MessageBox.Show("Wrong,No item selected!!");
                    ifDrawRect = false;

                }
                else
                {
                    charList[cbCharList.SelectedIndex].X = e.Location.X;
                    charList[cbCharList.SelectedIndex].Y = e.Location.Y;
                    this.pictureBox1.Invalidate();
                }
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

                int fontSize = charList[cbCharList.SelectedIndex].fontSize;
                string fontFamily = charList[cbCharList.SelectedIndex].fontFamily;
                FontStyle fs = charList[cbCharList.SelectedIndex].fs;
                Color c = charList[cbCharList.SelectedIndex].c;
                int X = charList[cbCharList.SelectedIndex].X;
                int Y = charList[cbCharList.SelectedIndex].Y;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(cbCharList.Items[cbCharList.SelectedIndex].ToString(), new Font(fontFamily, fontSize, fs), new SolidBrush(c), X, Y,sf);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            charList[cbCharList.SelectedIndex].fontSize++;
            this.lblFontSize.Text = charList[cbCharList.SelectedIndex].fontSize.ToString();
            this.pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            charList[cbCharList.SelectedIndex].fontSize--;
            if (charList[cbCharList.SelectedIndex].fontSize == 1)
            {
                charList[cbCharList.SelectedIndex].fontSize = 1;
            }
            this.lblFontSize.Text = charList[cbCharList.SelectedIndex].fontSize.ToString();
            this.pictureBox1.Invalidate();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.BackColor = colorDialog1.Color;
                charList[cbCharList.SelectedIndex].c = colorDialog1.Color;
                this.pictureBox1.Invalidate();
                
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.charList[cbCharList.SelectedIndex].fontFamily = fontDialog1.Font.Name;
                this.charList[cbCharList.SelectedIndex].fs = fontDialog1.Font.Style;
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
            
            //Form f2 = new Form2(currentPosition,fontSize,fontFamily,fs,c,imagePath);
            //f2.Show();
            
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
                string path = this.lblFileName.Text + "\\" + tbFileName.Text + ".txt";
                FileInfo myFile = new FileInfo(path);
                StreamWriter sW = myFile.CreateText();

                try
                {
                    if (cbCharList.Items.Count == 0)
                    {
                        MessageBox.Show("Wrong,no items");
                    }
                    else
                    {
                        sW.WriteLine(cbCharList.Items.Count);
                        for (int i = 0; i != cbCharList.Items.Count; i++)
                        {
                            Font f = new Font(charList[i].fontFamily, charList[i].fontSize, charList[i].fs);
                            FontConverter x = new FontConverter();
                            string s = x.ConvertToString(f);
                            //t = x.ConvertFromString(s) as Font;
                            sW.WriteLine(cbCharList.Items[i]);
                            sW.WriteLine(s);
                            sW.WriteLine(charList[i].c.ToArgb()); 
                            sW.WriteLine(charList[i].X);
                            sW.WriteLine(charList[i].Y);
                            
                        }

                    }
                    
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

                cbCharList.Items.Clear();
                string path = ofd.FileName;
                string fileName = path.Substring(path.LastIndexOf("\\") + 1);
                this.lblShowConfigFile.Text = fileName;
                StreamReader sR = File.OpenText(path);
                int count = int.Parse(sR.ReadLine());
                this.lblItemNumber.Text = count.ToString();
                charList.Clear();
                for (int i = 0; i != count; i++)
                {
                    cbCharList.Items.Add(sR.ReadLine());
                    string s = sR.ReadLine();
                    //Font f = new Font(charList[i].fontFamily, charList[i].fontSize, charList[i].fs);

                    FontConverter x = new FontConverter();
                    
                    Font f = x.ConvertFromString(s) as Font;
                    Color c = Color.FromArgb(int.Parse(sR.ReadLine()));
                    int X = int.Parse(sR.ReadLine());
                    int Y = int.Parse(sR.ReadLine());
                    PropertyOfChar poc = new PropertyOfChar((int)f.Size, c, f.FontFamily.Name, f.Style, X, Y);
                    charList.Add(poc);
                }
                sR.Close();
                //sW.WriteLine(cbCharList.Items[i]);
                //
                //sW.WriteLine(charList[i].c.ToArgb());
                //sW.WriteLine(charList[i].X);
                //sW.WriteLine(charList[i].Y);

                //string strFontSize = sR.ReadLine();
                //this.fontSize = int.Parse(strFontSize);
                //this.lblFontSize.Text = fontSize.ToString();
                //MessageBox.Show(fontSize.ToString());
                //string strC = sR.ReadLine();
                //this.c = Color.FromArgb(int.Parse(strC));
                //this.pictureBox2.BackColor = c;
                //MessageBox.Show(c.Name);
                //string strFontFamily = sR.ReadLine();
                //this.fontFamily = strFontFamily;
                //MessageBox.Show(fontFamily.ToString());
                //this.pictureBox1.Invalidate();

                //sR.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblFontSize.Text = charList[cbCharList.SelectedIndex].fontSize.ToString();
            this.pictureBox2.BackColor = charList[cbCharList.SelectedIndex].c;
            currentPosition.X = charList[cbCharList.SelectedIndex].X;
            currentPosition.Y = charList[cbCharList.SelectedIndex].X;

            this.pictureBox1.Invalidate();
        }
        private List<PropertyOfChar> charList;

        private void btnAddChar_Click(object sender, EventArgs e)
        {
            if (tbItemadded.Text != "")
            {
                this.cbCharList.Items.Add(tbItemadded.Text);
                this.lblItemNumber.Text = cbCharList.Items.Count.ToString();
                
                PropertyOfChar poc = new PropertyOfChar(10, Color.White, "Arial",FontStyle.Bold,10,10);
                charList.Add(poc);
            }
            else
            {
                MessageBox.Show("No content input!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = cbCharList.SelectedIndex;
            charList.RemoveAt(index);
            this.cbCharList.Items.Remove(cbCharList.SelectedItem);
            if (this.cbCharList.Items.Count == 0)
            {
                cbCharList.Text = "";
            }
        }

        private void cbCharList_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lblFontSize.Text = charList[cbCharList.SelectedIndex].fontSize.ToString();
            this.pictureBox2.BackColor = charList[cbCharList.SelectedIndex].c;
            this.pictureBox1.Invalidate();
        }

        private void cbCharList_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
