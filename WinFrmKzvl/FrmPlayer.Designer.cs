namespace WinFrmKzvl
{
    partial class FrmPlayer
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxCountOfTheBestPlayer = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCountOfTheBestPlayer = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.dataGridViewTeamsFind = new System.Windows.Forms.DataGridView();
            this.pLIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLRoleRoleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLTeamTeamsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLCountOfBestPlayerMatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(8, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 37);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.comboBoxCategory);
            this.groupBoxParametrs.Controls.Add(this.comboBoxTeam);
            this.groupBoxParametrs.Controls.Add(this.comboBoxCountOfTheBestPlayer);
            this.groupBoxParametrs.Controls.Add(this.labelCategory);
            this.groupBoxParametrs.Controls.Add(this.labelCountOfTheBestPlayer);
            this.groupBoxParametrs.Controls.Add(this.labelTeam);
            this.groupBoxParametrs.Controls.Add(this.comboBoxRole);
            this.groupBoxParametrs.Controls.Add(this.labelRole);
            this.groupBoxParametrs.Controls.Add(this.labelHeight);
            this.groupBoxParametrs.Controls.Add(this.labelNumber);
            this.groupBoxParametrs.Controls.Add(this.labelName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxHeight);
            this.groupBoxParametrs.Controls.Add(this.comboBoxName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxNumber);
            this.groupBoxParametrs.Location = new System.Drawing.Point(8, 55);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(1022, 183);
            this.groupBoxParametrs.TabIndex = 14;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Parametrs";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(580, 147);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(319, 21);
            this.comboBoxCategory.TabIndex = 13;
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(580, 70);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(319, 21);
            this.comboBoxTeam.TabIndex = 12;
            // 
            // comboBoxCountOfTheBestPlayer
            // 
            this.comboBoxCountOfTheBestPlayer.FormattingEnabled = true;
            this.comboBoxCountOfTheBestPlayer.Location = new System.Drawing.Point(580, 108);
            this.comboBoxCountOfTheBestPlayer.Name = "comboBoxCountOfTheBestPlayer";
            this.comboBoxCountOfTheBestPlayer.Size = new System.Drawing.Size(319, 21);
            this.comboBoxCountOfTheBestPlayer.TabIndex = 11;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(455, 150);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category";
            // 
            // labelCountOfTheBestPlayer
            // 
            this.labelCountOfTheBestPlayer.AutoSize = true;
            this.labelCountOfTheBestPlayer.Location = new System.Drawing.Point(455, 111);
            this.labelCountOfTheBestPlayer.Name = "labelCountOfTheBestPlayer";
            this.labelCountOfTheBestPlayer.Size = new System.Drawing.Size(119, 13);
            this.labelCountOfTheBestPlayer.TabIndex = 9;
            this.labelCountOfTheBestPlayer.Text = "Count of the best player";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(455, 70);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(34, 13);
            this.labelTeam.TabIndex = 8;
            this.labelTeam.Text = "Team";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(79, 147);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(340, 21);
            this.comboBoxRole.TabIndex = 7;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(22, 150);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Role";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(22, 111);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(22, 70);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Number";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // comboBoxHeight
            // 
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Location = new System.Drawing.Point(79, 108);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(340, 21);
            this.comboBoxHeight.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(79, 24);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(492, 21);
            this.comboBoxName.TabIndex = 1;
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(79, 67);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(340, 21);
            this.comboBoxNumber.TabIndex = 0;
            // 
            // dataGridViewTeamsFind
            // 
            this.dataGridViewTeamsFind.AllowUserToAddRows = false;
            this.dataGridViewTeamsFind.AllowUserToOrderColumns = true;
            this.dataGridViewTeamsFind.AutoGenerateColumns = false;
            this.dataGridViewTeamsFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamsFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pLIdDataGridViewTextBoxColumn,
            this.pLNumberDataGridViewTextBoxColumn,
            this.pLNameDataGridViewTextBoxColumn,
            this.pLHeightDataGridViewTextBoxColumn,
            this.pLRoleRoleIdDataGridViewTextBoxColumn,
            this.Column1,
            this.pLTeamTeamsIdDataGridViewTextBoxColumn,
            this.Column2,
            this.pLCountOfBestPlayerMatchDataGridViewTextBoxColumn,
            this.pLCategoryDataGridViewTextBoxColumn,
            this.groupsDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn,
            this.teams1DataGridViewTextBoxColumn});
            this.dataGridViewTeamsFind.DataSource = this.playersBindingSource;
            this.dataGridViewTeamsFind.Location = new System.Drawing.Point(8, 244);
            this.dataGridViewTeamsFind.Name = "dataGridViewTeamsFind";
            this.dataGridViewTeamsFind.Size = new System.Drawing.Size(1029, 332);
            this.dataGridViewTeamsFind.TabIndex = 13;
            // 
            // pLIdDataGridViewTextBoxColumn
            // 
            this.pLIdDataGridViewTextBoxColumn.DataPropertyName = "PL_Id";
            this.pLIdDataGridViewTextBoxColumn.HeaderText = "PL_Id";
            this.pLIdDataGridViewTextBoxColumn.Name = "pLIdDataGridViewTextBoxColumn";
            this.pLIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLNumberDataGridViewTextBoxColumn
            // 
            this.pLNumberDataGridViewTextBoxColumn.DataPropertyName = "PL_Number";
            this.pLNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.pLNumberDataGridViewTextBoxColumn.Name = "pLNumberDataGridViewTextBoxColumn";
            // 
            // pLNameDataGridViewTextBoxColumn
            // 
            this.pLNameDataGridViewTextBoxColumn.DataPropertyName = "PL_Name";
            this.pLNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pLNameDataGridViewTextBoxColumn.Name = "pLNameDataGridViewTextBoxColumn";
            // 
            // pLHeightDataGridViewTextBoxColumn
            // 
            this.pLHeightDataGridViewTextBoxColumn.DataPropertyName = "PL_Height";
            this.pLHeightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.pLHeightDataGridViewTextBoxColumn.Name = "pLHeightDataGridViewTextBoxColumn";
            // 
            // pLRoleRoleIdDataGridViewTextBoxColumn
            // 
            this.pLRoleRoleIdDataGridViewTextBoxColumn.DataPropertyName = "PL_Role_Role_Id";
            this.pLRoleRoleIdDataGridViewTextBoxColumn.HeaderText = "PL_Role_Role_Id";
            this.pLRoleRoleIdDataGridViewTextBoxColumn.Name = "pLRoleRoleIdDataGridViewTextBoxColumn";
            this.pLRoleRoleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PL_Role_Role_Id";
            this.Column1.DataSource = this.roleBindingSource;
            this.Column1.DisplayMember = "RL_Name";
            this.Column1.HeaderText = "Role";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "RL_Id";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(KZVLDataEF.Role);
            // 
            // pLTeamTeamsIdDataGridViewTextBoxColumn
            // 
            this.pLTeamTeamsIdDataGridViewTextBoxColumn.DataPropertyName = "PL_Team_Teams_Id";
            this.pLTeamTeamsIdDataGridViewTextBoxColumn.HeaderText = "PL_Team_Teams_Id";
            this.pLTeamTeamsIdDataGridViewTextBoxColumn.Name = "pLTeamTeamsIdDataGridViewTextBoxColumn";
            this.pLTeamTeamsIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PL_Team_Teams_Id";
            this.Column2.DataSource = this.teamsBindingSource;
            this.Column2.DisplayMember = "TM_Name";
            this.Column2.HeaderText = "Teams";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "TM_Id";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(KZVLDataEF.Teams);
            // 
            // pLCountOfBestPlayerMatchDataGridViewTextBoxColumn
            // 
            this.pLCountOfBestPlayerMatchDataGridViewTextBoxColumn.DataPropertyName = "PL_CountOfBestPlayerMatch";
            this.pLCountOfBestPlayerMatchDataGridViewTextBoxColumn.HeaderText = "Count Of Best Player Match";
            this.pLCountOfBestPlayerMatchDataGridViewTextBoxColumn.Name = "pLCountOfBestPlayerMatchDataGridViewTextBoxColumn";
            // 
            // pLCategoryDataGridViewTextBoxColumn
            // 
            this.pLCategoryDataGridViewTextBoxColumn.DataPropertyName = "PL_Category";
            this.pLCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.pLCategoryDataGridViewTextBoxColumn.Name = "pLCategoryDataGridViewTextBoxColumn";
            // 
            // groupsDataGridViewTextBoxColumn
            // 
            this.groupsDataGridViewTextBoxColumn.DataPropertyName = "Groups";
            this.groupsDataGridViewTextBoxColumn.HeaderText = "Groups";
            this.groupsDataGridViewTextBoxColumn.Name = "groupsDataGridViewTextBoxColumn";
            this.groupsDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "Teams";
            this.teamsDataGridViewTextBoxColumn.HeaderText = "Teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // teams1DataGridViewTextBoxColumn
            // 
            this.teams1DataGridViewTextBoxColumn.DataPropertyName = "Teams1";
            this.teams1DataGridViewTextBoxColumn.HeaderText = "Teams1";
            this.teams1DataGridViewTextBoxColumn.Name = "teams1DataGridViewTextBoxColumn";
            this.teams1DataGridViewTextBoxColumn.Visible = false;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = typeof(KZVLDataEF.Players);
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 588);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.dataGridViewTeamsFind);
            this.Name = "FrmPlayer";
            this.Text = "FrmPlayer";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxCountOfTheBestPlayer;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCountOfTheBestPlayer;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxHeight;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.DataGridView dataGridViewTeamsFind;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLRoleRoleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLTeamTeamsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLCountOfBestPlayerMatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teams1DataGridViewTextBoxColumn;
    }
}