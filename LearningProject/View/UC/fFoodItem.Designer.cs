namespace LearningProject.View.UC
{
    partial class fFoodItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDataClass = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.Column6 = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailInfraction = new System.Windows.Forms.Button();
            this.btnRefreshOffensesDataOffense = new System.Windows.Forms.Button();
            this.btnNewOffense1 = new System.Windows.Forms.Button();
            this.tpForm = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneVSeparator1 = new Siticone.UI.WinForms.SiticoneVSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudAlertThreshold = new System.Windows.Forms.NumericUpDown();
            this.cbUnitOfMesure = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Column2 = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.Column3 = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.Column8 = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.Column9 = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.Column10 = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnInitFormOffense = new System.Windows.Forms.Button();
            this.btnDeleteOffense = new System.Windows.Forms.Button();
            this.btnNewOffense2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpDataClass.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpForm.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertThreshold)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tpDataClass);
            this.tabControl.Controls.Add(this.tpForm);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(697, 379);
            this.tabControl.TabIndex = 1;
            // 
            // tpDataClass
            // 
            this.tpDataClass.Controls.Add(this.panel5);
            this.tpDataClass.Controls.Add(this.panel1);
            this.tpDataClass.Location = new System.Drawing.Point(25, 4);
            this.tpDataClass.Name = "tpDataClass";
            this.tpDataClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataClass.Size = new System.Drawing.Size(668, 371);
            this.tpDataClass.TabIndex = 1;
            this.tpDataClass.Text = "Données";
            this.tpDataClass.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvItems);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 339);
            this.panel5.TabIndex = 2;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItems.GridColor = System.Drawing.SystemColors.Control;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(662, 339);
            this.dgvItems.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "category";
            this.Column7.HeaderText = "Catégorie";
            this.Column7.Name = "Column7";
            this.Column7.Width = 82;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "UnitOfMesureStr";
            this.Column4.HeaderText = "Unité de mesure";
            this.Column4.Name = "Column4";
            this.Column4.Width = 106;
            // 
            // Column5
            // 
            this.Column5.AllowDecimals = false;
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "stockQuantity";
            this.Column5.HeaderText = "Qté stock";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 74;
            // 
            // Column6
            // 
            this.Column6.AllowDecimals = false;
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "alertThreshold";
            this.Column6.HeaderText = "Seuil d\'alerte";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 91;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetailInfraction);
            this.panel1.Controls.Add(this.btnRefreshOffensesDataOffense);
            this.panel1.Controls.Add(this.btnNewOffense1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 26);
            this.panel1.TabIndex = 0;
            // 
            // btnDetailInfraction
            // 
            this.btnDetailInfraction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetailInfraction.Location = new System.Drawing.Point(587, 0);
            this.btnDetailInfraction.Name = "btnDetailInfraction";
            this.btnDetailInfraction.Size = new System.Drawing.Size(75, 26);
            this.btnDetailInfraction.TabIndex = 2;
            this.btnDetailInfraction.Text = "Détail";
            this.btnDetailInfraction.UseVisualStyleBackColor = true;
            this.btnDetailInfraction.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnRefreshOffensesDataOffense
            // 
            this.btnRefreshOffensesDataOffense.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshOffensesDataOffense.Location = new System.Drawing.Point(75, 0);
            this.btnRefreshOffensesDataOffense.Name = "btnRefreshOffensesDataOffense";
            this.btnRefreshOffensesDataOffense.Size = new System.Drawing.Size(75, 26);
            this.btnRefreshOffensesDataOffense.TabIndex = 1;
            this.btnRefreshOffensesDataOffense.Text = "Actualiser";
            this.btnRefreshOffensesDataOffense.UseVisualStyleBackColor = true;
            this.btnRefreshOffensesDataOffense.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewOffense1
            // 
            this.btnNewOffense1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewOffense1.Location = new System.Drawing.Point(0, 0);
            this.btnNewOffense1.Name = "btnNewOffense1";
            this.btnNewOffense1.Size = new System.Drawing.Size(75, 26);
            this.btnNewOffense1.TabIndex = 0;
            this.btnNewOffense1.Text = "Nouveau";
            this.btnNewOffense1.UseVisualStyleBackColor = true;
            this.btnNewOffense1.Click += new System.EventHandler(this.btnNew1_Click);
            // 
            // tpForm
            // 
            this.tpForm.Controls.Add(this.panel4);
            this.tpForm.Controls.Add(this.panel3);
            this.tpForm.Location = new System.Drawing.Point(25, 4);
            this.tpForm.Name = "tpForm";
            this.tpForm.Padding = new System.Windows.Forms.Padding(3);
            this.tpForm.Size = new System.Drawing.Size(668, 371);
            this.tpForm.TabIndex = 0;
            this.tpForm.Text = "Formulaire";
            this.tpForm.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.siticoneVSeparator1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.nudStockQuantity);
            this.panel4.Controls.Add(this.nudAlertThreshold);
            this.panel4.Controls.Add(this.cbUnitOfMesure);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbDescription);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tbName);
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 339);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Catégorie";
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneVSeparator1.Location = new System.Drawing.Point(510, 82);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(10, 37);
            this.siticoneVSeparator1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantité stock";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Seuil d\'alerte";
            // 
            // nudStockQuantity
            // 
            this.nudStockQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStockQuantity.Location = new System.Drawing.Point(526, 97);
            this.nudStockQuantity.Name = "nudStockQuantity";
            this.nudStockQuantity.ReadOnly = true;
            this.nudStockQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudStockQuantity.TabIndex = 26;
            this.nudStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAlertThreshold
            // 
            this.nudAlertThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAlertThreshold.Location = new System.Drawing.Point(384, 97);
            this.nudAlertThreshold.Name = "nudAlertThreshold";
            this.nudAlertThreshold.Size = new System.Drawing.Size(120, 22);
            this.nudAlertThreshold.TabIndex = 25;
            this.nudAlertThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbUnitOfMesure
            // 
            this.cbUnitOfMesure.FormattingEnabled = true;
            this.cbUnitOfMesure.Items.AddRange(new object[] {
            "Théorique",
            "Pratique",
            "Laboratoire",
            "Atelier",
            "En ligne",
            "Séminaire",
            "Stage",
            "Cours magistral",
            "Tutorat",
            "Cours à option",
            "Cours d\'auto-apprentissage",
            "Cours intensif",
            "Conférence",
            "Simulation",
            "Projet"});
            this.cbUnitOfMesure.Location = new System.Drawing.Point(3, 98);
            this.cbUnitOfMesure.Name = "cbUnitOfMesure";
            this.cbUnitOfMesure.Size = new System.Drawing.Size(275, 21);
            this.cbUnitOfMesure.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Unité de mesure";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(384, 17);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(275, 59);
            this.tbDescription.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 22);
            this.tbName.TabIndex = 18;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 125);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(656, 208);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(648, 182);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Stock";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvStock);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(642, 176);
            this.panel7.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(642, 176);
            this.dgvStock.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.Checked = false;
            this.Column2.DataPropertyName = "EntryDate";
            this.Column2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Column2.HeaderText = "Date stock";
            this.Column2.Name = "Column2";
            this.Column2.Width = 100;
            // 
            // Column3
            // 
            this.Column3.AllowDecimals = false;
            this.Column3.DataPropertyName = "currentQuantity";
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 100;
            // 
            // Column8
            // 
            this.Column8.AllowDecimals = false;
            this.Column8.DataPropertyName = "unitPrice";
            this.Column8.HeaderText = "Prix unitaire";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.Width = 100;
            // 
            // Column9
            // 
            this.Column9.AllowDecimals = false;
            this.Column9.DataPropertyName = "CurrentTotalPrice";
            this.Column9.HeaderText = "Prix total";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.Width = 100;
            // 
            // Column10
            // 
            this.Column10.Checked = false;
            this.Column10.DataPropertyName = "expirationDate";
            this.Column10.HeaderText = "Date expiration";
            this.Column10.Name = "Column10";
            this.Column10.Width = 100;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Fruits et légumes",
            "Viandes et volailles",
            "Poissons et fruits de mer",
            "Produits laitiers",
            "Pains et pâtisseries",
            "Céréales et légumineuses",
            "Snacks et confiseries",
            "Plats cuisinés et surgelés",
            "Sauces et condiments",
            "Épices et herbes",
            "Boissons non alcoolisées",
            "Boissons alcoolisées",
            "Produits sans gluten",
            "Produits bio",
            "",
            "Produits vegan",
            "Produits sans lactose"});
            this.cbCategory.Location = new System.Drawing.Point(3, 58);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(275, 21);
            this.cbCategory.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnValidate);
            this.panel3.Controls.Add(this.btnInitFormOffense);
            this.panel3.Controls.Add(this.btnDeleteOffense);
            this.panel3.Controls.Add(this.btnNewOffense2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 26);
            this.panel3.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnValidate.Location = new System.Drawing.Point(437, 0);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 26);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnInitFormOffense
            // 
            this.btnInitFormOffense.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInitFormOffense.Location = new System.Drawing.Point(512, 0);
            this.btnInitFormOffense.Name = "btnInitFormOffense";
            this.btnInitFormOffense.Size = new System.Drawing.Size(75, 26);
            this.btnInitFormOffense.TabIndex = 2;
            this.btnInitFormOffense.Text = "Annuler";
            this.btnInitFormOffense.UseVisualStyleBackColor = true;
            this.btnInitFormOffense.Click += new System.EventHandler(this.btnInitForm_Click);
            // 
            // btnDeleteOffense
            // 
            this.btnDeleteOffense.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteOffense.Location = new System.Drawing.Point(587, 0);
            this.btnDeleteOffense.Name = "btnDeleteOffense";
            this.btnDeleteOffense.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteOffense.TabIndex = 1;
            this.btnDeleteOffense.Text = "Supprimer";
            this.btnDeleteOffense.UseVisualStyleBackColor = true;
            this.btnDeleteOffense.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewOffense2
            // 
            this.btnNewOffense2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewOffense2.Location = new System.Drawing.Point(0, 0);
            this.btnNewOffense2.Name = "btnNewOffense2";
            this.btnNewOffense2.Size = new System.Drawing.Size(75, 26);
            this.btnNewOffense2.TabIndex = 0;
            this.btnNewOffense2.Text = "Nouveau";
            this.btnNewOffense2.UseVisualStyleBackColor = true;
            this.btnNewOffense2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // fFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 379);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fFoodItem";
            this.Text = "Aliments";
            this.Load += new System.EventHandler(this.fFoodItem_Load);
            this.tabControl.ResumeLayout(false);
            this.tpDataClass.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpForm.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlertThreshold)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnInitFormOffense;
        private System.Windows.Forms.Button btnDeleteOffense;
        private System.Windows.Forms.Button btnNewOffense2;
        private System.Windows.Forms.TabPage tpDataClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetailInfraction;
        private System.Windows.Forms.Button btnRefreshOffensesDataOffense;
        private System.Windows.Forms.Button btnNewOffense1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUnitOfMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn Column5;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn Column6;
        private System.Windows.Forms.NumericUpDown nudStockQuantity;
        private System.Windows.Forms.NumericUpDown nudAlertThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Column2;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn Column3;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn Column8;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn Column9;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Column10;
        private System.Windows.Forms.Label label1;
    }
}