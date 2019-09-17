namespace SqlInstance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNetworkServers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnFindDatabases = new System.Windows.Forms.Button();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLocaleServers = new System.Windows.Forms.ComboBox();
            this.rdoNetwork = new System.Windows.Forms.RadioButton();
            this.rdoLocale = new System.Windows.Forms.RadioButton();
            this.chkUseSqlAuthentication = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Servers Name";
            // 
            // cmbNetworkServers
            // 
            this.cmbNetworkServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNetworkServers.FormattingEnabled = true;
            this.cmbNetworkServers.Location = new System.Drawing.Point(135, 6);
            this.cmbNetworkServers.Name = "cmbNetworkServers";
            this.cmbNetworkServers.Size = new System.Drawing.Size(249, 21);
            this.cmbNetworkServers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Locale Servers Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.Location = new System.Drawing.Point(135, 87);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(249, 20);
            this.txtUserId.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(135, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnFindDatabases
            // 
            this.btnFindDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindDatabases.Location = new System.Drawing.Point(135, 154);
            this.btnFindDatabases.Name = "btnFindDatabases";
            this.btnFindDatabases.Size = new System.Drawing.Size(249, 23);
            this.btnFindDatabases.TabIndex = 8;
            this.btnFindDatabases.Text = "Find Databases";
            this.btnFindDatabases.UseVisualStyleBackColor = true;
            this.btnFindDatabases.Click += new System.EventHandler(this.BtnFindDatabases_Click);
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(135, 200);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(249, 21);
            this.cmbDatabases.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Databases";
            // 
            // cmbLocaleServers
            // 
            this.cmbLocaleServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocaleServers.FormattingEnabled = true;
            this.cmbLocaleServers.Location = new System.Drawing.Point(135, 33);
            this.cmbLocaleServers.Name = "cmbLocaleServers";
            this.cmbLocaleServers.Size = new System.Drawing.Size(249, 21);
            this.cmbLocaleServers.TabIndex = 4;
            // 
            // rdoNetwork
            // 
            this.rdoNetwork.AutoSize = true;
            this.rdoNetwork.Location = new System.Drawing.Point(390, 7);
            this.rdoNetwork.Name = "rdoNetwork";
            this.rdoNetwork.Size = new System.Drawing.Size(65, 17);
            this.rdoNetwork.TabIndex = 1;
            this.rdoNetwork.Text = "Network";
            this.rdoNetwork.UseVisualStyleBackColor = true;
            this.rdoNetwork.CheckedChanged += new System.EventHandler(this.RdoNetwork_CheckedChanged);
            // 
            // rdoLocale
            // 
            this.rdoLocale.AutoSize = true;
            this.rdoLocale.Location = new System.Drawing.Point(390, 34);
            this.rdoLocale.Name = "rdoLocale";
            this.rdoLocale.Size = new System.Drawing.Size(57, 17);
            this.rdoLocale.TabIndex = 3;
            this.rdoLocale.Text = "Locale";
            this.rdoLocale.UseVisualStyleBackColor = true;
            this.rdoLocale.CheckedChanged += new System.EventHandler(this.RdoLocale_CheckedChanged);
            // 
            // chkUseSqlAuthentication
            // 
            this.chkUseSqlAuthentication.AutoSize = true;
            this.chkUseSqlAuthentication.Location = new System.Drawing.Point(135, 64);
            this.chkUseSqlAuthentication.Name = "chkUseSqlAuthentication";
            this.chkUseSqlAuthentication.Size = new System.Drawing.Size(134, 17);
            this.chkUseSqlAuthentication.TabIndex = 5;
            this.chkUseSqlAuthentication.Text = "Use Sql Authentication";
            this.chkUseSqlAuthentication.UseVisualStyleBackColor = true;
            this.chkUseSqlAuthentication.CheckedChanged += new System.EventHandler(this.ChkUseSqlAuthentication_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.chkUseSqlAuthentication);
            this.Controls.Add(this.rdoLocale);
            this.Controls.Add(this.rdoNetwork);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.btnFindDatabases);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.cmbLocaleServers);
            this.Controls.Add(this.cmbNetworkServers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNetworkServers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnFindDatabases;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLocaleServers;
        private System.Windows.Forms.RadioButton rdoNetwork;
        private System.Windows.Forms.RadioButton rdoLocale;
        private System.Windows.Forms.CheckBox chkUseSqlAuthentication;
    }
}

