using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_Launcher
{
    public partial class MainForm : Form
    {
        #region Variables

        private bool argFlag = false;
        private bool horizontal = false;
        private bool vertical = false;

        private string screenWidth;
        private string screenHeight;
        private string userPath;
        private string settingsPath;
        private string exePath;
        private string split;
        private string WindowString;

        private static Version latest;

        private Screen[] screens;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string[] args)
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

        #endregion

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //verion number from assembly
            string AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            int idx = AssemblyVersion.IndexOf('0') - 1;
            AssemblyVersion = AssemblyVersion.Substring(0, idx);
            VersionLinkLabel.Text = "v" + AssemblyVersion;

            //Check for a new version.
            int updateResult = await CheckForUpdate();
            if (updateResult == -1)
            {
                //Some Error occurred.
                //TODO: Handle this Error.
            }
            else if (updateResult == 1)
            {
                //An update is available, but user has chosen not to update.
                VersionLinkLabel.LinkColor = Color.Red;
                VersionLinkLabel.Text = "v" + latest + "\nupdate\navailable!";
            }
            else if (updateResult == 2)
            {
                //An update is available, and the user has chosen to update.
                //TODO: Exit the application. Later, initiate a process that downloads new updated binaries.
                Close();
            }

            if (!File.Exists("RocketSettings.ini"))
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
                var RocketSettings = new IniFile("RocketSettings.ini");

                RocketSettings.Write("Path", exePath, "Settings");
                RocketSettings.Write("Split", "", "Settings");
                RocketSettings.Write("Window", "", "Settings");
                RocketSettings.Write("ResX", "", "Settings");
                RocketSettings.Write("ResY", "", "Settings");
            }
            else
            {
                try
                {
                    //open the text file using a stream reader
                    var RocketSettings = new IniFile("RocketSettings.ini");

                    exePath = RocketSettings.Read("Path", "Settings");
                    split = RocketSettings.Read("Split", "Settings");
                    WindowString = RocketSettings.Read("Window", "Settings");

                    if (WindowString == "Borderless")
                    {
                        BorderlessCheckBox.Checked = true;
                    }
                    else if (WindowString == "Fullscreen")
                    {
                        FullscreenCheckBox.Checked = true;
                    }
                    else if (WindowString == "Windowed")
                    {
                        WindowedCheckBox.Checked = true;
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

            var RocketSettings1 = new IniFile("RocketSettings.ini");

            string tempX = RocketSettings1.Read("ResX", "Settings");
            string tempY = RocketSettings1.Read("ResY", "Settings");

            if (tempX == "" && tempY == "")
            {
                XtextBox.Text = screenWidth;
                YtextBox.Text = screenHeight;
            }
            else
            {
                XtextBox.Text = tempX;
                YtextBox.Text = tempY;

                SaveResCheckBox.Checked = true;
            }

            if (split == "Horizontal") HorizontalCheckBox.Checked = true;
            else if (split == "Vertical") VerticalCheckBox.Checked = true;

            if (argFlag == true)
            {
                if (horizontal == true) HorizontalCheckBox.Checked = true;
                else if (vertical == true) VerticalCheckBox.Checked = true;

                LaunchButton.PerformClick();
                Close();
            }

            //bring window to front / give active focus (BrintToFront() and Focus() would not work for some reason)
            Activate();
        }

        #region Check Boxes

        //split checkboxes
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

        //window checkboxes
        private void BorderlessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BorderlessCheckBox.Checked == true)
            {
                FullscreenCheckBox.Checked = false;
                WindowedCheckBox.Checked = false;
            }
        }

        private void WindowedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowedCheckBox.Checked == true)
            {
                BorderlessCheckBox.Checked = false;
                FullscreenCheckBox.Checked = false;
            }
        }

        private void FullscreenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FullscreenCheckBox.Checked == true)
            {
                BorderlessCheckBox.Checked = false;
                WindowedCheckBox.Checked = false;
            }
        }

        private void SaveResCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var settingsINI = new IniFile(settingsPath);
            var RocketSettings = new IniFile("RocketSettings.ini");

            if (BorderlessCheckBox.Checked == true) settingsINI.Write("Borderless", "True", "SystemSettings");
            else settingsINI.Write("Borderless", "False", "SystemSettings");
            if (FullscreenCheckBox.Checked == true) settingsINI.Write("Fullscreen", "True", "SystemSettings");
            else settingsINI.Write("Fullscreen", "False", "SystemSettings");
            if (WindowedCheckBox.Checked == true)
            {
                //might not need this if statement
                settingsINI.Write("Fullscreen", "False", "SystemSettings");
                settingsINI.Write("Borderless", "False", "SystemSettings");
            }

            settingsINI.Write("ResX", XtextBox.Text, "SystemSettings");
            settingsINI.Write("ResY", YtextBox.Text, "SystemSettings");

            if (HorizontalCheckBox.Checked == true) RocketSettings.Write("Split", "Horizontal", "Settings");
            else if (VerticalCheckBox.Checked == true) RocketSettings.Write("Split", "Vertical", "Settings");
            else RocketSettings.Write("Split", "", "Settings");
            if (BorderlessCheckBox.Checked == true) RocketSettings.Write("Window", "Borderless", "Settings");
            else if (FullscreenCheckBox.Checked == true) RocketSettings.Write("Window", "Fullscreen", "Settings");
            else if (WindowedCheckBox.Checked == true) RocketSettings.Write("Window", "Windowed", "Settings");

            if(SaveResCheckBox.Checked == true)
            {
                RocketSettings.Write("ResX", XtextBox.Text, "Settings");
                RocketSettings.Write("ResY", YtextBox.Text, "Settings");
            }
            else
            {
                RocketSettings.Write("ResX", "", "Settings");
                RocketSettings.Write("ResY", "", "Settings");
            }

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

        //Checks if an update is available. 
        //-1 for check Error, 0 for no update, 1 for update is available, 2 for perform update.
        private static async Task<int> CheckForUpdate()
        {
            //Nkosi Note: Always use asynchronous versions of network and IO methods.

            //Check for version updates
            var client = new HttpClient();
            client.Timeout = new TimeSpan(0, 0, 0, 10);
            try
            {
                //open the text file using a stream reader
                using (Stream stream = await client.GetStreamAsync("http://textuploader.com/5bk2v/raw"))
                {
                    Version current = Assembly.GetExecutingAssembly().GetName().Version;
                    StreamReader reader = new StreamReader(stream);
                    latest = Version.Parse(reader.ReadToEnd());

                    if (latest != current)
                    {
                        DialogResult answer = MessageBox.Show("A new version of RocketLauncher is available!\n\nCurrent Version     " + current + "\nLatest Version     " + latest + "\n\nUpdate Now?", "RocketLauncher Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (answer == DialogResult.Yes)
                        {
                            //TODO: Later on, remove this and replace with automated process of downloading new binaries.
                            Process.Start("https://github.com/rex706/RocketLauncher");
                            //Update is available, and user wants to update. Requires app to close.
                            return 2;
                        }

                        //Update is available, but user chose not to update just yet.
                        return 1;
                    }
                }

                //No update available.
                return 0;
            }
            catch (Exception m)
            {
                //MessageBox.Show("Failed to check for update.\n" + m.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
