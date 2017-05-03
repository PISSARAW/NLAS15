using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace NLAS15
{
    public partial class Authentification : DevExpress.XtraEditors.XtraForm
    {
        SpeechSynthesizer p = new SpeechSynthesizer();
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void connbtn_Click_1(object sender, EventArgs e)
        {
            //Utilisation des champs user.txt et mdp.text pour vérifier la connnexion
            if (usertxt.Text == "" || MdPtxt.Text == "")
            {
                p.SpeakAsync("Insérer le mot de passe et votre nom d'utilisateur");
                MessageBox.Show("Insérer le mot de passe et votre nom d'utilisateur");
                return;
            }
            try
            {
                //Creation d'une connexion SqlConnection
                SqlConnection con = Connection.getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Admin where Users=@user and Password=@Mdp", con);
                cmd.Parameters.AddWithValue("@user", usertxt.Text);
                cmd.Parameters.AddWithValue("@Mdp", MdPtxt.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    p.SpeakAsync("Connexion réussite");
                    MessageBox.Show("Connexion réussite");
                    this.Hide();
                    VPortail fm = new VPortail(usertxt.Text);
                    fm.Show();
                }
                else
                {
                    p.SpeakAsync("La connexion a échoué");
                    MessageBox.Show("La connexion a échoué");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }
    }
}
