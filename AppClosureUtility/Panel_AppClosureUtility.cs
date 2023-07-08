using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;
using System.Net.NetworkInformation;

namespace Panel_AppClosureUtility
{
    public partial class Panel_AppClosureUtility : Form
    {
        string application00 = ConfigurationSettings.AppSettings["application00"];
        string application01 = ConfigurationSettings.AppSettings["application01"];
        string application02 = ConfigurationSettings.AppSettings["application02"];
        string application03 = ConfigurationSettings.AppSettings["application03"];
        string application04 = ConfigurationSettings.AppSettings["application04"];


        public Panel_AppClosureUtility()
        {
            InitializeComponent();        
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void curvostylePictureBox1_Click(object sender, EventArgs e)
        {
            // Cerrar application00
            Process[] processesApp00 = Process.GetProcessesByName(application00);
            foreach (Process process in processesApp00)
            {
                if (!process.CloseMainWindow())
                {
                    process.Kill(); // Forzar el cierre del proceso
                }
                process.WaitForExit();
            }

            // Cerrar application01
            Process[] processesApp01 = Process.GetProcessesByName(application01);
            foreach (Process process in processesApp01)
            {
                if (!process.CloseMainWindow())
                {
                    process.Kill(); // Forzar el cierre del proceso
                }
                process.WaitForExit();
            }

            // Cerrar application02
            Process[] processesApp02 = Process.GetProcessesByName(application02);
            foreach (Process process in processesApp02)
            {
                if (!process.CloseMainWindow())
                {
                    process.Kill(); // Forzar el cierre del proceso
                }
                process.WaitForExit();
            }

            // Cerrar application03
            Process[] processesApp03 = Process.GetProcessesByName(application03);
            foreach (Process process in processesApp03)
            {
                if (!process.CloseMainWindow())
                {
                    process.Kill(); // Forzar el cierre del proceso
                }
                process.WaitForExit();
            }

            // Cerrar application04
            Process[] processesApp04 = Process.GetProcessesByName(application04);
            foreach (Process process in processesApp04)
            {
                if (!process.CloseMainWindow())
                {
                    process.Kill(); // Forzar el cierre del proceso
                }
                process.WaitForExit();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_AppClosureUtility_Load(object sender, EventArgs e)
        {

        }
    }
}
