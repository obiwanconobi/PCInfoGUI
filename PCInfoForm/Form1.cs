using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace PCInfoForm
{
    public partial class Form1 : Form
    {
        decimal totalRam;
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 10000;//10 seconds
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            getTotalRAM();
            getFreeRAM();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Environment.UserName;
            lblHostName.Text = Environment.MachineName;
            lblDomain.Text = Environment.UserDomainName;
            GetOS();
            GetIP();
            getDefaultGateway();
            getLastBoot();
            getTotalRAM();
            getFreeRAM();
            getDiskSpace();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public void GetOS()
        {
            string osName;
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"); //select all of the info from win32_os
            ManagementObjectCollection objectCollection = objectSearcher.Get(); //puts data into a collection

            foreach (ManagementObject managementObject in objectCollection)
            {
                osName = managementObject.GetPropertyValue("Caption").ToString();
                lblOS.Text = osName.Replace("Microsoft ", "");
                //Console.WriteLine("OS: {0}", managementObject.GetPropertyValue("Caption").ToString()); //looks for the line with "caption" and takes data from here. prints it
            }
        }
        public void GetIP()
        {
            ManagementObjectSearcher objectsearcherIP = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration"); //gets all the info for network adapters
            foreach (ManagementObject queryObj in objectsearcherIP.Get())
            {
                if (queryObj["IPAddress"] == null) //finds the IP address info 
                {

                }
                else
                {
                    String[] arrIPAddress = (String[])(queryObj["IPAddress"]);
                    foreach (String arrValue in arrIPAddress)
                    {
                        if (arrValue.StartsWith("192") || arrValue.StartsWith("172") || arrValue.StartsWith("10."))
                        { //Checks if the IP is v4 or v6
                            //Console.WriteLine("IPv4: {0}", arrValue);
                            lblIP4.Text = arrValue;
                        }
                        else
                        {
                            //  Console.WriteLine("IPv6: {0}", arrValue);
                            lblip6.Text = arrValue;
                        }
                    }
                }
            }
        }
        public void getDefaultGateway()
        {
            ManagementObjectSearcher objectsearcherGW = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration"); //gets all the info for network adapters
            foreach (ManagementObject queryObj in objectsearcherGW.Get())
            {
                if (queryObj["DefaultIPGateway"] == null) //finds the Gateway IP info
                {

                }
                else
                {
                    String[] arrIPAddress = (String[])(queryObj["DefaultIPGateway"]);
                    foreach (String arrValue in arrIPAddress)
                    {
                        //Console.WriteLine("Default Gateway: {0}", arrValue); //prints out the default gateway
                        lblDefaultGateway.Text = arrValue;
                    }
                }
            }
        }

        public void getLastBoot()
        {
            string txtDate;
            DateTime dtBoot;
            // string bootuptime;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMv2", "SELECT * FROM Win32_OperatingSystem"); //does an empty search for all data win Win32_OS
            foreach (ManagementObject queryObj in searcher.Get()) //goes through every returned data 
            {
                dtBoot = ManagementDateTimeConverter.ToDateTime(queryObj.Properties["LastBootUpTime"].Value.ToString()); //looks for "lastbootuptime"
                txtDate = dtBoot.ToLongDateString();
                // bootuptime = queryObj["LastBootUpTime"].ToString();
                // Console.WriteLine("Last Boot Up: {0}", txtDate); //prints out the last boot up time as a date 
                lblLastBoot.Text = txtDate;

                //  bool rebootreq;
                //  rebootreq = (dtBoot - DateTime.Now).TotalDays < 30;
                if ((dtBoot - DateTime.Today).TotalDays > 7)
                {
                    lblLastBoot.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        public void getTotalRAM()
        {
            ManagementObjectSearcher RAMSearch = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject queryObj in RAMSearch.Get())
            {
               // decimal totalRam;
                totalRam = (Convert.ToDecimal(queryObj["TotalPhysicalMemory"])) / (1024 * 1024 * 1024);
                //Console.WriteLine("Total RAM: {0:F1}GB", totalRam);
               // lblTotalRAM.Text = totalRam.ToString("00.00");
                lblTotalRam.Text = totalRam.ToString("0.00GB");
                
            }
        }
        public void getFreeRAM()
        {
            ManagementObjectSearcher FreeRamSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject queryObj in FreeRamSearcher.Get())
            {
                decimal freeram;
                freeram = (Convert.ToDecimal(queryObj["FreePhysicalMemory"])) / (1024 * 1024);
                // Console.WriteLine("FreePhysicalMemory: {0:F1}GB", freeram);
                lblFreeRAM.Text = freeram.ToString("0.00GB");
                if (freeram < (totalRam/4))
                {
                    lblFreeRAM.ForeColor = System.Drawing.Color.Red;
                    lblfreeram6.ForeColor = System.Drawing.Color.Red;
                }
            }

        }
        

        public void getDiskSpace()
        { 
            float freespacestring;
            float totaldiskstring;
            float percentfree;
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> freeSpace = new List<string>();

            
            foreach (DriveInfo drive in drives)
            { 
                try
                {
                    if (drive.DriveType == DriveType.Fixed)
                    {
                        totaldiskstring = drive.TotalSize;
                        freespacestring = drive.AvailableFreeSpace;
                        percentfree = ((freespacestring / 10000) / (totaldiskstring / 10000) * 100);
                        freeSpace.Add(string.Format(@"{0}\ {1} GB - {2:F1}% free", drive.Name, (drive.AvailableFreeSpace / (1024 * 1024)).ToString("##,#"), percentfree)); //adds the disk data to the freespace list
                                                                                                                                                                           
                        lbldrive1.Text = drive.Name;                                                                                                                                                  
                        lbldrivespace1.Text = (drive.AvailableFreeSpace / (1024 * 1024)).ToString("##,#");                                                                                                                                                  
                    }

                }
                catch (Exception) { }
            }
            freeSpace.ForEach(Console.WriteLine); 

        }



        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getTotalRAM();
            getFreeRAM();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            bool bHandled = false;
            switch (keydata)
            {
                case Keys.F5:
                getTotalRAM(); //items to refresh. Will create a method for this 
                getFreeRAM();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
    }
}
