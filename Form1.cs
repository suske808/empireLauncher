using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EmpireLauncher
{
    public partial class EmpireLauncher : Form
    {
        public EmpireLauncher()
        {
            InitializeComponent();
        }

        private void EmpireLauncher_Load(object sender, EventArgs e)
        {

        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/scnqcfYs6r");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/suske808/empireLauncher");
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/188.212.102.26");
            this.Close();
        }

        // FiveMServerLauncher.Form1
        // Token: 0x06000004 RID: 4 RVA: 0x000021B0 File Offset: 0x000003B0
    }
}
