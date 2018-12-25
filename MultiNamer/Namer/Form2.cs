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
        private List<PropertyOfChar> pof;
        private List<string> l;

        
        public Form2(List<PropertyOfChar> pof, List<string> l ,string imagePath)
        {
            InitializeComponent();
            this.pof = pof;
            this.imagePath = imagePath;
            string name = "list";
            string btnName = "btn";
            
            this.l = l;
            for (int i = 0; i < pof.Count; i++)
            {
                Label ll = new Label();
                ll.Text = l[i];
                ll.Location = new Point(170, 10 + i * 150);
                Button btn = new Button();
                btn.Name = btn + i.ToString();
                btn.Size = new Size(103, 27);
                btn.Text = "Choose";
                btn.Location = new Point(32,  i * 150);
                ListBox gbox = new ListBox();
                gbox.Name = name + i.ToString();
                gbox.Text = name + i.ToString();
                gbox.Width = 200;
                gbox.Height = 100;
                gbox.Location = new Point(32, 40 + i * 150);
                gbox.HorizontalScrollbar = true;
                this.panel1.Controls.Add(btn);
                this.panel1.Controls.Add(ll);
                this.panel1.Controls.Add(gbox);
               
                btn.Click += new EventHandler(this.btn_Click);
                
            }
            
           
            
          
        }
        private List<int> numberOfeveryList;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            string btnName = btn.Name;
            ListBox obj = ((ListBox)(this.panel1.Controls.Find("list"+btnName[btnName.Length-1], false)[0]));
            OpenFileDialog ofdg = new OpenFileDialog();
            if (ofdg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string file = ofdg.FileName;//得到选择的文件的完整路径
                string[] lines = File.ReadAllLines(file, Encoding.Default);
                obj.Items.Clear();
                foreach (string s in lines)
                {
                    obj.Items.Add(s);
                }

                


                if (this.panel1.Controls.Find("lbl" + btnName[btnName.Length - 1], false).Length != 0)
                {
                    Label lobj = ((Label)(this.panel1.Controls.Find("lbl" + btnName[btnName.Length - 1], false)[0]));
                    this.panel1.Controls.Remove(lobj);
                    Label l = new Label();
                    l.Name = "lbl" + btnName[btnName.Length - 1];
                    l.Text = obj.Items.Count.ToString();
                    string num = btnName[btnName.Length - 1] + "";
                    int ii = int.Parse(num);
                    MessageBox.Show(ii.ToString());
                    l.Location = new Point(140, 10 + ii * 150);
                    this.panel1.Controls.Add(l);
                    
                  
                }
                else
                {
                    Label l = new Label();
                    l.Name = "lbl" + btnName[btnName.Length - 1];
                    l.Text = obj.Items.Count.ToString();
                    string num = btnName[btnName.Length - 1] + "";
                    int ii = int.Parse(num);
                    MessageBox.Show(ii.ToString());
                    l.Location = new Point(140, 10 + ii * 150);
                    this.panel1.Controls.Add(l);
                    numberOfeveryList.Add(obj.Items.Count);
                }
            }
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ifNull = true;
            for (int i = 0; i != pof.Count; i++)
            {
                ListBox obj = ((ListBox)(this.panel1.Controls.Find("list" + i, false)[0]));
                ifNull = false;
                if (obj.Items.Count == 0)
                {
                    MessageBox.Show("The  " + i.ToString() + " list is null");
                    ifNull = true;
                }

              

            }
           
            if (!ifNull)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                string imageFormat = Path.GetExtension(imagePath);


                string foldPath = "";
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    foldPath = dialog.SelectedPath;


                }
                ListBox obj = ((ListBox)(this.panel1.Controls.Find("list" + 0, false)[0]));
                int numOfName = obj.Items.Count;
                List<List<string>> data = new List<List<string>>();
                for (int j = 0; j != pof.Count; j++)
                {
                    ListBox objj = ((ListBox)(this.panel1.Controls.Find("list" +j, false)[0]));
                    List<string> dd = new List<string>();
                    for (int i = 0; i != objj.Items.Count; i++)
                    {
                        dd.Add(objj.Items[i].ToString());
                    }
                    data.Add(dd);
                }
                try
                {
                    for (int i = 0; i != numOfName; i++)
                    {
                    
                        Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);
                        Graphics g1 = Graphics.FromImage(bitmap);
                   
                        StringFormat sf = new StringFormat();
                        for (int j = 0; j != data.Count; j++)
                        {
                            if (pof[j].alignment == 1)
                            {
                                sf.Alignment = StringAlignment.Center;
                            }
                            else
                            {
                                sf.Alignment = StringAlignment.Near;
                            }
                            g1.DrawString(data[j][i], new Font(pof[j].fontFamily, pof[j].fontSize, pof[j].fs), new SolidBrush(pof[j].c), pof[j].X, pof[j].Y, sf);

                        }
                        string path = foldPath + "/" + data[0][i] + imageFormat;
                        bitmap.Save(@path, System.Drawing.Imaging.ImageFormat.Jpeg);

                    }
                    MessageBox.Show("Finished!!");
                }
                catch
                {
                    MessageBox.Show("Number is different!!!");
                }

            }


            //foreach (string item in listBox1.Items)
            //{
            //    Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);

            //    Graphics g1 = Graphics.FromImage(bitmap);

            //    StringFormat sf = new StringFormat();
            //    sf.Alignment = StringAlignment.Center;
            //    g1.DrawString(item, new Font(fontFamily, fontSize, fs), new SolidBrush(c), currentPosition.X, currentPosition.Y, sf);
            //    string path = foldPath + "/" + item + imageFormat;
            //    bitmap.Save(@path, System.Drawing.Imaging.ImageFormat.Jpeg);

            //}
            //if (foldPath != "")
            //{
            //    MessageBox.Show("成功！！" + " 打开目录  " + foldPath + "   查看");
            //}

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numberOfeveryList = new List<int>();
            toolTip1.SetToolTip(btnSave, "选择一个文件夹存放结果");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
