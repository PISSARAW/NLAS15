namespace NLAS15
{
    partial class CreerBenevole
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
            System.Windows.Forms.Label nom_personneLabel;
            System.Windows.Forms.Label prenom_personneLabel;
            System.Windows.Forms.Label sexe_personneLabel;
            System.Windows.Forms.Label date2naissance_personneLabel;
            System.Windows.Forms.Label lieu2naissance_personneLabel;
            System.Windows.Forms.Label telephone_personneLabel;
            System.Windows.Forms.Label email_personneLabel;
            System.Windows.Forms.Label adresse_personneLabel;
            System.Windows.Forms.Label codePostal_personneLabel;
            System.Windows.Forms.Label ville_personneLabel;
            System.Windows.Forms.Label pays_personneLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerBenevole));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Réponse = new NLAS15.NLAS();
            this.pays_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ville_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codePostal_personneSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.adresse_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.email_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telephone_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lieu2naissance_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.date2naissance_personneDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sexe_personneComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.prenom_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nom_personneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.personneTableAdapter = new NLAS15.NLASTableAdapters.PersonneTableAdapter();
            this.tableAdapterManager = new NLAS15.NLASTableAdapters.TableAdapterManager();
            this.personneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nom_personneLabel = new System.Windows.Forms.Label();
            prenom_personneLabel = new System.Windows.Forms.Label();
            sexe_personneLabel = new System.Windows.Forms.Label();
            date2naissance_personneLabel = new System.Windows.Forms.Label();
            lieu2naissance_personneLabel = new System.Windows.Forms.Label();
            telephone_personneLabel = new System.Windows.Forms.Label();
            email_personneLabel = new System.Windows.Forms.Label();
            adresse_personneLabel = new System.Windows.Forms.Label();
            codePostal_personneLabel = new System.Windows.Forms.Label();
            ville_personneLabel = new System.Windows.Forms.Label();
            pays_personneLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Réponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pays_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ville_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePostal_personneSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresse_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieu2naissance_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2naissance_personneDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2naissance_personneDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexe_personneComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_personneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingNavigator)).BeginInit();
            this.personneBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nom_personneLabel
            // 
            nom_personneLabel.AutoSize = true;
            nom_personneLabel.Location = new System.Drawing.Point(33, 31);
            nom_personneLabel.Name = "nom_personneLabel";
            nom_personneLabel.Size = new System.Drawing.Size(29, 13);
            nom_personneLabel.TabIndex = 110;
            nom_personneLabel.Text = "Nom";
            // 
            // prenom_personneLabel
            // 
            prenom_personneLabel.AutoSize = true;
            prenom_personneLabel.Location = new System.Drawing.Point(33, 84);
            prenom_personneLabel.Name = "prenom_personneLabel";
            prenom_personneLabel.Size = new System.Drawing.Size(43, 13);
            prenom_personneLabel.TabIndex = 111;
            prenom_personneLabel.Text = "Prénom";
            // 
            // sexe_personneLabel
            // 
            sexe_personneLabel.AutoSize = true;
            sexe_personneLabel.Location = new System.Drawing.Point(28, 123);
            sexe_personneLabel.Name = "sexe_personneLabel";
            sexe_personneLabel.Size = new System.Drawing.Size(31, 13);
            sexe_personneLabel.TabIndex = 112;
            sexe_personneLabel.Text = "Sexe";
            // 
            // date2naissance_personneLabel
            // 
            date2naissance_personneLabel.AutoSize = true;
            date2naissance_personneLabel.Location = new System.Drawing.Point(28, 173);
            date2naissance_personneLabel.Name = "date2naissance_personneLabel";
            date2naissance_personneLabel.Size = new System.Drawing.Size(27, 13);
            date2naissance_personneLabel.TabIndex = 113;
            date2naissance_personneLabel.Text = "Née";
            // 
            // lieu2naissance_personneLabel
            // 
            lieu2naissance_personneLabel.AutoSize = true;
            lieu2naissance_personneLabel.Location = new System.Drawing.Point(359, 171);
            lieu2naissance_personneLabel.Name = "lieu2naissance_personneLabel";
            lieu2naissance_personneLabel.Size = new System.Drawing.Size(14, 13);
            lieu2naissance_personneLabel.TabIndex = 114;
            lieu2naissance_personneLabel.Text = "A";
            // 
            // telephone_personneLabel
            // 
            telephone_personneLabel.AutoSize = true;
            telephone_personneLabel.Location = new System.Drawing.Point(28, 221);
            telephone_personneLabel.Name = "telephone_personneLabel";
            telephone_personneLabel.Size = new System.Drawing.Size(58, 13);
            telephone_personneLabel.TabIndex = 115;
            telephone_personneLabel.Text = "Téléphone";
            // 
            // email_personneLabel
            // 
            email_personneLabel.AutoSize = true;
            email_personneLabel.Location = new System.Drawing.Point(359, 217);
            email_personneLabel.Name = "email_personneLabel";
            email_personneLabel.Size = new System.Drawing.Size(32, 13);
            email_personneLabel.TabIndex = 116;
            email_personneLabel.Text = "Email";
            // 
            // adresse_personneLabel
            // 
            adresse_personneLabel.AutoSize = true;
            adresse_personneLabel.Location = new System.Drawing.Point(28, 273);
            adresse_personneLabel.Name = "adresse_personneLabel";
            adresse_personneLabel.Size = new System.Drawing.Size(45, 13);
            adresse_personneLabel.TabIndex = 117;
            adresse_personneLabel.Text = "Adresse";
            // 
            // codePostal_personneLabel
            // 
            codePostal_personneLabel.AutoSize = true;
            codePostal_personneLabel.Location = new System.Drawing.Point(359, 273);
            codePostal_personneLabel.Name = "codePostal_personneLabel";
            codePostal_personneLabel.Size = new System.Drawing.Size(64, 13);
            codePostal_personneLabel.TabIndex = 118;
            codePostal_personneLabel.Text = "Code Postal";
            // 
            // ville_personneLabel
            // 
            ville_personneLabel.AutoSize = true;
            ville_personneLabel.Location = new System.Drawing.Point(28, 319);
            ville_personneLabel.Name = "ville_personneLabel";
            ville_personneLabel.Size = new System.Drawing.Size(26, 13);
            ville_personneLabel.TabIndex = 119;
            ville_personneLabel.Text = "Ville";
            // 
            // pays_personneLabel
            // 
            pays_personneLabel.AutoSize = true;
            pays_personneLabel.Location = new System.Drawing.Point(359, 317);
            pays_personneLabel.Name = "pays_personneLabel";
            pays_personneLabel.Size = new System.Drawing.Size(30, 13);
            pays_personneLabel.TabIndex = 120;
            pays_personneLabel.Text = "Pays";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(359, 27);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 121;
            typeLabel.Text = "Type:";
            // 
            // tabPane1
            // 
            this.tabPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPane1.BackgroundImage")));
            this.tabPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(-1, -1);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(634, 419);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(634, 419);
            this.tabPane1.TabIndex = 4;
            this.tabPane1.Text = "Mission";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.BackgroundImage")));
            this.tabNavigationPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabNavigationPage1.Caption = "Civilité";
            this.tabNavigationPage1.Controls.Add(typeLabel);
            this.tabNavigationPage1.Controls.Add(this.typeTextBox);
            this.tabNavigationPage1.Controls.Add(pays_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.pays_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(ville_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.ville_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(codePostal_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.codePostal_personneSpinEdit);
            this.tabNavigationPage1.Controls.Add(adresse_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.adresse_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(email_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.email_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(telephone_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.telephone_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(lieu2naissance_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.lieu2naissance_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(date2naissance_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.date2naissance_personneDateEdit);
            this.tabNavigationPage1.Controls.Add(sexe_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.sexe_personneComboBoxEdit);
            this.tabNavigationPage1.Controls.Add(prenom_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.prenom_personneTextEdit);
            this.tabNavigationPage1.Controls.Add(nom_personneLabel);
            this.tabNavigationPage1.Controls.Add(this.nom_personneTextEdit);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(616, 374);
            this.tabNavigationPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage1_Paint);
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(481, 20);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 122;
            this.typeTextBox.Text = "Bénévole";
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "Personne";
            this.personneBindingSource.DataSource = this.Réponse;
            // 
            // Réponse
            // 
            this.Réponse.DataSetName = "Réponse";
            this.Réponse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pays_personneTextEdit
            // 
            this.pays_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Pays_personne", true));
            this.pays_personneTextEdit.Location = new System.Drawing.Point(481, 310);
            this.pays_personneTextEdit.Name = "pays_personneTextEdit";
            this.pays_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pays_personneTextEdit.TabIndex = 121;
            // 
            // ville_personneTextEdit
            // 
            this.ville_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Ville_personne", true));
            this.ville_personneTextEdit.Location = new System.Drawing.Point(165, 316);
            this.ville_personneTextEdit.Name = "ville_personneTextEdit";
            this.ville_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.ville_personneTextEdit.TabIndex = 120;
            // 
            // codePostal_personneSpinEdit
            // 
            this.codePostal_personneSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "CodePostal_personne", true));
            this.codePostal_personneSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.codePostal_personneSpinEdit.Location = new System.Drawing.Point(481, 266);
            this.codePostal_personneSpinEdit.Name = "codePostal_personneSpinEdit";
            this.codePostal_personneSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.codePostal_personneSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.codePostal_personneSpinEdit.TabIndex = 119;
            // 
            // adresse_personneTextEdit
            // 
            this.adresse_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Adresse_personne", true));
            this.adresse_personneTextEdit.Location = new System.Drawing.Point(165, 266);
            this.adresse_personneTextEdit.Name = "adresse_personneTextEdit";
            this.adresse_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.adresse_personneTextEdit.TabIndex = 118;
            // 
            // email_personneTextEdit
            // 
            this.email_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Email_personne", true));
            this.email_personneTextEdit.Location = new System.Drawing.Point(481, 214);
            this.email_personneTextEdit.Name = "email_personneTextEdit";
            this.email_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.email_personneTextEdit.TabIndex = 117;
            // 
            // telephone_personneTextEdit
            // 
            this.telephone_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Telephone_personne", true));
            this.telephone_personneTextEdit.Location = new System.Drawing.Point(165, 214);
            this.telephone_personneTextEdit.Name = "telephone_personneTextEdit";
            this.telephone_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.telephone_personneTextEdit.TabIndex = 116;
            // 
            // lieu2naissance_personneTextEdit
            // 
            this.lieu2naissance_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Lieu2naissance_personne", true));
            this.lieu2naissance_personneTextEdit.Location = new System.Drawing.Point(481, 168);
            this.lieu2naissance_personneTextEdit.Name = "lieu2naissance_personneTextEdit";
            this.lieu2naissance_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.lieu2naissance_personneTextEdit.TabIndex = 115;
            // 
            // date2naissance_personneDateEdit
            // 
            this.date2naissance_personneDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "Date2naissance_personne", true));
            this.date2naissance_personneDateEdit.EditValue = null;
            this.date2naissance_personneDateEdit.Location = new System.Drawing.Point(165, 166);
            this.date2naissance_personneDateEdit.Name = "date2naissance_personneDateEdit";
            this.date2naissance_personneDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2naissance_personneDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2naissance_personneDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date2naissance_personneDateEdit.TabIndex = 114;
            // 
            // sexe_personneComboBoxEdit
            // 
            this.sexe_personneComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "sexe_personne", true));
            this.sexe_personneComboBoxEdit.Location = new System.Drawing.Point(165, 116);
            this.sexe_personneComboBoxEdit.Name = "sexe_personneComboBoxEdit";
            this.sexe_personneComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexe_personneComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.sexe_personneComboBoxEdit.TabIndex = 113;
            // 
            // prenom_personneTextEdit
            // 
            this.prenom_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "prenom_personne", true));
            this.prenom_personneTextEdit.Location = new System.Drawing.Point(165, 81);
            this.prenom_personneTextEdit.Name = "prenom_personneTextEdit";
            this.prenom_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.prenom_personneTextEdit.TabIndex = 112;
            // 
            // nom_personneTextEdit
            // 
            this.nom_personneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personneBindingSource, "nom_personne", true));
            this.nom_personneTextEdit.Location = new System.Drawing.Point(165, 24);
            this.nom_personneTextEdit.Name = "nom_personneTextEdit";
            this.nom_personneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nom_personneTextEdit.TabIndex = 111;
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BenevoleTableAdapter = null;
            this.tableAdapterManager.LigueTableAdapter = null;
            this.tableAdapterManager.PersonnelTableAdapter = null;
            this.tableAdapterManager.PersonneTableAdapter = this.personneTableAdapter;
            this.tableAdapterManager.StageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NLAS15.NLASTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisiteTableAdapter = null;
            this.tableAdapterManager.VisiteurTableAdapter = null;
            // 
            // personneBindingNavigator
            // 
            this.personneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personneBindingNavigator.BindingSource = this.personneBindingSource;
            this.personneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personneBindingNavigatorSaveItem});
            this.personneBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personneBindingNavigator.Name = "personneBindingNavigator";
            this.personneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personneBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.personneBindingNavigator.TabIndex = 5;
            this.personneBindingNavigator.Text = "bindingNavigator1";
            this.personneBindingNavigator.RefreshItems += new System.EventHandler(this.personneBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // personneBindingNavigatorSaveItem
            // 
            this.personneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personneBindingNavigatorSaveItem.Image")));
            this.personneBindingNavigatorSaveItem.Name = "personneBindingNavigatorSaveItem";
            this.personneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personneBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.personneBindingNavigatorSaveItem.Click += new System.EventHandler(this.personneBindingNavigatorSaveItem_Click);
            // 
            // CreerBenevole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 418);
            this.Controls.Add(this.personneBindingNavigator);
            this.Controls.Add(this.tabPane1);
            this.Name = "CreerBenevole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CreerBenevole";
            this.Load += new System.EventHandler(this.CreerBenevole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Réponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pays_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ville_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePostal_personneSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresse_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieu2naissance_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2naissance_personneDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2naissance_personneDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexe_personneComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_personneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingNavigator)).EndInit();
            this.personneBindingNavigator.ResumeLayout(false);
            this.personneBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private NLAS Réponse;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private NLASTableAdapters.PersonneTableAdapter personneTableAdapter;
        private NLASTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personneBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personneBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit pays_personneTextEdit;
        private DevExpress.XtraEditors.TextEdit ville_personneTextEdit;
        private DevExpress.XtraEditors.SpinEdit codePostal_personneSpinEdit;
        private DevExpress.XtraEditors.TextEdit adresse_personneTextEdit;
        private DevExpress.XtraEditors.TextEdit email_personneTextEdit;
        private DevExpress.XtraEditors.TextEdit telephone_personneTextEdit;
        private DevExpress.XtraEditors.TextEdit lieu2naissance_personneTextEdit;
        private DevExpress.XtraEditors.DateEdit date2naissance_personneDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit sexe_personneComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit prenom_personneTextEdit;
        private DevExpress.XtraEditors.TextEdit nom_personneTextEdit;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}