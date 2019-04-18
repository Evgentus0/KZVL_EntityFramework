namespace WinFrmKzvl
{
    partial class FrmGroup
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelBestPlayer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxBestPlayer = new System.Windows.Forms.ComboBox();
            this.dataGridViewGroupsSrc = new System.Windows.Forms.DataGridView();
            this.gRIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.divizionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divizionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupsSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divizionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(13, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 37);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.labelNumber);
            this.groupBoxParametrs.Controls.Add(this.labelBestPlayer);
            this.groupBoxParametrs.Controls.Add(this.labelName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxNumber);
            this.groupBoxParametrs.Controls.Add(this.comboBoxName);
            this.groupBoxParametrs.Controls.Add(this.comboBoxBestPlayer);
            this.groupBoxParametrs.Location = new System.Drawing.Point(11, 55);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(905, 183);
            this.groupBoxParametrs.TabIndex = 14;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Parametrs";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(22, 144);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(84, 13);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "Divizion Number";
            // 
            // labelBestPlayer
            // 
            this.labelBestPlayer.AutoSize = true;
            this.labelBestPlayer.Location = new System.Drawing.Point(22, 89);
            this.labelBestPlayer.Name = "labelBestPlayer";
            this.labelBestPlayer.Size = new System.Drawing.Size(60, 13);
            this.labelBestPlayer.TabIndex = 4;
            this.labelBestPlayer.Text = "Best Player";
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
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(278, 136);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(492, 21);
            this.comboBoxNumber.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(278, 19);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(492, 21);
            this.comboBoxName.TabIndex = 1;
            // 
            // comboBoxBestPlayer
            // 
            this.comboBoxBestPlayer.FormattingEnabled = true;
            this.comboBoxBestPlayer.Location = new System.Drawing.Point(278, 81);
            this.comboBoxBestPlayer.Name = "comboBoxBestPlayer";
            this.comboBoxBestPlayer.Size = new System.Drawing.Size(492, 21);
            this.comboBoxBestPlayer.TabIndex = 0;
            // 
            // dataGridViewGroupsSrc
            // 
            this.dataGridViewGroupsSrc.AllowUserToAddRows = false;
            this.dataGridViewGroupsSrc.AllowUserToOrderColumns = true;
            this.dataGridViewGroupsSrc.AutoGenerateColumns = false;
            this.dataGridViewGroupsSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupsSrc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRIdDataGridViewTextBoxColumn,
            this.gRNameDataGridViewTextBoxColumn,
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn,
            this.Column1,
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn,
            this.Column2,
            this.divizionsDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn});
            this.dataGridViewGroupsSrc.DataSource = this.groupsBindingSource;
            this.dataGridViewGroupsSrc.Location = new System.Drawing.Point(11, 244);
            this.dataGridViewGroupsSrc.Name = "dataGridViewGroupsSrc";
            this.dataGridViewGroupsSrc.Size = new System.Drawing.Size(903, 332);
            this.dataGridViewGroupsSrc.TabIndex = 13;
            // 
            // gRIdDataGridViewTextBoxColumn
            // 
            this.gRIdDataGridViewTextBoxColumn.DataPropertyName = "GR_Id";
            this.gRIdDataGridViewTextBoxColumn.HeaderText = "GR_Id";
            this.gRIdDataGridViewTextBoxColumn.Name = "gRIdDataGridViewTextBoxColumn";
            this.gRIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // gRNameDataGridViewTextBoxColumn
            // 
            this.gRNameDataGridViewTextBoxColumn.DataPropertyName = "GR_Name";
            this.gRNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.gRNameDataGridViewTextBoxColumn.Name = "gRNameDataGridViewTextBoxColumn";
            // 
            // gRBestPlayerPlayersIdDataGridViewTextBoxColumn
            // 
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn.DataPropertyName = "GR_BestPlayer_Players_Id";
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn.HeaderText = "GR_BestPlayer_Players_Id";
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn.Name = "gRBestPlayerPlayersIdDataGridViewTextBoxColumn";
            this.gRBestPlayerPlayersIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GR_BestPlayer_Players_Id";
            this.Column1.DataSource = this.playersBindingSource;
            this.Column1.DisplayMember = "PL_Name";
            this.Column1.HeaderText = "Best Player";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "PL_Id";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = typeof(KZVLDataEF.Players);
            // 
            // gRDivizionDivizionsIdDataGridViewTextBoxColumn
            // 
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn.DataPropertyName = "GR_Divizion_Divizions_Id";
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn.HeaderText = "Divizion";
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn.Name = "gRDivizionDivizionsIdDataGridViewTextBoxColumn";
            this.gRDivizionDivizionsIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GR_Divizion_Divizions_Id";
            this.Column2.DataSource = this.divizionsBindingSource;
            this.Column2.DisplayMember = "DZ_Number";
            this.Column2.HeaderText = "Divizion";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "DZ_Id";
            // 
            // divizionsBindingSource
            // 
            this.divizionsBindingSource.DataSource = typeof(KZVLDataEF.Divizions);
            // 
            // divizionsDataGridViewTextBoxColumn
            // 
            this.divizionsDataGridViewTextBoxColumn.DataPropertyName = "Divizions";
            this.divizionsDataGridViewTextBoxColumn.HeaderText = "Divizions";
            this.divizionsDataGridViewTextBoxColumn.Name = "divizionsDataGridViewTextBoxColumn";
            this.divizionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "Teams";
            this.teamsDataGridViewTextBoxColumn.HeaderText = "Teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(KZVLDataEF.Groups);
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 588);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.dataGridViewGroupsSrc);
            this.Name = "FrmGroup";
            this.Text = "FrmGroup";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupsSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divizionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelBestPlayer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxBestPlayer;
        private System.Windows.Forms.DataGridView dataGridViewGroupsSrc;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRBestPlayerPlayersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRDivizionDivizionsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.BindingSource divizionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn divizionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
    }
}