using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace WindowsDiagnostic
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            eventsListBox.Items.Clear();
            startupListBox.Items.Clear();
            eventsListBox.Items.Add("Starting diagnosis");

            toolStripProgressBar.Value = 1;

            toolStripStatusLabel.Text = "Fetching startup entries...";
            GetRegistryFieldsAndInstertToList(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"), "[Current User-Run]");
            GetRegistryFieldsAndInstertToList(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), "[Current User-RunOnce]");
            eventsListBox.Items.Add("Got CurrentUser startup tasks.");
            GetRegistryFieldsAndInstertToList(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"), "[Local Machine-Run]");
            GetRegistryFieldsAndInstertToList(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), "[Local Machine-RunOnce]");
            eventsListBox.Items.Add("Got LocalMachine startup tasks.");

            toolStripProgressBar.Value = 10;

            foreach (string startupFile in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
            {
                startupListBox.Items.Add("[User-Startup] " + startupFile);
            };

            toolStripProgressBar.Value = 15;

            foreach (string startupFile in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)))
            {
                startupListBox.Items.Add("[Common-Startup] " + startupFile);
            };

            toolStripProgressBar.Value = 20;

            toolStripStatusLabel.Text = "Fetching CPU data...";
            cpuLabel.Text = "CPU - " + getFieldFromManagment("select Name from Win32_Processor") +
                "(" + getFieldFromManagment("select AddressWidth from Win32_Processor") + "bit) "
                + " | Manufacturer: " + getFieldFromManagment("select Manufacturer from Win32_Processor")
                + " | " + getFieldFromManagment("select Caption from Win32_Processor")
                + " | Cache L1 " + getFieldFromManagment("select L1CacheSize from Win32_Processor") + " bytes"
                + " | Cache L2 " + getFieldFromManagment("select L2CacheSize from Win32_Processor") + " bytes"
                + " | Cache L3 " + getFieldFromManagment("select L3CacheSize from Win32_Processor") + " bytes";
            toolStripProgressBar.Value = 40;

            toolStripStatusLabel.Text = "Fetching Motherboard data...";
            motherboardInfo.Text = "MOTHERBOARD - " + getFieldFromManagment("select Product from Win32_BaseBoard")
                + " | Manufacturer : " + getFieldFromManagment("select Manufacturer from Win32_BaseBoard")
                + " | Serial no. " + getFieldFromManagment("select SerialNumber from Win32_BaseBoard");

            toolStripStatusLabel.Text = "Fetching OS data...";
            osName.Text = getFieldFromManagment("select Caption from Win32_OperatingSystem");

            toolStripStatusLabel.Text = "Fetching RAM data...";
            ramInfo.Text = "RAM - " + Math.Round(float.Parse(getFieldFromManagment("select TotalPhysicalMemory from  Win32_ComputerSystem")) / 1073741824) + " GB";

            toolStripStatusLabel.Text = "Fetching GPU data...";
            gpuInfo.Text = "GPU (Current) - " + getFieldFromManagment("select VideoProcessor from Win32_VideoController")
                + " " + Math.Round(float.Parse(getFieldFromManagment("select AdapterRam from  Win32_VideoController")) / 1073741824) + " GB";
            eventsListBox.Items.Add("Got PC specs");

            toolStripProgressBar.Value = 60;

            if (settingsDumpDb.Checked) {
                toolStripStatusLabel.Text = "Fetching WIN32 database data...";
                listAvalableNamesManagmentObject("select * from Win32_ComputerSystem");
                listAvalableNamesManagmentObject("select * from Win32_BaseBoard");
                listAvalableNamesManagmentObject("select * from Win32_Processor");
                listAvalableNamesManagmentObject("select * from Win32_OperatingSystem");
                listAvalableNamesManagmentObject("select * from Win32_VideoController");
                listAvalableNamesManagmentObject("select * from Win32_ProcessStartup");
            }
            toolStripProgressBar.Value = 0;

            toolStripProgressBar.Style = ProgressBarStyle.Marquee;

            if (settingsCheckComponents.Checked) {
                System.Drawing.Color okForeground = System.Drawing.Color.FromArgb(158, 235, 52);
                System.Drawing.Color okBackground = System.Drawing.Color.FromArgb(20, 145, 37);
                System.Drawing.Color notOkForeground = System.Drawing.Color.FromArgb(235, 76, 52);
                System.Drawing.Color notOkBackground = System.Drawing.Color.FromArgb(145, 20, 20);

                Label display;

                string status;
                string deviceQuerryResponce;
                string wmiClass;
                string deviceID;

                errorsFlexBox.Controls.Clear();

                // Get all devices and retrive their status
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select PartComponent from Win32_SystemDevices");
                foreach (ManagementObject share in searcher.Get())
                {
                    foreach (PropertyData PC in share.Properties)
                    {

                        if (PC.Value != null)
                        {
                            deviceQuerryResponce = PC.Value.ToString();
                            Console.WriteLine(deviceQuerryResponce.Split(':')[1]);

                            wmiClass = deviceQuerryResponce.Split(':')[1].Split('.')[0];
                            Console.WriteLine("Class : " + wmiClass);

                            deviceID = deviceQuerryResponce.Split(':')[1].Split('=')[1].Replace("\"", "'");
                            Console.WriteLine("Device id : " + deviceID);

                            try {
                                ManagementObject deviceInstance = new ManagementObject(wmiClass + ".DeviceID=" + deviceID);
                                deviceInstance.Get();

                                if (deviceInstance.GetPropertyValue("Status") != null) {
                                    toolStripStatusLabel.Name = "Diagnosing " + deviceInstance.GetPropertyValue("Name");

                                    status = deviceInstance.GetPropertyValue("Status").ToString();

                                    display = new Label();
                                    display.AutoSize = true;
                                    display.Text = deviceInstance.GetPropertyValue("Name") + " - " + status;
                                    display.Padding = new Padding(15);
                                    display.Margin = new Padding(5);

                                    if (status == "OK" || status == "")
                                    {
                                        display.ForeColor = okForeground;
                                        display.BackColor = okBackground;
                                    }
                                    else
                                    {
                                        display.ForeColor = notOkForeground;
                                        display.BackColor = notOkBackground;
                                    }

                                    errorsFlexBox.Controls.Add(display);
                                }
                            }
                            catch (Exception ex){ 
                            
                            }
                            

                            
                        }

                    }
                }
            }
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            toolStripStatusLabel.Text = "Ready";
        }

        private void GetRegistryFieldsAndInstertToList(RegistryKey registryKey, string prefix)
        {
            foreach (string fieldName in registryKey.GetValueNames())
            {
                startupListBox.Items.Add(prefix + " " + registryKey.GetValue(fieldName));
            }
        }

        private List<string> getManagmentObjectAsList(string sqlQuerry)
        {
            List<string> list = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(sqlQuerry);
            foreach (ManagementObject share in searcher.Get())
            {
                foreach (PropertyData PC in share.Properties)
                {

                    if (PC.Value != null)
                    {
                        list.Add(PC.Value.ToString());
                    }

                }
            }
            return list;
        }

        private void listAvalableNamesManagmentObject(string sqlQuerry)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(sqlQuerry);

            foreach (ManagementObject share in searcher.Get())
            {
                foreach (PropertyData PC in share.Properties)
                {

                    if (PC.Value != null)
                    {
                        eventsListBox.Items.Add("(" + sqlQuerry + ") " + PC.Name + " " + PC.Value.ToString());
                    }

                }
            }

        }

        private string getFieldFromManagment(string sqlQuerry)
        {
            ;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(sqlQuerry);
                foreach (ManagementObject share in searcher.Get())
                {
                    foreach (PropertyData propertyData in share.Properties)
                    {
                        if (propertyData.Value != null)
                        {
                            return propertyData.Value.ToString();
                        }
                    }
                }
                return "unknown";
            }
            catch (Exception ex)
            {
                return "unknown";
            }
        }

    }
}
