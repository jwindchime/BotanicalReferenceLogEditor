using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BotanicalReferenceStandardsEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //The log may not be in the originally specified location
            try
            {
                Application.Run(new MainForm());
            }

            //If an exception is thrown, the program will search for the log starting from the application directory.
            catch
            {
                string[] results;
                Uri uriPath;

                //gets the directory of the Reference Log Editor application
                string searchPath = Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

                //The loop will run until the file is found or there are no more parent directories.
                while (searchPath != null)
                {
                    uriPath = new Uri(searchPath);
                    //results is an array that will contain all found instances of the search String in the given directory.
                    results = Directory.GetFiles(uriPath.LocalPath, "BotanicalReferenceLog.xlsx");
                    
                    //if results contains a match (and there should only be one)
                    if (results.Length > 0)
                    {
                        //Set the workbookPath string to the working path string
                        Properties.Settings.Default.workbookPath =
                            Path.GetFullPath(results[0]);
                        Properties.Settings.Default.Save();
                        
                        //the loop is no longer needed and the program can continue
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        //move up to the next parent directory for more searching
                        searchPath = Path.GetDirectoryName(searchPath);
                    }
                }
            }
        }
    }
}
