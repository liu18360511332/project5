using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace project_five
{
    public partial class result_show : Form
    {
        public DataTable dt_hcode= new DataTable(); //热力节点数据表
        public DataTable dt_hpipe = new DataTable();//热力支路数据表
        public DataTable dt_ecode = new DataTable();//电力节点数据表
        public DataTable dt_epipe = new DataTable();//电力支路数据表
        public DataTable dt_gcode = new DataTable();//天然气节点数据表
        public DataTable dt_gpipe = new DataTable();//天然气支路数据表
          


        public result_show()
        {
            InitializeComponent();
        }

        private void e_grid_Click(object sender, EventArgs e)
        {
            this.dt_edata.Visible = true;              //显示电力网络的数据表和数据图
            this.chart_e_image.Visible = true;

            this.rab_ecode_data.Visible = true;       //显示电力网络的radiobutton
            this.rab_epipe_data.Visible = true;

            this.dt_gas_data.Visible = false;        //隐藏天然气网络的数据表和数据图
            this.chart_gas_image.Visible = false;

            this.rab_gcode_data.Visible = false;     //隐藏天然气网络的radiobutton
            this.rab_gpipe_data.Visible = false;

            this.dt__heat_datat.Visible = false;     //隐藏热力网络的数据表和数据图
            this.chart_heat_image.Visible = false;

            this.rab_hcode_data.Visible = false;     //隐藏热力网络的radiobutton
            this.rab_hpipe_data.Visible = false;

            this.dt_edata.BringToFront();            ////将电力的datatable移到最前面
            this.chart_e_image.BringToFront();

        }

        private void Gas_Click(object sender, EventArgs e)
        {
            this.dt_edata.Visible = false;         //隐藏电力网络的数据表和数据图
            this.chart_e_image.Visible = false;

            this.rab_ecode_data.Visible = false;  //隐藏电力网络的radiobutton
            this.rab_epipe_data.Visible = false;

            this.dt_gas_data.Visible = true;      //显示天然气网络的数据表和数据图
            this.chart_gas_image.Visible = true;

            this.rab_gcode_data.Visible = true;   //显示天然气网络的radiobutton
            this.rab_gpipe_data.Visible = true;

            this.dt__heat_datat.Visible = false;   //隐藏热力网络的数据表和数据图
            this.chart_heat_image.Visible = false;

            this.rab_hcode_data.Visible = false; //隐藏热力网络的radiobutton
            this.rab_hpipe_data.Visible = false;

            this.dt_gas_data.BringToFront();//将天然气的datatable移到最前面
            this.chart_gas_image.BringToFront();


            this.dt_gas_data.Location = this.dt_edata.Location;//天然气数据显示界面与电力数据显示界面重合
            this.chart_gas_image.Location = this.chart_e_image.Location;
        }

        private void Heat_Click(object sender, EventArgs e)
        {
            this.dt_edata.Visible = false;        //隐藏电力网络的数据表和数据图
            this.chart_e_image.Visible = false;

            this.rab_ecode_data.Visible = false;  //隐藏电力网络的radiobutton
            this.rab_epipe_data.Visible = false;

            this.dt_gas_data.Visible = false;     //隐藏天然气网络的数据表和数据图
            this.chart_gas_image.Visible = false;


            this.rab_gcode_data.Visible = false;//隐藏天然气网络的radiobutton
            this.rab_gpipe_data.Visible = false;

            this.dt__heat_datat.Visible = true; //显示热力网络的数据表和数据图
            this.chart_heat_image.Visible = true;

            this.rab_hcode_data.Visible = true; //显示热力网络的radiobutton
            this.rab_hpipe_data.Visible = true;

            this.dt__heat_datat.BringToFront();//将热力的datatable移到最前面
            this.chart_heat_image.BringToFront();


            this.dt__heat_datat.Location = this.dt_edata.Location;//热力数据显示界面与电力数据显示界面重合
            this.chart_heat_image.Location = this.chart_e_image.Location;
        }

        private void rab_ecode_data_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //清空电力节点和支路数据
                dt_ecode.Rows.Clear();
            dt_ecode.Columns.Clear();
            dt_epipe.Rows.Clear();
            dt_epipe.Columns.Clear();


            //读电力网络节点数据
            FileStream fs1 = new FileStream("E:\\matlab\\bin\\chaoliu\\EBusResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr1 = new StreamReader(fs1, System.Text.Encoding.GetEncoding(936));                                                //
            string str1 = "";                                                                                                               // 每行读出的内容
            //定义一个count1，跳过读第一行
            int count1 = 0;

            dt__heat_datat.ReadOnly = true;
            //插入列
            dt_ecode.Columns.Add(new DataColumn("序号", typeof(int)));//列的名称、数据的类型
            dt_ecode.Columns.Add(new DataColumn("电压", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("相角", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("有功注入", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("无功注入", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("有功生成", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("无功生成", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("节点负荷", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("CHP机组功率", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("压缩机功率", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("循环泵功率", typeof(float)));
            dt_ecode.Columns.Add(new DataColumn("电锅炉功率", typeof(float)));

            //循环读
            while (true)
            {
                //读一行
                str1 = sr1.ReadLine();
                // 如果读到最后了，就不读了
                if (str1 == null)
                {
                    break;
                }
                //跳过第一行
                if (count1 > 0)
                {
                    // 把读到的一行数据按照逗号分隔
                    string[] data1 = str1.Split(',');
                    //新建一行dr1并赋值
                    DataRow dr1;
                    dr1 = dt_ecode.NewRow();
                    dr1["序号"] = data1[0];
                    dr1["电压"] = data1[1];
                    dr1["相角"] = data1[2];
                    dr1["有功注入"] = data1[3];
                    dr1["无功注入"] = data1[4];
                    dr1["有功生成"] = data1[5];
                    dr1["无功生成"] = data1[6];
                    dr1["节点负荷"] = data1[7];
                    dr1["CHP机组功率"] = data1[8];
                    dr1["压缩机功率"] = data1[9];
                    dr1["循环泵功率"] = data1[10];
                    dr1["电锅炉功率"] = data1[11]; 
                     //将这一行添加到数据表中
                    dt_ecode.Rows.Add(dr1);
                }
                count1++;
            }
            sr1.Close();
            //显示数据
            dt_edata.DataSource = dt_ecode;

            //插入图形
            chart_e_image.DataSource = dt_ecode;
            this.chart_e_image.Series.Clear();          //清空图表中的内容
            Series series = this.chart_e_image.Series.Add("电压");
            series.XValueMember = "";  //x轴为时间
            series.YValueMembers = "电压";  //y轴为数据
            Series series1 = this.chart_e_image.Series.Add("有功生成");
            series1.XValueMember = "";  //x轴为时间
            series1.YValueMembers = "有功生成";  //y轴为数据
            Series series2 = this.chart_e_image.Series.Add("无功生成");
            series2.XValueMember = "";  //x轴为时间
            series2.YValueMembers = "无功生成";  //y轴为数据

            this.chart_e_image.Series[0].ChartType = SeriesChartType.Line;
            this.chart_e_image.Series[0].Color = Color.Blue;
            this.chart_e_image.Series[1].ChartType = SeriesChartType.Column;
            this.chart_e_image.Series[1].Color = Color.Red;
            this.chart_e_image.Series[2].ChartType = SeriesChartType.Column;
            this.chart_e_image.Series[2].Color = Color.Yellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void rab_epipe_data_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dt_ecode.Rows.Clear();
            dt_ecode.Columns.Clear();
            dt_epipe.Rows.Clear();
            dt_epipe.Columns.Clear();

            //读电力网络支路数据
            FileStream fs2 = new FileStream("E:\\matlab\\bin\\chaoliu\\ELineResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr2 = new StreamReader(fs2, System.Text.Encoding.GetEncoding(936));
            string str2 = "";
            int count2 = 0;
            dt__heat_datat.ReadOnly = true;
            dt_epipe.Columns.Add(new DataColumn("起点", typeof(int)));
            dt_epipe.Columns.Add(new DataColumn("终点", typeof(float)));
            dt_epipe.Columns.Add(new DataColumn("有功功率", typeof(float)));
            dt_epipe.Columns.Add(new DataColumn("无功功率", typeof(float)));
            dt_epipe.Columns.Add(new DataColumn("有功损耗", typeof(float)));
            dt_epipe.Columns.Add(new DataColumn("无功损耗", typeof(float)));
            while (true)
            {
                str2 = sr2.ReadLine();
                if (str2 == null)
                {
                    break;
                }
                if (count2 > 0)
                {
                    string[] data2 = str2.Split(',');
                    DataRow dr2;
                    dr2 = dt_epipe.NewRow();
                    dr2["起点"] = data2[0];
                    dr2["终点"] = data2[1];
                    dr2["有功功率"] = data2[2];
                    dr2["无功功率"] = data2[3];
                    dr2["有功损耗"] = data2[4];
                    dr2["无功损耗"] = data2[5];
                    dt_epipe.Rows.Add(dr2);
                }
                count2++;
            }
            sr2.Close();

            dt_edata.DataSource = dt_epipe;

            //插入图形
            chart_e_image.DataSource = dt_epipe;
            this.chart_e_image.Series.Clear();  //清空图表中的内容
            
            Series series = this.chart_e_image.Series.Add("有功损耗");
            series.XValueMember = "";  //x轴为时间
            series.YValueMembers = "有功损耗";  //y轴为数据
            Series series1 = this.chart_e_image.Series.Add("无功损耗");
            series1.XValueMember = "";  //x轴为时间
            series1.YValueMembers = "无功损耗";  //y轴为数据

            this.chart_e_image.Series[0].ChartType = SeriesChartType.Column;
            this.chart_e_image.Series[0].Color = Color.Blue;
            this.chart_e_image.Series[1].ChartType = SeriesChartType.Column;
            this.chart_e_image.Series[1].Color = Color.Red;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rab_hcode_data_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            { 
            dt_hcode.Rows.Clear();
            dt_hcode.Columns.Clear();
            dt_hpipe.Rows.Clear();
            dt_hpipe.Columns.Clear();
            //读热力网络节点数据
            FileStream fs1 = new FileStream("E:\\matlab\\bin\\chaoliu\\HNodeResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr1 = new StreamReader(fs1, System.Text.Encoding.GetEncoding(936));
            string str1 = "";
            int count1 = 0;
            dt__heat_datat.ReadOnly = true;
            dt_hcode.Columns.Add(new DataColumn("序号", typeof(int)));
            dt_hcode.Columns.Add(new DataColumn("供水温度", typeof(float)));
            dt_hcode.Columns.Add(new DataColumn("回水温度", typeof(float)));
            dt_hcode.Columns.Add(new DataColumn("热负荷", typeof(float)));
            dt_hcode.Columns.Add(new DataColumn("CHP负荷", typeof(float)));
            dt_hcode.Columns.Add(new DataColumn("电锅炉负荷", typeof(float)));
            while (true)
            {

                str1 = sr1.ReadLine();
                if (str1 == null)
                {
                    break;
                }
                if (count1 > 0)
                {
                    string[] data1 = str1.Split(',');
                    DataRow dr1;
                    dr1 = dt_hcode.NewRow();
                    dr1["序号"] = data1[0];
                    dr1["供水温度"] = data1[1];
                    dr1["回水温度"] = data1[2];
                    dr1["热负荷"] = data1[3];
                    dr1["CHP负荷"] = data1[4];
                    dr1["电锅炉负荷"] = data1[5];
                    dt_hcode.Rows.Add(dr1);
                }
                count1++;
            }
            sr1.Close();
            dt__heat_datat.DataSource = dt_hcode;

                //插入图形
                this.chart_heat_image.DataSource = dt_hcode;
                this.chart_heat_image.Series.Clear();

                Series series = this.chart_heat_image.Series.Add("供水温度");
                series.XValueMember = "";  //x轴为时间
                series.YValueMembers = "供水温度";  //y轴为数据
                Series series1 = this.chart_heat_image.Series.Add("回水温度");
                series1.XValueMember = "";  //x轴为时间
                series1.YValueMembers = "回水温度";  //y轴为数据
                Series series2 = this.chart_heat_image.Series.Add("热负荷");
                series2.XValueMember = "";  //x轴为时间
                series2.YValueMembers = "热负荷";  //y轴为数据


                this.chart_heat_image.Series[0].ChartType = SeriesChartType.Line;
                this.chart_heat_image.Series[0].Color = Color.Blue;
                this.chart_heat_image.Series[1].ChartType = SeriesChartType.Line;
                this.chart_heat_image.Series[1].Color = Color.Red;
                this.chart_heat_image.Series[2].ChartType = SeriesChartType.Column;
                this.chart_heat_image.Series[2].Color = Color.Orange;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rab_hpipe_data_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            { 
            dt_hcode.Rows.Clear();
            dt_hcode.Columns.Clear();
            dt_hpipe.Rows.Clear();
            dt_hpipe.Columns.Clear();

            //读热力网络支路数据
            FileStream fs2 = new FileStream("E:\\matlab\\bin\\chaoliu\\HPipeResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr2 = new StreamReader(fs2, System.Text.Encoding.GetEncoding(936));
            string str2 = "";
            int count2 = 0;
            dt__heat_datat.ReadOnly = true;
            dt_hpipe.Columns.Add(new DataColumn("起点", typeof(int)));
            dt_hpipe.Columns.Add(new DataColumn("终点", typeof(float)));
            dt_hpipe.Columns.Add(new DataColumn("管道质量流", typeof(float)));
            dt_hpipe.Columns.Add(new DataColumn("热功率", typeof(float)));
            dt_hpipe.Columns.Add(new DataColumn("热功率损耗", typeof(float)));
            while (true)
            {
                str2 = sr2.ReadLine();
                if (str2 == null)
                {
                    break;
                }
                if (count2 > 0)
                {
                    string[] data2 = str2.Split(',');
                    DataRow dr2;
                    dr2 = dt_hpipe.NewRow();
                    dr2["起点"] = data2[0];
                    dr2["终点"] = data2[1];
                    dr2["管道质量流"] = data2[2];
                    dr2["热功率"] = data2[3];
                    dr2["热功率损耗"] = data2[4];
                    dt_hpipe.Rows.Add(dr2);
                }
                count2++;
            }
            sr2.Close();
            dt__heat_datat.DataSource = dt_hpipe;

                //插入图形
                this.chart_heat_image.DataSource = dt_hpipe;
                this.chart_heat_image.Series.Clear();

                Series series = this.chart_heat_image.Series.Add("热功率损耗");
                series.XValueMember = "";  //x轴为时间
                series.YValueMembers = "热功率损耗";  //y轴为数据

                this.chart_heat_image.Series[0].ChartType = SeriesChartType.Column;
                this.chart_heat_image.Series[0].Color = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rab_gcode_data_CheckedChanged(object sender, EventArgs e)
        {
            try
            { 
            dt_gcode.Rows.Clear();
            dt_gcode.Columns.Clear();
            dt_gpipe.Rows.Clear();
            dt_gpipe.Columns.Clear();


            //读天然气网络节点数据
            FileStream fs1 = new FileStream("E:\\matlab\\bin\\chaoliu\\GNodeResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr1 = new StreamReader(fs1, System.Text.Encoding.GetEncoding(936));
            string str1 = "";
            int count1 = 0;
            dt_gas_data.ReadOnly = true;
            dt_gcode.Columns.Add(new DataColumn("序号", typeof(int)));
            dt_gcode.Columns.Add(new DataColumn("压力", typeof(float)));
            dt_gcode.Columns.Add(new DataColumn("节点流量", typeof(float)));
            dt_gcode.Columns.Add(new DataColumn("燃气轮机所需流量", typeof(float)));
            dt_gcode.Columns.Add(new DataColumn("CHP所需流量", typeof(float)));
            dt_gcode.Columns.Add(new DataColumn("气锅炉所需流量", typeof(float)));
            while (true)
            {

                str1 = sr1.ReadLine();
                if (str1 == null)
                {
                    break;
                }
                if (count1 > 0)
                {
                    string[] data1 = str1.Split(',');
                    DataRow dr1;
                    dr1 = dt_gcode.NewRow();
                    dr1["序号"] = data1[0];
                    dr1["压力"] = data1[1];
                    dr1["节点流量"] = data1[2];
                    dr1["燃气轮机所需流量"] = data1[3];
                    dr1["CHP所需流量"] = data1[4];
                    dr1["气锅炉所需流量"] = data1[5];
                    dt_gcode.Rows.Add(dr1);
                }
                count1++;
            }
            sr1.Close();
            dt_gas_data.DataSource = dt_gcode;

                //插入图形
                this.chart_gas_image.DataSource = dt_gcode;
                this.chart_gas_image.Series.Clear();

                Series series = this.chart_gas_image.Series.Add("压力");
                series.XValueMember = "";  //x轴为时间
                series.YValueMembers = "压力";  //y轴为数据
                Series series1 = this.chart_gas_image.Series.Add("节点流量");
                series1.XValueMember = "";  //x轴为时间
                series1.YValueMembers = "节点流量";  //y轴为数据

                this.chart_gas_image.Series[0].ChartType = SeriesChartType.Column;
                this.chart_gas_image.Series[0].Color = Color.Blue;
                this.chart_gas_image.Series[1].ChartType = SeriesChartType.Column;
                this.chart_gas_image.Series[1].Color = Color.Red;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rab_gpipe_data_CheckedChanged(object sender, EventArgs e)
        {
            try
            { 
            dt_gcode.Rows.Clear();
            dt_gcode.Columns.Clear();
            dt_gpipe.Rows.Clear();
            dt_gpipe.Columns.Clear();


            //读天然气网络节点数据
            FileStream fs2 = new FileStream("E:\\matlab\\bin\\chaoliu\\GPipeResult.txt", FileMode.Open, FileAccess.Read, FileShare.None);    // 读文件用的
            StreamReader sr2 = new StreamReader(fs2, System.Text.Encoding.GetEncoding(936));
            string str2 = "";
            int count2 = 0;
            dt_gas_data.ReadOnly = true;
            dt_gpipe.Columns.Add(new DataColumn("起点", typeof(int)));
            dt_gpipe.Columns.Add(new DataColumn("终点", typeof(float)));
            dt_gpipe.Columns.Add(new DataColumn("管道流量", typeof(float)));
            while (true)
            {

                str2 = sr2.ReadLine();
                if (str2 == null)
                {
                    break;
                }
                if (count2 > 0)
                {
                    string[] data2 = str2.Split(',');
                    DataRow dr2;
                    dr2 = dt_gpipe.NewRow();
                    dr2["起点"] = data2[0];
                    dr2["终点"] = data2[1];
                    dr2["管道流量"] = data2[2];
                    dt_gpipe.Rows.Add(dr2);
                }
                count2++;
            }
            sr2.Close();
            dt_gas_data.DataSource = dt_gpipe;

                //插入图形
                this.chart_gas_image.DataSource = dt_gpipe;
                this.chart_gas_image.Series.Clear();

                Series series = this.chart_gas_image.Series.Add("管道流量");
                series.XValueMember = "";  //x轴为时间
                series.YValueMembers = "管道流量";  //y轴为数据

                this.chart_gas_image.Series[0].ChartType = SeriesChartType.Column;
                this.chart_gas_image.Series[0].Color = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
