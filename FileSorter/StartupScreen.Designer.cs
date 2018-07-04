namespace FileSorter
{
    partial class StartupScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.folderToStart = new System.Windows.Forms.FolderBrowserDialog();
            this.linkStartPath = new System.Windows.Forms.LinkLabel();
            this.cboFileTypes = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chkTemporary = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMultiple = new System.Windows.Forms.DataGridView();
            this.Deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multipleVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDuplicate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoVersionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exactDuplicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgDeleteList = new System.Windows.Forms.DataGridView();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoVersionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedTimeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.chkAllowMainFiles = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualDelete = new System.Windows.Forms.Button();
            this.txtCompareResult = new System.Windows.Forms.RichTextBox();
            this.btnCompareBinary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultiple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipleVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDuplicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exactDuplicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // folderToStart
            // 
            this.folderToStart.ShowNewFolderButton = false;
            // 
            // linkStartPath
            // 
            this.linkStartPath.AutoSize = true;
            this.linkStartPath.Location = new System.Drawing.Point(236, 6);
            this.linkStartPath.Name = "linkStartPath";
            this.linkStartPath.Size = new System.Drawing.Size(122, 13);
            this.linkStartPath.TabIndex = 1;
            this.linkStartPath.TabStop = true;
            this.linkStartPath.Text = "Click To Set Start Folder";
            this.linkStartPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStartPath_LinkClicked);
            // 
            // cboFileTypes
            // 
            this.cboFileTypes.FormattingEnabled = true;
            this.cboFileTypes.Items.AddRange(new object[] {
            "*.*",
            "*.jpg",
            "*.doc"});
            this.cboFileTypes.Location = new System.Drawing.Point(101, 11);
            this.cboFileTypes.Name = "cboFileTypes";
            this.cboFileTypes.Size = new System.Drawing.Size(82, 21);
            this.cboFileTypes.TabIndex = 2;
            this.cboFileTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(632, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(272, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "ResultFileName.xml";
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToOrderColumns = true;
            this.dgFiles.AllowUserToResizeColumns = false;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.AutoGenerateColumns = false;
            this.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.iDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.lastModifiedTimeDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.iDNoVersionDataGridViewTextBoxColumn});
            this.dgFiles.DataSource = this.fileBindingSource;
            this.dgFiles.Location = new System.Drawing.Point(12, 78);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFiles.Size = new System.Drawing.Size(561, 227);
            this.dgFiles.TabIndex = 4;
            this.dgFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiles_CellClick);
            this.dgFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiles_CellContentClick);
            this.dgFiles.SelectionChanged += new System.EventHandler(this.dgFiles_SelectionChanged);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Deleted";
            this.dataGridViewCheckBoxColumn2.FalseValue = "False";
            this.dataGridViewCheckBoxColumn2.FillWeight = 35.69632F;
            this.dataGridViewCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewCheckBoxColumn2.HeaderText = "X";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.TrueValue = "True";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.FillWeight = 128.5068F;
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 121.8274F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size(KB)";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 72;
            // 
            // lastModifiedTimeDataGridViewTextBoxColumn
            // 
            this.lastModifiedTimeDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedTime";
            this.lastModifiedTimeDataGridViewTextBoxColumn.FillWeight = 85.46274F;
            this.lastModifiedTimeDataGridViewTextBoxColumn.HeaderText = "Modified On";
            this.lastModifiedTimeDataGridViewTextBoxColumn.Name = "lastModifiedTimeDataGridViewTextBoxColumn";
            this.lastModifiedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.FillWeight = 128.5068F;
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.filePathDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDNoVersionDataGridViewTextBoxColumn
            // 
            this.iDNoVersionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDNoVersionDataGridViewTextBoxColumn.DataPropertyName = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn.HeaderText = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn.Name = "iDNoVersionDataGridViewTextBoxColumn";
            this.iDNoVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNoVersionDataGridViewTextBoxColumn.Visible = false;
            this.iDNoVersionDataGridViewTextBoxColumn.Width = 98;
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataMember = "Documents";
            this.fileBindingSource.DataSource = typeof(FileSorterLibrary.SearchData);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1021, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(923, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 24);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load File...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkTemporary
            // 
            this.chkTemporary.AutoSize = true;
            this.chkTemporary.Location = new System.Drawing.Point(632, 30);
            this.chkTemporary.Name = "chkTemporary";
            this.chkTemporary.Size = new System.Drawing.Size(138, 17);
            this.chkTemporary.TabIndex = 8;
            this.chkTemporary.Text = "Include Temporary Files";
            this.chkTemporary.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(483, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Start Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1108, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove Duplicates";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "File List";
            // 
            // dgMultiple
            // 
            this.dgMultiple.AllowUserToAddRows = false;
            this.dgMultiple.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.dgMultiple.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMultiple.AutoGenerateColumns = false;
            this.dgMultiple.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMultiple.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgMultiple.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultiple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deleted,
            this.iDDataGridViewTextBoxColumn1,
            this.fileNameDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.lastModifiedTimeDataGridViewTextBoxColumn1,
            this.filePathDataGridViewTextBoxColumn1,
            this.iDNoVersionDataGridViewTextBoxColumn1});
            this.dgMultiple.DataSource = this.multipleVersionBindingSource;
            this.dgMultiple.Location = new System.Drawing.Point(15, 331);
            this.dgMultiple.Name = "dgMultiple";
            this.dgMultiple.ReadOnly = true;
            this.dgMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgMultiple.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMultiple.Size = new System.Drawing.Size(571, 252);
            this.dgMultiple.TabIndex = 12;
            this.dgMultiple.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMultiple_CellClick);
            this.dgMultiple.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMultiple_CellContentClick_1);
            // 
            // Deleted
            // 
            this.Deleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.FalseValue = "False";
            this.Deleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deleted.Frozen = true;
            this.Deleted.HeaderText = "X";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Deleted.TrueValue = "True";
            this.Deleted.Width = 20;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn1
            // 
            this.fileNameDataGridViewTextBoxColumn1.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn1.FillWeight = 150.8013F;
            this.fileNameDataGridViewTextBoxColumn1.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn1.Name = "fileNameDataGridViewTextBoxColumn1";
            this.fileNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.sizeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.sizeDataGridViewTextBoxColumn1.FillWeight = 82.59485F;
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size(KB)";
            this.sizeDataGridViewTextBoxColumn1.MaxInputLength = 50;
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn1.Width = 72;
            // 
            // lastModifiedTimeDataGridViewTextBoxColumn1
            // 
            this.lastModifiedTimeDataGridViewTextBoxColumn1.DataPropertyName = "LastModifiedTime";
            this.lastModifiedTimeDataGridViewTextBoxColumn1.FillWeight = 103.112F;
            this.lastModifiedTimeDataGridViewTextBoxColumn1.HeaderText = "Modified On";
            this.lastModifiedTimeDataGridViewTextBoxColumn1.Name = "lastModifiedTimeDataGridViewTextBoxColumn1";
            this.lastModifiedTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // filePathDataGridViewTextBoxColumn1
            // 
            this.filePathDataGridViewTextBoxColumn1.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn1.FillWeight = 150.8013F;
            this.filePathDataGridViewTextBoxColumn1.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn1.Name = "filePathDataGridViewTextBoxColumn1";
            this.filePathDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDNoVersionDataGridViewTextBoxColumn1
            // 
            this.iDNoVersionDataGridViewTextBoxColumn1.DataPropertyName = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn1.HeaderText = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn1.Name = "iDNoVersionDataGridViewTextBoxColumn1";
            this.iDNoVersionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDNoVersionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // multipleVersionBindingSource
            // 
            this.multipleVersionBindingSource.DataMember = "MultipleVersion";
            this.multipleVersionBindingSource.DataSource = typeof(FileSorterLibrary.SearchData);
            // 
            // dgDuplicate
            // 
            this.dgDuplicate.AllowUserToAddRows = false;
            this.dgDuplicate.AutoGenerateColumns = false;
            this.dgDuplicate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDuplicate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgDuplicate.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgDuplicate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDuplicate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn2,
            this.fileNameDataGridViewTextBoxColumn2,
            this.sizeDataGridViewTextBoxColumn2,
            this.lastModifiedTimeDataGridViewTextBoxColumn2,
            this.filePathDataGridViewTextBoxColumn2,
            this.iDNoVersionDataGridViewTextBoxColumn2});
            this.dgDuplicate.DataSource = this.exactDuplicateBindingSource;
            this.dgDuplicate.Location = new System.Drawing.Point(15, 623);
            this.dgDuplicate.Name = "dgDuplicate";
            this.dgDuplicate.ReadOnly = true;
            this.dgDuplicate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDuplicate.Size = new System.Drawing.Size(571, 204);
            this.dgDuplicate.TabIndex = 13;
            this.dgDuplicate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDuplicate_CellClick);
            this.dgDuplicate.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDuplicate_ColumnHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Deleted";
            this.dataGridViewTextBoxColumn1.FalseValue = "False";
            this.dataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.TrueValue = "True";
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn2
            // 
            this.fileNameDataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn2.FillWeight = 154.2129F;
            this.fileNameDataGridViewTextBoxColumn2.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn2.Name = "fileNameDataGridViewTextBoxColumn2";
            this.fileNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn2
            // 
            this.sizeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizeDataGridViewTextBoxColumn2.DataPropertyName = "Size";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.sizeDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.sizeDataGridViewTextBoxColumn2.FillWeight = 58.93486F;
            this.sizeDataGridViewTextBoxColumn2.HeaderText = "Size(KB)";
            this.sizeDataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.sizeDataGridViewTextBoxColumn2.Name = "sizeDataGridViewTextBoxColumn2";
            this.sizeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn2.Width = 72;
            // 
            // lastModifiedTimeDataGridViewTextBoxColumn2
            // 
            this.lastModifiedTimeDataGridViewTextBoxColumn2.DataPropertyName = "LastModifiedTime";
            this.lastModifiedTimeDataGridViewTextBoxColumn2.FillWeight = 107.2586F;
            this.lastModifiedTimeDataGridViewTextBoxColumn2.HeaderText = "Modified On";
            this.lastModifiedTimeDataGridViewTextBoxColumn2.Name = "lastModifiedTimeDataGridViewTextBoxColumn2";
            this.lastModifiedTimeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // filePathDataGridViewTextBoxColumn2
            // 
            this.filePathDataGridViewTextBoxColumn2.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn2.FillWeight = 154.2129F;
            this.filePathDataGridViewTextBoxColumn2.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn2.Name = "filePathDataGridViewTextBoxColumn2";
            this.filePathDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iDNoVersionDataGridViewTextBoxColumn2
            // 
            this.iDNoVersionDataGridViewTextBoxColumn2.DataPropertyName = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn2.HeaderText = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn2.Name = "iDNoVersionDataGridViewTextBoxColumn2";
            this.iDNoVersionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDNoVersionDataGridViewTextBoxColumn2.Visible = false;
            // 
            // exactDuplicateBindingSource
            // 
            this.exactDuplicateBindingSource.DataMember = "ExactDuplicate";
            this.exactDuplicateBindingSource.DataSource = typeof(FileSorterLibrary.SearchData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Multiple Versions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-6, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Exact Duplicates";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(483, 42);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(118, 30);
            this.btnCancelRequest.TabIndex = 16;
            this.btnCancelRequest.Text = "Cancel and Get Data";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1189, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(76, 25);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(615, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Following files will be deleted. ";
            // 
            // dgDeleteList
            // 
            this.dgDeleteList.AllowUserToAddRows = false;
            this.dgDeleteList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.dgDeleteList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDeleteList.AutoGenerateColumns = false;
            this.dgDeleteList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDeleteList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgDeleteList.BackgroundColor = System.Drawing.Color.White;
            this.dgDeleteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeleteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deletedDataGridViewCheckBoxColumn,
            this.iDDataGridViewTextBoxColumn3,
            this.iDNoVersionDataGridViewTextBoxColumn3,
            this.fileNameDataGridViewTextBoxColumn3,
            this.filePathDataGridViewTextBoxColumn3,
            this.sizeDataGridViewTextBoxColumn3,
            this.lastModifiedTimeDataGridViewTextBoxColumn3});
            this.dgDeleteList.DataSource = this.documentsBindingSource;
            this.dgDeleteList.GridColor = System.Drawing.Color.Red;
            this.dgDeleteList.Location = new System.Drawing.Point(592, 98);
            this.dgDeleteList.Name = "dgDeleteList";
            this.dgDeleteList.ReadOnly = true;
            this.dgDeleteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDeleteList.Size = new System.Drawing.Size(565, 676);
            this.dgDeleteList.TabIndex = 18;
            this.dgDeleteList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeleteList_CellClick);
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // iDNoVersionDataGridViewTextBoxColumn3
            // 
            this.iDNoVersionDataGridViewTextBoxColumn3.DataPropertyName = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn3.HeaderText = "ID_NoVersion";
            this.iDNoVersionDataGridViewTextBoxColumn3.Name = "iDNoVersionDataGridViewTextBoxColumn3";
            this.iDNoVersionDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDNoVersionDataGridViewTextBoxColumn3.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn3
            // 
            this.fileNameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fileNameDataGridViewTextBoxColumn3.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn3.FillWeight = 8.474579F;
            this.fileNameDataGridViewTextBoxColumn3.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn3.Name = "fileNameDataGridViewTextBoxColumn3";
            this.fileNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn3.Width = 76;
            // 
            // filePathDataGridViewTextBoxColumn3
            // 
            this.filePathDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.filePathDataGridViewTextBoxColumn3.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn3.FillWeight = 283.0508F;
            this.filePathDataGridViewTextBoxColumn3.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn3.Name = "filePathDataGridViewTextBoxColumn3";
            this.filePathDataGridViewTextBoxColumn3.ReadOnly = true;
            this.filePathDataGridViewTextBoxColumn3.Width = 70;
            // 
            // sizeDataGridViewTextBoxColumn3
            // 
            this.sizeDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizeDataGridViewTextBoxColumn3.DataPropertyName = "Size";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sizeDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.sizeDataGridViewTextBoxColumn3.HeaderText = "Size(KB)";
            this.sizeDataGridViewTextBoxColumn3.Name = "sizeDataGridViewTextBoxColumn3";
            this.sizeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn3.Width = 72;
            // 
            // lastModifiedTimeDataGridViewTextBoxColumn3
            // 
            this.lastModifiedTimeDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastModifiedTimeDataGridViewTextBoxColumn3.DataPropertyName = "LastModifiedTime";
            this.lastModifiedTimeDataGridViewTextBoxColumn3.FillWeight = 8.474579F;
            this.lastModifiedTimeDataGridViewTextBoxColumn3.HeaderText = "Last Modified";
            this.lastModifiedTimeDataGridViewTextBoxColumn3.Name = "lastModifiedTimeDataGridViewTextBoxColumn3";
            this.lastModifiedTimeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.lastModifiedTimeDataGridViewTextBoxColumn3.Width = 95;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = typeof(FileSorterLibrary.SearchData);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(809, 42);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(118, 30);
            this.btnDeleteList.TabIndex = 20;
            this.btnDeleteList.Text = "Prepare Delete List";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // chkAllowMainFiles
            // 
            this.chkAllowMainFiles.AutoSize = true;
            this.chkAllowMainFiles.Checked = true;
            this.chkAllowMainFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowMainFiles.Location = new System.Drawing.Point(632, 49);
            this.chkAllowMainFiles.Name = "chkAllowMainFiles";
            this.chkAllowMainFiles.Size = new System.Drawing.Size(135, 17);
            this.chkAllowMainFiles.TabIndex = 21;
            this.chkAllowMainFiles.Text = "Allow Delete Main Files";
            this.chkAllowMainFiles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select File Type";
            // 
            // btnActualDelete
            // 
            this.btnActualDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualDelete.ForeColor = System.Drawing.Color.Red;
            this.btnActualDelete.Location = new System.Drawing.Point(993, 42);
            this.btnActualDelete.Name = "btnActualDelete";
            this.btnActualDelete.Size = new System.Drawing.Size(122, 30);
            this.btnActualDelete.TabIndex = 23;
            this.btnActualDelete.Text = "DELETE files";
            this.btnActualDelete.UseVisualStyleBackColor = true;
            this.btnActualDelete.Click += new System.EventHandler(this.btnActualDeletes_Click);
            // 
            // txtCompareResult
            // 
            this.txtCompareResult.Location = new System.Drawing.Point(1201, 98);
            this.txtCompareResult.Name = "txtCompareResult";
            this.txtCompareResult.Size = new System.Drawing.Size(331, 563);
            this.txtCompareResult.TabIndex = 24;
            this.txtCompareResult.Text = "";
            // 
            // btnCompareBinary
            // 
            this.btnCompareBinary.Location = new System.Drawing.Point(1144, 44);
            this.btnCompareBinary.Name = "btnCompareBinary";
            this.btnCompareBinary.Size = new System.Drawing.Size(120, 34);
            this.btnCompareBinary.TabIndex = 25;
            this.btnCompareBinary.Text = "Deep Compare";
            this.btnCompareBinary.UseVisualStyleBackColor = true;
            this.btnCompareBinary.Click += new System.EventHandler(this.btnCompareBinary_Click);
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 839);
            this.Controls.Add(this.btnCompareBinary);
            this.Controls.Add(this.txtCompareResult);
            this.Controls.Add(this.btnActualDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkAllowMainFiles);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgDeleteList);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDuplicate);
            this.Controls.Add(this.dgMultiple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkTemporary);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cboFileTypes);
            this.Controls.Add(this.linkStartPath);
            this.Name = "StartupScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultiple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipleVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDuplicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exactDuplicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderToStart;
        private System.Windows.Forms.LinkLabel linkStartPath;
        private System.Windows.Forms.ComboBox cboFileTypes;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox chkTemporary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMultiple;
        private System.Windows.Forms.DataGridView dgDuplicate;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private System.Windows.Forms.BindingSource multipleVersionBindingSource;
        private System.Windows.Forms.BindingSource exactDuplicateBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelRequest;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgDeleteList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.CheckBox chkAllowMainFiles;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoVersionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedTimeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoVersionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.RichTextBox txtCompareResult;
        private System.Windows.Forms.Button btnCompareBinary;
    }
}

