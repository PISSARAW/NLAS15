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
    public partial class CreerStag : DevExpress.XtraEditors.XtraForm
    {
        public CreerStag()
        {
            InitializeComponent();
        }

        

        private void personneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // système de validation des données
            this.Validate();
            this.personneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Réponse);

        }

        private void CreerStag_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Stage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Ligue'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligueTableAdapter.Fill(this.Réponse.Ligue);
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.Réponse.Personne);

        }

        private void nom_personneTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void personneBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}