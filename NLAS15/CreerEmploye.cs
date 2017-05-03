using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NLAS15
{
    public partial class CreerEmploye : Form
    {
        public CreerEmploye()
        {
            InitializeComponent();
        }



        

        private void Enom_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Epre_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Esex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enee_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Ea_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Eadd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Epost_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Eville_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Epays_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Etel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Emel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Abandonner_Click(object sender, EventArgs e)
        {
            
        }

        private void personneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Réponse);

        }

        private void CreerEmploye_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.Réponse.Personne);

        }

        private void prenom_personneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
