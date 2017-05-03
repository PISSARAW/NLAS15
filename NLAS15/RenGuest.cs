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
    public partial class RenGuest : DevExpress.XtraEditors.XtraForm
    {
        public RenGuest()
        {
            InitializeComponent();
        }

        private void RenGuest_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'réponse.Visite'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteTableAdapter.Fill(this.réponse.Visite);
            // TODO: cette ligne de code charge les données dans la table 'réponse.Visite'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteTableAdapter.Fill(this.réponse.Visite);

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visiteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visiteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.réponse);

        }

        private void visiteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.visiteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.réponse);

        }
    }
}