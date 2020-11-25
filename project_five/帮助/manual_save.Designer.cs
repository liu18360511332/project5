namespace project_five
{
    partial class manual_save
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
            this.labFile_Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnyes_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labFile_Name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labAddress);
            this.panel1.Controls.Add(this.btnAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 168);
            this.panel1.TabIndex = 27;
            // 
            // labFile_Name
            // 
            this.labFile_Name.BackColor = System.Drawing.Color.White;
            this.labFile_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labFile_Name.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFile_Name.Location = new System.Drawing.Point(153, 107);
            this.labFile_Name.Name = "labFile_Name";
            this.labFile_Name.Size = new System.Drawing.Size(374, 30);
            this.labFile_Name.TabIndex = 26;
            this.labFile_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "文件名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAddress
            // 
            this.labAddress.BackColor = System.Drawing.Color.White;
            this.labAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAddress.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAddress.Location = new System.Drawing.Point(153, 33);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(374, 30);
            this.labAddress.TabIndex = 23;
            this.labAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.White;
            this.btnAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.Location = new System.Drawing.Point(533, 33);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(45, 30);
            this.btnAddress.TabIndex = 24;
            this.btnAddress.Text = "…";
            this.btnAddress.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "保存地址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnyes_save
            // 
            this.btnyes_save.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnyes_save.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnyes_save.Location = new System.Drawing.Point(260, 209);
            this.btnyes_save.Name = "btnyes_save";
            this.btnyes_save.Size = new System.Drawing.Size(78, 39);
            this.btnyes_save.TabIndex = 29;
            this.btnyes_save.Text = "确定";
            this.btnyes_save.UseVisualStyleBackColor = false;
            this.btnyes_save.Click += new System.EventHandler(this.btnyes_save_Click);
            // 
            // manual_save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 274);
            this.Controls.Add(this.btnyes_save);
            this.Controls.Add(this.panel1);
            this.Name = "manual_save";
            this.Text = "手册下载";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labFile_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyes_save;
    }
}