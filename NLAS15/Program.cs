using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;

namespace NLAS15
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Authentification());
        }
    }

    public static class Connection
    {
        private static SqlConnection connexion;


        public static SqlConnection getConnection()
        {
            if (connexion == null)
                try
                {
                    connexion = new SqlConnection(@"Data Source=PROCAM-PC\HENRIP;Initial Catalog=ETP;Integrated Security=True");
                    //connexion.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            return connexion;

        }
        public static void close()
        {
            connexion.Close();
        }

    }

}
