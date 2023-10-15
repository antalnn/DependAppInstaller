using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using CheckBox = System.Windows.Forms.CheckBox;

namespace DependAppInstaller
{
    public partial class Form1 : Form
    {
        #region vars
        private int index = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region installation
        private void installBtn_Click(object sender, EventArgs e)
        {
            installBtn.Enabled = false;
            installPackages();
        }

        /// <summary>
        /// To install a package
        /// </summary>
        /// <param name="link">Link where to download the file from</param>
        /// <param name="name">Name of the file</param>
        /// <param name="extension">Extension of the file (exe, zip, rar, ...)</param>
        private void installPackage(string link, string name, string extension = "exe")
        {
            if(extension.Contains("zip") || extension.Contains("rar"))
            {
                MessageBox.Show($"You will have to install the file from {name}.{extension} manually, and close it afterward to continue with the installation of other packages.");
            }

            string filePath = Application.StartupPath + $"\\{name}.{extension}";

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) // Check if connected to the internet
            {
                if (!File.Exists(filePath))
                {
                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        Log($"Installing {name}...");
                        client.DownloadFile(
                        new Uri(link),
                        filePath);
                    }
                }

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = filePath
                    }
                };
                try
                {
                    process.Start();
                    try
                    {
                        process.WaitForExit();
                        Log("Done.");
                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            Log("You have to delete the cache manually, as the program does not have sufficient permissions.");
                        }
                    }
                    catch(InvalidOperationException)
                    {
                        Log("The specified executable is not a valid application for this OS platform.");
                        Log("Failed.");
                    }
                }
                catch (Win32Exception ex)
                {
                    Log(ex.ToString());
                }
            }
            else
            {
                Log("Access to the internet is required.");
            }
        }

        /// <summary>
        /// Runs/installs all the packages/files
        /// </summary>
        /// <param name="path"></param>
        private void installPackages()
        {
            foreach (Control container in new Control[] { groupBox1, groupBox2 })
            {
                foreach (Control control in container.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox check = (CheckBox)control;

                        if (check.Checked)
                        {
                            switch (check.Text)
                            {
                                case "Visual Studio 2022":
                                    installPackage("https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030:8bf9b352f8cf44d285d2dd7cc9287733", check.Text, "exe");
                                    break;
                                case "IDA Pro":
                                    installPackage("link", check.Text, "zip");
                                    break;
                                case "HxD":
                                    installPackage("https://mh-nexus.de/downloads/HxDSetup.zip", check.Text, "zip");
                                    break;
                                case "Cheat Engine":
                                    installPackage("https://d1vdn3r1396bak.cloudfront.net/installer/64819247198774119/26116644", check.Text, "exe");
                                    break;
                                case "GitHub Desktop":
                                    installPackage("https://desktop.githubusercontent.com/github-desktop/releases/3.3.3-abf8a692/GitHubDesktopSetup-x64.exe", check.Text, "exe");
                                    break;
                                case "AIO Runtimes":
                                    installPackage("https://media.computerbase.de/s/b-71ks16U3QerSsykCxX0A/1697389654/download/758/aio-runtimes_v2.5.0.exe", check.Text, "exe");
                                    break;
                                case "Discord":
                                    installPackage("https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9019/DiscordSetup.exe", check.Text, "exe");
                                    break;
                            }
                        }
                    }
                }
            }
            Log("Installation finished.");
            installBtn.Enabled = true;
        }
        #endregion

        #region logging

        /// <summary>
        /// Sends a message to the log box
        /// </summary>
        /// <param name="message">Your message</param>
        private void Log(string message)
        {
            logBox.Text += "\r\n";
            logBox.Text += message;
        }

        /// <summary>
        /// Will automatically scroll the log box
        /// </summary>
        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }
        #endregion

        #region others
        private void selectionCheckBox(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                index++;
            }
            else
            {
                index--;
            }

            if (index > 0) // If at least one package selected
            {
                logBox.Text = $"Click 'Install' button to install {index} packages.";
                logBox.ReadOnly = false;
                installBtn.Enabled = true;
            }
            else // If no package is selected
            {
                logBox.Text = "Select at least one package.";
                logBox.ReadOnly = true;
                installBtn.Enabled = false;
            }
        }

        private void aboutToolStripItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a tool to help you install important things at once when you reinstall your OS.\n\n" +
                            "github.com/antalnn");
        }
        #endregion
    }
}