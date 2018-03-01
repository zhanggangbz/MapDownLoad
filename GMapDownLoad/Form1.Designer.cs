namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_dic = new System.Windows.Forms.TextBox();
            this.button_init = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_s_lon = new System.Windows.Forms.TextBox();
            this.textBox_s_lat = new System.Windows.Forms.TextBox();
            this.textBox_e_lon = new System.Windows.Forms.TextBox();
            this.textBox_e_lat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_selectDic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_error_down = new System.Windows.Forms.TextBox();
            this.textBox_complate_down = new System.Windows.Forms.TextBox();
            this.textBox_need_down = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownSZ = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownEZ = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEZ)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_dic
            // 
            this.textBox_dic.Location = new System.Drawing.Point(74, 21);
            this.textBox_dic.Name = "textBox_dic";
            this.textBox_dic.Size = new System.Drawing.Size(340, 21);
            this.textBox_dic.TabIndex = 0;
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(12, 310);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(110, 23);
            this.button_init.TabIndex = 5;
            this.button_init.Text = "1.初始化任务";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "存储位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "任务名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(74, 56);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(340, 21);
            this.textBox_name.TabIndex = 2;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(153, 310);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(93, 23);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "2.下载数据";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "完成进度";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "剩余数据";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "起始经度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "起始纬度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "结束经度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "结束纬度";
            // 
            // textBox_s_lon
            // 
            this.textBox_s_lon.Location = new System.Drawing.Point(74, 27);
            this.textBox_s_lon.Name = "textBox_s_lon";
            this.textBox_s_lon.Size = new System.Drawing.Size(143, 21);
            this.textBox_s_lon.TabIndex = 0;
            this.textBox_s_lon.Text = "-175";
            // 
            // textBox_s_lat
            // 
            this.textBox_s_lat.Location = new System.Drawing.Point(74, 64);
            this.textBox_s_lat.Name = "textBox_s_lat";
            this.textBox_s_lat.Size = new System.Drawing.Size(143, 21);
            this.textBox_s_lat.TabIndex = 1;
            this.textBox_s_lat.Text = "-80";
            // 
            // textBox_e_lon
            // 
            this.textBox_e_lon.Location = new System.Drawing.Point(74, 98);
            this.textBox_e_lon.Name = "textBox_e_lon";
            this.textBox_e_lon.Size = new System.Drawing.Size(143, 21);
            this.textBox_e_lon.TabIndex = 2;
            this.textBox_e_lon.Text = "175";
            // 
            // textBox_e_lat
            // 
            this.textBox_e_lat.Location = new System.Drawing.Point(74, 135);
            this.textBox_e_lat.Name = "textBox_e_lat";
            this.textBox_e_lat.Size = new System.Drawing.Size(143, 21);
            this.textBox_e_lat.TabIndex = 3;
            this.textBox_e_lat.Text = "80";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownEZ);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDownSZ);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_s_lat);
            this.groupBox1.Controls.Add(this.textBox_e_lat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_e_lon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_s_lon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据范围";
            // 
            // button_selectDic
            // 
            this.button_selectDic.Location = new System.Drawing.Point(420, 19);
            this.button_selectDic.Name = "button_selectDic";
            this.button_selectDic.Size = new System.Drawing.Size(34, 23);
            this.button_selectDic.TabIndex = 1;
            this.button_selectDic.Text = "...";
            this.button_selectDic.UseVisualStyleBackColor = true;
            this.button_selectDic.Click += new System.EventHandler(this.button_selectDic_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "需下载数据标记";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "下载完成后标记";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_error_down);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_complate_down);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_need_down);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(272, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多次下载标记设置";
            // 
            // textBox_error_down
            // 
            this.textBox_error_down.Location = new System.Drawing.Point(125, 129);
            this.textBox_error_down.Name = "textBox_error_down";
            this.textBox_error_down.Size = new System.Drawing.Size(100, 21);
            this.textBox_error_down.TabIndex = 2;
            this.textBox_error_down.Text = "2";
            // 
            // textBox_complate_down
            // 
            this.textBox_complate_down.Location = new System.Drawing.Point(125, 80);
            this.textBox_complate_down.Name = "textBox_complate_down";
            this.textBox_complate_down.Size = new System.Drawing.Size(100, 21);
            this.textBox_complate_down.TabIndex = 1;
            this.textBox_complate_down.Text = "1";
            // 
            // textBox_need_down
            // 
            this.textBox_need_down.Location = new System.Drawing.Point(125, 36);
            this.textBox_need_down.Name = "textBox_need_down";
            this.textBox_need_down.Size = new System.Drawing.Size(100, 21);
            this.textBox_need_down.TabIndex = 0;
            this.textBox_need_down.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "下载错误标记";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "Z范围";
            // 
            // numericUpDownSZ
            // 
            this.numericUpDownSZ.Location = new System.Drawing.Point(74, 167);
            this.numericUpDownSZ.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDownSZ.Name = "numericUpDownSZ";
            this.numericUpDownSZ.Size = new System.Drawing.Size(44, 21);
            this.numericUpDownSZ.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "---";
            // 
            // numericUpDownEZ
            // 
            this.numericUpDownEZ.Location = new System.Drawing.Point(153, 167);
            this.numericUpDownEZ.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDownEZ.Name = "numericUpDownEZ";
            this.numericUpDownEZ.Size = new System.Drawing.Size(43, 21);
            this.numericUpDownEZ.TabIndex = 5;
            this.numericUpDownEZ.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 292);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(246, 106);
            this.textBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_selectDic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.textBox_dic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dic;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_s_lon;
        private System.Windows.Forms.TextBox textBox_s_lat;
        private System.Windows.Forms.TextBox textBox_e_lon;
        private System.Windows.Forms.TextBox textBox_e_lat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_selectDic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_error_down;
        private System.Windows.Forms.TextBox textBox_complate_down;
        private System.Windows.Forms.TextBox textBox_need_down;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownEZ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownSZ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
    }
}

