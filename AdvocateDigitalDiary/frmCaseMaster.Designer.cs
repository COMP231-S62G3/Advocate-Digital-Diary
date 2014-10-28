namespace AdvocateDigitalDiary
{
    partial class frmCaseMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditDefendent = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssCaseMaster = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEditPlaintiff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDefendent = new System.Windows.Forms.DataGridView();
            this.btnPlantiffReset = new System.Windows.Forms.Button();
            this.btnAddPlantiff = new System.Windows.Forms.Button();
            this.dgvPlantiff = new System.Windows.Forms.DataGridView();
            this.cboPlantiffPartyType = new System.Windows.Forms.ComboBox();
            this.lblplantiffID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPlantiffPhone = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnCaseCancel = new System.Windows.Forms.Button();
            this.btnSaveCase = new System.Windows.Forms.Button();
            this.lblPlantiffPin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPlantiffAddress = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPlantiffCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPlantiffName = new System.Windows.Forms.Label();
            this.cboCaseJudgeId = new System.Windows.Forms.ComboBox();
            this.lblCaseJudgeId = new System.Windows.Forms.Label();
            this.cboCaseTypeId = new System.Windows.Forms.ComboBox();
            this.lblCaseCaseTypeId = new System.Windows.Forms.Label();
            this.cboCourtTypeId = new System.Windows.Forms.ComboBox();
            this.lblCaseCourtId = new System.Windows.Forms.Label();
            this.DtCasesFileDate = new System.Windows.Forms.DateTimePicker();
            this.lblCaseFileDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCaseDescription = new System.Windows.Forms.Label();
            this.txtCaseTitle = new System.Windows.Forms.TextBox();
            this.lblCaseTitle = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefendent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantiff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditDefendent
            // 
            this.btnEditDefendent.Location = new System.Drawing.Point(392, 270);
            this.btnEditDefendent.Name = "btnEditDefendent";
            this.btnEditDefendent.Size = new System.Drawing.Size(75, 23);
            this.btnEditDefendent.TabIndex = 21;
            this.btnEditDefendent.Text = "Edit";
            this.btnEditDefendent.UseVisualStyleBackColor = true;
            this.btnEditDefendent.Click += new System.EventHandler(this.btnEditDefendent_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssCaseMaster});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ssCaseMaster
            // 
            this.ssCaseMaster.Name = "ssCaseMaster";
            this.ssCaseMaster.Size = new System.Drawing.Size(16, 17);
            this.ssCaseMaster.Text = "...";
            // 
            // btnEditPlaintiff
            // 
            this.btnEditPlaintiff.Location = new System.Drawing.Point(11, 270);
            this.btnEditPlaintiff.Name = "btnEditPlaintiff";
            this.btnEditPlaintiff.Size = new System.Drawing.Size(75, 23);
            this.btnEditPlaintiff.TabIndex = 20;
            this.btnEditPlaintiff.Text = "Edit";
            this.btnEditPlaintiff.UseVisualStyleBackColor = true;
            this.btnEditPlaintiff.Click += new System.EventHandler(this.btnEditPlaintiff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Defendants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plaintiffs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDefendent
            // 
            this.dgvDefendent.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefendent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDefendent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefendent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDefendent.Location = new System.Drawing.Point(392, 117);
            this.dgvDefendent.MultiSelect = false;
            this.dgvDefendent.Name = "dgvDefendent";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefendent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDefendent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefendent.Size = new System.Drawing.Size(355, 147);
            this.dgvDefendent.TabIndex = 17;
            this.dgvDefendent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefendent_CellContentClick);
            // 
            // btnPlantiffReset
            // 
            this.btnPlantiffReset.Location = new System.Drawing.Point(674, 75);
            this.btnPlantiffReset.Name = "btnPlantiffReset";
            this.btnPlantiffReset.Size = new System.Drawing.Size(75, 23);
            this.btnPlantiffReset.TabIndex = 14;
            this.btnPlantiffReset.Text = "Reset";
            this.btnPlantiffReset.UseVisualStyleBackColor = true;
            this.btnPlantiffReset.Click += new System.EventHandler(this.btnPlantiffReset_Click);
            // 
            // btnAddPlantiff
            // 
            this.btnAddPlantiff.Location = new System.Drawing.Point(567, 75);
            this.btnAddPlantiff.Name = "btnAddPlantiff";
            this.btnAddPlantiff.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlantiff.TabIndex = 13;
            this.btnAddPlantiff.Text = "Add";
            this.btnAddPlantiff.UseVisualStyleBackColor = true;
            this.btnAddPlantiff.Click += new System.EventHandler(this.btnAddPlantiff_Click);
            // 
            // dgvPlantiff
            // 
            this.dgvPlantiff.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlantiff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlantiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlantiff.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlantiff.Location = new System.Drawing.Point(11, 117);
            this.dgvPlantiff.MultiSelect = false;
            this.dgvPlantiff.Name = "dgvPlantiff";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlantiff.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlantiff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantiff.Size = new System.Drawing.Size(361, 147);
            this.dgvPlantiff.TabIndex = 15;
            this.dgvPlantiff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlantiff_CellContentClick);
            // 
            // cboPlantiffPartyType
            // 
            this.cboPlantiffPartyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlantiffPartyType.FormattingEnabled = true;
            this.cboPlantiffPartyType.Items.AddRange(new object[] {
            "Plaintiff",
            "Defendent"});
            this.cboPlantiffPartyType.Location = new System.Drawing.Point(69, 19);
            this.cboPlantiffPartyType.Name = "cboPlantiffPartyType";
            this.cboPlantiffPartyType.Size = new System.Drawing.Size(183, 21);
            this.cboPlantiffPartyType.TabIndex = 6;
            this.cboPlantiffPartyType.SelectedIndexChanged += new System.EventHandler(this.cboPlantiffPartyType_SelectedIndexChanged);
            // 
            // lblplantiffID
            // 
            this.lblplantiffID.AutoSize = true;
            this.lblplantiffID.Location = new System.Drawing.Point(8, 24);
            this.lblplantiffID.Name = "lblplantiffID";
            this.lblplantiffID.Size = new System.Drawing.Size(55, 13);
            this.lblplantiffID.TabIndex = 13;
            this.lblplantiffID.Text = "PartyType";
            this.lblplantiffID.Click += new System.EventHandler(this.lblplantiffID_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(314, 72);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 20);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPlantiffPhone
            // 
            this.lblPlantiffPhone.AutoSize = true;
            this.lblPlantiffPhone.Location = new System.Drawing.Point(258, 75);
            this.lblPlantiffPhone.Name = "lblPlantiffPhone";
            this.lblPlantiffPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPlantiffPhone.TabIndex = 8;
            this.lblPlantiffPhone.Text = "Phone No";
            this.lblPlantiffPhone.Click += new System.EventHandler(this.lblPlantiffPhone_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(68, 72);
            this.txtPin.MaxLength = 20;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(183, 20);
            this.txtPin.TabIndex = 10;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnCaseCancel
            // 
            this.btnCaseCancel.Location = new System.Drawing.Point(700, 427);
            this.btnCaseCancel.Name = "btnCaseCancel";
            this.btnCaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCaseCancel.TabIndex = 33;
            this.btnCaseCancel.Text = "Close";
            this.btnCaseCancel.UseVisualStyleBackColor = true;
            this.btnCaseCancel.Click += new System.EventHandler(this.btnCaseCancel_Click);
            // 
            // btnSaveCase
            // 
            this.btnSaveCase.Location = new System.Drawing.Point(601, 427);
            this.btnSaveCase.Name = "btnSaveCase";
            this.btnSaveCase.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCase.TabIndex = 32;
            this.btnSaveCase.Text = "Save";
            this.btnSaveCase.UseVisualStyleBackColor = true;
            this.btnSaveCase.Click += new System.EventHandler(this.btnSaveCase_Click);
            // 
            // lblPlantiffPin
            // 
            this.lblPlantiffPin.AutoSize = true;
            this.lblPlantiffPin.Location = new System.Drawing.Point(15, 75);
            this.lblPlantiffPin.Name = "lblPlantiffPin";
            this.lblPlantiffPin.Size = new System.Drawing.Size(50, 13);
            this.lblPlantiffPin.TabIndex = 6;
            this.lblPlantiffPin.Text = "Pin Code";
            this.lblPlantiffPin.Click += new System.EventHandler(this.lblPlantiffPin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditDefendent);
            this.groupBox1.Controls.Add(this.btnEditPlaintiff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDefendent);
            this.groupBox1.Controls.Add(this.btnPlantiffReset);
            this.groupBox1.Controls.Add(this.btnAddPlantiff);
            this.groupBox1.Controls.Add(this.dgvPlantiff);
            this.groupBox1.Controls.Add(this.cboPlantiffPartyType);
            this.groupBox1.Controls.Add(this.lblplantiffID);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPlantiffPhone);
            this.groupBox1.Controls.Add(this.txtPin);
            this.groupBox1.Controls.Add(this.lblPlantiffPin);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblPlantiffAddress);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblPlantiffCity);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPlantiffName);
            this.groupBox1.Location = new System.Drawing.Point(10, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 307);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(315, 46);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 20);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblPlantiffAddress
            // 
            this.lblPlantiffAddress.AutoSize = true;
            this.lblPlantiffAddress.Location = new System.Drawing.Point(264, 49);
            this.lblPlantiffAddress.Name = "lblPlantiffAddress";
            this.lblPlantiffAddress.Size = new System.Drawing.Size(45, 13);
            this.lblPlantiffAddress.TabIndex = 4;
            this.lblPlantiffAddress.Text = "Address";
            this.lblPlantiffAddress.Click += new System.EventHandler(this.lblPlantiffAddress_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(567, 46);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 20);
            this.txtCity.TabIndex = 9;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblPlantiffCity
            // 
            this.lblPlantiffCity.AutoSize = true;
            this.lblPlantiffCity.Location = new System.Drawing.Point(537, 49);
            this.lblPlantiffCity.Name = "lblPlantiffCity";
            this.lblPlantiffCity.Size = new System.Drawing.Size(24, 13);
            this.lblPlantiffCity.TabIndex = 2;
            this.lblPlantiffCity.Text = "City";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 46);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPlantiffName
            // 
            this.lblPlantiffName.AutoSize = true;
            this.lblPlantiffName.Location = new System.Drawing.Point(29, 49);
            this.lblPlantiffName.Name = "lblPlantiffName";
            this.lblPlantiffName.Size = new System.Drawing.Size(35, 13);
            this.lblPlantiffName.TabIndex = 0;
            this.lblPlantiffName.Text = "Name";
            this.lblPlantiffName.Click += new System.EventHandler(this.lblPlantiffName_Click);
            // 
            // cboCaseJudgeId
            // 
            this.cboCaseJudgeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaseJudgeId.FormattingEnabled = true;
            this.cboCaseJudgeId.Location = new System.Drawing.Point(324, 32);
            this.cboCaseJudgeId.Name = "cboCaseJudgeId";
            this.cboCaseJudgeId.Size = new System.Drawing.Size(183, 21);
            this.cboCaseJudgeId.TabIndex = 25;
            this.cboCaseJudgeId.SelectedIndexChanged += new System.EventHandler(this.cboCaseJudgeId_SelectedIndexChanged);
            // 
            // lblCaseJudgeId
            // 
            this.lblCaseJudgeId.AutoSize = true;
            this.lblCaseJudgeId.Location = new System.Drawing.Point(282, 35);
            this.lblCaseJudgeId.Name = "lblCaseJudgeId";
            this.lblCaseJudgeId.Size = new System.Drawing.Size(36, 13);
            this.lblCaseJudgeId.TabIndex = 30;
            this.lblCaseJudgeId.Text = "Judge";
            this.lblCaseJudgeId.Click += new System.EventHandler(this.lblCaseJudgeId_Click);
            // 
            // cboCaseTypeId
            // 
            this.cboCaseTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaseTypeId.FormattingEnabled = true;
            this.cboCaseTypeId.Location = new System.Drawing.Point(79, 32);
            this.cboCaseTypeId.Name = "cboCaseTypeId";
            this.cboCaseTypeId.Size = new System.Drawing.Size(183, 21);
            this.cboCaseTypeId.TabIndex = 24;
            this.cboCaseTypeId.SelectedIndexChanged += new System.EventHandler(this.cboCaseTypeId_SelectedIndexChanged);
            // 
            // lblCaseCaseTypeId
            // 
            this.lblCaseCaseTypeId.AutoSize = true;
            this.lblCaseCaseTypeId.Location = new System.Drawing.Point(18, 35);
            this.lblCaseCaseTypeId.Name = "lblCaseCaseTypeId";
            this.lblCaseCaseTypeId.Size = new System.Drawing.Size(55, 13);
            this.lblCaseCaseTypeId.TabIndex = 29;
            this.lblCaseCaseTypeId.Text = "CaseType";
            this.lblCaseCaseTypeId.Click += new System.EventHandler(this.lblCaseCaseTypeId_Click);
            // 
            // cboCourtTypeId
            // 
            this.cboCourtTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourtTypeId.FormattingEnabled = true;
            this.cboCourtTypeId.Location = new System.Drawing.Point(577, 6);
            this.cboCourtTypeId.Name = "cboCourtTypeId";
            this.cboCourtTypeId.Size = new System.Drawing.Size(183, 21);
            this.cboCourtTypeId.TabIndex = 22;
            this.cboCourtTypeId.SelectedIndexChanged += new System.EventHandler(this.cboCourtTypeId_SelectedIndexChanged);
            // 
            // lblCaseCourtId
            // 
            this.lblCaseCourtId.AutoSize = true;
            this.lblCaseCourtId.Location = new System.Drawing.Point(536, 8);
            this.lblCaseCourtId.Name = "lblCaseCourtId";
            this.lblCaseCourtId.Size = new System.Drawing.Size(32, 13);
            this.lblCaseCourtId.TabIndex = 28;
            this.lblCaseCourtId.Text = "Court";
            this.lblCaseCourtId.Click += new System.EventHandler(this.lblCaseCourtId_Click);
            // 
            // DtCasesFileDate
            // 
            this.DtCasesFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtCasesFileDate.Location = new System.Drawing.Point(324, 6);
            this.DtCasesFileDate.Name = "DtCasesFileDate";
            this.DtCasesFileDate.Size = new System.Drawing.Size(183, 20);
            this.DtCasesFileDate.TabIndex = 21;
            this.DtCasesFileDate.ValueChanged += new System.EventHandler(this.DtCasesFileDate_ValueChanged);
            // 
            // lblCaseFileDate
            // 
            this.lblCaseFileDate.AutoSize = true;
            this.lblCaseFileDate.Location = new System.Drawing.Point(269, 9);
            this.lblCaseFileDate.Name = "lblCaseFileDate";
            this.lblCaseFileDate.Size = new System.Drawing.Size(49, 13);
            this.lblCaseFileDate.TabIndex = 26;
            this.lblCaseFileDate.Text = "File Date";
            this.lblCaseFileDate.Click += new System.EventHandler(this.lblCaseFileDate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(577, 32);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 75);
            this.txtDescription.TabIndex = 27;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblCaseDescription
            // 
            this.lblCaseDescription.AutoSize = true;
            this.lblCaseDescription.Location = new System.Drawing.Point(511, 32);
            this.lblCaseDescription.Name = "lblCaseDescription";
            this.lblCaseDescription.Size = new System.Drawing.Size(60, 13);
            this.lblCaseDescription.TabIndex = 23;
            this.lblCaseDescription.Text = "Description";
            this.lblCaseDescription.Click += new System.EventHandler(this.lblCaseDescription_Click);
            // 
            // txtCaseTitle
            // 
            this.txtCaseTitle.Location = new System.Drawing.Point(78, 6);
            this.txtCaseTitle.MaxLength = 20;
            this.txtCaseTitle.Name = "txtCaseTitle";
            this.txtCaseTitle.Size = new System.Drawing.Size(183, 20);
            this.txtCaseTitle.TabIndex = 19;
            // 
            // lblCaseTitle
            // 
            this.lblCaseTitle.AutoSize = true;
            this.lblCaseTitle.Location = new System.Drawing.Point(45, 9);
            this.lblCaseTitle.Name = "lblCaseTitle";
            this.lblCaseTitle.Size = new System.Drawing.Size(27, 13);
            this.lblCaseTitle.TabIndex = 20;
            this.lblCaseTitle.Text = "Title";
            this.lblCaseTitle.Click += new System.EventHandler(this.lblCaseTitle_Click);
            // 
            // frmCaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCaseCancel);
            this.Controls.Add(this.btnSaveCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCaseJudgeId);
            this.Controls.Add(this.lblCaseJudgeId);
            this.Controls.Add(this.cboCaseTypeId);
            this.Controls.Add(this.lblCaseCaseTypeId);
            this.Controls.Add(this.cboCourtTypeId);
            this.Controls.Add(this.lblCaseCourtId);
            this.Controls.Add(this.DtCasesFileDate);
            this.Controls.Add(this.lblCaseFileDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCaseDescription);
            this.Controls.Add(this.txtCaseTitle);
            this.Controls.Add(this.lblCaseTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCaseMaster";
            this.Text = "Case Details";
            this.Load += new System.EventHandler(this.frmCaseMaster_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefendent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantiff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditDefendent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssCaseMaster;
        private System.Windows.Forms.Button btnEditPlaintiff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDefendent;
        private System.Windows.Forms.Button btnPlantiffReset;
        private System.Windows.Forms.Button btnAddPlantiff;
        private System.Windows.Forms.DataGridView dgvPlantiff;
        private System.Windows.Forms.ComboBox cboPlantiffPartyType;
        private System.Windows.Forms.Label lblplantiffID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPlantiffPhone;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnCaseCancel;
        private System.Windows.Forms.Button btnSaveCase;
        private System.Windows.Forms.Label lblPlantiffPin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPlantiffAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPlantiffCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPlantiffName;
        private System.Windows.Forms.ComboBox cboCaseJudgeId;
        private System.Windows.Forms.Label lblCaseJudgeId;
        private System.Windows.Forms.ComboBox cboCaseTypeId;
        private System.Windows.Forms.Label lblCaseCaseTypeId;
        private System.Windows.Forms.ComboBox cboCourtTypeId;
        private System.Windows.Forms.Label lblCaseCourtId;
        private System.Windows.Forms.DateTimePicker DtCasesFileDate;
        private System.Windows.Forms.Label lblCaseFileDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCaseDescription;
        private System.Windows.Forms.TextBox txtCaseTitle;
        private System.Windows.Forms.Label lblCaseTitle;

    }
}