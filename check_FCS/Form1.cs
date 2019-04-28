using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace check_FCS
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLength.Text = Convert.ToString(txtWord.TextLength);

            //int n = txtWord.TextLength;
            //int i = 0;
            //int a = 0;
            //while (i < n)
            //{
            //    a = (byte)Convert.ToChar(a) ^ (byte)Convert.ToChar(txtWord.Text.Substring(i, 1));
            //    i++;
            //}
            //txtFCS.Text = string.Format("{0:x}", a).ToUpper();
            txtFCS.Text = string2FCS(txtWord.Text);
        }
        public string string2FCS(string wordText)
        {
            int n = wordText.Length;
            int i = 0;
            int a = 0;
            while (i < n)
            {
                a = (byte)Convert.ToChar(a) ^ (byte)Convert.ToChar(wordText.Substring(i, 1));
                i++;
            }
            
            return string.Format("{0:x}", a).ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
