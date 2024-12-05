using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using System.Threading.Channels;
using System.Windows.Forms;

namespace ApplicationPoolUpdater
{
    /// <summary>
    /// on windows: to use this app, you should add the APPCMD.EXE path file
    /// to the environment variables
    /// To do so, follow the steps below:
    /// -Right click on "This PC" or "My Computer" and select "Properties."
    /// -Select "Advanced system settings" in the left panel.
    /// -Click the "Environment Variables" button.
    /// -Find the "PATH" variable in the list of system variables and click "Edit."
    /// -Add the path of the folder containing the "appcmd.exe" file to the end of the list of paths, separating them with a semicolon(;).
    /// -The appcmd.exe file is usually located in the folder "C:\Windows\System32\inetsrv"
    /// -Click "OK" to save the changes.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = UpdatePassword(UserNameTBox.Text, PasswordTBox.Text);
        }

        private static string UpdatePassword(string userName, string password)
        {
            //application pool list
            var applicationPools = new string[] { "DMDC Admin", "DMDC Auth", "DMDC Internal Services", "DMDC Marketing", "DMDC Mobile", "DMDC Platform", "DMDC Portal", "DMDC Static" };

            string finalMessage = "";

            foreach (string pool in applicationPools)
            {
                //Batch command
                string command = $"appcmd set apppool /apppool.name:\"{pool}\" /processModel.userName:{userName} /processModel.password:{password}";
                var (cmdResult, output) = RunCmdCommand(command);

                if (cmdResult == 0)
                    finalMessage = string.Concat(finalMessage, $"{pool}: Updated | ");
                else
                    finalMessage = string.Concat(finalMessage, $"{pool}: Error-> {output} | ");
            }

            return finalMessage;
        }

        private static Tuple<int, string> RunCmdCommand(string comando)
        {
            int cmdResult = -1;
            string output = "";

            try
            {
                //Prepare process
                ProcessStartInfo startInfo = new("cmd.exe", $"/c {comando}")
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                };

                //Create process obj
                Process process = new()
                {
                    StartInfo = startInfo
                };

                //Execute command in cmd
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                //0 Execution succeeded
                cmdResult = process.ExitCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Tuple.Create(cmdResult, output);
        }
    }
}