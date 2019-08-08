namespace PCInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIP4 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblip6 = new System.Windows.Forms.Label();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblDefaultGateway = new System.Windows.Forms.Label();
            this.lblBootTime = new System.Windows.Forms.Label();
            this.lblLastBoot = new System.Windows.Forms.Label();
            this.lblTotalRAMTEXT = new System.Windows.Forms.Label();
            this.lblTotalRam = new System.Windows.Forms.Label();
            this.lblfreeram6 = new System.Windows.Forms.Label();
            this.lblFreeRAM = new System.Windows.Forms.Label();
            this.lbldrivespace1 = new System.Windows.Forms.Label();
            this.lbldrive1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(138, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 19);
            this.lblUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hostname: ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(138, 87);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(0, 19);
            this.lblHostName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domain: ";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.Location = new System.Drawing.Point(138, 114);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(0, 19);
            this.lblDomain.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "OS: ";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(138, 140);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(0, 19);
            this.lblOS.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "IPv4: ";
            // 
            // lblIP4
            // 
            this.lblIP4.AutoSize = true;
            this.lblIP4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP4.Location = new System.Drawing.Point(137, 165);
            this.lblIP4.Name = "lblIP4";
            this.lblIP4.Size = new System.Drawing.Size(54, 19);
            this.lblIP4.TabIndex = 10;
            this.lblIP4.Text = "label6";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(90, 192);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(52, 19);
            this.lblIP.TabIndex = 11;
            this.lblIP.Text = "IPv6: ";
            // 
            // lblip6
            // 
            this.lblip6.AutoSize = true;
            this.lblip6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblip6.Location = new System.Drawing.Point(138, 193);
            this.lblip6.Name = "lblip6";
            this.lblip6.Size = new System.Drawing.Size(54, 19);
            this.lblip6.TabIndex = 12;
            this.lblip6.Text = "label6";
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDG.Location = new System.Drawing.Point(-2, 218);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(143, 19);
            this.lblDG.TabIndex = 13;
            this.lblDG.Text = "Default Gateway: ";
            // 
            // lblDefaultGateway
            // 
            this.lblDefaultGateway.AutoSize = true;
            this.lblDefaultGateway.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultGateway.Location = new System.Drawing.Point(137, 220);
            this.lblDefaultGateway.Name = "lblDefaultGateway";
            this.lblDefaultGateway.Size = new System.Drawing.Size(54, 19);
            this.lblDefaultGateway.TabIndex = 14;
            this.lblDefaultGateway.Text = "label6";
            // 
            // lblBootTime
            // 
            this.lblBootTime.AutoSize = true;
            this.lblBootTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBootTime.Location = new System.Drawing.Point(29, 244);
            this.lblBootTime.Name = "lblBootTime";
            this.lblBootTime.Size = new System.Drawing.Size(112, 19);
            this.lblBootTime.TabIndex = 15;
            this.lblBootTime.Text = "Last Reboot: ";
            this.lblBootTime.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblLastBoot
            // 
            this.lblLastBoot.AutoSize = true;
            this.lblLastBoot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBoot.Location = new System.Drawing.Point(137, 245);
            this.lblLastBoot.Name = "lblLastBoot";
            this.lblLastBoot.Size = new System.Drawing.Size(54, 19);
            this.lblLastBoot.TabIndex = 16;
            this.lblLastBoot.Text = "label6";
            // 
            // lblTotalRAMTEXT
            // 
            this.lblTotalRAMTEXT.AutoSize = true;
            this.lblTotalRAMTEXT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRAMTEXT.Location = new System.Drawing.Point(45, 268);
            this.lblTotalRAMTEXT.Name = "lblTotalRAMTEXT";
            this.lblTotalRAMTEXT.Size = new System.Drawing.Size(96, 19);
            this.lblTotalRAMTEXT.TabIndex = 17;
            this.lblTotalRAMTEXT.Text = "Total RAM: ";
            // 
            // lblTotalRam
            // 
            this.lblTotalRam.AutoSize = true;
            this.lblTotalRam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRam.Location = new System.Drawing.Point(137, 269);
            this.lblTotalRam.Name = "lblTotalRam";
            this.lblTotalRam.Size = new System.Drawing.Size(54, 19);
            this.lblTotalRam.TabIndex = 18;
            this.lblTotalRam.Text = "label6";
            // 
            // lblfreeram6
            // 
            this.lblfreeram6.AutoSize = true;
            this.lblfreeram6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfreeram6.Location = new System.Drawing.Point(48, 293);
            this.lblfreeram6.Name = "lblfreeram6";
            this.lblfreeram6.Size = new System.Drawing.Size(89, 19);
            this.lblfreeram6.TabIndex = 19;
            this.lblfreeram6.Text = "Free RAM:";
            // 
            // lblFreeRAM
            // 
            this.lblFreeRAM.AutoSize = true;
            this.lblFreeRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeRAM.Location = new System.Drawing.Point(137, 294);
            this.lblFreeRAM.Name = "lblFreeRAM";
            this.lblFreeRAM.Size = new System.Drawing.Size(54, 19);
            this.lblFreeRAM.TabIndex = 20;
            this.lblFreeRAM.Text = "label6";
            // 
            // lbldrivespace1
            // 
            this.lbldrivespace1.AutoSize = true;
            this.lbldrivespace1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrivespace1.Location = new System.Drawing.Point(137, 318);
            this.lbldrivespace1.Name = "lbldrivespace1";
            this.lbldrivespace1.Size = new System.Drawing.Size(54, 19);
            this.lbldrivespace1.TabIndex = 21;
            this.lbldrivespace1.Text = "label6";
            // 
            // lbldrive1
            // 
            this.lbldrive1.AutoSize = true;
            this.lbldrive1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrive1.Location = new System.Drawing.Point(67, 317);
            this.lbldrive1.Name = "lbldrive1";
            this.lbldrive1.Size = new System.Drawing.Size(75, 19);
            this.lbldrive1.TabIndex = 22;
            this.lbldrive1.Text = "C Drive: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.lbldrive1);
            this.Controls.Add(this.lbldrivespace1);
            this.Controls.Add(this.lblFreeRAM);
            this.Controls.Add(this.lblfreeram6);
            this.Controls.Add(this.lblTotalRam);
            this.Controls.Add(this.lblTotalRAMTEXT);
            this.Controls.Add(this.lblLastBoot);
            this.Controls.Add(this.lblBootTime);
            this.Controls.Add(this.lblDefaultGateway);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.lblip6);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblIP4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PC Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIP4;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblip6;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblDefaultGateway;
        private System.Windows.Forms.Label lblBootTime;
        private System.Windows.Forms.Label lblLastBoot;
        private System.Windows.Forms.Label lblTotalRAMTEXT;
        private System.Windows.Forms.Label lblTotalRam;
        private System.Windows.Forms.Label lblfreeram6;
        private System.Windows.Forms.Label lblFreeRAM;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label lbldrivespace1;
        private System.Windows.Forms.Label lbldrive1;
    }
}

