namespace NLAS15
{
    partial class RenBenevole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenBenevole));
            System.Windows.Forms.Label date2Debut_benevoleLabel;
            System.Windows.Forms.Label date2Fin_benevoleLabel;
            System.Windows.Forms.Label association_benevoleLabel;
            System.Windows.Forms.Label personne_idLabel;
            System.Windows.Forms.Label ligue_idLabel;
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.réponse = new NLAS15.Réponse();
            this.benevoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benevoleTableAdapter = new NLAS15.RéponseTableAdapters.BenevoleTableAdapter();
            this.tableAdapterManager = new NLAS15.RéponseTableAdapters.TableAdapterManager();
            this.benevoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.benevoleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.date2Debut_benevoleDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.date2Fin_benevoleDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.association_benevoleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.personne_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ligue_idComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            date2Debut_benevoleLabel = new System.Windows.Forms.Label();
            date2Fin_benevoleLabel = new System.Windows.Forms.Label();
            association_benevoleLabel = new System.Windows.Forms.Label();
            personne_idLabel = new System.Windows.Forms.Label();
            ligue_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benevoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benevoleBindingNavigator)).BeginInit();
            this.benevoleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date2Debut_benevoleDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Debut_benevoleDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Fin_benevoleDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Fin_benevoleDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.association_benevoleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personne_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligue_idComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.BackColor = System.Drawing.Color.White;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(1, 42);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(839, 290);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(839, 290);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Renseignements";
            this.tabNavigationPage1.Controls.Add(date2Debut_benevoleLabel);
            this.tabNavigationPage1.Controls.Add(this.date2Debut_benevoleDateEdit);
            this.tabNavigationPage1.Controls.Add(date2Fin_benevoleLabel);
            this.tabNavigationPage1.Controls.Add(this.date2Fin_benevoleDateEdit);
            this.tabNavigationPage1.Controls.Add(association_benevoleLabel);
            this.tabNavigationPage1.Controls.Add(this.association_benevoleTextEdit);
            this.tabNavigationPage1.Controls.Add(personne_idLabel);
            this.tabNavigationPage1.Controls.Add(this.personne_idSpinEdit);
            this.tabNavigationPage1.Controls.Add(ligue_idLabel);
            this.tabNavigationPage1.Controls.Add(this.ligue_idComboBoxEdit);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(821, 245);
            // 
            // réponse
            // 
            this.réponse.DataSetName = "Réponse";
            this.réponse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benevoleBindingSource
            // 
            this.benevoleBindingSource.DataMember = "Benevole";
            this.benevoleBindingSource.DataSource = this.réponse;
            // 
            // benevoleTableAdapter
            // 
            this.benevoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BenevoleTableAdapter = this.benevoleTableAdapter;
            this.tableAdapterManager.LigueTableAdapter = null;
            this.tableAdapterManager.PersonnelTableAdapter = null;
            this.tableAdapterManager.PersonneTableAdapter = null;
            this.tableAdapterManager.StageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NLAS15.RéponseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisiteTableAdapter = null;
            this.tableAdapterManager.VisiteurTableAdapter = null;
            // 
            // benevoleBindingNavigator
            // 
            this.benevoleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.benevoleBindingNavigator.BindingSource = this.benevoleBindingSource;
            this.benevoleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.benevoleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.benevoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.benevoleBindingNavigatorSaveItem});
            this.benevoleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.benevoleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.benevoleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.benevoleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.benevoleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.benevoleBindingNavigator.Name = "benevoleBindingNavigator";
            this.benevoleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.benevoleBindingNavigator.Size = new System.Drawing.Size(840, 25);
            this.benevoleBindingNavigator.TabIndex = 6;
            this.benevoleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // benevoleBindingNavigatorSaveItem
            // 
            this.benevoleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.benevoleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("benevoleBindingNavigatorSaveItem.Image")));
            this.benevoleBindingNavigatorSaveItem.Name = "benevoleBindingNavigatorSaveItem";
            this.benevoleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.benevoleBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.benevoleBindingNavigatorSaveItem.Click += new System.EventHandler(this.benevoleBindingNavigatorSaveItem_Click);
            // 
            // date2Debut_benevoleLabel
            // 
            date2Debut_benevoleLabel.AutoSize = true;
            date2Debut_benevoleLabel.Location = new System.Drawing.Point(22, 56);
            date2Debut_benevoleLabel.Name = "date2Debut_benevoleLabel";
            date2Debut_benevoleLabel.Size = new System.Drawing.Size(135, 13);
            date2Debut_benevoleLabel.TabIndex = 0;
            date2Debut_benevoleLabel.Text = "Début de service bénévole";
            // 
            // date2Debut_benevoleDateEdit
            // 
            this.date2Debut_benevoleDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.benevoleBindingSource, "Date2Debut_benevole", true));
            this.date2Debut_benevoleDateEdit.EditValue = null;
            this.date2Debut_benevoleDateEdit.Location = new System.Drawing.Point(166, 53);
            this.date2Debut_benevoleDateEdit.Name = "date2Debut_benevoleDateEdit";
            this.date2Debut_benevoleDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2Debut_benevoleDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2Debut_benevoleDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2Debut_benevoleDateEdit.TabIndex = 1;
            // 
            // date2Fin_benevoleLabel
            // 
            date2Fin_benevoleLabel.AutoSize = true;
            date2Fin_benevoleLabel.Location = new System.Drawing.Point(482, 56);
            date2Fin_benevoleLabel.Name = "date2Fin_benevoleLabel";
            date2Fin_benevoleLabel.Size = new System.Drawing.Size(73, 13);
            date2Fin_benevoleLabel.TabIndex = 2;
            date2Fin_benevoleLabel.Text = "Fin du service";
            // 
            // date2Fin_benevoleDateEdit
            // 
            this.date2Fin_benevoleDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.benevoleBindingSource, "Date2Fin_benevole", true));
            this.date2Fin_benevoleDateEdit.EditValue = null;
            this.date2Fin_benevoleDateEdit.Location = new System.Drawing.Point(604, 53);
            this.date2Fin_benevoleDateEdit.Name = "date2Fin_benevoleDateEdit";
            this.date2Fin_benevoleDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2Fin_benevoleDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2Fin_benevoleDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2Fin_benevoleDateEdit.TabIndex = 3;
            // 
            // association_benevoleLabel
            // 
            association_benevoleLabel.AutoSize = true;
            association_benevoleLabel.Location = new System.Drawing.Point(22, 111);
            association_benevoleLabel.Name = "association_benevoleLabel";
            association_benevoleLabel.Size = new System.Drawing.Size(61, 13);
            association_benevoleLabel.TabIndex = 4;
            association_benevoleLabel.Text = "Association";
            // 
            // association_benevoleTextEdit
            // 
            this.association_benevoleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.benevoleBindingSource, "Association_benevole", true));
            this.association_benevoleTextEdit.Location = new System.Drawing.Point(166, 108);
            this.association_benevoleTextEdit.Name = "association_benevoleTextEdit";
            this.association_benevoleTextEdit.Size = new System.Drawing.Size(100, 20);
            this.association_benevoleTextEdit.TabIndex = 5;
            // 
            // personne_idLabel
            // 
            personne_idLabel.AutoSize = true;
            personne_idLabel.Location = new System.Drawing.Point(22, 168);
            personne_idLabel.Name = "personne_idLabel";
            personne_idLabel.Size = new System.Drawing.Size(57, 13);
            personne_idLabel.TabIndex = 6;
            personne_idLabel.Text = "Identifiant";
            // 
            // personne_idSpinEdit
            // 
            this.personne_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.benevoleBindingSource, "personne_id", true));
            this.personne_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.personne_idSpinEdit.Location = new System.Drawing.Point(166, 165);
            this.personne_idSpinEdit.Name = "personne_idSpinEdit";
            this.personne_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personne_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.personne_idSpinEdit.TabIndex = 7;
            // 
            // ligue_idLabel
            // 
            ligue_idLabel.AutoSize = true;
            ligue_idLabel.Location = new System.Drawing.Point(482, 168);
            ligue_idLabel.Name = "ligue_idLabel";
            ligue_idLabel.Size = new System.Drawing.Size(79, 13);
            ligue_idLabel.TabIndex = 8;
            ligue_idLabel.Text = "Nom de la ligue";
            // 
            // ligue_idComboBoxEdit
            // 
            this.ligue_idComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.benevoleBindingSource, "ligue_id", true));
            this.ligue_idComboBoxEdit.Location = new System.Drawing.Point(604, 161);
            this.ligue_idComboBoxEdit.Name = "ligue_idComboBoxEdit";
            this.ligue_idComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ligue_idComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.ligue_idComboBoxEdit.TabIndex = 9;
            // 
            // RenBenevole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 332);
            this.Controls.Add(this.benevoleBindingNavigator);
            this.Controls.Add(this.tabPane1);
            this.Name = "RenBenevole";
            this.Text = "RenBenevole";
            this.Load += new System.EventHandler(this.RenBenevole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benevoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benevoleBindingNavigator)).EndInit();
            this.benevoleBindingNavigator.ResumeLayout(false);
            this.benevoleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date2Debut_benevoleDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Debut_benevoleDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Fin_benevoleDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Fin_benevoleDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.association_benevoleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personne_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligue_idComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private Réponse réponse;
        private System.Windows.Forms.BindingSource benevoleBindingSource;
        private RéponseTableAdapters.BenevoleTableAdapter benevoleTableAdapter;
        private RéponseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator benevoleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton benevoleBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.DateEdit date2Debut_benevoleDateEdit;
        private DevExpress.XtraEditors.DateEdit date2Fin_benevoleDateEdit;
        private DevExpress.XtraEditors.TextEdit association_benevoleTextEdit;
        private DevExpress.XtraEditors.SpinEdit personne_idSpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ligue_idComboBoxEdit;
    }
}