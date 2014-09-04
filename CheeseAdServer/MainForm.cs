using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheeseAdServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void refresh_bt_Click(object sender, EventArgs e)
        {
            //ControlClient.Connect("192.168.1.101", "Hello World\n 1 \n 2 \n");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. fetch config
            ScheduleConfig config = LocalDatabase.getInstance().getConfig();

            // 2. Initial UI control text from the config
            
        }

    }
}
