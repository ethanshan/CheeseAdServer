﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheeseAdServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh_bt_Click(object sender, EventArgs e)
        {
            ControlClient.Connect("192.168.1.101", "Hello World\n 1 \n 2 \n");
        }

    }
}
