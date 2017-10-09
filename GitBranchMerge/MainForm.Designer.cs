namespace GitBranchMerge
{
    partial class MainForm
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
            this.label_src = new System.Windows.Forms.Label();
            this.label_target = new System.Windows.Forms.Label();
            this.tb_src = new System.Windows.Forms.TextBox();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label_project_path = new System.Windows.Forms.Label();
            this.tb_project_path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cloud = new System.Windows.Forms.TextBox();
            this.label_cloud = new System.Windows.Forms.Label();
            this.label_sysinfo = new System.Windows.Forms.Label();
            this.tb_sysinfo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_src
            // 
            this.label_src.AutoSize = true;
            this.label_src.Location = new System.Drawing.Point(8, 49);
            this.label_src.Name = "label_src";
            this.label_src.Size = new System.Drawing.Size(65, 12);
            this.label_src.TabIndex = 0;
            this.label_src.Text = "开发分支：";
            this.label_src.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Location = new System.Drawing.Point(20, 76);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(53, 12);
            this.label_target.TabIndex = 1;
            this.label_target.Text = "主分支：";
            // 
            // tb_src
            // 
            this.tb_src.Location = new System.Drawing.Point(77, 45);
            this.tb_src.Name = "tb_src";
            this.tb_src.Size = new System.Drawing.Size(279, 21);
            this.tb_src.TabIndex = 2;
            this.tb_src.TextChanged += new System.EventHandler(this.tb_src_TextChanged);
            // 
            // tb_target
            // 
            this.tb_target.Location = new System.Drawing.Point(77, 73);
            this.tb_target.Name = "tb_target";
            this.tb_target.Size = new System.Drawing.Size(279, 21);
            this.tb_target.TabIndex = 3;
            this.tb_target.TextChanged += new System.EventHandler(this.tb_target_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Location = new System.Drawing.Point(370, 49);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(85, 71);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "执行";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label_project_path
            // 
            this.label_project_path.AutoSize = true;
            this.label_project_path.Location = new System.Drawing.Point(6, 17);
            this.label_project_path.Name = "label_project_path";
            this.label_project_path.Size = new System.Drawing.Size(65, 12);
            this.label_project_path.TabIndex = 5;
            this.label_project_path.Text = "工程目录：";
            // 
            // tb_project_path
            // 
            this.tb_project_path.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_project_path.Enabled = false;
            this.tb_project_path.Location = new System.Drawing.Point(77, 13);
            this.tb_project_path.Name = "tb_project_path";
            this.tb_project_path.Size = new System.Drawing.Size(279, 21);
            this.tb_project_path.TabIndex = 6;
            this.tb_project_path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_folder
            // 
            this.btn_folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_folder.Location = new System.Drawing.Point(370, 11);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(85, 23);
            this.btn_folder.TabIndex = 7;
            this.btn_folder.Text = "浏览";
            this.btn_folder.UseVisualStyleBackColor = false;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_cloud);
            this.panel1.Controls.Add(this.label_cloud);
            this.panel1.Controls.Add(this.label_sysinfo);
            this.panel1.Controls.Add(this.tb_sysinfo);
            this.panel1.Controls.Add(this.btn_folder);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.tb_project_path);
            this.panel1.Controls.Add(this.label_src);
            this.panel1.Controls.Add(this.label_project_path);
            this.panel1.Controls.Add(this.label_target);
            this.panel1.Controls.Add(this.tb_src);
            this.panel1.Controls.Add(this.tb_target);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 452);
            this.panel1.TabIndex = 8;
            // 
            // tb_cloud
            // 
            this.tb_cloud.Location = new System.Drawing.Point(78, 99);
            this.tb_cloud.Name = "tb_cloud";
            this.tb_cloud.Size = new System.Drawing.Size(278, 21);
            this.tb_cloud.TabIndex = 11;
            // 
            // label_cloud
            // 
            this.label_cloud.AutoSize = true;
            this.label_cloud.Location = new System.Drawing.Point(18, 99);
            this.label_cloud.Name = "label_cloud";
            this.label_cloud.Size = new System.Drawing.Size(53, 12);
            this.label_cloud.TabIndex = 10;
            this.label_cloud.Text = "云分支：";
            // 
            // label_sysinfo
            // 
            this.label_sysinfo.AutoSize = true;
            this.label_sysinfo.Location = new System.Drawing.Point(30, 126);
            this.label_sysinfo.Name = "label_sysinfo";
            this.label_sysinfo.Size = new System.Drawing.Size(41, 12);
            this.label_sysinfo.TabIndex = 9;
            this.label_sysinfo.Text = "信息：";
            // 
            // tb_sysinfo
            // 
            this.tb_sysinfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_sysinfo.ForeColor = System.Drawing.Color.Lime;
            this.tb_sysinfo.Location = new System.Drawing.Point(77, 126);
            this.tb_sysinfo.Multiline = true;
            this.tb_sysinfo.Name = "tb_sysinfo";
            this.tb_sysinfo.ReadOnly = true;
            this.tb_sysinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sysinfo.Size = new System.Drawing.Size(378, 321);
            this.tb_sysinfo.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(374, 456);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Powered by yahaln";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(318, 457);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 12);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ReadMe";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 468);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Git分支合并工具(win版)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_src;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.TextBox tb_src;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label_project_path;
        private System.Windows.Forms.TextBox tb_project_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_sysinfo;
        private System.Windows.Forms.Label label_sysinfo;
        private System.Windows.Forms.Label label_cloud;
        private System.Windows.Forms.TextBox tb_cloud;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

