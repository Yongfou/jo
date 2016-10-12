namespace Compagnie
{
    partial class ListAllPersons
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
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridClient = new System.Windows.Forms.DataGridView();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Compagnie.Person);
            // 
            // GridClient
            // 
            this.GridClient.AutoGenerateColumns = false;
            this.GridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.numberclientDataGridViewTextBoxColumn});
            this.GridClient.DataSource = this.personBindingSource;
            this.GridClient.Location = new System.Drawing.Point(11, 12);
            this.GridClient.Name = "GridClient";
            this.GridClient.Size = new System.Drawing.Size(349, 341);
            this.GridClient.TabIndex = 36;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // numberclientDataGridViewTextBoxColumn
            // 
            this.numberclientDataGridViewTextBoxColumn.DataPropertyName = "Numberclient";
            this.numberclientDataGridViewTextBoxColumn.HeaderText = "Numberclient";
            this.numberclientDataGridViewTextBoxColumn.Name = "numberclientDataGridViewTextBoxColumn";
            // 
            // ListAllPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 365);
            this.Controls.Add(this.GridClient);
            this.Name = "ListAllPersons";
            this.Text = "ListAllPersons";
            this.Load += new System.EventHandler(this.ListAllPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView GridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberclientDataGridViewTextBoxColumn;
    }
}