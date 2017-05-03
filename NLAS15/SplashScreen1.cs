using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace NLAS15
{
    public partial class SplashScreen1 : SplashScreen
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        Timer tmr;
        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            tmr = new Timer();
            //mise en place de l'intervalle de temps avant changement
            tmr.Interval =0;
            //Début du chrono
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)

        {
            //après n sec stop
            tmr.Stop();
            //affichage de la page d'authentification
            Authentification mf = new Authentification();
            mf.Show();
            //Cacher cette page et la remplacer par la page d'authentification
            this.Hide();

        }

        private void SplashScreen1_Load_1(object sender, EventArgs e)
        {

        }
    }
}