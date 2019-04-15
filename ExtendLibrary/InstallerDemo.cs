using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendLibrary
{
    [RunInstaller(true)]
    public partial class InstallerDemo : System.Configuration.Install.Installer
    {
        public InstallerDemo()
        {
            InitializeComponent();
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            LogWrite("OnAfterInstall！");
            string path = this.Context.Parameters["targetdir"];//获取用户设定的安装目标路径, 注意，需要在Setup项目里面自定义操作的属性栏里面的CustomActionData添加上/targetdir="[TARGETDIR]\"
            LogWrite("安装目录：" + path);//开机启动
            //RegistryKey hklm = Registry.LocalMachine;
            //RegistryKey run = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            try
            {//64位系统在计算机\HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run
                LogWrite("设置注册表！");
                LogWrite(path.Replace(@"\\", @"\") + "OCRTest.exe");//
                //run.CreateSubKey("OCRTest");
                //run.SetValue("OCRTest", @"D:\文件识别\OCRTest.exe");
                //hklm.Close();
                LogWrite("设置结束！");

            }
            catch (Exception my)
            {
                my.ToString();
                LogWrite(my.ToString());
            }
            base.OnAfterInstall(savedState);
        }
        public override void Install(IDictionary stateSaver)
        {
            LogWrite("Install！");
            base.Install(stateSaver);
        }
        protected override void OnBeforeInstall(IDictionary savedState)
        {
            LogWrite("OnBeforeInstall!");
            base.OnBeforeInstall(savedState);
        }
        public override void Uninstall(IDictionary savedState)
        {
            LogWrite("Uninstall!");
            base.Uninstall(savedState);
        }
        public override void Rollback(IDictionary savedState)
        {
            LogWrite("Rollback");
            base.Rollback(savedState);
        }
        public void LogWrite(string str)
        {
            string LogPath = @"D:\文件识别\log\";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(LogPath + @"SetUpLog.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\n");

            }
        }
    }
}
