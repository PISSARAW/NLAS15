using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace NLAS15
{
    public partial class VPortail : DevExpress.XtraEditors.XtraForm
    {
        SpeechSynthesizer p = new SpeechSynthesizer();

        public VPortail(string User)
        {
            InitializeComponent();
            userlab.Text = User;
            
        }

        

        private void stagbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void abobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox fm = new AboutBox(this);
            fm.Show();

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }



        private void VPortail_Load(object sender, EventArgs e)
        {
            p.SpeakAsync("Bienvenu à vous Mr " + userlab.Text + "Votre portail est prêt à être utiliser");
        }

        private void userlab_Click(object sender, EventArgs e)
        {

        }

        private void stagbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Stagiaire fm = new Stagiaire(this);
            fm.Show();
        }

        private void abobtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox fm = new AboutBox(this);
            fm.Show();
        }

        private void visbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visiteurs fm = new Visiteurs(this);
            fm.Show();
        }
    }
}

