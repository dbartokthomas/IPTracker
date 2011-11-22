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
            this.serviceList.Items.Add(IPAddressService.WhatIsMyIpDotOrg);
            this.serviceList.SelectedIndex = 0;

            this.whenChangesList.SelectedIndex = 0;
        }

        private void whenChangesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When this changes, change the panel
            var newSelection = whenChangesList.SelectedItem as string;

            //Check it
            switch (newSelection.ToLower())
            { 
                case "email":
                    if (!whenChangesPanel.HasChildren || !(whenChangesPanel.Controls[0] is Control.Email))
                    {
                        whenChangesPanel.Controls.Clear();
                        whenChangesPanel.Controls.Add(new Control.Email());
                    }
                    break;
                case "httprequest":
                    if (!whenChangesPanel.HasChildren || !(whenChangesPanel.Controls[0] is Control.HttpRequest))
                    {
                        whenChangesPanel.Controls.Clear();
                        whenChangesPanel.Controls.Add(new Control.HttpRequest());
                    }
                    break;
            }
        }
    }
}
