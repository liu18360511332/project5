namespace project_five
{
    partial class help
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
            this.manual_instru = new System.Windows.Forms.Button();
            this.manual_download = new System.Windows.Forms.Button();
            this.pal_manual = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pal_manual_dowl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.about_us = new System.Windows.Forms.Button();
            this.btnYes1 = new System.Windows.Forms.Button();
            this.pal_aboout_use = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pal_manual.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pal_manual_dowl.SuspendLayout();
            this.pal_aboout_use.SuspendLayout();
            this.SuspendLayout();
            // 
            // manual_instru
            // 
            this.manual_instru.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manual_instru.Location = new System.Drawing.Point(26, 95);
            this.manual_instru.Name = "manual_instru";
            this.manual_instru.Size = new System.Drawing.Size(108, 41);
            this.manual_instru.TabIndex = 27;
            this.manual_instru.Text = "使用手册";
            this.manual_instru.UseVisualStyleBackColor = true;
            this.manual_instru.Click += new System.EventHandler(this.manual_instru_Click);
            // 
            // manual_download
            // 
            this.manual_download.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manual_download.Location = new System.Drawing.Point(26, 185);
            this.manual_download.Name = "manual_download";
            this.manual_download.Size = new System.Drawing.Size(108, 41);
            this.manual_download.TabIndex = 28;
            this.manual_download.Text = "手册下载";
            this.manual_download.UseVisualStyleBackColor = true;
            this.manual_download.Click += new System.EventHandler(this.manual_download_Click);
            // 
            // pal_manual
            // 
            this.pal_manual.Controls.Add(this.richTextBox1);
            this.pal_manual.Controls.Add(this.label1);
            this.pal_manual.Location = new System.Drawing.Point(3, 3);
            this.pal_manual.Name = "pal_manual";
            this.pal_manual.Size = new System.Drawing.Size(532, 379);
            this.pal_manual.TabIndex = 0;
            this.pal_manual.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(195, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用手册";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pal_aboout_use);
            this.panel1.Controls.Add(this.pal_manual_dowl);
            this.panel1.Controls.Add(this.pal_manual);
            this.panel1.Location = new System.Drawing.Point(153, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 385);
            this.panel1.TabIndex = 30;
            // 
            // pal_manual_dowl
            // 
            this.pal_manual_dowl.Controls.Add(this.label2);
            this.pal_manual_dowl.Location = new System.Drawing.Point(3, 3);
            this.pal_manual_dowl.Name = "pal_manual_dowl";
            this.pal_manual_dowl.Size = new System.Drawing.Size(532, 379);
            this.pal_manual_dowl.TabIndex = 1;
            this.pal_manual_dowl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "关于我们";
            // 
            // about_us
            // 
            this.about_us.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.about_us.Location = new System.Drawing.Point(26, 280);
            this.about_us.Name = "about_us";
            this.about_us.Size = new System.Drawing.Size(108, 41);
            this.about_us.TabIndex = 29;
            this.about_us.Text = "关于我们";
            this.about_us.UseVisualStyleBackColor = true;
            this.about_us.Click += new System.EventHandler(this.about_us_Click);
            // 
            // btnYes1
            // 
            this.btnYes1.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnYes1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYes1.Location = new System.Drawing.Point(340, 440);
            this.btnYes1.Name = "btnYes1";
            this.btnYes1.Size = new System.Drawing.Size(78, 39);
            this.btnYes1.TabIndex = 31;
            this.btnYes1.Text = "确定";
            this.btnYes1.UseVisualStyleBackColor = false;
            // 
            // pal_aboout_use
            // 
            this.pal_aboout_use.Controls.Add(this.richTextBox2);
            this.pal_aboout_use.Controls.Add(this.label3);
            this.pal_aboout_use.Location = new System.Drawing.Point(3, 3);
            this.pal_aboout_use.Name = "pal_aboout_use";
            this.pal_aboout_use.Size = new System.Drawing.Size(532, 379);
            this.pal_aboout_use.TabIndex = 0;
            this.pal_aboout_use.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(195, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "关于我们";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(89, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 226);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "    本软件主要提供潮流计算、GAN数据生成、数据下载等功能。\n    其中GAN数据生成功能可对存在缺失的初始数据进行补全。\n    潮流计算功能完成对初始数" +
    "据和GAN生成数据的潮流计算并输出结果，允许使用者对初始数据进行自定义操作。\n    数据下载功能可对标准拓扑模型、节点数据、潮流计算输出结果进行下载。";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(102, 74);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(304, 226);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "    本软件由东北大学信息学院电气研究所完成编制，主要成员包括：曲福明、任汝飞、吴玒璘、李正、刘要博、张元德、许晴等。";
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 511);
            this.Controls.Add(this.manual_instru);
            this.Controls.Add(this.manual_download);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.about_us);
            this.Controls.Add(this.btnYes1);
            this.Name = "help";
            this.Text = "help";
            this.pal_manual.ResumeLayout(false);
            this.pal_manual.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pal_manual_dowl.ResumeLayout(false);
            this.pal_manual_dowl.PerformLayout();
            this.pal_aboout_use.ResumeLayout(false);
            this.pal_aboout_use.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manual_instru;
        private System.Windows.Forms.Button manual_download;
        private System.Windows.Forms.Panel pal_manual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pal_manual_dowl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button about_us;
        private System.Windows.Forms.Button btnYes1;
        private System.Windows.Forms.Panel pal_aboout_use;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}