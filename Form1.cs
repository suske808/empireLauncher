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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/188.212.102.26");
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // factiuni image
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/jcKHhVXtpt");
        }

        // System.Diagnostics.Process.Start("fivem://connect/188.212.102.26");
        // this.Close();

        // FiveMServerLauncher.Form1
        // Token: 0x06000004 RID: 4 RVA: 0x000021B0 File Offset: 0x000003B0
    }
}
