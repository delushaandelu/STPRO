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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

