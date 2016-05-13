using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Rocket_Launcher
{
    public partial class Form1 : Form
    {
        private bool argFlag = false;
        private bool horizontal = false;
        private bool vertical = false;
        private bool borderless = true;

        private string screenWidth;
        private string screenHeight;
        private string userPath;
        private string settingsPath;
        private string exePath;
        private string preset;
        private string borderlessString;

        private Screen[] screens;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Substring(1) == "horizontal")
                {
                    horizontal = true;
                    argFlag = true;
                }
                else if (args[0].Substring(1) == "vertical")
                {
                    vertical = true;
                    argFlag = true;
                }
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check for version updates
            WebClient client = new WebClient();

            try
            {   //open the text file using a stream reader
                using (Stream stream = client.OpenRead("http://textuploader.com/5bk2v/raw"))
                {
                    StreamReader reader = new StreamReader(stream);
                    String latest = reader.ReadToEnd();

                    //MessageBox.Show(latest);
                    if (latest != VersionLinkLabel.Text.Substring(1))
                    {
                        DialogResult answer = MessageBox.Show("There is a new update available!\nDownload now?", "Update Found!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (answer == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/rex706/RocketLauncher");
                            Close();
                        }
                    }
                }
            }
            catch (Exception m)
            {
                //MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (!File.Exists("RocketSettings.txt"))
            {
                MessageBox.Show("No 'RocketSettings' file found! \nPlease locate RocketLeague.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string defaultPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\rocketleague\\Binaries\\Win32";
                string secondaryPath = "D:\\Program Files (x86)\\Steam\\steamapps\\common\\rocketleague\\Binaries\\Win32";

                OpenFileDialog exeDialog = new OpenFileDialog();
                exeDialog.Filter = "RocketLeague.exe (*.exe)|*.exe";
                exeDialog.FilterIndex = 1;
                exeDialog.Multiselect = false;

                if (Directory.Exists(defaultPath)) exeDialog.InitialDirectory = defaultPath;
                else if (Directory.Exists(secondaryPath)) exeDialog.InitialDirectory = secondaryPath;

                if (exeDialog.ShowDialog() == DialogResult.OK) exePath = exeDialog.FileName;
                else
                {
                    MessageBox.Show("You must select a valid game exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                //create settings file
                using (StreamWriter sw = File.CreateText(Directory.GetCurrentDirectory() + "\\RocketSettings.txt"))
                {
                    sw.WriteLine(exePath);
                    sw.WriteLine("\n");
                }
            }
            else
            {
                try
                {   //open the text file using a stream reader
                    using (StreamReader sr = new StreamReader("RocketSettings.txt"))
                    {
                        exePath = sr.ReadLine();
                        preset = sr.ReadLine();
                        borderlessString = sr.ReadLine();

                        if (borderlessString == "0")
                        {
                            borderless = false;
                            BorderlessCheckBox.Checked = false;
                        }
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //get settings path
            userPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                userPath = Directory.GetParent(userPath).ToString();
            }

            settingsPath = userPath + "\\Documents\\My Games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini";

            //get and set initial screen resolution
            screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            screens = Screen.AllScreens;

            XtextBox.Text = screenWidth;
            YtextBox.Text = screenHeight;

            if (preset == "h") HorizontalCheckBox.Checked = true;
            else if (preset == "v") VerticalCheckBox.Checked = true;

            if (argFlag == true)
            {
                if (horizontal == true) HorizontalCheckBox.Checked = true;
                else if (vertical == true) VerticalCheckBox.Checked = true;

                LaunchButton.PerformClick();
                Close();
            }

        }

        private void VerticalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VerticalCheckBox.Checked == true)
            {
                HorizontalCheckBox.Checked = false;

                for (int i = 0; i < screens.Length; i++)
                {
                    int tempH = screens[i].Bounds.Height;
                    int tempW = screens[i].Bounds.Width;

                    if (tempH < Int32.Parse(screenHeight) && tempW < Int32.Parse(screenWidth))
                    {
                        screenHeight = tempH.ToString();
                        screenWidth = tempW.ToString();
                    }
                }

                int doubleWidth = Int32.Parse(screenWidth) * 2;
                XtextBox.Text = doubleWidth.ToString();
                YtextBox.Text = screenHeight;
            }

            if (VerticalCheckBox.Checked == false)
            {
                XtextBox.Text = screenWidth;
            }
        }

        private void HorizontalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HorizontalCheckBox.Checked == true)
            {
                VerticalCheckBox.Checked = false;

                for (int i = 0; i < screens.Length; i++)
                {
                    int tempH = screens[i].Bounds.Height;
                    int tempW = screens[i].Bounds.Width;

                    if (tempH < Int32.Parse(screenHeight) && tempW < Int32.Parse(screenWidth))
                    {
                        screenHeight = tempH.ToString();
                        screenWidth = tempW.ToString();
                    }
                }

                int doubleHeight = Int32.Parse(screenHeight) * 2;
                XtextBox.Text = screenWidth;
                YtextBox.Text = doubleHeight.ToString();
            }

            if (HorizontalCheckBox.Checked == false)
            {
                YtextBox.Text = screenHeight;
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var settingsINI = new IniFile(settingsPath);

            if (borderless == true) settingsINI.Write("Borderless", "True", "SystemSettings");
            else settingsINI.Write("Borderless", "False", "SystemSettings");

            settingsINI.Write("ResX", XtextBox.Text, "SystemSettings");
            settingsINI.Write("ResY", YtextBox.Text, "SystemSettings");

            string[] arrLine = File.ReadAllLines("RocketSettings.txt");
            if (HorizontalCheckBox.Checked == true) arrLine[1] = "h";
            else if (VerticalCheckBox.Checked == true) arrLine[1] = "v";
            else arrLine[1] = "";
            if (BorderlessCheckBox.Checked == true) arrLine[2] = "1";
            else arrLine[2] = "0";
            File.WriteAllLines("RocketSettings.txt", arrLine);

            //get working directory from exePath variable
            int last_slash_idx = exePath.LastIndexOf('\\');
            string workingDirectory = exePath.Substring(0, last_slash_idx);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.FileName = exePath;
            startInfo.WorkingDirectory = workingDirectory;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.Arguments = parameters;

            try
            {
                //sart the process with the info specified and wait for close
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //link version number to git
        private void VersionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/rex706/RocketLauncher");
        }

        private void BorderlessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BorderlessCheckBox.Checked == true)
            {
                borderless = true;
            }
            else if (BorderlessCheckBox.Checked == false)
            {
                borderless = false;
            }
        }
    }
}
