using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Microsoft.Win32;
using Windows.UI.Notifications;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Anti_Device_Ban
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bypass_Click(object sender, EventArgs e)
        {
            log.Clear();
            log.AppendText("Started At" + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" +DateTime.Now.Second);
            Thread.Sleep(500);
            log.AppendText(Environment.NewLine + "Checking System");
            Thread.Sleep(500);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC", true);
            key.SetValue("VMDeviceManufacturer",dname.Text);
            key.SetValue("VMDeviceModel", dmodel.Text);
            Thread.Sleep(50);
            log.AppendText(Environment.NewLine + "Success");
            Thread.Sleep(50);
            MetroMessageBox.Show(this,"Bypass Success","");
           

        }

        private void dlist_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/warss7878/devices/main/devices.txt");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            MetroTextBox rc = new MetroTextBox();
            rc.ReadOnly = true;
            rc.Multiline = true;
            rc.Text = content;
            rc.Dock = DockStyle.Fill;
            Form frm = new MetroFramework.Forms.MetroForm();
            frm.Text = "Device List";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Controls.Add(rc);
           

            frm.Show();
            
        }
    }
}
