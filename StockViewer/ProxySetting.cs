﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockViewer
{
    public partial class ProxySetting : Form
    {
        bool isEnable = false;
        string host = "";
        int port = 0;

        public ProxySetting()
        {
            InitializeComponent();
        }

        private void ProxySetting_Load(object sender, EventArgs e)
        {
            ParseConfig();
            UpdateUI();
        }

        private void ParseConfig()
        {
            //isEnable = false;

            isEnable = true;
            host = "twty3tmg01.delta.corp";
            port = 8080;
        }

        private void UpdateUI()
        {
            if (isEnable)
            {
                checkBoxEnable.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxEnable.CheckState = CheckState.Unchecked;
            }

            textBoxHost.Text = host;
            textBoxPort.Text = port.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnable.Checked)
            {
                textBoxHost.Enabled = true;
                textBoxPort.Enabled = true;
            }
            else
            {
                textBoxHost.Enabled = false;
                textBoxPort.Enabled = false;
            }
        }
    }
}
