namespace project_five
{
    partial class result_show
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_e_grid = new System.Windows.Forms.Button();
            this.btn_Heat = new System.Windows.Forms.Button();
            this.btn_Gas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_gas_image = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_heat_image = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_e_image = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt__heat_datat = new System.Windows.Forms.DataGridView();
            this.dt_gas_data = new System.Windows.Forms.DataGridView();
            this.dt_edata = new System.Windows.Forms.DataGridView();
            this.rab_ecode_data = new System.Windows.Forms.RadioButton();
            this.rab_epipe_data = new System.Windows.Forms.RadioButton();
            this.rab_gcode_data = new System.Windows.Forms.RadioButton();
            this.rab_gpipe_data = new System.Windows.Forms.RadioButton();
            this.rab_hcode_data = new System.Windows.Forms.RadioButton();
            this.rab_hpipe_data = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gas_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_heat_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_e_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt__heat_datat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gas_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_edata)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_e_grid
            // 
            this.btn_e_grid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_e_grid.Location = new System.Drawing.Point(40, 10);
            this.btn_e_grid.Margin = new System.Windows.Forms.Padding(2);
            this.btn_e_grid.Name = "btn_e_grid";
            this.btn_e_grid.Size = new System.Drawing.Size(100, 35);
            this.btn_e_grid.TabIndex = 5;
            this.btn_e_grid.Text = "电力网络";
            this.btn_e_grid.UseVisualStyleBackColor = true;
            this.btn_e_grid.Click += new System.EventHandler(this.e_grid_Click);
            // 
            // btn_Heat
            // 
            this.btn_Heat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Heat.Location = new System.Drawing.Point(38, 10);
            this.btn_Heat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Heat.Name = "btn_Heat";
            this.btn_Heat.Size = new System.Drawing.Size(100, 35);
            this.btn_Heat.TabIndex = 6;
            this.btn_Heat.Text = "热力网络";
            this.btn_Heat.UseVisualStyleBackColor = true;
            this.btn_Heat.Click += new System.EventHandler(this.Heat_Click);
            // 
            // btn_Gas
            // 
            this.btn_Gas.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Gas.Location = new System.Drawing.Point(39, 10);
            this.btn_Gas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Gas.Name = "btn_Gas";
            this.btn_Gas.Size = new System.Drawing.Size(100, 35);
            this.btn_Gas.TabIndex = 7;
            this.btn_Gas.Text = "天然气网络";
            this.btn_Gas.UseVisualStyleBackColor = true;
            this.btn_Gas.Click += new System.EventHandler(this.Gas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chart_gas_image);
            this.panel2.Controls.Add(this.chart_heat_image);
            this.panel2.Controls.Add(this.chart_e_image);
            this.panel2.Location = new System.Drawing.Point(151, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 338);
            this.panel2.TabIndex = 10;
            // 
            // chart_gas_image
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_gas_image.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_gas_image.Legends.Add(legend1);
            this.chart_gas_image.Location = new System.Drawing.Point(43, 0);
            this.chart_gas_image.Name = "chart_gas_image";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_gas_image.Series.Add(series1);
            this.chart_gas_image.Size = new System.Drawing.Size(709, 338);
            this.chart_gas_image.TabIndex = 21;
            this.chart_gas_image.Text = "chart1";
            this.chart_gas_image.Visible = false;
            // 
            // chart_heat_image
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_heat_image.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_heat_image.Legends.Add(legend2);
            this.chart_heat_image.Location = new System.Drawing.Point(17, 0);
            this.chart_heat_image.Name = "chart_heat_image";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_heat_image.Series.Add(series2);
            this.chart_heat_image.Size = new System.Drawing.Size(709, 338);
            this.chart_heat_image.TabIndex = 21;
            this.chart_heat_image.Text = "chart1";
            this.chart_heat_image.Visible = false;
            // 
            // chart_e_image
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_e_image.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_e_image.Legends.Add(legend3);
            this.chart_e_image.Location = new System.Drawing.Point(-1, -1);
            this.chart_e_image.Name = "chart_e_image";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_e_image.Series.Add(series3);
            this.chart_e_image.Size = new System.Drawing.Size(709, 338);
            this.chart_e_image.TabIndex = 21;
            this.chart_e_image.Text = "chart1";
            this.chart_e_image.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(151, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 182);
            this.panel1.TabIndex = 17;
            // 
            // dt__heat_datat
            // 
            this.dt__heat_datat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt__heat_datat.Location = new System.Drawing.Point(195, 100);
            this.dt__heat_datat.Name = "dt__heat_datat";
            this.dt__heat_datat.RowTemplate.Height = 23;
            this.dt__heat_datat.Size = new System.Drawing.Size(709, 182);
            this.dt__heat_datat.TabIndex = 18;
            this.dt__heat_datat.Visible = false;
            // 
            // dt_gas_data
            // 
            this.dt_gas_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_gas_data.Location = new System.Drawing.Point(169, 100);
            this.dt_gas_data.Name = "dt_gas_data";
            this.dt_gas_data.RowTemplate.Height = 23;
            this.dt_gas_data.Size = new System.Drawing.Size(709, 182);
            this.dt_gas_data.TabIndex = 19;
            this.dt_gas_data.Visible = false;
            // 
            // dt_edata
            // 
            this.dt_edata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_edata.Location = new System.Drawing.Point(151, 100);
            this.dt_edata.Name = "dt_edata";
            this.dt_edata.RowTemplate.Height = 23;
            this.dt_edata.Size = new System.Drawing.Size(709, 182);
            this.dt_edata.TabIndex = 20;
            this.dt_edata.Visible = false;
            // 
            // rab_ecode_data
            // 
            this.rab_ecode_data.AutoSize = true;
            this.rab_ecode_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_ecode_data.Location = new System.Drawing.Point(3, 3);
            this.rab_ecode_data.Name = "rab_ecode_data";
            this.rab_ecode_data.Size = new System.Drawing.Size(81, 18);
            this.rab_ecode_data.TabIndex = 21;
            this.rab_ecode_data.Text = "节点数据";
            this.rab_ecode_data.UseVisualStyleBackColor = true;
            this.rab_ecode_data.CheckedChanged += new System.EventHandler(this.rab_ecode_data_CheckedChanged);
            // 
            // rab_epipe_data
            // 
            this.rab_epipe_data.AutoSize = true;
            this.rab_epipe_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_epipe_data.Location = new System.Drawing.Point(90, 3);
            this.rab_epipe_data.Name = "rab_epipe_data";
            this.rab_epipe_data.Size = new System.Drawing.Size(81, 18);
            this.rab_epipe_data.TabIndex = 22;
            this.rab_epipe_data.Text = "支路数据";
            this.rab_epipe_data.UseVisualStyleBackColor = true;
            this.rab_epipe_data.CheckedChanged += new System.EventHandler(this.rab_epipe_data_CheckedChanged);
            // 
            // rab_gcode_data
            // 
            this.rab_gcode_data.AutoSize = true;
            this.rab_gcode_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_gcode_data.Location = new System.Drawing.Point(3, 3);
            this.rab_gcode_data.Name = "rab_gcode_data";
            this.rab_gcode_data.Size = new System.Drawing.Size(81, 18);
            this.rab_gcode_data.TabIndex = 21;
            this.rab_gcode_data.Text = "节点数据";
            this.rab_gcode_data.UseVisualStyleBackColor = true;
            this.rab_gcode_data.Visible = false;
            this.rab_gcode_data.CheckedChanged += new System.EventHandler(this.rab_gcode_data_CheckedChanged);
            // 
            // rab_gpipe_data
            // 
            this.rab_gpipe_data.AutoSize = true;
            this.rab_gpipe_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_gpipe_data.Location = new System.Drawing.Point(90, 3);
            this.rab_gpipe_data.Name = "rab_gpipe_data";
            this.rab_gpipe_data.Size = new System.Drawing.Size(81, 18);
            this.rab_gpipe_data.TabIndex = 22;
            this.rab_gpipe_data.Text = "支路数据";
            this.rab_gpipe_data.UseVisualStyleBackColor = true;
            this.rab_gpipe_data.Visible = false;
            this.rab_gpipe_data.CheckedChanged += new System.EventHandler(this.rab_gpipe_data_CheckedChanged);
            // 
            // rab_hcode_data
            // 
            this.rab_hcode_data.AutoSize = true;
            this.rab_hcode_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_hcode_data.Location = new System.Drawing.Point(4, 3);
            this.rab_hcode_data.Name = "rab_hcode_data";
            this.rab_hcode_data.Size = new System.Drawing.Size(81, 18);
            this.rab_hcode_data.TabIndex = 21;
            this.rab_hcode_data.Text = "节点数据";
            this.rab_hcode_data.UseVisualStyleBackColor = true;
            this.rab_hcode_data.Visible = false;
            this.rab_hcode_data.CheckedChanged += new System.EventHandler(this.rab_hcode_data_CheckedChanged_1);
            this.rab_hcode_data.Click += new System.EventHandler(this.rab_hcode_data_CheckedChanged_1);
            // 
            // rab_hpipe_data
            // 
            this.rab_hpipe_data.AutoSize = true;
            this.rab_hpipe_data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_hpipe_data.Location = new System.Drawing.Point(91, 3);
            this.rab_hpipe_data.Name = "rab_hpipe_data";
            this.rab_hpipe_data.Size = new System.Drawing.Size(81, 18);
            this.rab_hpipe_data.TabIndex = 22;
            this.rab_hpipe_data.Text = "支路数据";
            this.rab_hpipe_data.UseVisualStyleBackColor = true;
            this.rab_hpipe_data.Visible = false;
            this.rab_hpipe_data.CheckedChanged += new System.EventHandler(this.rab_hpipe_data_CheckedChanged_1);
            this.rab_hpipe_data.Click += new System.EventHandler(this.rab_hpipe_data_CheckedChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_e_grid);
            this.panel3.Location = new System.Drawing.Point(111, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 57);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Gas);
            this.panel4.Location = new System.Drawing.Point(301, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 57);
            this.panel4.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rab_ecode_data);
            this.panel6.Controls.Add(this.rab_epipe_data);
            this.panel6.Location = new System.Drawing.Point(111, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 27);
            this.panel6.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rab_gcode_data);
            this.panel7.Controls.Add(this.rab_gpipe_data);
            this.panel7.Location = new System.Drawing.Point(300, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 27);
            this.panel7.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rab_hpipe_data);
            this.panel8.Controls.Add(this.rab_hcode_data);
            this.panel8.Location = new System.Drawing.Point(491, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 27);
            this.panel8.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Heat);
            this.panel5.Location = new System.Drawing.Point(491, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 57);
            this.panel5.TabIndex = 25;
            // 
            // result_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 637);
            this.Controls.Add(this.dt__heat_datat);
            this.Controls.Add(this.dt_gas_data);
            this.Controls.Add(this.dt_edata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Name = "result_show";
            this.Text = "潮流结果显示";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_gas_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_heat_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_e_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt__heat_datat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gas_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_edata)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_e_grid;
        private System.Windows.Forms.Button btn_Heat;
        private System.Windows.Forms.Button btn_Gas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dt__heat_datat;
        private System.Windows.Forms.DataGridView dt_gas_data;
        private System.Windows.Forms.DataGridView dt_edata;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gas_image;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_heat_image;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_e_image;
        private System.Windows.Forms.RadioButton rab_ecode_data;
        private System.Windows.Forms.RadioButton rab_epipe_data;
        private System.Windows.Forms.RadioButton rab_gcode_data;
        private System.Windows.Forms.RadioButton rab_gpipe_data;
        private System.Windows.Forms.RadioButton rab_hcode_data;
        private System.Windows.Forms.RadioButton rab_hpipe_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
    }
}