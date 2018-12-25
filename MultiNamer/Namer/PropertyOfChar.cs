using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namer
{
    class PropertyOfChar
    {
        public int fontSize;
        public Color c;
        public string fontFamily;
        public FontStyle fs;
        public int X;
        public int Y;

       
        public PropertyOfChar(int fontSize, Color c, string fontFamily,FontStyle fs,int X,int Y)
        {
            this.fontSize = fontSize;
            this.c = c;
            this.fontFamily = fontFamily;
            this.fs = fs;
            this.X = X;
            this.Y = Y;
        }
        //string strFontSize = sR.ReadLine();
        //        this.fontSize = int.Parse(strFontSize);
        //        this.lblFontSize.Text = fontSize.ToString();
        //        MessageBox.Show(fontSize.ToString());
        //        string strC = sR.ReadLine();
        //        this.c = Color.FromArgb(int.Parse(strC));
        //        this.pictureBox2.BackColor = c;
        //        MessageBox.Show(c.Name);
        //        string strFontFamily = sR.ReadLine();
        //        this.fontFamily = strFontFamily;
        //        MessageBox.Show(fontFamily.ToString());
        //        this.pictureBox1.Invalidate();
        
    }
}
