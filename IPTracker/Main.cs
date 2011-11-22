using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void refreshIp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Add the available Services to the list
            this.serviceList.Items.Add(IPAddressFinder.WhatIsMyIpDotOrg);
            this.serviceList.SelectedIndex = 0;

            this.whenChangesList.SelectedIndex = 0;
        }
    }
}
