namespace Namer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShowConfigFile = new System.Windows.Forms.Label();
            this.btnChooseConfig = new System.Windows.Forms.Button();
            this.cbCharList = new System.Windows.Forms.ComboBox();
            this.gbSetParameters = new System.Windows.Forms.GroupBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.tbItemadded = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.reLeft = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbSetParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(13, 28);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(117, 27);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Open";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(19, 22);
            this.btnBig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(100, 27);
            this.btnBig.TabIndex = 2;
            this.btnBig.Text = "Big";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.reLeft);
            this.groupBox1.Controls.Add(this.lblFontSize);
            this.groupBox1.Controls.Add(this.btnSmall);
            this.groupBox1.Controls.Add(this.btnBig);
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(352, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FontSize";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(244, 28);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(39, 15);
            this.lblFontSize.TabIndex = 11;
            this.lblFontSize.Text = "NULL";
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(125, 22);
            this.btnSmall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(100, 27);
            this.btnSmall.TabIndex = 3;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(14, 162);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(137, 27);
            this.btnChooseColor.TabIndex = 5;
            this.btnChooseColor.Text = "ChooseColor";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(170, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 27);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(261, 162);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(89, 27);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 689);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 33);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(405, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 710);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnChooseColor);
            this.groupBox2.Controls.Add(this.btnFont);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(11, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 208);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFileName);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnChoosePath);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbFileName);
            this.groupBox3.Location = new System.Drawing.Point(15, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 133);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saving";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(119, 63);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(31, 15);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "D:/";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 91);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path：";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(28, 91);
            this.btnChoosePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(137, 27);
            this.btnChoosePath.TabIndex = 8;
            this.btnChoosePath.Text = "ChoosePath";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FileName：";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(119, 27);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(100, 25);
            this.tbFileName.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblShowConfigFile);
            this.groupBox4.Controls.Add(this.btnChooseConfig);
            this.groupBox4.Location = new System.Drawing.Point(13, 545);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 135);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loading";
            // 
            // lblShowConfigFile
            // 
            this.lblShowConfigFile.AutoSize = true;
            this.lblShowConfigFile.Location = new System.Drawing.Point(27, 45);
            this.lblShowConfigFile.Name = "lblShowConfigFile";
            this.lblShowConfigFile.Size = new System.Drawing.Size(39, 15);
            this.lblShowConfigFile.TabIndex = 12;
            this.lblShowConfigFile.Text = "NULL";
            // 
            // btnChooseConfig
            // 
            this.btnChooseConfig.Location = new System.Drawing.Point(29, 84);
            this.btnChooseConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseConfig.Name = "btnChooseConfig";
            this.btnChooseConfig.Size = new System.Drawing.Size(137, 27);
            this.btnChooseConfig.TabIndex = 9;
            this.btnChooseConfig.Text = "Choose";
            this.btnChooseConfig.UseVisualStyleBackColor = true;
            this.btnChooseConfig.Click += new System.EventHandler(this.btnChooseConfig_Click);
            // 
            // cbCharList
            // 
            this.cbCharList.FormattingEnabled = true;
            this.cbCharList.Location = new System.Drawing.Point(8, 65);
            this.cbCharList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCharList.Name = "cbCharList";
            this.cbCharList.Size = new System.Drawing.Size(157, 23);
            this.cbCharList.TabIndex = 13;
            this.cbCharList.Text = "Select";
            this.cbCharList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbCharList.SelectedValueChanged += new System.EventHandler(this.cbCharList_SelectedValueChanged);
            this.cbCharList.TextChanged += new System.EventHandler(this.cbCharList_TextChanged);
            // 
            // gbSetParameters
            // 
            this.gbSetParameters.Controls.Add(this.lblItemNumber);
            this.gbSetParameters.Controls.Add(this.tbItemadded);
            this.gbSetParameters.Controls.Add(this.btnDelete);
            this.gbSetParameters.Controls.Add(this.btnAddChar);
            this.gbSetParameters.Controls.Add(this.cbCharList);
            this.gbSetParameters.Location = new System.Drawing.Point(13, 65);
            this.gbSetParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSetParameters.Name = "gbSetParameters";
            this.gbSetParameters.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSetParameters.Size = new System.Drawing.Size(385, 119);
            this.gbSetParameters.TabIndex = 14;
            this.gbSetParameters.TabStop = false;
            this.gbSetParameters.Text = "Setting";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(188, 35);
            this.lblItemNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(15, 15);
            this.lblItemNumber.TabIndex = 17;
            this.lblItemNumber.Text = "0";
            // 
            // tbItemadded
            // 
            this.tbItemadded.Location = new System.Drawing.Point(8, 35);
            this.tbItemadded.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbItemadded.Name = "tbItemadded";
            this.tbItemadded.Size = new System.Drawing.Size(157, 25);
            this.tbItemadded.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 27);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(176, 62);
            this.btnAddChar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(83, 27);
            this.btnAddChar.TabIndex = 14;
            this.btnAddChar.Text = "Add";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
            // 
            // reLeft
            // 
            this.reLeft.AutoSize = true;
            this.reLeft.Location = new System.Drawing.Point(19, 68);
            this.reLeft.Name = "reLeft";
            this.reLeft.Size = new System.Drawing.Size(60, 19);
            this.reLeft.TabIndex = 13;
            this.reLeft.Text = "Left";
            this.reLeft.UseVisualStyleBackColor = true;
            this.reLeft.CheckedChanged += new System.EventHandler(this.reLeft_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Checked = true;
            this.rbCenter.Location = new System.Drawing.Point(125, 68);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(76, 19);
            this.rbCenter.TabIndex = 14;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 734);
            this.Controls.Add(this.gbSetParameters);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Invitation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbSetParameters.ResumeLayout(false);
            this.gbSetParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblShowConfigFile;
        private System.Windows.Forms.Button btnChooseConfig;
        private System.Windows.Forms.ComboBox cbCharList;
        private System.Windows.Forms.GroupBox gbSetParameters;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddChar;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox tbItemadded;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton reLeft;
    }
}

