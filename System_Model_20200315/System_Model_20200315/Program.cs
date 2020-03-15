using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Model_20200315.Form_Dir;

namespace System_Model_20200315
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// 先呼叫Login_Fm 來登入
        /// 通過才開啟主窗體
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login_Fm login = new Login_Fm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                //線上程中開啟主窗體
                Application.Run(new Main_Fm());
            }
        }
    }
}
