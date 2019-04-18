namespace WinFrmKzvl
{
    partial class FrmTeam
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
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCaptain = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxCaptain = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.dataGridViewTeamsFind = new System.Windows.Forms.DataGridView();
            this.tMIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMGroupGroupsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.players1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(13, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 37);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.comboBoxGroup);
            this.groupBoxParametrs.Controls.Add(this.labelGroup);
            this.groupBoxParametrs.Controls.Add(this.labelCaptain);
            this.groupBoxParametrs.Controls.Add(this.labelRating);
            this.groupBoxParametrs.Controls.Add(this.labelName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxCaptain);
            this.groupBoxParametrs.Controls.Add(this.comboBoxName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxRating);
            this.groupBoxParametrs.Location = new System.Drawing.Point(11, 55);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(905, 183);
            this.groupBoxParametrs.TabIndex = 9;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Parametrs";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(278, 142);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(492, 21);
            this.comboBoxGroup.TabIndex = 7;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(22, 150);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "Group";
            // 
            // labelCaptain
            // 
            this.labelCaptain.AutoSize = true;
            this.labelCaptain.Location = new System.Drawing.Point(22, 111);
            this.labelCaptain.Name = "labelCaptain";
            this.labelCaptain.Size = new System.Drawing.Size(43, 13);
            this.labelCaptain.TabIndex = 5;
            this.labelCaptain.Text = "Captain";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(22, 70);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 4;
            this.labelRating.Text = "Rating";
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
            // comboBoxCaptain
            // 
            this.comboBoxCaptain.FormattingEnabled = true;
            this.comboBoxCaptain.Location = new System.Drawing.Point(278, 103);
            this.comboBoxCaptain.Name = "comboBoxCaptain";
            this.comboBoxCaptain.Size = new System.Drawing.Size(492, 21);
            this.comboBoxCaptain.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(278, 19);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(492, 21);
            this.comboBoxName.TabIndex = 1;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(278, 62);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(492, 21);
            this.comboBoxRating.TabIndex = 0;
            // 
            // dataGridViewTeamsFind
            // 
            this.dataGridViewTeamsFind.AllowUserToAddRows = false;
            this.dataGridViewTeamsFind.AllowUserToOrderColumns = true;
            this.dataGridViewTeamsFind.AutoGenerateColumns = false;
            this.dataGridViewTeamsFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamsFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tMIdDataGridViewTextBoxColumn,
            this.tMNameDataGridViewTextBoxColumn,
            this.tMGroupGroupsIdDataGridViewTextBoxColumn,
            this.Column1,
            this.tMRatingDataGridViewTextBoxColumn,
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn,
            this.Column2,
            this.groupsDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.players1DataGridViewTextBoxColumn});
            this.dataGridViewTeamsFind.DataSource = this.teamsBindingSource;
            this.dataGridViewTeamsFind.Location = new System.Drawing.Point(11, 244);
            this.dataGridViewTeamsFind.Name = "dataGridViewTeamsFind";
            this.dataGridViewTeamsFind.Size = new System.Drawing.Size(903, 332);
            this.dataGridViewTeamsFind.TabIndex = 8;
            // 
            // tMIdDataGridViewTextBoxColumn
            // 
            this.tMIdDataGridViewTextBoxColumn.DataPropertyName = "TM_Id";
            this.tMIdDataGridViewTextBoxColumn.HeaderText = "TM_Id";
            this.tMIdDataGridViewTextBoxColumn.Name = "tMIdDataGridViewTextBoxColumn";
            this.tMIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tMNameDataGridViewTextBoxColumn
            // 
            this.tMNameDataGridViewTextBoxColumn.DataPropertyName = "TM_Name";
            this.tMNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.tMNameDataGridViewTextBoxColumn.Name = "tMNameDataGridViewTextBoxColumn";
            // 
            // tMGroupGroupsIdDataGridViewTextBoxColumn
            // 
            this.tMGroupGroupsIdDataGridViewTextBoxColumn.DataPropertyName = "TM_Group_Groups_Id";
            this.tMGroupGroupsIdDataGridViewTextBoxColumn.HeaderText = "TM_Group_Groups_Id";
            this.tMGroupGroupsIdDataGridViewTextBoxColumn.Name = "tMGroupGroupsIdDataGridViewTextBoxColumn";
            this.tMGroupGroupsIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TM_Group_Groups_Id";
            this.Column1.DataSource = this.groupsBindingSource;
            this.Column1.DisplayMember = "GR_Name";
            this.Column1.HeaderText = "Group";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "GR_Id";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(KZVLDataEF.Groups);
            // 
            // tMRatingDataGridViewTextBoxColumn
            // 
            this.tMRatingDataGridViewTextBoxColumn.DataPropertyName = "TM_Rating";
            this.tMRatingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.tMRatingDataGridViewTextBoxColumn.Name = "tMRatingDataGridViewTextBoxColumn";
            // 
            // tMCaptainPlayersIdDataGridViewTextBoxColumn
            // 
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn.DataPropertyName = "TM_Captain_Players_Id";
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn.HeaderText = "TM_Captain_Players_Id";
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn.Name = "tMCaptainPlayersIdDataGridViewTextBoxColumn";
            this.tMCaptainPlayersIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TM_Captain_Players_Id";
            this.Column2.DataSource = this.playersBindingSource;
            this.Column2.DisplayMember = "PL_Name";
            this.Column2.HeaderText = "Captain";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "PL_Id";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = typeof(KZVLDataEF.Players);
            // 
            // groupsDataGridViewTextBoxColumn
            // 
            this.groupsDataGridViewTextBoxColumn.DataPropertyName = "Groups";
            this.groupsDataGridViewTextBoxColumn.HeaderText = "Groups";
            this.groupsDataGridViewTextBoxColumn.Name = "groupsDataGridViewTextBoxColumn";
            this.groupsDataGridViewTextBoxColumn.Visible = false;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.Visible = false;
            // 
            // players1DataGridViewTextBoxColumn
            // 
            this.players1DataGridViewTextBoxColumn.DataPropertyName = "Players1";
            this.players1DataGridViewTextBoxColumn.HeaderText = "Players1";
            this.players1DataGridViewTextBoxColumn.Name = "players1DataGridViewTextBoxColumn";
            this.players1DataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(KZVLDataEF.Teams);
            // 
            // FrmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 588);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.dataGridViewTeamsFind);
            this.Name = "FrmTeam";
            this.Text = "FrmTeam";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCaptain;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxCaptain;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.DataGridView dataGridViewTeamsFind;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMGroupGroupsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCaptainPlayersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn players1DataGridViewTextBoxColumn;
    }
}