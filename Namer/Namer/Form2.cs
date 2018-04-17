using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namer
{
    public partial class Form2 : Form
    {

        private Point currentPosition;
        private int fontSize ;
        private string fontFamily ;
        private FontStyle fs;
        private Color c ;
        private string imagePath;
        private int width;
        private int height;



        public Form2(Point pt,int fontSize,string fontFamily,FontStyle fs,Color c,string imagePath)
        {
            this.currentPosition = pt;
            this.fontSize = fontSize;
            this.fontFamily = fontFamily;
            this.fs = fs;
            this.c = c;
            this.imagePath = imagePath;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdg = new OpenFileDialog();
            if (ofdg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string file = ofdg.FileName;//得到选择的文件的完整路径
                StreamReader sR2 = File.OpenText(file);
                string name = "";
                while ((name = sR2.ReadLine()) != null)
                {   // 4 将每行添加到文件List中
                    this.listBox1.Items.Add(name);
                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string imageFormat = Path.GetExtension(imagePath);
            Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);
           
            Graphics g1 = Graphics.FromImage(bitmap);

            string foldPath="";
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                
                MessageBox.Show(foldPath);
            }


            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g1.DrawString("爱因斯坦", new Font(fontFamily, fontSize, fs), new SolidBrush(c), currentPosition.X, currentPosition.Y, sf);
            this.pictureBox1.Image = bitmap;
            this.pictureBox1.Image.Save(foldPath+"/"+"a"+imageFormat,System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
