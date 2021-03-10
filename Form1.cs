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

namespace KronosLauncher
{
    public partial class KronosLauncher : Form
    {
        public KronosLauncher()
        {
            InitializeComponent();
        }

        private void KronosLauncher_Load(object sender, EventArgs e)
        {

        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/stefan.mst/");
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/kronosro");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/suske808/kronosLauncher");
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/345al8");
            this.Close();
        }

        // FiveMServerLauncher.Form1
        // Token: 0x06000004 RID: 4 RVA: 0x000021B0 File Offset: 0x000003B0
    }
}
