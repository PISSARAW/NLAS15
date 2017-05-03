using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLAS15
{
    public partial class CreerBenevole : Form
    {
        public CreerBenevole()
        {
            InitializeComponent();
        }

        private void personneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Réponse);

        }

        private void CreerBenevole_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.Réponse.Personne);

        }

        private void personneBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
