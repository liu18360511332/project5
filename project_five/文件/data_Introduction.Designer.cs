namespace project_five
{
    partial class data_Introduction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pal_pre_dada = new System.Windows.Forms.Panel();
            this.btn_pre_data = new System.Windows.Forms.Button();
            this.btn_GAN_generate = new System.Windows.Forms.Button();
            this.btn_self_defining = new System.Windows.Forms.Button();
            this.pal_self_defining = new System.Windows.Forms.Panel();
            this.pal_GAN_generate = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pal_pre_dada.SuspendLayout();
            this.pal_self_defining.SuspendLayout();
            this.pal_GAN_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_self_defining);
            this.panel1.Controls.Add(this.btn_GAN_generate);
            this.panel1.Controls.Add(this.btn_pre_data);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 289);
            this.panel1.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pal_GAN_generate);
            this.panel8.Controls.Add(this.pal_self_defining);
            this.panel8.Controls.Add(this.pal_pre_dada);
            this.panel8.Location = new System.Drawing.Point(255, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(419, 289);
            this.panel8.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 126);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "    说明：预先设定的系统参数，初始数据包括发电机额定功率、气平衡节点压力、热源供水温度等";
            // 
            // pal_pre_dada
            // 
            this.pal_pre_dada.BackColor = System.Drawing.Color.White;
            this.pal_pre_dada.Controls.Add(this.richTextBox1);
            this.pal_pre_dada.Location = new System.Drawing.Point(26, 34);
            this.pal_pre_dada.Name = "pal_pre_dada";
            this.pal_pre_dada.Size = new System.Drawing.Size(355, 205);
            this.pal_pre_dada.TabIndex = 5;
            this.pal_pre_dada.Visible = false;
            // 
            // btn_pre_data
            // 
            this.btn_pre_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_pre_data.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_pre_data.Location = new System.Drawing.Point(33, 37);
            this.btn_pre_data.Name = "btn_pre_data";
            this.btn_pre_data.Size = new System.Drawing.Size(171, 41);
            this.btn_pre_data.TabIndex = 14;
            this.btn_pre_data.Text = "初始数据";
            this.btn_pre_data.UseVisualStyleBackColor = false;
            this.btn_pre_data.Click += new System.EventHandler(this.btn_pre_data_Click);
            // 
            // btn_GAN_generate
            // 
            this.btn_GAN_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GAN_generate.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GAN_generate.Location = new System.Drawing.Point(33, 99);
            this.btn_GAN_generate.Name = "btn_GAN_generate";
            this.btn_GAN_generate.Size = new System.Drawing.Size(171, 41);
            this.btn_GAN_generate.TabIndex = 14;
            this.btn_GAN_generate.Text = "GAN生成数据";
            this.btn_GAN_generate.UseVisualStyleBackColor = false;
            this.btn_GAN_generate.Click += new System.EventHandler(this.btn_GAN_generate_Click);
            // 
            // btn_self_defining
            // 
            this.btn_self_defining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_self_defining.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_self_defining.Location = new System.Drawing.Point(33, 166);
            this.btn_self_defining.Name = "btn_self_defining";
            this.btn_self_defining.Size = new System.Drawing.Size(171, 41);
            this.btn_self_defining.TabIndex = 14;
            this.btn_self_defining.Text = "自定义数据";
            this.btn_self_defining.UseVisualStyleBackColor = false;
            this.btn_self_defining.Click += new System.EventHandler(this.btn_self_defining_Click);
            // 
            // pal_self_defining
            // 
            this.pal_self_defining.BackColor = System.Drawing.Color.White;
            this.pal_self_defining.Controls.Add(this.richTextBox2);
            this.pal_self_defining.Location = new System.Drawing.Point(52, 3);
            this.pal_self_defining.Name = "pal_self_defining";
            this.pal_self_defining.Size = new System.Drawing.Size(355, 205);
            this.pal_self_defining.TabIndex = 5;
            this.pal_self_defining.Visible = false;
            // 
            // pal_GAN_generate
            // 
            this.pal_GAN_generate.Controls.Add(this.richTextBox3);
            this.pal_GAN_generate.Location = new System.Drawing.Point(23, 68);
            this.pal_GAN_generate.Name = "pal_GAN_generate";
            this.pal_GAN_generate.Size = new System.Drawing.Size(355, 205);
            this.pal_GAN_generate.TabIndex = 5;
            this.pal_GAN_generate.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(25, 34);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(304, 126);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "    说明：在系统设定值允许范围值之内可以修改预先设定的系统参数";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox3.Location = new System.Drawing.Point(25, 39);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(304, 126);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "    说明：由初始数据GAN网络生成的数据";
            // 
            // data_Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Name = "data_Introduction";
            this.Text = "加载数据说明";
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pal_pre_dada.ResumeLayout(false);
            this.pal_self_defining.ResumeLayout(false);
            this.pal_GAN_generate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pal_pre_dada;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_self_defining;
        private System.Windows.Forms.Button btn_GAN_generate;
        private System.Windows.Forms.Button btn_pre_data;
        private System.Windows.Forms.Panel pal_self_defining;
        private System.Windows.Forms.Panel pal_GAN_generate;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}