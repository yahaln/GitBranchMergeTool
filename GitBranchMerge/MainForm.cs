using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace GitBranchMerge
{
    public partial class MainForm : Form
    {
        private string filePath="";

        private static string cd_project_path="cd ";

        private static String cd_git_switch = "git checkout ";

        private static String cd_git_pull = "git pull ";

        private static String cd_git_merge = "git merge ";

        private static String cd_git_status = "git status ";

        private static String cd_git_push = "git push ";

        private static String cd_git_cmit = "git commit ";

        private static String cmd_echo = "echo ";

        private delegate void FlushClient();//代理

        public MainForm()
        {
            InitializeComponent();
            init();
        }
        public void init() {
            Win32Utility.SetCueText(tb_src,"请输入开发分支名");
            Win32Utility.SetCueText(tb_target, "请输入主分支名");
            Win32Utility.SetCueText(tb_cloud, "请输入云分支名");
            Win32Utility.SetCueText(tb_cloud_test, "请输入云测试分支名");
            this.linkLabel1.Links.Add(0, this.linkLabel1.Text.Length, @"https://yahaln.github.io/index.html");
            this.linkLabel2.Links.Add(0, this.linkLabel2.Text.Length, @"https://yahaln.github.io/index.html"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_src_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_target_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 浏览文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                   MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.filePath = folderBrowserDialog.SelectedPath;
                this.tb_project_path.Text = this.filePath;
                //MessageBox.Show(this, this.filePath, "提示");
            }
        }
        /// <summary>
        /// 执行按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.tb_sysinfo.Text = "命令执行中，请稍后。。。。。。\n";

            if (string.IsNullOrEmpty(this.tb_project_path.Text))
            {
                MessageBox.Show(this,"git工程目录不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(this.tb_src.Text))
            {
                MessageBox.Show(this,"源分支不能为空！");
                return;
            }
              if (string.IsNullOrEmpty(this.tb_target.Text))
            {
                MessageBox.Show(this,"目的分支不能为空！");
                return;
            }
            //创建线程
              Thread t = new Thread(threadrunnable);
              t.IsBackground = true;
            //执行
              t.Start();

        }
        /// <summary>
        /// 线程执行方法
        /// </summary>
        public void threadrunnable()
        {
            //git工程目录
            string _projectPath = this.tb_project_path.Text.Trim();
            //开发分支
            string _branch_src = this.tb_src.Text.Trim();
            //主分支
            string _branch_target = this.tb_target.Text.Trim();
            //云分支
            string _branch_cloud = this.tb_cloud.Text.Trim();
            //云测试分支
            string _branch_cloud_test = this.tb_cloud_test.Text.Trim();
            //:的位置
            int _index = _projectPath.IndexOf(":");
            ///形如d:
            string _dir = _projectPath.Substring(0, _index + 1);

            try
            {
                //创建一个进程
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                p.Start();//启动程序
                //向cmd窗口发送输入信息
                //进入盘符
                p.StandardInput.WriteLine(_dir);
                //进入相应的目录
                p.StandardInput.WriteLine(cd_project_path + _projectPath);
                ////执行dir命令
                //p.StandardInput.WriteLine("dir");
                //切换到开发分支
                p.StandardInput.WriteLine(cd_git_switch + _branch_src);
                //执行拉取命令
                p.StandardInput.WriteLine(cd_git_pull);
                //---------------------------主start---------------------------------
                p.StandardInput.WriteLine(cmd_echo + "====>" + _branch_target + "<====");
                //切换到主分支
                p.StandardInput.WriteLine(cd_git_switch + _branch_target);
                //执行拉取命令
                p.StandardInput.WriteLine(cd_git_pull);
                //执行合并命令（开发分支合并到主分支）
                p.StandardInput.WriteLine(cd_git_merge + _branch_src);
                //执行本地提交命令
                p.StandardInput.WriteLine(cd_git_cmit);
                //将本地修改缓存推到服务器上
                p.StandardInput.WriteLine(cd_git_push);
                //---------------------------主end---------------------------------


                //---------------------------云start---------------------------------
                if (!string.IsNullOrEmpty(_branch_cloud))
                {
                    p.StandardInput.WriteLine(cmd_echo + "====>" + _branch_cloud + "<====");
                    //切换到云分支
                    p.StandardInput.WriteLine(cd_git_switch + _branch_cloud);
                    //执行拉取命令
                    p.StandardInput.WriteLine(cd_git_pull);
                    //执行合并命令（主分支合并到云分支）
                    p.StandardInput.WriteLine(cd_git_merge + _branch_target);
                    //执行本地提交命令
                    p.StandardInput.WriteLine(cd_git_cmit);
                    //将本地修改缓存推到服务器上
                    p.StandardInput.WriteLine(cd_git_push);
                }
                //---------------------------云end---------------------------------
                //---------------------------云测试start---------------------------------
                if (!string.IsNullOrEmpty(_branch_cloud_test))
                {
                    p.StandardInput.WriteLine(cmd_echo + "====>" + _branch_cloud_test + "<====");
                    //切换到云分支
                    p.StandardInput.WriteLine(cd_git_switch + _branch_cloud_test);
                    //执行拉取命令
                    p.StandardInput.WriteLine(cd_git_pull);
                    //执行合并命令（主分支合并到云分支）
                    p.StandardInput.WriteLine(cd_git_merge + _branch_target);
                    //执行本地提交命令
                    p.StandardInput.WriteLine(cd_git_cmit);
                    //将本地修改缓存推到服务器上
                    p.StandardInput.WriteLine(cd_git_push);
                }
                //---------------------------云测试end---------------------------------
                //切换到开发分支
                p.StandardInput.WriteLine(cd_git_switch + _branch_src);
                //执行查看状态命令
                p.StandardInput.WriteLine(cd_git_status);
                //退出
                p.StandardInput.WriteLine("exit");
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                //等待程序执行完退出进程
                p.WaitForExit();
                p.Close();
                if (this.tb_sysinfo.InvokeRequired)//等待异步
            {
                FlushClient fc = new FlushClient(threadrunnable);
                this.Invoke(fc);//通过代理调用刷新方法
            }
            else
            {
                this.tb_sysinfo.AppendText(output);
                this.tb_sysinfo.AppendText("命令执行完毕！");
            }
                //MessageBox.Show(output);
                //Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);
            }
        }
        /// <summary>
        /// 作者超链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[this.linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (string.IsNullOrEmpty(targetUrl))
                MessageBox.Show("没有链接地址！");
            else
                System.Diagnostics.Process.Start("iexplore.exe", targetUrl); 
        }
        /// <summary>
        /// ReadME 超链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.Links[this.linkLabel2.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (string.IsNullOrEmpty(targetUrl))
                MessageBox.Show("没有链接地址！");
            else
                System.Diagnostics.Process.Start("iexplore.exe", targetUrl); 
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            ////git工程目录
            //string _projectPath = this.tb_project_path.Text.Trim();
            ////开发分支
            //string _branch_src = this.tb_src.Text.Trim();
            ////主分支
            //string _branch_target = this.tb_target.Text.Trim();
            ////云分支
            //string _branch_cloud = this.tb_cloud.Text.Trim();
            ////云测试分支
            //string _branch_cloud_test = this.tb_cloud_test.Text.Trim();
            this.tb_project_path.Text = @"D:\workspace_sts\api-ecpw";
            this.tb_src.Text = @"dev";
            this.tb_target.Text = @"master";
            this.tb_cloud.Text = @"cloud";
            this.tb_cloud_test.Text = @"bcloud_test";
        }
    }
}
