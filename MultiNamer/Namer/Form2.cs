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
                string[] lines = File.ReadAllLines(file,Encoding.Default);
                listBox1.Items.Clear();
                foreach (string s in lines)
                {
                    listBox1.Items.Add(s);
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
            

            string foldPath="";
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                
                
            }

            foreach (string item in listBox1.Items)
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);

                Graphics g1 = Graphics.FromImage(bitmap);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                g1.DrawString(item, new Font(fontFamily, fontSize, fs), new SolidBrush(c), currentPosition.X, currentPosition.Y, sf);
                string path = foldPath + "/" + item + imageFormat;
                bitmap.Save(@path, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            if (foldPath != "")
            {
                MessageBox.Show("成功！！" + " 打开目录  " + foldPath + "   查看");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnChoose, "打开带名字的列表");
            toolTip1.SetToolTip(btnSave, "选择一个文件夹存放结果");
        }
    }
}
