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

namespace NLAS15
{
    public partial class CreerGuest : DevExpress.XtraEditors.XtraForm
    {
        public CreerGuest()
        {
            InitializeComponent();
        }

        private void personneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Réponse);

        }

        private void CreerGuest_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nLAS.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.Réponse.Personne);

        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}