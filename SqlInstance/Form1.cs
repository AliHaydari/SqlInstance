using SqlInstance.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SqlInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rdoLocale.Checked = true;
            chkUseSqlAuthentication.Checked = true;
        }

        private void RdoNetwork_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNetwork.Checked)
            {
                cmbNetworkServers.Enabled = true;
                cmbLocaleServers.Enabled = false;
                cmbNetworkServers.DataSource = DbHelpers.FindNetworkSqlInstances();
            }
            else
            {
                cmbNetworkServers.Enabled = false;
                cmbLocaleServers.Enabled = true;
                cmbNetworkServers.DataSource = null;
            }
        }

        private void RdoLocale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocale.Checked)
            {
                cmbLocaleServers.Enabled = true;
                cmbNetworkServers.Enabled = false;
                cmbLocaleServers.DataSource = DbHelpers.FindLocaleSqlInstances();
            }
            else
            {
                cmbLocaleServers.Enabled = false;
                cmbNetworkServers.Enabled = true;
                cmbLocaleServers.DataSource = null;
            }
        }

        private void ChkUseSqlAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseSqlAuthentication.Checked)
            {
                txtUserId.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUserId.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void BtnFindDatabases_Click(object sender, EventArgs e)
        {
            if (!ValidateControls()) return;

            btnFindDatabases.Enabled = false;

            var dataSource = rdoNetwork.Checked ? cmbNetworkServers.Text : cmbLocaleServers.Text;

            cmbDatabases.DataSource = chkUseSqlAuthentication.Checked
                ? DbHelpers.GetAllDataBases(dataSource, txtUserId.Text, txtPassword.Text)
                : DbHelpers.GetAllDataBases(dataSource);

            btnFindDatabases.Enabled = true;
        }

        private bool ValidateControls()
        {
            var errors = new List<string>();

            if (rdoNetwork.Checked)
            {
                if (string.IsNullOrWhiteSpace(cmbNetworkServers.Text))
                {
                    errors.Add("Network Servers");
                }
            }

            if (rdoLocale.Checked)
            {
                if (string.IsNullOrWhiteSpace(cmbLocaleServers.Text))
                {
                    errors.Add("Locale Servers");
                }
            }

            if (chkUseSqlAuthentication.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text))
                {
                    errors.Add("User Id");
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errors.Add("Password");
                }
            }

            if (errors.Any())
            {
                var msg = string.Join(Environment.NewLine, errors);
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }
    }
}
