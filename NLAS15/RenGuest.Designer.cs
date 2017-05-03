namespace NLAS15
{
    partial class RenGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenGuest));
            System.Windows.Forms.Label date2VisiteLabel;
            System.Windows.Forms.Label heure2VisiteLabel;
            System.Windows.Forms.Label personne_idLabel;
            System.Windows.Forms.Label ligue_idLabel;
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.réponse = new NLAS15.Réponse();
            this.visiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteTableAdapter = new NLAS15.RéponseTableAdapters.VisiteTableAdapter();
            this.tableAdapterManager = new NLAS15.RéponseTableAdapters.TableAdapterManager();
            this.visiteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.visiteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.date2VisiteDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.heure2VisiteTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.personne_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ligue_idComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            date2VisiteLabel = new System.Windows.Forms.Label();
            heure2VisiteLabel = new System.Windows.Forms.Label();
            personne_idLabel = new System.Windows.Forms.Label();
            ligue_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingNavigator)).BeginInit();
            this.visiteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date2VisiteDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2VisiteDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heure2VisiteTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personne_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligue_idComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.BackColor = System.Drawing.Color.White;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(-1, 31);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(839, 276);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(839, 276);
            this.tabPane1.TabIndex = 3;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Renseignements";
            this.tabNavigationPage1.Controls.Add(date2VisiteLabel);
            this.tabNavigationPage1.Controls.Add(this.date2VisiteDateEdit);
            this.tabNavigationPage1.Controls.Add(heure2VisiteLabel);
            this.tabNavigationPage1.Controls.Add(this.heure2VisiteTimeEdit);
            this.tabNavigationPage1.Controls.Add(personne_idLabel);
            this.tabNavigationPage1.Controls.Add(this.personne_idSpinEdit);
            this.tabNavigationPage1.Controls.Add(ligue_idLabel);
            this.tabNavigationPage1.Controls.Add(this.ligue_idComboBoxEdit);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(821, 231);
            // 
            // réponse
            // 
            this.réponse.DataSetName = "Réponse";
            this.réponse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteBindingSource
            // 
            this.visiteBindingSource.DataMember = "Visite";
            this.visiteBindingSource.DataSource = this.réponse;
            // 
            // visiteTableAdapter
            // 
            this.visiteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BenevoleTableAdapter = null;
            this.tableAdapterManager.LigueTableAdapter = null;
            this.tableAdapterManager.PersonnelTableAdapter = null;
            this.tableAdapterManager.PersonneTableAdapter = null;
            this.tableAdapterManager.StageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NLAS15.RéponseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisiteTableAdapter = this.visiteTableAdapter;
            this.tableAdapterManager.VisiteurTableAdapter = null;
            // 
            // visiteBindingNavigator
            // 
            this.visiteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visiteBindingNavigator.BindingSource = this.visiteBindingSource;
            this.visiteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visiteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visiteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.visiteBindingNavigatorSaveItem});
            this.visiteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visiteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visiteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visiteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visiteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visiteBindingNavigator.Name = "visiteBindingNavigator";
            this.visiteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visiteBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.visiteBindingNavigator.TabIndex = 4;
            this.visiteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // visiteBindingNavigatorSaveItem
            // 
            this.visiteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visiteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visiteBindingNavigatorSaveItem.Image")));
            this.visiteBindingNavigatorSaveItem.Name = "visiteBindingNavigatorSaveItem";
            this.visiteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.visiteBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.visiteBindingNavigatorSaveItem.Click += new System.EventHandler(this.visiteBindingNavigatorSaveItem_Click_1);
            // 
            // date2VisiteLabel
            // 
            date2VisiteLabel.AutoSize = true;
            date2VisiteLabel.Location = new System.Drawing.Point(16, 67);
            date2VisiteLabel.Name = "date2VisiteLabel";
            date2VisiteLabel.Size = new System.Drawing.Size(84, 13);
            date2VisiteLabel.TabIndex = 2;
            date2VisiteLabel.Text = "Date de la visite";
            // 
            // date2VisiteDateEdit
            // 
            this.date2VisiteDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.visiteBindingSource, "Date2Visite", true));
            this.date2VisiteDateEdit.EditValue = null;
            this.date2VisiteDateEdit.Location = new System.Drawing.Point(138, 63);
            this.date2VisiteDateEdit.Name = "date2VisiteDateEdit";
            this.date2VisiteDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2VisiteDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2VisiteDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2VisiteDateEdit.TabIndex = 3;
            // 
            // heure2VisiteLabel
            // 
            heure2VisiteLabel.AutoSize = true;
            heure2VisiteLabel.Location = new System.Drawing.Point(495, 71);
            heure2VisiteLabel.Name = "heure2VisiteLabel";
            heure2VisiteLabel.Size = new System.Drawing.Size(90, 13);
            heure2VisiteLabel.TabIndex = 4;
            heure2VisiteLabel.Text = "Heure de la visite";
            // 
            // heure2VisiteTimeEdit
            // 
            this.heure2VisiteTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.visiteBindingSource, "Heure2Visite", true));
            this.heure2VisiteTimeEdit.EditValue = new System.DateTime(2016, 5, 25, 0, 0, 0, 0);
            this.heure2VisiteTimeEdit.Location = new System.Drawing.Point(602, 68);
            this.heure2VisiteTimeEdit.Name = "heure2VisiteTimeEdit";
            this.heure2VisiteTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heure2VisiteTimeEdit.Size = new System.Drawing.Size(100, 20);
            this.heure2VisiteTimeEdit.TabIndex = 5;
            // 
            // personne_idLabel
            // 
            personne_idLabel.AutoSize = true;
            personne_idLabel.Location = new System.Drawing.Point(16, 133);
            personne_idLabel.Name = "personne_idLabel";
            personne_idLabel.Size = new System.Drawing.Size(57, 13);
            personne_idLabel.TabIndex = 6;
            personne_idLabel.Text = "Identifiant";
            // 
            // personne_idSpinEdit
            // 
            this.personne_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.visiteBindingSource, "personne_id", true));
            this.personne_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.personne_idSpinEdit.Location = new System.Drawing.Point(138, 129);
            this.personne_idSpinEdit.Name = "personne_idSpinEdit";
            this.personne_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personne_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.personne_idSpinEdit.TabIndex = 7;
            // 
            // ligue_idLabel
            // 
            ligue_idLabel.AutoSize = true;
            ligue_idLabel.Location = new System.Drawing.Point(495, 133);
            ligue_idLabel.Name = "ligue_idLabel";
            ligue_idLabel.Size = new System.Drawing.Size(79, 13);
            ligue_idLabel.TabIndex = 8;
            ligue_idLabel.Text = "Nom de la ligue";
            // 
            // ligue_idComboBoxEdit
            // 
            this.ligue_idComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.visiteBindingSource, "ligue_id", true));
            this.ligue_idComboBoxEdit.Location = new System.Drawing.Point(602, 130);
            this.ligue_idComboBoxEdit.Name = "ligue_idComboBoxEdit";
            this.ligue_idComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ligue_idComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.ligue_idComboBoxEdit.TabIndex = 9;
            // 
            // RenGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 331);
            this.Controls.Add(this.visiteBindingNavigator);
            this.Controls.Add(this.tabPane1);
            this.Name = "RenGuest";
            this.Text = "RenGuest";
            this.Load += new System.EventHandler(this.RenGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingNavigator)).EndInit();
            this.visiteBindingNavigator.ResumeLayout(false);
            this.visiteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date2VisiteDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2VisiteDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heure2VisiteTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personne_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligue_idComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private Réponse réponse;
        private System.Windows.Forms.BindingSource visiteBindingSource;
        private RéponseTableAdapters.VisiteTableAdapter visiteTableAdapter;
        private RéponseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visiteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton visiteBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.DateEdit date2VisiteDateEdit;
        private DevExpress.XtraEditors.TimeEdit heure2VisiteTimeEdit;
        private DevExpress.XtraEditors.SpinEdit personne_idSpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ligue_idComboBoxEdit;
    }
}