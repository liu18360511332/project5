namespace project_five
{
    partial class login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_page));
            this.label1 = new System.Windows.Forms.Label();
            this.zhanghao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mima = new System.Windows.Forms.TextBox();
            this.labelmima = new System.Windows.Forms.Label();
            this.labelzhanghao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(279, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "全域智能进化仿真实验平台";
            // 
            // zhanghao
            // 
            this.zhanghao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhanghao.Location = new System.Drawing.Point(391, 313);
            this.zhanghao.Name = "zhanghao";
            this.zhanghao.Size = new System.Drawing.Size(242, 26);
            this.zhanghao.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(444, 426);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(118, 42);
            this.login.TabIndex = 15;
            this.login.Text = "登  录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(274, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Copyright © 2020 by Northeastern University, All Rights Reserved";
            // 
            // mima
            // 
            this.mima.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima.Location = new System.Drawing.Point(391, 371);
            this.mima.Name = "mima";
            this.mima.PasswordChar = '*';
            this.mima.Size = new System.Drawing.Size(242, 26);
            this.mima.TabIndex = 13;
            // 
            // labelmima
            // 
            this.labelmima.AutoSize = true;
            this.labelmima.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelmima.Location = new System.Drawing.Point(317, 372);
            this.labelmima.Name = "labelmima";
            this.labelmima.Size = new System.Drawing.Size(49, 19);
            this.labelmima.TabIndex = 11;
            this.labelmima.Text = "密码";
            // 
            // labelzhanghao
            // 
            this.labelzhanghao.AutoSize = true;
            this.labelzhanghao.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelzhanghao.Location = new System.Drawing.Point(317, 314);
            this.labelzhanghao.Name = "labelzhanghao";
            this.labelzhanghao.Size = new System.Drawing.Size(49, 19);
            this.labelzhanghao.TabIndex = 10;
            this.labelzhanghao.Text = "账号";
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zhanghao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.labelmima);
            this.Controls.Add(this.labelzhanghao);
            this.Name = "login_page";
            this.Text = "全域智能进化仿真实验平台";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zhanghao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mima;
        private System.Windows.Forms.Label labelmima;
        private System.Windows.Forms.Label labelzhanghao;
    }
}