using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
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
            eventsListBox.Items.Add("Starting diagnosis");

            toolStripProgressBar.Value = 1;

            GetRegistryFieldsAndInstertToList(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"), "[Current User-Run]");
            GetRegistryFieldsAndInstertToList(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), "[Current User-RunOnce]");
            eventsListBox.Items.Add("Got CurrentUser startup tasks.");
            GetRegistryFieldsAndInstertToList(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"), "[Local Machine-Run]");
            GetRegistryFieldsAndInstertToList(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"), "[Local Machine-RunOnce]");
            eventsListBox.Items.Add("Got LocalMachine startup tasks.");

            toolStripProgressBar.Value = 10;

            foreach (string startupFile in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup))) {
                startupListBox.Items.Add("[User-Startup] " + startupFile);
            };

            toolStripProgressBar.Value = 15;

            foreach (string startupFile in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)))
            {
                startupListBox.Items.Add("[Common-Startup] " + startupFile);
            };

            toolStripProgressBar.Value = 20;

            cpuLabel.Text = "CPU - " + getFieldFromManagment("select Name from Win32_Processor") + 
                "(" + getFieldFromManagment("select AddressWidth from Win32_Processor") + "bit) "
                + " | Manufacturer: " + getFieldFromManagment("select Manufacturer from Win32_Processor") 
                + " | " + getFieldFromManagment("select Caption from Win32_Processor")
                + " | Cache L1 " + getFieldFromManagment("select L1CacheSize from Win32_Processor") + " bytes"
                + " | Cache L2 " + getFieldFromManagment("select L2CacheSize from Win32_Processor") + " bytes"
                + " | Cache L3 " + getFieldFromManagment("select L3CacheSize from Win32_Processor") + " bytes";
            toolStripProgressBar.Value = 40;

            motherboardInfo.Text = "MOTHERBOARD - " + getFieldFromManagment("select Product from Win32_BaseBoard") + " | Manufacturer : " + getFieldFromManagment("select Manufacturer from Win32_BaseBoard") + " | Serial no. " + getFieldFromManagment("select SerialNumber from Win32_BaseBoard");
            toolStripProgressBar.Value = 60;

            listAvalableNamesManagmentObject("select * from Win32_ComputerSystem");
            listAvalableNamesManagmentObject("select * from Win32_BaseBoard");
            listAvalableNamesManagmentObject("select * from Win32_Processor");

            toolStripProgressBar.Value = 100;
        }

        private void GetRegistryFieldsAndInstertToList(RegistryKey registryKey, string prefix) {
            foreach (string fieldName in registryKey.GetValueNames())
            {
                startupListBox.Items.Add(prefix + " " + registryKey.GetValue(fieldName));
            }
        }

        private List<string> getManagmentObjectAsList(string sqlQuerry) {
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
                        eventsListBox.Items.Add("(" + sqlQuerry + ") " + PC.Name + " " +PC.Value.ToString());
                    }

                }
            }
            
        }

        private string getFieldFromManagment(string sqlQuerry) {
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
