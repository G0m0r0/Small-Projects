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

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path =
              @"D:\Programming\University\Coursework\fn181218001\fn181218001\p1\bin\Debug\netcoreapp3.1\p1.exe";
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
         
            if (comboBox1.SelectedIndex == 0)
            {
                proc.StandardInput.WriteLine($"{path} -h");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                proc.StandardInput.WriteLine($"{path} -g un.txt");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                proc.StandardInput.WriteLine($"{path} -v un.txt");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                proc.StandardInput.WriteLine($"{path} -s un.txt st.txt");
            }

            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            proc.WaitForExit();
            var message=proc.StandardOutput.ReadToEnd();

            MessageBox.Show(message);
        }
    }
}
