using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapFormatPainter.tests;

namespace MapFormatPainter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      //打开新窗体Form2
       private void startForm2BtnClick(object sender, EventArgs e)
              {
                  Form2 f2 = new Form2();

                  f2.Show();
              }

    }
}