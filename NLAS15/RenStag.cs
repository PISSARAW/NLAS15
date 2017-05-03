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
using System.Data.SqlClient;

namespace NLAS15
{
    public partial class RenStag : DevExpress.XtraEditors.XtraForm
    {
        public RenStag()
        {
            InitializeComponent();
        }

        private void RenStag_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'réponse.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.réponse.Personne);
            // TODO: cette ligne de code charge les données dans la table 'réponse.Stage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.stageTableAdapter.Fill(this.réponse.Stage);
            // TODO: cette ligne de code charge les données dans la table 'réponse.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.réponse.Personne);
            // TODO: cette ligne de code charge les données dans la table 'réponse.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
          

        }


        private void stageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.réponse);

        }

        private void personne_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette commande retrouve les personne ayant un type Stagiaire
            SqlCommand cmd = new SqlCommand("SELECT Stage.personne_id FROM Stage CROSS JOIN Personne WHERE(Personne.Type = @Stagiaire)");
            cmd.Parameters.AddWithValue("@Stagiaire", "Stagiaire");
        }

        private void ligue_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette commande Retrouve les ligues
            SqlCommand cmd = new SqlCommand("SELECT Stage.ligue_id FROM Stage CROSS JOIN Ligue");
           
        }

        private void stageBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
