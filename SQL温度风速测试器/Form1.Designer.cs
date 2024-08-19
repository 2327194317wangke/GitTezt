namespace SQL温度风速测试器
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ipt_time = new System.Windows.Forms.TextBox();
            this.btn_Settime = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.ckb_temperature = new System.Windows.Forms.CheckBox();
            this.ckb_humidity = new System.Windows.Forms.CheckBox();
            this.ckb_oxygen = new System.Windows.Forms.CheckBox();
            this.ckb_manner = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ipt_ceshi = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ipt_time
            // 
            this.ipt_time.Location = new System.Drawing.Point(29, 23);
            this.ipt_time.Name = "ipt_time";
            this.ipt_time.Size = new System.Drawing.Size(134, 25);
            this.ipt_time.TabIndex = 0;
            // 
            // btn_Settime
            // 
            this.btn_Settime.Location = new System.Drawing.Point(199, 24);
            this.btn_Settime.Name = "btn_Settime";
            this.btn_Settime.Size = new System.Drawing.Size(75, 23);
            this.btn_Settime.TabIndex = 1;
            this.btn_Settime.Text = "设置时间间隔";
            this.btn_Settime.UseVisualStyleBackColor = true;
            this.btn_Settime.Click += new System.EventHandler(this.btn_Settime_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(560, 24);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(88, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "开始/停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(709, 25);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(88, 23);
            this.btn_query.TabIndex = 3;
            this.btn_query.Text = "历史查询";
            this.btn_query.UseVisualStyleBackColor = true;
            // 
            // ckb_temperature
            // 
            this.ckb_temperature.AutoSize = true;
            this.ckb_temperature.Location = new System.Drawing.Point(29, 75);
            this.ckb_temperature.Name = "ckb_temperature";
            this.ckb_temperature.Size = new System.Drawing.Size(59, 19);
            this.ckb_temperature.TabIndex = 4;
            this.ckb_temperature.Text = "温度";
            this.ckb_temperature.UseVisualStyleBackColor = true;
            // 
            // ckb_humidity
            // 
            this.ckb_humidity.AutoSize = true;
            this.ckb_humidity.Location = new System.Drawing.Point(113, 75);
            this.ckb_humidity.Name = "ckb_humidity";
            this.ckb_humidity.Size = new System.Drawing.Size(59, 19);
            this.ckb_humidity.TabIndex = 5;
            this.ckb_humidity.Text = "湿度";
            this.ckb_humidity.UseVisualStyleBackColor = true;
            // 
            // ckb_oxygen
            // 
            this.ckb_oxygen.AutoSize = true;
            this.ckb_oxygen.Location = new System.Drawing.Point(199, 75);
            this.ckb_oxygen.Name = "ckb_oxygen";
            this.ckb_oxygen.Size = new System.Drawing.Size(59, 19);
            this.ckb_oxygen.TabIndex = 6;
            this.ckb_oxygen.Text = "氧气";
            this.ckb_oxygen.UseVisualStyleBackColor = true;
            // 
            // ckb_manner
            // 
            this.ckb_manner.AutoSize = true;
            this.ckb_manner.Location = new System.Drawing.Point(283, 75);
            this.ckb_manner.Name = "ckb_manner";
            this.ckb_manner.Size = new System.Drawing.Size(59, 19);
            this.ckb_manner.TabIndex = 7;
            this.ckb_manner.Text = "风速";
            this.ckb_manner.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(692, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "发邮件测试";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ipt_ceshi
            // 
            this.ipt_ceshi.Location = new System.Drawing.Point(481, 73);
            this.ipt_ceshi.Name = "ipt_ceshi";
            this.ipt_ceshi.Size = new System.Drawing.Size(188, 25);
            this.ipt_ceshi.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 122);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(794, 387);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 521);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ipt_ceshi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ckb_manner);
            this.Controls.Add(this.ckb_oxygen);
            this.Controls.Add(this.ckb_humidity);
            this.Controls.Add(this.ckb_temperature);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_Settime);
            this.Controls.Add(this.ipt_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipt_time;
        private System.Windows.Forms.Button btn_Settime;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.CheckBox ckb_temperature;
        private System.Windows.Forms.CheckBox ckb_humidity;
        private System.Windows.Forms.CheckBox ckb_oxygen;
        private System.Windows.Forms.CheckBox ckb_manner;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ipt_ceshi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

