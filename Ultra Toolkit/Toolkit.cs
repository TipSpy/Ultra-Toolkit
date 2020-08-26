using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultra_Toolkit.Classes;
using System.ServiceProcess;
using System.Management;
using System.Diagnostics;

namespace Ultra_Toolkit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Logger.LogRTB = LogRTB;
            Logger.List("Welcome to Ultra Toolkit!");
            Logger.List("To begin, enter a hostname above!");

            serviceList.ColumnCount = 3;
            serviceList.Columns[0].Name = "Service";
            serviceList.Columns[1].Name = "Display Name";
            serviceList.Columns[2].Name = "Status";
            serviceList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            serviceList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static bool PingCheck(string hostname)
        {
            bool online = false;
            Ping sendping = null;

            try
            {
                sendping = new Ping();
                PingReply reply = sendping.Send(hostname);
                online = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
            finally
            {
                if (sendping != null)
                {
                    sendping.Dispose();
                }
            }

            return online;
        }

        public void initConnection()
        {
            if (hostname.Text != "")
            {
                Logger.Warning("Attempting to connect to '" + hostname.Text + "'");
                connectBtn.Enabled = false;
                connectBtn.Text = "Connecting...";
                hostname.Enabled = false;
                if (PingCheck(hostname.Text))
                {
                    Logger.Good("Connected to '" + hostname.Text + "'!");
                    connectBtn.Text = "Disconnect";
                    connectBtn.Enabled = true;
                    this.Text = "Ultra Toolkit | " + hostname.Text;
                }
                else
                {
                    Logger.Error("Could not connect to '" + hostname.Text + "'! Is the hostname correct?");
                    connectBtn.Enabled = true;
                    connectBtn.Text = "Connect";
                    hostname.Enabled = true;
                }
            }
        }

        public void StopRemoteService(string serviceName)
        {
            //Commands.RunPowershell("echo \"hi\"");
            //Commands.RunPowershell("(Get-WmiObject Win32_Service -ComputerName " + hostname.Text + " | ?{ $_.ProcessName -match '" + serviceName + "' }).Terminate()");
            Commands.RunPowershell("(Get-WmiObject -ComputerName " + hostname.Text + " -Class Win32_Service -Filter \\\"Name='" + serviceName + "'\\\").stopservice()");
        }
        public void StopRemoteProcess(string process)
        {
            Commands.RunPowershell("(Get-WmiObject Win32_Process -ComputerName " + hostname.Text + " | ?{ $_.ProcessName -match \\\"" + process + "\\\" }).Terminate()");
        }
        public void StartRemoteService(string serviceName)
        {
            Commands.RunPowershell("(Get-WmiObject Win32_Process -ComputerName " + hostname.Text + " | ?{ $_.ProcessName -match \\\"" + serviceName + "\\\" }).Start()");
        }

        public void RestartRemoteService(string serviceName)
        {
            Commands.RunPowershell("(Get-WmiObject Win32_Process -ComputerName " + hostname.Text + " | ?{ $_.ProcessName -match \\\"" + serviceName + "\\\" }).Restart()");
        }

        public void disconnect()
        {
            Logger.Warning("Disconnecting from '" + hostname.Text + "'");
            hostname.Enabled = true;
            connectBtn.Text = "Connect";
            Logger.Good("Disconnected from '" + hostname.Text + "'");
            this.Text = "Ultra Toolkit | Idle";
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (connectBtn.Text == "Connect")
            {
                initConnection();
            } else
            {
                disconnect();
            }
        }

        private void hostname_TextChanged(object sender, EventArgs e)
        {
            if (hostname.Text != "")
            {
                connectBtn.Enabled = true;
            } else
            {
                connectBtn.Enabled = false;
            }
        }

        private void damewareConnect_Click(object sender, EventArgs e)
        {
            // something using this ?
            // dwrcc.exe [-?|-?:] [-c:] [-h:] [-m:MachineName] [-u:UserName] [-p:Password | -p:"Password"] [-d:Domain] [-o:TCPport] [-s:SharedSecret] [-r:] [-vnc:] [-a:0|1|2] [-prxa:MRCproxyAddress] [-prxp:MRCproxyPort] [-prxsMRCproxySecret] [-v:] [-md:] [-i:n] [-x:] [-bh:CentralServerHostAddress] [-bpn: CentralServerPortNumber] [-bu:CentralServerUserName] [-bps:CentralServerUserPassword]
            Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -Name create -ArgumentList  'c:\\Program Files (x86)\\SolarWinds\\DameWare Remote Support\\DWRCC.exe -m:" + hostname.Text + "'");
            Logger.Good("Opening DameWare for '" + hostname.Text + "'");
        }

        private void rebootBTN_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("Restart-Computer –ComputerName " + hostname.Text + " -Force");
            Logger.Good("Rebooting '" + hostname.Text + "'!");
            Logger.Error("Disconnecting due to reboot!");
            disconnect();
        }

        private void killSarOps_Click(object sender, EventArgs e)
        {
            StopRemoteService("SarOpsWin32");
            Logger.Good("\"Kill SarOps\" Command sent!");
        }

        private void getServices_Click(object sender, EventArgs e)
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices(hostname.Text);

            // Display the list of services currently running on this computer.

            Logger.Log("Showing services list from '" + hostname.Text + "'");
            this.Size = new Size(1411, 651);
            this.CenterToScreen();
            serviceList.Rows.Clear();
            foreach (ServiceController scTemp in scServices)
            {
                string[] tmpRow = { scTemp.ServiceName, scTemp.DisplayName, scTemp.Status.ToString() };
                serviceList.Rows.Add(tmpRow);
            }
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            if (message.Text != "")
            {
                displayMessage.Enabled = true;
            } else
            {
                displayMessage.Enabled = false;
            }
        }

        private void displayMessage_Click(object sender, EventArgs e)
        {
            if (message.Text != "")
            {
                Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -ComputerName " + hostname.Text + " -Name create -ArgumentList  'c:\\windows\\system32\\msg.exe * " + message.Text + "'");
                Logger.Good("Displaying message on '" + hostname.Text + "'");
            } else
            {
                MessageBox.Show("Enter a message to display!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(664, 651);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1268, 651);
        }

        private void restartService_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedRows.Count > 0)
            {
                if (serviceList.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    Logger.Log("Selected service: " + serviceList.SelectedRows[0].Cells[0].Value.ToString());
                } else
                {
                    Logger.Error("You must select a service first!");
                }
            } else
            {
                Logger.Error("You must select a service first!");
            }
        }

        private void hideServicesList_Click(object sender, EventArgs e)
        {
            this.Size = new Size(681, 651);
            this.CenterToScreen();
        }

        private void stopService_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedRows.Count > 0)
            {
                if (serviceList.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    Logger.Log("Stopping service '" + serviceList.SelectedRows[0].Cells[0].Value.ToString() + "' on '" + hostname.Text + "'");
                    StopRemoteService(serviceList.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    Logger.Error("You must select a service first!");
                }
            }
            else
            {
                Logger.Error("You must select a service first!");
            }
        }

        private void startService_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedRows.Count > 0)
            {
                if (serviceList.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    Logger.Log("Starting service '" + serviceList.SelectedRows[0].Cells[0].Value.ToString() + "' on '" + hostname.Text + "'");
                    StartRemoteService(serviceList.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    Logger.Error("You must select a service first!");
                }
            }
            else
            {
                Logger.Error("You must select a service first!");
            }
        }

        private void LogRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void superCal_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -ComputerName " + hostname.Text + " -Name create -ArgumentList  'c:\\MICROS\\SuperCAL\\SuperCAL.exe'");
            Logger.Good("Launching SuperCAL on '" + hostname.Text + "'");
        }

        private void redownload_Click(object sender, EventArgs e)
        {
            StopRemoteService("SarOpsWin32");
            StopRemoteProcess("SuperStart");
            Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -ComputerName " + hostname.Text + " -Name create -ArgumentList  'c:\\MICROS\\SuperCAL\\SuperCAL.exe /redownload'");
            Logger.Good("Initiating Re-Download on '" + hostname.Text + "'");
        }

        private void startExplorer_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -ComputerName " + hostname.Text + " -Name create -ArgumentList  'c:\\Windows\\explorer.exe'");
            Logger.Good("Launching explorer.exe on '" + hostname.Text + "'");
        }

        private void startOps_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IMPLEMENT THIS RN! Find the path of the StartOps app.");
            //Commands.RunPowershell("Invoke-WmiMethod -Class win32_process -ComputerName " + hostname.Text + " -Name create -ArgumentList  'c:\\Windows\\explorer.exe'");
            Logger.Good("Launching OPS on '" + hostname.Text + "'");
        }

        private void restartFreedompay_Click(object sender, EventArgs e)
        {
            RestartRemoteService("MsrLibHost");
            Logger.Good("Restarting the FreedomPay Service on '" + hostname.Text + "'");
        }
    }
}
