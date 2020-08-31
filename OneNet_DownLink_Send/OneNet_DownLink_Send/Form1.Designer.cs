namespace OneNet_DownLink_Send
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_heartbeat = new System.Windows.Forms.TextBox();
            this.tb_level = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_read = new System.Windows.Forms.Button();
            this.tb_imei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_7886 = new System.Windows.Forms.Button();
            this.bt_8082 = new System.Windows.Forms.Button();
            this.bt_lv1 = new System.Windows.Forms.Button();
            this.bt_lv2 = new System.Windows.Forms.Button();
            this.bt_lv3 = new System.Windows.Forms.Button();
            this.bt_lv5 = new System.Windows.Forms.Button();
            this.bt_lv4 = new System.Windows.Forms.Button();
            this.bt_1_min = new System.Windows.Forms.Button();
            this.bt_24_hour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_heartbeat
            // 
            this.tb_heartbeat.Location = new System.Drawing.Point(59, 44);
            this.tb_heartbeat.Name = "tb_heartbeat";
            this.tb_heartbeat.Size = new System.Drawing.Size(100, 21);
            this.tb_heartbeat.TabIndex = 1;
            // 
            // tb_level
            // 
            this.tb_level.Location = new System.Drawing.Point(59, 71);
            this.tb_level.Name = "tb_level";
            this.tb_level.Size = new System.Drawing.Size(100, 21);
            this.tb_level.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "心跳包";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "等级";
            // 
            // bt_read
            // 
            this.bt_read.Location = new System.Drawing.Point(39, 165);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(120, 51);
            this.bt_read.TabIndex = 3;
            this.bt_read.Text = "读取配置";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // tb_imei
            // 
            this.tb_imei.Location = new System.Drawing.Point(59, 17);
            this.tb_imei.Name = "tb_imei";
            this.tb_imei.Size = new System.Drawing.Size(100, 21);
            this.tb_imei.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMEI";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(39, 107);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(120, 51);
            this.bt_send.TabIndex = 3;
            this.bt_send.Text = "发送下行";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_7886
            // 
            this.bt_7886.Location = new System.Drawing.Point(16, 26);
            this.bt_7886.Name = "bt_7886";
            this.bt_7886.Size = new System.Drawing.Size(91, 36);
            this.bt_7886.TabIndex = 4;
            this.bt_7886.Text = "7886";
            this.bt_7886.UseVisualStyleBackColor = true;
            this.bt_7886.Click += new System.EventHandler(this.bt_7886_Click);
            // 
            // bt_8082
            // 
            this.bt_8082.Location = new System.Drawing.Point(16, 74);
            this.bt_8082.Name = "bt_8082";
            this.bt_8082.Size = new System.Drawing.Size(91, 36);
            this.bt_8082.TabIndex = 4;
            this.bt_8082.Text = "8082";
            this.bt_8082.UseVisualStyleBackColor = true;
            this.bt_8082.Click += new System.EventHandler(this.bt_8082_Click);
            // 
            // bt_lv1
            // 
            this.bt_lv1.Location = new System.Drawing.Point(18, 20);
            this.bt_lv1.Name = "bt_lv1";
            this.bt_lv1.Size = new System.Drawing.Size(88, 32);
            this.bt_lv1.TabIndex = 4;
            this.bt_lv1.Text = "LV_1";
            this.bt_lv1.UseVisualStyleBackColor = true;
            this.bt_lv1.Click += new System.EventHandler(this.bt_lv1_Click);
            // 
            // bt_lv2
            // 
            this.bt_lv2.Location = new System.Drawing.Point(18, 58);
            this.bt_lv2.Name = "bt_lv2";
            this.bt_lv2.Size = new System.Drawing.Size(88, 36);
            this.bt_lv2.TabIndex = 4;
            this.bt_lv2.Text = "LV_2";
            this.bt_lv2.UseVisualStyleBackColor = true;
            this.bt_lv2.Click += new System.EventHandler(this.bt_lv2_Click);
            // 
            // bt_lv3
            // 
            this.bt_lv3.Location = new System.Drawing.Point(18, 100);
            this.bt_lv3.Name = "bt_lv3";
            this.bt_lv3.Size = new System.Drawing.Size(88, 38);
            this.bt_lv3.TabIndex = 4;
            this.bt_lv3.Text = "LV_3";
            this.bt_lv3.UseVisualStyleBackColor = true;
            this.bt_lv3.Click += new System.EventHandler(this.bt_lv3_Click);
            // 
            // bt_lv5
            // 
            this.bt_lv5.Location = new System.Drawing.Point(16, 192);
            this.bt_lv5.Name = "bt_lv5";
            this.bt_lv5.Size = new System.Drawing.Size(90, 36);
            this.bt_lv5.TabIndex = 4;
            this.bt_lv5.Text = "LV_5";
            this.bt_lv5.UseVisualStyleBackColor = true;
            this.bt_lv5.Click += new System.EventHandler(this.bt_lv5_Click);
            // 
            // bt_lv4
            // 
            this.bt_lv4.Location = new System.Drawing.Point(18, 145);
            this.bt_lv4.Name = "bt_lv4";
            this.bt_lv4.Size = new System.Drawing.Size(88, 41);
            this.bt_lv4.TabIndex = 4;
            this.bt_lv4.Text = "LV_4";
            this.bt_lv4.UseVisualStyleBackColor = true;
            this.bt_lv4.Click += new System.EventHandler(this.bt_lv4_Click);
            // 
            // bt_1_min
            // 
            this.bt_1_min.Location = new System.Drawing.Point(6, 26);
            this.bt_1_min.Name = "bt_1_min";
            this.bt_1_min.Size = new System.Drawing.Size(91, 38);
            this.bt_1_min.TabIndex = 4;
            this.bt_1_min.Text = "1分钟";
            this.bt_1_min.UseVisualStyleBackColor = true;
            this.bt_1_min.Click += new System.EventHandler(this.bt_1_min_Click);
            // 
            // bt_24_hour
            // 
            this.bt_24_hour.Location = new System.Drawing.Point(6, 70);
            this.bt_24_hour.Name = "bt_24_hour";
            this.bt_24_hour.Size = new System.Drawing.Size(91, 42);
            this.bt_24_hour.TabIndex = 4;
            this.bt_24_hour.Text = "24小时";
            this.bt_24_hour.UseVisualStyleBackColor = true;
            this.bt_24_hour.Click += new System.EventHandler(this.bt_24_hour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_lv1);
            this.groupBox1.Controls.Add(this.bt_lv2);
            this.groupBox1.Controls.Add(this.bt_lv3);
            this.groupBox1.Controls.Add(this.bt_lv4);
            this.groupBox1.Controls.Add(this.bt_lv5);
            this.groupBox1.Location = new System.Drawing.Point(428, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "震动等级";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_1_min);
            this.groupBox2.Controls.Add(this.bt_24_hour);
            this.groupBox2.Location = new System.Drawing.Point(315, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 250);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "心跳包时间";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_7886);
            this.groupBox3.Controls.Add(this.bt_8082);
            this.groupBox3.Location = new System.Drawing.Point(196, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 250);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMEI";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(39, 224);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(120, 51);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "清除信息";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 287);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_read);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_level);
            this.Controls.Add(this.tb_imei);
            this.Controls.Add(this.tb_heartbeat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_heartbeat;
        private System.Windows.Forms.TextBox tb_level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.TextBox tb_imei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Button bt_7886;
        private System.Windows.Forms.Button bt_8082;
        private System.Windows.Forms.Button bt_lv1;
        private System.Windows.Forms.Button bt_lv2;
        private System.Windows.Forms.Button bt_lv3;
        private System.Windows.Forms.Button bt_lv5;
        private System.Windows.Forms.Button bt_lv4;
        private System.Windows.Forms.Button bt_1_min;
        private System.Windows.Forms.Button bt_24_hour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_clear;
    }
}

