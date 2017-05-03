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
    public partial class RenBenevole : DevExpress.XtraEditors.XtraForm
    {
        public RenBenevole()
        {
            InitializeComponent();

        }



        private void benevoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.benevoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.réponse);

        }

        private void RenBenevole_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'réponse.Benevole'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.benevoleTableAdapter.Fill(this.réponse.Benevole);

        }
    }
}