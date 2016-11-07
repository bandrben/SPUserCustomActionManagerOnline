namespace SPUserCustomActionManagerOnline
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.cbIsSPOnline = new System.Windows.Forms.CheckBox();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lnkOpenSnippet = new System.Windows.Forms.LinkLabel();
            this.ddlSnippets = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddAction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScriptSrc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbScriptBlock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScriptSeq = new System.Windows.Forms.TextBox();
            this.tbActionDescr = new System.Windows.Forms.TextBox();
            this.tbActionName = new System.Windows.Forms.TextBox();
            this.btnDelSel = new System.Windows.Forms.Button();
            this.btnSaveSelChanges = new System.Windows.Forms.Button();
            this.btnLoadActions = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScriptSrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScriptBlock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCheckUserScriptsEnabled = new System.Windows.Forms.Button();
            this.ddlAdvRegType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAdvRegID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAdvCmdUIExt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAdvURL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAdvLocation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAdvImageURL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAdvGroup = new System.Windows.Forms.TextBox();
            this.btnAdvAddAction = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdvScriptSrc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdvScriptBlock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAdvSeq = new System.Windows.Forms.TextBox();
            this.tbAdvDescr = new System.Windows.Forms.TextBox();
            this.tbAdvName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbSiteUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.lnkExport = new System.Windows.Forms.LinkLabel();
            this.imageBandR = new System.Windows.Forms.PictureBox();
            this.imageBandRwait = new System.Windows.Forms.PictureBox();
            this.lblErrorFound = new System.Windows.Forms.Label();
            this.lblNoErrorFound = new System.Windows.Forms.Label();
            this.ddlScope = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandRwait)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tb1.Controls.Add(this.tabPage2);
            this.tb1.Controls.Add(this.tabPage1);
            this.tb1.Controls.Add(this.tabPage3);
            this.tb1.Location = new System.Drawing.Point(12, 56);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(909, 471);
            this.tb1.TabIndex = 500;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnTestConnection);
            this.tabPage2.Controls.Add(this.cbIsSPOnline);
            this.tabPage2.Controls.Add(this.tbDomain);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.lblPassword);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.lblUsername);
            this.tabPage2.Controls.Add(this.tbUsername);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(901, 442);
            this.tabPage2.TabIndex = 500;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTestConnection.Location = new System.Drawing.Point(67, 111);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(120, 23);
            this.btnTestConnection.TabIndex = 14;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // cbIsSPOnline
            // 
            this.cbIsSPOnline.AutoSize = true;
            this.cbIsSPOnline.Location = new System.Drawing.Point(67, 88);
            this.cbIsSPOnline.Name = "cbIsSPOnline";
            this.cbIsSPOnline.Size = new System.Drawing.Size(81, 17);
            this.cbIsSPOnline.TabIndex = 13;
            this.cbIsSPOnline.Text = "Is SPOnline";
            this.cbIsSPOnline.UseVisualStyleBackColor = true;
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(67, 62);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(301, 20);
            this.tbDomain.TabIndex = 12;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(5, 65);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(46, 13);
            this.label41.TabIndex = 500;
            this.label41.Text = "Domain:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 39);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 500;
            this.lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(67, 36);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(301, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 500;
            this.lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(67, 10);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(301, 20);
            this.tbUsername.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lnkOpenSnippet);
            this.tabPage1.Controls.Add(this.ddlSnippets);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.btnAddAction);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbScriptSrc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbScriptBlock);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbScriptSeq);
            this.tabPage1.Controls.Add(this.tbActionDescr);
            this.tabPage1.Controls.Add(this.tbActionName);
            this.tabPage1.Controls.Add(this.btnDelSel);
            this.tabPage1.Controls.Add(this.btnSaveSelChanges);
            this.tabPage1.Controls.Add(this.btnLoadActions);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 442);
            this.tabPage1.TabIndex = 500;
            this.tabPage1.Text = "Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lnkOpenSnippet
            // 
            this.lnkOpenSnippet.AutoSize = true;
            this.lnkOpenSnippet.Location = new System.Drawing.Point(739, 138);
            this.lnkOpenSnippet.Name = "lnkOpenSnippet";
            this.lnkOpenSnippet.Size = new System.Drawing.Size(31, 13);
            this.lnkOpenSnippet.TabIndex = 703;
            this.lnkOpenSnippet.TabStop = true;
            this.lnkOpenSnippet.Text = "Load";
            this.lnkOpenSnippet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenSnippet_LinkClicked);
            // 
            // ddlSnippets
            // 
            this.ddlSnippets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSnippets.FormattingEnabled = true;
            this.ddlSnippets.Location = new System.Drawing.Point(482, 135);
            this.ddlSnippets.Name = "ddlSnippets";
            this.ddlSnippets.Size = new System.Drawing.Size(251, 21);
            this.ddlSnippets.TabIndex = 702;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(401, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 503;
            this.label21.Text = "Insert Snippet:";
            // 
            // btnAddAction
            // 
            this.btnAddAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddAction.Location = new System.Drawing.Point(71, 83);
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.Size = new System.Drawing.Size(111, 23);
            this.btnAddAction.TabIndex = 500;
            this.btnAddAction.Text = "Add New Action";
            this.btnAddAction.UseVisualStyleBackColor = false;
            this.btnAddAction.Click += new System.EventHandler(this.btnAddAction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 500;
            this.label6.Text = "Script Src:";
            // 
            // tbScriptSrc
            // 
            this.tbScriptSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScriptSrc.Location = new System.Drawing.Point(403, 5);
            this.tbScriptSrc.MinimumSize = new System.Drawing.Size(225, 4);
            this.tbScriptSrc.Name = "tbScriptSrc";
            this.tbScriptSrc.Size = new System.Drawing.Size(486, 20);
            this.tbScriptSrc.TabIndex = 23;
            this.tbScriptSrc.MouseEnter += new System.EventHandler(this.tbScriptSrc_MouseEnter);
            this.tbScriptSrc.MouseLeave += new System.EventHandler(this.tbScriptSrc_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 500;
            this.label5.Text = "Script Block:";
            // 
            // tbScriptBlock
            // 
            this.tbScriptBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScriptBlock.Location = new System.Drawing.Point(403, 31);
            this.tbScriptBlock.MinimumSize = new System.Drawing.Size(225, 4);
            this.tbScriptBlock.Multiline = true;
            this.tbScriptBlock.Name = "tbScriptBlock";
            this.tbScriptBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbScriptBlock.Size = new System.Drawing.Size(486, 98);
            this.tbScriptBlock.TabIndex = 24;
            this.tbScriptBlock.WordWrap = false;
            this.tbScriptBlock.MouseEnter += new System.EventHandler(this.tbScriptBlock_MouseEnter);
            this.tbScriptBlock.MouseLeave += new System.EventHandler(this.tbScriptBlock_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 500;
            this.label4.Text = "Sequence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 500;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 500;
            this.label2.Text = "Name:";
            // 
            // tbScriptSeq
            // 
            this.tbScriptSeq.Location = new System.Drawing.Point(71, 57);
            this.tbScriptSeq.Name = "tbScriptSeq";
            this.tbScriptSeq.Size = new System.Drawing.Size(247, 20);
            this.tbScriptSeq.TabIndex = 22;
            this.tbScriptSeq.MouseEnter += new System.EventHandler(this.tbScriptSeq_MouseEnter);
            this.tbScriptSeq.MouseLeave += new System.EventHandler(this.tbScriptSeq_MouseLeave);
            // 
            // tbActionDescr
            // 
            this.tbActionDescr.Location = new System.Drawing.Point(71, 31);
            this.tbActionDescr.Name = "tbActionDescr";
            this.tbActionDescr.Size = new System.Drawing.Size(247, 20);
            this.tbActionDescr.TabIndex = 21;
            // 
            // tbActionName
            // 
            this.tbActionName.Location = new System.Drawing.Point(71, 5);
            this.tbActionName.Name = "tbActionName";
            this.tbActionName.Size = new System.Drawing.Size(247, 20);
            this.tbActionName.TabIndex = 20;
            this.tbActionName.MouseEnter += new System.EventHandler(this.tbActionName_MouseEnter);
            this.tbActionName.MouseLeave += new System.EventHandler(this.tbActionName_MouseLeave);
            // 
            // btnDelSel
            // 
            this.btnDelSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelSel.Location = new System.Drawing.Point(255, 169);
            this.btnDelSel.Name = "btnDelSel";
            this.btnDelSel.Size = new System.Drawing.Size(111, 23);
            this.btnDelSel.TabIndex = 500;
            this.btnDelSel.Text = "Delete Selected";
            this.btnDelSel.UseVisualStyleBackColor = false;
            this.btnDelSel.Click += new System.EventHandler(this.btnDelSel_Click);
            // 
            // btnSaveSelChanges
            // 
            this.btnSaveSelChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveSelChanges.Location = new System.Drawing.Point(123, 169);
            this.btnSaveSelChanges.Name = "btnSaveSelChanges";
            this.btnSaveSelChanges.Size = new System.Drawing.Size(126, 23);
            this.btnSaveSelChanges.TabIndex = 500;
            this.btnSaveSelChanges.Text = "Save Grid Changes";
            this.btnSaveSelChanges.UseVisualStyleBackColor = false;
            this.btnSaveSelChanges.Click += new System.EventHandler(this.btnSaveSelChanges_Click);
            // 
            // btnLoadActions
            // 
            this.btnLoadActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoadActions.Location = new System.Drawing.Point(6, 169);
            this.btnLoadActions.Name = "btnLoadActions";
            this.btnLoadActions.Size = new System.Drawing.Size(111, 23);
            this.btnLoadActions.TabIndex = 500;
            this.btnLoadActions.Text = "Load Actions";
            this.btnLoadActions.UseVisualStyleBackColor = false;
            this.btnLoadActions.Click += new System.EventHandler(this.btnLoadActions_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colID,
            this.colName,
            this.colDescr,
            this.colSeq,
            this.colScriptSrc,
            this.colScriptBlock});
            this.dataGridView1.Location = new System.Drawing.Point(6, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 236);
            this.dataGridView1.TabIndex = 500;
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // colSelect
            // 
            this.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSelect.HeaderText = "Select";
            this.colSelect.MinimumWidth = 50;
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 50;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 43;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 60;
            // 
            // colDescr
            // 
            this.colDescr.HeaderText = "Descr";
            this.colDescr.Name = "colDescr";
            this.colDescr.Width = 150;
            // 
            // colSeq
            // 
            this.colSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSeq.HeaderText = "Seq";
            this.colSeq.Name = "colSeq";
            this.colSeq.Width = 51;
            // 
            // colScriptSrc
            // 
            this.colScriptSrc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colScriptSrc.HeaderText = "ScriptSrc";
            this.colScriptSrc.Name = "colScriptSrc";
            this.colScriptSrc.Width = 75;
            // 
            // colScriptBlock
            // 
            this.colScriptBlock.HeaderText = "ScriptBlock";
            this.colScriptBlock.Name = "colScriptBlock";
            this.colScriptBlock.Width = 200;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.btnCheckUserScriptsEnabled);
            this.tabPage3.Controls.Add(this.ddlAdvRegType);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.tbAdvRegID);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.tbAdvCmdUIExt);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.tbAdvURL);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.tbAdvLocation);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbAdvImageURL);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tbAdvGroup);
            this.tabPage3.Controls.Add(this.btnAdvAddAction);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tbAdvScriptSrc);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbAdvScriptBlock);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbAdvSeq);
            this.tabPage3.Controls.Add(this.tbAdvDescr);
            this.tabPage3.Controls.Add(this.tbAdvName);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 442);
            this.tabPage3.TabIndex = 501;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCheckUserScriptsEnabled
            // 
            this.btnCheckUserScriptsEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheckUserScriptsEnabled.Location = new System.Drawing.Point(71, 269);
            this.btnCheckUserScriptsEnabled.Name = "btnCheckUserScriptsEnabled";
            this.btnCheckUserScriptsEnabled.Size = new System.Drawing.Size(165, 23);
            this.btnCheckUserScriptsEnabled.TabIndex = 705;
            this.btnCheckUserScriptsEnabled.Text = "Check User Scripts Enabled";
            this.btnCheckUserScriptsEnabled.UseVisualStyleBackColor = false;
            this.btnCheckUserScriptsEnabled.Click += new System.EventHandler(this.btnCheckUserScriptsEnabled_Click);
            // 
            // ddlAdvRegType
            // 
            this.ddlAdvRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAdvRegType.FormattingEnabled = true;
            this.ddlAdvRegType.Items.AddRange(new object[] {
            "SKIP",
            "None",
            "List",
            "ContentType",
            "ProgId",
            "FileType"});
            this.ddlAdvRegType.Location = new System.Drawing.Point(71, 213);
            this.ddlAdvRegType.Name = "ddlAdvRegType";
            this.ddlAdvRegType.Size = new System.Drawing.Size(247, 21);
            this.ddlAdvRegType.TabIndex = 608;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 525;
            this.label18.Text = "Reg. Type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 523;
            this.label17.Text = "Reg. ID:";
            // 
            // tbAdvRegID
            // 
            this.tbAdvRegID.Location = new System.Drawing.Point(71, 187);
            this.tbAdvRegID.Name = "tbAdvRegID";
            this.tbAdvRegID.Size = new System.Drawing.Size(247, 20);
            this.tbAdvRegID.TabIndex = 607;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(332, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 521;
            this.label16.Text = "Cmd UI Ext:";
            // 
            // tbAdvCmdUIExt
            // 
            this.tbAdvCmdUIExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdvCmdUIExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdvCmdUIExt.Location = new System.Drawing.Point(403, 109);
            this.tbAdvCmdUIExt.MinimumSize = new System.Drawing.Size(225, 4);
            this.tbAdvCmdUIExt.Multiline = true;
            this.tbAdvCmdUIExt.Name = "tbAdvCmdUIExt";
            this.tbAdvCmdUIExt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdvCmdUIExt.Size = new System.Drawing.Size(484, 72);
            this.tbAdvCmdUIExt.TabIndex = 612;
            this.tbAdvCmdUIExt.WordWrap = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 519;
            this.label15.Text = "URL:";
            // 
            // tbAdvURL
            // 
            this.tbAdvURL.Location = new System.Drawing.Point(71, 161);
            this.tbAdvURL.Name = "tbAdvURL";
            this.tbAdvURL.Size = new System.Drawing.Size(247, 20);
            this.tbAdvURL.TabIndex = 606;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 517;
            this.label14.Text = "Location:";
            // 
            // tbAdvLocation
            // 
            this.tbAdvLocation.Location = new System.Drawing.Point(71, 135);
            this.tbAdvLocation.Name = "tbAdvLocation";
            this.tbAdvLocation.Size = new System.Drawing.Size(247, 20);
            this.tbAdvLocation.TabIndex = 605;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 515;
            this.label13.Text = "Image URL:";
            // 
            // tbAdvImageURL
            // 
            this.tbAdvImageURL.Location = new System.Drawing.Point(71, 109);
            this.tbAdvImageURL.Name = "tbAdvImageURL";
            this.tbAdvImageURL.Size = new System.Drawing.Size(247, 20);
            this.tbAdvImageURL.TabIndex = 604;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 513;
            this.label12.Text = "Group:";
            // 
            // tbAdvGroup
            // 
            this.tbAdvGroup.Location = new System.Drawing.Point(71, 83);
            this.tbAdvGroup.Name = "tbAdvGroup";
            this.tbAdvGroup.Size = new System.Drawing.Size(247, 20);
            this.tbAdvGroup.TabIndex = 603;
            // 
            // btnAdvAddAction
            // 
            this.btnAdvAddAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdvAddAction.Location = new System.Drawing.Point(71, 240);
            this.btnAdvAddAction.Name = "btnAdvAddAction";
            this.btnAdvAddAction.Size = new System.Drawing.Size(111, 23);
            this.btnAdvAddAction.TabIndex = 613;
            this.btnAdvAddAction.Text = "Add New Action";
            this.btnAdvAddAction.UseVisualStyleBackColor = false;
            this.btnAdvAddAction.Click += new System.EventHandler(this.btnAdvAddAction_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 507;
            this.label7.Text = "Script Src:";
            // 
            // tbAdvScriptSrc
            // 
            this.tbAdvScriptSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdvScriptSrc.Location = new System.Drawing.Point(403, 5);
            this.tbAdvScriptSrc.MinimumSize = new System.Drawing.Size(225, 4);
            this.tbAdvScriptSrc.Name = "tbAdvScriptSrc";
            this.tbAdvScriptSrc.Size = new System.Drawing.Size(484, 20);
            this.tbAdvScriptSrc.TabIndex = 610;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 508;
            this.label8.Text = "Script Block:";
            // 
            // tbAdvScriptBlock
            // 
            this.tbAdvScriptBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdvScriptBlock.Location = new System.Drawing.Point(403, 31);
            this.tbAdvScriptBlock.MinimumSize = new System.Drawing.Size(225, 4);
            this.tbAdvScriptBlock.Multiline = true;
            this.tbAdvScriptBlock.Name = "tbAdvScriptBlock";
            this.tbAdvScriptBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdvScriptBlock.Size = new System.Drawing.Size(484, 72);
            this.tbAdvScriptBlock.TabIndex = 611;
            this.tbAdvScriptBlock.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 509;
            this.label9.Text = "Sequence:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 510;
            this.label10.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 511;
            this.label11.Text = "Name:";
            // 
            // tbAdvSeq
            // 
            this.tbAdvSeq.Location = new System.Drawing.Point(71, 57);
            this.tbAdvSeq.Name = "tbAdvSeq";
            this.tbAdvSeq.Size = new System.Drawing.Size(247, 20);
            this.tbAdvSeq.TabIndex = 602;
            // 
            // tbAdvDescr
            // 
            this.tbAdvDescr.Location = new System.Drawing.Point(71, 31);
            this.tbAdvDescr.Name = "tbAdvDescr";
            this.tbAdvDescr.Size = new System.Drawing.Size(247, 20);
            this.tbAdvDescr.TabIndex = 601;
            // 
            // tbAdvName
            // 
            this.tbAdvName.Location = new System.Drawing.Point(71, 5);
            this.tbAdvName.Name = "tbAdvName";
            this.tbAdvName.Size = new System.Drawing.Size(247, 20);
            this.tbAdvName.TabIndex = 600;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 500;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.BackColor = System.Drawing.SystemColors.Info;
            this.tbStatus.Location = new System.Drawing.Point(12, 533);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatus.Size = new System.Drawing.Size(948, 195);
            this.tbStatus.TabIndex = 500;
            // 
            // tbSiteUrl
            // 
            this.tbSiteUrl.Location = new System.Drawing.Point(75, 30);
            this.tbSiteUrl.Name = "tbSiteUrl";
            this.tbSiteUrl.Size = new System.Drawing.Size(454, 20);
            this.tbSiteUrl.TabIndex = 700;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 500;
            this.label1.Text = "Site URL:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 500;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lnkClear
            // 
            this.lnkClear.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClear.AutoSize = true;
            this.lnkClear.BackColor = System.Drawing.SystemColors.Info;
            this.lnkClear.Location = new System.Drawing.Point(896, 539);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(42, 13);
            this.lnkClear.TabIndex = 500;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "CLEAR";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // lnkExport
            // 
            this.lnkExport.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExport.AutoSize = true;
            this.lnkExport.BackColor = System.Drawing.SystemColors.Info;
            this.lnkExport.Location = new System.Drawing.Point(887, 555);
            this.lnkExport.Name = "lnkExport";
            this.lnkExport.Size = new System.Drawing.Size(51, 13);
            this.lnkExport.TabIndex = 500;
            this.lnkExport.TabStop = true;
            this.lnkExport.Text = "EXPORT";
            this.lnkExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExport_LinkClicked);
            // 
            // imageBandR
            // 
            this.imageBandR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBandR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBandR.Image = ((System.Drawing.Image)(resources.GetObject("imageBandR.Image")));
            this.imageBandR.Location = new System.Drawing.Point(927, 27);
            this.imageBandR.Name = "imageBandR";
            this.imageBandR.Size = new System.Drawing.Size(33, 45);
            this.imageBandR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBandR.TabIndex = 500;
            this.imageBandR.TabStop = false;
            this.imageBandR.Click += new System.EventHandler(this.imageBandR_Click);
            // 
            // imageBandRwait
            // 
            this.imageBandRwait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBandRwait.Image = ((System.Drawing.Image)(resources.GetObject("imageBandRwait.Image")));
            this.imageBandRwait.Location = new System.Drawing.Point(927, 27);
            this.imageBandRwait.Name = "imageBandRwait";
            this.imageBandRwait.Size = new System.Drawing.Size(33, 45);
            this.imageBandRwait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBandRwait.TabIndex = 500;
            this.imageBandRwait.TabStop = false;
            // 
            // lblErrorFound
            // 
            this.lblErrorFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFound.AutoSize = true;
            this.lblErrorFound.BackColor = System.Drawing.SystemColors.Info;
            this.lblErrorFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblErrorFound.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFound.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorFound.Location = new System.Drawing.Point(652, 705);
            this.lblErrorFound.Name = "lblErrorFound";
            this.lblErrorFound.Size = new System.Drawing.Size(284, 15);
            this.lblErrorFound.TabIndex = 500;
            this.lblErrorFound.Text = "1 OR MORE ERRORS FOUND, CHECK LOG";
            // 
            // lblNoErrorFound
            // 
            this.lblNoErrorFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoErrorFound.AutoSize = true;
            this.lblNoErrorFound.BackColor = System.Drawing.SystemColors.Info;
            this.lblNoErrorFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNoErrorFound.ForeColor = System.Drawing.Color.Green;
            this.lblNoErrorFound.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNoErrorFound.Location = new System.Drawing.Point(795, 705);
            this.lblNoErrorFound.Name = "lblNoErrorFound";
            this.lblNoErrorFound.Size = new System.Drawing.Size(141, 15);
            this.lblNoErrorFound.TabIndex = 500;
            this.lblNoErrorFound.Text = "NO ERRORS FOUND";
            // 
            // ddlScope
            // 
            this.ddlScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlScope.FormattingEnabled = true;
            this.ddlScope.Items.AddRange(new object[] {
            "Site Collection",
            "Web"});
            this.ddlScope.Location = new System.Drawing.Point(582, 29);
            this.ddlScope.Name = "ddlScope";
            this.ddlScope.Size = new System.Drawing.Size(147, 21);
            this.ddlScope.TabIndex = 701;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(535, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 502;
            this.label19.Text = "Scope:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 753);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ddlScope);
            this.Controls.Add(this.lblNoErrorFound);
            this.Controls.Add(this.lblErrorFound);
            this.Controls.Add(this.imageBandR);
            this.Controls.Add(this.lnkExport);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSiteUrl);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imageBandRwait);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SPUserCustomActionManagerOnline";
            this.tb1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBandRwait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbSiteUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.LinkLabel lnkExport;
        private System.Windows.Forms.PictureBox imageBandR;
        private System.Windows.Forms.PictureBox imageBandRwait;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox cbIsSPOnline;
        private System.Windows.Forms.Label lblErrorFound;
        private System.Windows.Forms.Label lblNoErrorFound;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadActions;
        private System.Windows.Forms.Button btnSaveSelChanges;
        private System.Windows.Forms.Button btnDelSel;
        private System.Windows.Forms.Button btnAddAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbScriptSrc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbScriptBlock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbScriptSeq;
        private System.Windows.Forms.TextBox tbActionDescr;
        private System.Windows.Forms.TextBox tbActionName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScriptSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScriptBlock;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAdvAddAction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdvScriptSrc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdvScriptBlock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAdvSeq;
        private System.Windows.Forms.TextBox tbAdvDescr;
        private System.Windows.Forms.TextBox tbAdvName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAdvURL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAdvLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAdvImageURL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdvGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAdvCmdUIExt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbAdvRegID;
        private System.Windows.Forms.ComboBox ddlScope;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ddlAdvRegType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel lnkOpenSnippet;
        private System.Windows.Forms.ComboBox ddlSnippets;
        private System.Windows.Forms.Button btnCheckUserScriptsEnabled;
    }
}

