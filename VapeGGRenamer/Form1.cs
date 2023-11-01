using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeGGRenamer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string FakePass = "D24956159";
        public string RealPass = "46611";
        public Form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == FakePass)
            {
                MessageBox.Show("We are currently experiencing technical difficulties with our servers. We apologize for the inconvenience and kindly request that you try again later.", "Image Manager | Powered BY COS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (guna2TextBox1.Text == RealPass)
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C \"imgcore.dll\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            } else
            {
                MessageBox.Show("Invalid Credentials", "Image Manager | Powered BY COS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
