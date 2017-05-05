namespace main
{
    partial class Students
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.City = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.donateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.City,
            this.standDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.studentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(38, 179);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1257, 507);
            this.dataGridView.TabIndex = 1;
            // 
            // mtSave
            // 
            this.mtSave.Location = new System.Drawing.Point(471, 77);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(84, 73);
            this.mtSave.TabIndex = 0;
            this.mtSave.Text = "Save";
            this.mtSave.TileImage = global::main.Properties.Resources.save_as;
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseTileImage = true;
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(364, 77);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(84, 73);
            this.mtDelete.TabIndex = 0;
            this.mtDelete.Text = "Delete";
            this.mtDelete.TileImage = global::main.Properties.Resources.delete;
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(253, 77);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(84, 73);
            this.mtEdit.TabIndex = 0;
            this.mtEdit.Text = "Update";
            this.mtEdit.TileImage = global::main.Properties.Resources.upgrade_downgrade_account;
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.UseTileImage = true;
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(147, 77);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(84, 73);
            this.mtAdd.TabIndex = 0;
            this.mtAdd.Text = "Add";
            this.mtAdd.TileImage = global::main.Properties.Resources.add_on;
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtRefresh
            // 
            this.mtRefresh.Location = new System.Drawing.Point(38, 77);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(84, 73);
            this.mtRefresh.TabIndex = 0;
            this.mtRefresh.Text = "Refresh";
            this.mtRefresh.TileImage = global::main.Properties.Resources.recycle;
            this.mtRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefresh.UseTileImage = true;
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.DataSource = this.cityBindingSource;
            this.City.DisplayMember = "CityName";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.City.ValueMember = "CityId";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // donateDataGridViewTextBoxColumn
            // 
            this.donateDataGridViewTextBoxColumn.DataPropertyName = "Donate";
            this.donateDataGridViewTextBoxColumn.HeaderText = "Donate";
            this.donateDataGridViewTextBoxColumn.Name = "donateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(main.City);
            // 
            // standDataGridViewTextBoxColumn
            // 
            this.standDataGridViewTextBoxColumn.DataPropertyName = "Stand";
            this.standDataGridViewTextBoxColumn.HeaderText = "Stand";
            this.standDataGridViewTextBoxColumn.Name = "standDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(main.Student);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 709);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtRefresh);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn City;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn standDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}

