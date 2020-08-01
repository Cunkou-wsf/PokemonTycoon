﻿namespace EasyCon
{
    partial class CaptureVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureVideo));
            this.reasultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Snapshot = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.targetImg = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchMethodComBox = new System.Windows.Forms.ComboBox();
            this.imgLableList = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchResultImg = new System.Windows.Forms.PictureBox();
            this.CaptureVideoHelp = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.VideoSourcePlayerMonitor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Snapshot)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSourcePlayerMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // reasultListBox
            // 
            this.reasultListBox.FormattingEnabled = true;
            this.reasultListBox.ItemHeight = 12;
            this.reasultListBox.Location = new System.Drawing.Point(520, 506);
            this.reasultListBox.Name = "reasultListBox";
            this.reasultListBox.Size = new System.Drawing.Size(120, 40);
            this.reasultListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "搜图标签-双击加载";
            // 
            // Snapshot
            // 
            this.Snapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Snapshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Snapshot.Location = new System.Drawing.Point(0, 0);
            this.Snapshot.Margin = new System.Windows.Forms.Padding(0);
            this.Snapshot.Name = "Snapshot";
            this.Snapshot.Size = new System.Drawing.Size(640, 360);
            this.Snapshot.TabIndex = 4;
            this.Snapshot.TabStop = false;
            this.Snapshot.Paint += new System.Windows.Forms.PaintEventHandler(this.Snapshot_Paint);
            this.Snapshot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseDown);
            this.Snapshot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseMove);
            this.Snapshot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseUp);
            this.Snapshot.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseWheel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "截图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "双击切换采集/编辑模式，滚轮缩放，ctrl+滚轮水平缩放，shift+滚轮垂直缩放";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "开始圈选(红)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "搜索测试";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "开始圈选(绿)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.targetImg);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchMethodComBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 122);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索参数";
            // 
            // targetImg
            // 
            this.targetImg.Location = new System.Drawing.Point(438, 68);
            this.targetImg.Name = "targetImg";
            this.targetImg.Size = new System.Drawing.Size(63, 48);
            this.targetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetImg.TabIndex = 34;
            this.targetImg.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(78, 16);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(99, 21);
            this.textBox10.TabIndex = 33;
            this.textBox10.Text = "5号路蛋屋主人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "搜图标签名:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(442, 18);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 21);
            this.textBox9.TabIndex = 31;
            this.textBox9.Text = "90.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "最低更新匹配度:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(311, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 29;
            this.label22.Text = "搜索范围";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(94, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 28;
            this.label21.Text = "目标位置";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 21);
            this.textBox4.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "X:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 21);
            this.textBox5.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(113, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "Y:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(35, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(69, 21);
            this.textBox7.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "宽:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(138, 96);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(69, 21);
            this.textBox8.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(110, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 20;
            this.label20.Text = "长:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 21);
            this.textBox2.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "X:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 21);
            this.textBox3.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "Y:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 21);
            this.textBox1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "宽:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(353, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(69, 21);
            this.textBox6.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(325, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "长:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "搜索方法";
            // 
            // searchMethodComBox
            // 
            this.searchMethodComBox.FormattingEnabled = true;
            this.searchMethodComBox.Location = new System.Drawing.Point(239, 17);
            this.searchMethodComBox.Name = "searchMethodComBox";
            this.searchMethodComBox.Size = new System.Drawing.Size(104, 20);
            this.searchMethodComBox.TabIndex = 0;
            this.searchMethodComBox.Text = "选择搜索方法";
            // 
            // imgLableList
            // 
            this.imgLableList.FormattingEnabled = true;
            this.imgLableList.ItemHeight = 12;
            this.imgLableList.Location = new System.Drawing.Point(651, 365);
            this.imgLableList.Name = "imgLableList";
            this.imgLableList.Size = new System.Drawing.Size(143, 256);
            this.imgLableList.TabIndex = 19;
            this.imgLableList.DoubleClick += new System.EventHandler(this.imgLableList_DoubleClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(440, 441);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "保存标签";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(519, 463);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 12);
            this.label23.TabIndex = 21;
            this.label23.Text = "匹配度：耗时：";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(343, 441);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "动态测试";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchResultImg
            // 
            this.searchResultImg.Location = new System.Drawing.Point(520, 548);
            this.searchResultImg.Name = "searchResultImg";
            this.searchResultImg.Size = new System.Drawing.Size(120, 73);
            this.searchResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchResultImg.TabIndex = 24;
            this.searchResultImg.TabStop = false;
            // 
            // CaptureVideoHelp
            // 
            this.CaptureVideoHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CaptureVideoHelp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptureVideoHelp.Location = new System.Drawing.Point(800, 298);
            this.CaptureVideoHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaptureVideoHelp.Multiline = true;
            this.CaptureVideoHelp.Name = "CaptureVideoHelp";
            this.CaptureVideoHelp.ReadOnly = true;
            this.CaptureVideoHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CaptureVideoHelp.Size = new System.Drawing.Size(284, 323);
            this.CaptureVideoHelp.TabIndex = 25;
            this.CaptureVideoHelp.Text = resources.GetString("CaptureVideoHelp.Text");
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 470);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "打开截图";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(648, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "当前分辨率：1080P";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // VideoSourcePlayerMonitor
            // 
            this.VideoSourcePlayerMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VideoSourcePlayerMonitor.Location = new System.Drawing.Point(648, 0);
            this.VideoSourcePlayerMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.VideoSourcePlayerMonitor.Name = "VideoSourcePlayerMonitor";
            this.VideoSourcePlayerMonitor.Size = new System.Drawing.Size(447, 251);
            this.VideoSourcePlayerMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VideoSourcePlayerMonitor.TabIndex = 29;
            this.VideoSourcePlayerMonitor.TabStop = false;
            this.VideoSourcePlayerMonitor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseDoubleClick);
            this.VideoSourcePlayerMonitor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseDown);
            this.VideoSourcePlayerMonitor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseMove);
            this.VideoSourcePlayerMonitor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseUp);
            this.VideoSourcePlayerMonitor.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseWheel);
            this.VideoSourcePlayerMonitor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.VideoSourcePlayerMonitor_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "左键按住移动，滚轮缩放，右键按住圈选";
            // 
            // CaptureVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoSourcePlayerMonitor);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CaptureVideoHelp);
            this.Controls.Add(this.searchResultImg);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imgLableList);
            this.Controls.Add(this.reasultListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Snapshot);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaptureVideo";
            this.Text = "CaptureVideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureVideo_FormClosed);
            this.Load += new System.EventHandler(this.CaptureVideo_Load);
            this.Resize += new System.EventHandler(this.CaptureVideo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Snapshot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSourcePlayerMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox reasultListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Snapshot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox imgLableList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox searchMethodComBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox searchResultImg;
        private System.Windows.Forms.PictureBox targetImg;
        private System.Windows.Forms.TextBox CaptureVideoHelp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox VideoSourcePlayerMonitor;
        private System.Windows.Forms.Label label2;
    }
}