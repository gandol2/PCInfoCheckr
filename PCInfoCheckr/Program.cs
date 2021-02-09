using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCInfoCheckr
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                int cnt = 0;

                Process[] procs = Process.GetProcesses();

                foreach (Process p in procs)
                {
                    if (p.ProcessName.Equals("PCInfoCheckr") == true) cnt++;
                }

                if (cnt > 1)
                {
                    MessageBox.Show("PCInfoCheckr가 이미 실행중입니다.");
                    return;
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new PCInfoCheckr());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program - Error");
            }
        }
    }
}