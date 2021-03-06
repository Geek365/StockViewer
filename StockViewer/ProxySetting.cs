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
        public ProxySetting()
        {
            InitializeComponent();
        }

        private void ProxySetting_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (Config.Proxy.Enable)
            {
                checkBoxEnable.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxEnable.CheckState = CheckState.Unchecked;
            }

            textBoxHost.Text = Config.Proxy.Host;
            textBoxPort.Text = Config.Proxy.Port.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Config.Proxy.Enable = checkBoxEnable.Checked;
            Config.Proxy.Host = textBoxHost.Text;
            Config.Proxy.Port = int.Parse(textBoxPort.Text);
        }
    }
}
