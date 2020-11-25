namespace project_five
{
    partial class GAN_Creat
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
            this.label6 = new System.Windows.Forms.Label();
            this.picCreate = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picYuan = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rabTP = new System.Windows.Forms.RadioButton();
            this.rabT = new System.Windows.Forms.RadioButton();
            this.rabFlow = new System.Windows.Forms.RadioButton();
            this.rabPa = new System.Windows.Forms.RadioButton();
            this.rabQ = new System.Windows.Forms.RadioButton();
            this.rabP = new System.Windows.Forms.RadioButton();
            this.rabAngle = new System.Windows.Forms.RadioButton();
            this.rabVoltage = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cobType = new System.Windows.Forms.ComboBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCreate)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYuan)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(155, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "生成后数据图像";
            // 
            // picCreate
            // 
            this.picCreate.Location = new System.Drawing.Point(3, 16);
            this.picCreate.Name = "picCreate";
            this.picCreate.Size = new System.Drawing.Size(717, 216);
            this.picCreate.TabIndex = 1;
            this.picCreate.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.picCreate);
            this.panel4.Location = new System.Drawing.Point(155, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(725, 260);
            this.panel4.TabIndex = 27;
            // 
            // picYuan
            // 
            this.picYuan.Location = new System.Drawing.Point(3, 17);
            this.picYuan.Name = "picYuan";
            this.picYuan.Size = new System.Drawing.Size(717, 199);
            this.picYuan.TabIndex = 0;
            this.picYuan.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picYuan);
            this.panel2.Location = new System.Drawing.Point(159, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 232);
            this.panel2.TabIndex = 26;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.全部生成ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // 全部生成ToolStripMenuItem
            // 
            this.全部生成ToolStripMenuItem.Name = "全部生成ToolStripMenuItem";
            this.全部生成ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.全部生成ToolStripMenuItem.Text = "全部生成";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // rabTP
            // 
            this.rabTP.AutoSize = true;
            this.rabTP.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabTP.Location = new System.Drawing.Point(31, 391);
            this.rabTP.Name = "rabTP";
            this.rabTP.Size = new System.Drawing.Size(74, 20);
            this.rabTP.TabIndex = 20;
            this.rabTP.TabStop = true;
            this.rabTP.Text = "热功率";
            this.rabTP.UseVisualStyleBackColor = true;
            // 
            // rabT
            // 
            this.rabT.AutoSize = true;
            this.rabT.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabT.Location = new System.Drawing.Point(31, 355);
            this.rabT.Name = "rabT";
            this.rabT.Size = new System.Drawing.Size(58, 20);
            this.rabT.TabIndex = 19;
            this.rabT.TabStop = true;
            this.rabT.Text = "温度";
            this.rabT.UseVisualStyleBackColor = true;
            // 
            // rabFlow
            // 
            this.rabFlow.AutoSize = true;
            this.rabFlow.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabFlow.Location = new System.Drawing.Point(31, 319);
            this.rabFlow.Name = "rabFlow";
            this.rabFlow.Size = new System.Drawing.Size(58, 20);
            this.rabFlow.TabIndex = 18;
            this.rabFlow.TabStop = true;
            this.rabFlow.Text = "流量";
            this.rabFlow.UseVisualStyleBackColor = true;
            // 
            // rabPa
            // 
            this.rabPa.AutoSize = true;
            this.rabPa.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabPa.Location = new System.Drawing.Point(31, 283);
            this.rabPa.Name = "rabPa";
            this.rabPa.Size = new System.Drawing.Size(58, 20);
            this.rabPa.TabIndex = 17;
            this.rabPa.TabStop = true;
            this.rabPa.Text = "压强";
            this.rabPa.UseVisualStyleBackColor = true;
            // 
            // rabQ
            // 
            this.rabQ.AutoSize = true;
            this.rabQ.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabQ.Location = new System.Drawing.Point(31, 247);
            this.rabQ.Name = "rabQ";
            this.rabQ.Size = new System.Drawing.Size(90, 20);
            this.rabQ.TabIndex = 16;
            this.rabQ.TabStop = true;
            this.rabQ.Text = "无功功率";
            this.rabQ.UseVisualStyleBackColor = true;
            // 
            // rabP
            // 
            this.rabP.AutoSize = true;
            this.rabP.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabP.Location = new System.Drawing.Point(31, 211);
            this.rabP.Name = "rabP";
            this.rabP.Size = new System.Drawing.Size(90, 20);
            this.rabP.TabIndex = 15;
            this.rabP.TabStop = true;
            this.rabP.Text = "有功功率";
            this.rabP.UseVisualStyleBackColor = true;
            // 
            // rabAngle
            // 
            this.rabAngle.AutoSize = true;
            this.rabAngle.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabAngle.Location = new System.Drawing.Point(31, 175);
            this.rabAngle.Name = "rabAngle";
            this.rabAngle.Size = new System.Drawing.Size(58, 20);
            this.rabAngle.TabIndex = 14;
            this.rabAngle.TabStop = true;
            this.rabAngle.Text = "相角";
            this.rabAngle.UseVisualStyleBackColor = true;
            // 
            // rabVoltage
            // 
            this.rabVoltage.AutoSize = true;
            this.rabVoltage.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabVoltage.Location = new System.Drawing.Point(31, 139);
            this.rabVoltage.Name = "rabVoltage";
            this.rabVoltage.Size = new System.Drawing.Size(58, 20);
            this.rabVoltage.TabIndex = 13;
            this.rabVoltage.TabStop = true;
            this.rabVoltage.Text = "电压";
            this.rabVoltage.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Location = new System.Drawing.Point(31, 436);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 34);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // cobType
            // 
            this.cobType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobType.FormattingEnabled = true;
            this.cobType.Items.AddRange(new object[] {
            "电",
            "气",
            "热"});
            this.cobType.Location = new System.Drawing.Point(56, 55);
            this.cobType.Name = "cobType";
            this.cobType.Size = new System.Drawing.Size(82, 24);
            this.cobType.TabIndex = 11;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(122, 88);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(16, 21);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(56, 88);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(16, 21);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // txtnum
            // 
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtnum.Location = new System.Drawing.Point(78, 86);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(38, 26);
            this.txtnum.TabIndex = 8;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "序号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "类别：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rabTP);
            this.panel1.Controls.Add(this.rabT);
            this.panel1.Controls.Add(this.rabFlow);
            this.panel1.Controls.Add(this.rabPa);
            this.panel1.Controls.Add(this.rabQ);
            this.panel1.Controls.Add(this.rabP);
            this.panel1.Controls.Add(this.rabAngle);
            this.panel1.Controls.Add(this.rabVoltage);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.cobType);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.txtnum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 543);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "节点选择";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(155, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "原始数据图像";
            // 
            // GAN_Creat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "GAN_Creat";
            this.Text = "GAN数据生成";
            ((System.ComponentModel.ISupportInitialize)(this.picCreate)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picYuan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picYuan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.RadioButton rabTP;
        private System.Windows.Forms.RadioButton rabT;
        private System.Windows.Forms.RadioButton rabFlow;
        private System.Windows.Forms.RadioButton rabPa;
        private System.Windows.Forms.RadioButton rabQ;
        private System.Windows.Forms.RadioButton rabP;
        private System.Windows.Forms.RadioButton rabAngle;
        private System.Windows.Forms.RadioButton rabVoltage;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cobType;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}