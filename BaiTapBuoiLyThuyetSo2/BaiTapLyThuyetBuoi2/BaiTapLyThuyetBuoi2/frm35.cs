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

namespace BaiTapLyThuyetBuoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL +  "?subject=hello");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string strURL = "mailto:2111875@dlu.edu.vn";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "http://Kashimono3.github.io";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://"))
                Process.Start(strURL);
        }
    }
}
