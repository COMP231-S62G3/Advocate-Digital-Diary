using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace advocate
{
    static class Program
    {
        public static string ConnectionString = "";
        public static bool ConnectionEstablished;

        public static int UserNo;
        public static string Password;
        public static string Permissions;
        public static string UserType;
        [STAThread]
        static void Main()
        {
            string strPath = Application.StartupPath + "\\DBConfig.CFG";

            if (File.Exists(strPath) == true)
            {
                FileStream FS = new FileStream(strPath, FileMode.Open);
                StreamReader SR = new StreamReader(FS);

                ConnectionString = SR.ReadToEnd();
                SR.Close();
                FS.Close();


                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    ConnectionEstablished = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    ConnectionEstablished = false;
                    MessageBox.Show("Application is not properly configured for database connectivity!", "File Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Application is not properly configured for database connectivity!", "File Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionEstablished = false;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
