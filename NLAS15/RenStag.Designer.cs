namespace NLAS15
{
    partial class RenStag
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
            System.Windows.Forms.Label date2DebutStageLabel;
            System.Windows.Forms.Label date2FinStageLabel;
            System.Windows.Forms.Label titre_stageLabel;
            System.Windows.Forms.Label taches_stageLabel;
            System.Windows.Forms.Label personne_idLabel1;
            System.Windows.Forms.Label ligue_idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenStag));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ligue_idComboBox = new System.Windows.Forms.ComboBox();
            this.stageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.réponse = new NLAS15.Réponse();
            this.personne_idComboBox = new System.Windows.Forms.ComboBox();
            this.date2DebutStageDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.date2FinStageDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.titre_stageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taches_stageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stageTableAdapter = new NLAS15.RéponseTableAdapters.StageTableAdapter();
            this.tableAdapterManager = new NLAS15.RéponseTableAdapters.TableAdapterManager();
            this.personneTableAdapter = new NLAS15.RéponseTableAdapters.PersonneTableAdapter();
            this.stageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            date2DebutStageLabel = new System.Windows.Forms.Label();
            date2FinStageLabel = new System.Windows.Forms.Label();
            titre_stageLabel = new System.Windows.Forms.Label();
            taches_stageLabel = new System.Windows.Forms.Label();
            personne_idLabel1 = new System.Windows.Forms.Label();
            ligue_idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2DebutStageDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2DebutStageDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2FinStageDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2FinStageDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titre_stageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taches_stageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingNavigator)).BeginInit();
            this.stageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date2DebutStageLabel
            // 
            date2DebutStageLabel.AutoSize = true;
            date2DebutStageLabel.Location = new System.Drawing.Point(38, 42);
            date2DebutStageLabel.Name = "date2DebutStageLabel";
            date2DebutStageLabel.Size = new System.Drawing.Size(81, 13);
            date2DebutStageLabel.TabIndex = 2;
            date2DebutStageLabel.Text = "Début du stage";
            // 
            // date2FinStageLabel
            // 
            date2FinStageLabel.AutoSize = true;
            date2FinStageLabel.Location = new System.Drawing.Point(455, 42);
            date2FinStageLabel.Name = "date2FinStageLabel";
            date2FinStageLabel.Size = new System.Drawing.Size(66, 13);
            date2FinStageLabel.TabIndex = 4;
            date2FinStageLabel.Text = "Fin du stage";
            // 
            // titre_stageLabel
            // 
            titre_stageLabel.AutoSize = true;
            titre_stageLabel.Location = new System.Drawing.Point(38, 111);
            titre_stageLabel.Name = "titre_stageLabel";
            titre_stageLabel.Size = new System.Drawing.Size(74, 13);
            titre_stageLabel.TabIndex = 6;
            titre_stageLabel.Text = "Titre du stage";
            // 
            // taches_stageLabel
            // 
            taches_stageLabel.AutoSize = true;
            taches_stageLabel.Location = new System.Drawing.Point(455, 111);
            taches_stageLabel.Name = "taches_stageLabel";
            taches_stageLabel.Size = new System.Drawing.Size(41, 13);
            taches_stageLabel.TabIndex = 8;
            taches_stageLabel.Text = "Taches";
            // 
            // personne_idLabel1
            // 
            personne_idLabel1.AutoSize = true;
            personne_idLabel1.Location = new System.Drawing.Point(38, 171);
            personne_idLabel1.Name = "personne_idLabel1";
            personne_idLabel1.Size = new System.Drawing.Size(67, 13);
            personne_idLabel1.TabIndex = 13;
            personne_idLabel1.Text = "personne id:";
            // 
            // ligue_idLabel1
            // 
            ligue_idLabel1.AutoSize = true;
            ligue_idLabel1.Location = new System.Drawing.Point(455, 171);
            ligue_idLabel1.Name = "ligue_idLabel1";
            ligue_idLabel1.Size = new System.Drawing.Size(79, 13);
            ligue_idLabel1.TabIndex = 14;
            ligue_idLabel1.Text = "Nom de la ligue";
            // 
            // tabPane1
            // 
            this.tabPane1.BackColor = System.Drawing.Color.White;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(2, 35);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(839, 255);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(839, 255);
            this.tabPane1.TabIndex = 4;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Renseignements";
            this.tabNavigationPage1.Controls.Add(ligue_idLabel1);
            this.tabNavigationPage1.Controls.Add(this.ligue_idComboBox);
            this.tabNavigationPage1.Controls.Add(personne_idLabel1);
            this.tabNavigationPage1.Controls.Add(this.personne_idComboBox);
            this.tabNavigationPage1.Controls.Add(date2DebutStageLabel);
            this.tabNavigationPage1.Controls.Add(this.date2DebutStageDateEdit);
            this.tabNavigationPage1.Controls.Add(date2FinStageLabel);
            this.tabNavigationPage1.Controls.Add(this.date2FinStageDateEdit);
            this.tabNavigationPage1.Controls.Add(titre_stageLabel);
            this.tabNavigationPage1.Controls.Add(this.titre_stageTextEdit);
            this.tabNavigationPage1.Controls.Add(taches_stageLabel);
            this.tabNavigationPage1.Controls.Add(this.taches_stageTextEdit);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(821, 210);
            // 
            // ligue_idComboBox
            // 
            this.ligue_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stageBindingSource, "ligue_id", true));
            this.ligue_idComboBox.DataSource = this.stageBindingSource;
            this.ligue_idComboBox.DisplayMember = "ligue_id";
            this.ligue_idComboBox.FormattingEnabled = true;
            this.ligue_idComboBox.Location = new System.Drawing.Point(561, 163);
            this.ligue_idComboBox.Name = "ligue_idComboBox";
            this.ligue_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.ligue_idComboBox.TabIndex = 15;
            this.ligue_idComboBox.SelectedIndexChanged += new System.EventHandler(this.ligue_idComboBox_SelectedIndexChanged);
            // 
            // stageBindingSource
            // 
            this.stageBindingSource.DataMember = "Stage";
            this.stageBindingSource.DataSource = this.réponse;
            // 
            // réponse
            // 
            this.réponse.DataSetName = "Réponse";
            this.réponse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personne_idComboBox
            // 
            this.personne_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stageBindingSource, "personne_id", true));
            this.personne_idComboBox.DataSource = this.stageBindingSource;
            this.personne_idComboBox.DisplayMember = "personne_id";
            this.personne_idComboBox.FormattingEnabled = true;
            this.personne_idComboBox.Location = new System.Drawing.Point(144, 163);
            this.personne_idComboBox.Name = "personne_idComboBox";
            this.personne_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.personne_idComboBox.TabIndex = 14;
            this.personne_idComboBox.SelectedIndexChanged += new System.EventHandler(this.personne_idComboBox_SelectedIndexChanged);
            // 
            // date2DebutStageDateEdit
            // 
            this.date2DebutStageDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stageBindingSource, "Date2DebutStage", true));
            this.date2DebutStageDateEdit.EditValue = null;
            this.date2DebutStageDateEdit.Location = new System.Drawing.Point(144, 39);
            this.date2DebutStageDateEdit.Name = "date2DebutStageDateEdit";
            this.date2DebutStageDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2DebutStageDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2DebutStageDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2DebutStageDateEdit.TabIndex = 3;
            // 
            // date2FinStageDateEdit
            // 
            this.date2FinStageDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stageBindingSource, "Date2FinStage", true));
            this.date2FinStageDateEdit.EditValue = null;
            this.date2FinStageDateEdit.Location = new System.Drawing.Point(561, 39);
            this.date2FinStageDateEdit.Name = "date2FinStageDateEdit";
            this.date2FinStageDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2FinStageDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2FinStageDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2FinStageDateEdit.TabIndex = 5;
            // 
            // titre_stageTextEdit
            // 
            this.titre_stageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stageBindingSource, "Titre_stage", true));
            this.titre_stageTextEdit.Location = new System.Drawing.Point(144, 108);
            this.titre_stageTextEdit.Name = "titre_stageTextEdit";
            this.titre_stageTextEdit.Size = new System.Drawing.Size(100, 20);
            this.titre_stageTextEdit.TabIndex = 7;
            // 
            // taches_stageTextEdit
            // 
            this.taches_stageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stageBindingSource, "Taches_stage", true));
            this.taches_stageTextEdit.Location = new System.Drawing.Point(561, 108);
            this.taches_stageTextEdit.Name = "taches_stageTextEdit";
            this.taches_stageTextEdit.Size = new System.Drawing.Size(100, 20);
            this.taches_stageTextEdit.TabIndex = 9;
            // 
            // stageTableAdapter
            // 
            this.stageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BenevoleTableAdapter = null;
            this.tableAdapterManager.LigueTableAdapter = null;
            this.tableAdapterManager.PersonnelTableAdapter = null;
            this.tableAdapterManager.PersonneTableAdapter = this.personneTableAdapter;
            this.tableAdapterManager.StageTableAdapter = this.stageTableAdapter;
            this.tableAdapterManager.UpdateOrder = NLAS15.RéponseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisiteTableAdapter = null;
            this.tableAdapterManager.VisiteurTableAdapter = null;
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // stageBindingNavigator
            // 
            this.stageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stageBindingNavigator.BindingSource = this.stageBindingSource;
            this.stageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stageBindingNavigatorSaveItem});
            this.stageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stageBindingNavigator.Name = "stageBindingNavigator";
            this.stageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stageBindingNavigator.Size = new System.Drawing.Size(844, 25);
            this.stageBindingNavigator.TabIndex = 5;
            this.stageBindingNavigator.Text = "bindingNavigator1";
            this.stageBindingNavigator.RefreshItems += new System.EventHandler(this.stageBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stageBindingNavigatorSaveItem
            // 
            this.stageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stageBindingNavigatorSaveItem.Image")));
            this.stageBindingNavigatorSaveItem.Name = "stageBindingNavigatorSaveItem";
            this.stageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stageBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.stageBindingNavigatorSaveItem.Click += new System.EventHandler(this.stageBindingNavigatorSaveItem_Click);
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "Personne";
            this.personneBindingSource.DataSource = this.réponse;
            // 
            // RenStag
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 296);
            this.Controls.Add(this.stageBindingNavigator);
            this.Controls.Add(this.tabPane1);
            this.Name = "RenStag";
            this.Text = "RenStag";
            this.Load += new System.EventHandler(this.RenStag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.réponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2DebutStageDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2DebutStageDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2FinStageDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2FinStageDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titre_stageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taches_stageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingNavigator)).EndInit();
            this.stageBindingNavigator.ResumeLayout(false);
            this.stageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private Réponse réponse;
        private System.Windows.Forms.BindingSource stageBindingSource;
        private RéponseTableAdapters.StageTableAdapter stageTableAdapter;
        private RéponseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stageBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stageBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.DateEdit date2DebutStageDateEdit;
        private DevExpress.XtraEditors.DateEdit date2FinStageDateEdit;
        private DevExpress.XtraEditors.TextEdit titre_stageTextEdit;
        private DevExpress.XtraEditors.TextEdit taches_stageTextEdit;
        private System.Windows.Forms.ComboBox personne_idComboBox;
        private RéponseTableAdapters.PersonneTableAdapter personneTableAdapter;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private System.Windows.Forms.ComboBox ligue_idComboBox;
    }
}