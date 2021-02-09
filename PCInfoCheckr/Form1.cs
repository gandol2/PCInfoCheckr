using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using MetroFramework.Forms;

namespace PCInfoCheckr
{
    public partial class PCInfoCheckr : MetroForm
    {
        public PCInfoCheckr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObject manageobject = new ManagementObject("win32_logicaldisk.deviceid=\"" + "C" + ":\"");
            manageobject.Get();
            tbx_hnum.Text = manageobject["VolumeSerialNumber"].ToString();
        }
    }
}