namespace Compagnie
{
    partial class Addperso
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnAddperson = new System.Windows.Forms.Button();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNameproduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberclient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridClient = new System.Windows.Forms.DataGridView();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(197, 95);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 29;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnAddperson
            // 
            this.btnAddperson.Location = new System.Drawing.Point(15, 95);
            this.btnAddperson.Name = "btnAddperson";
            this.btnAddperson.Size = new System.Drawing.Size(75, 23);
            this.btnAddperson.TabIndex = 28;
            this.btnAddperson.Text = "Add Person";
            this.btnAddperson.UseVisualStyleBackColor = true;
            this.btnAddperson.Click += new System.EventHandler(this.btnAddperson_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(12, 64);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(149, 20);
            this.txtlastname.TabIndex = 26;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(12, 25);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(149, 20);
            this.txtfirstname.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "Last Name";
            // 
            // lblNameproduct
            // 
            this.lblNameproduct.AutoSize = true;
            this.lblNameproduct.Location = new System.Drawing.Point(12, 9);
            this.lblNameproduct.Name = "lblNameproduct";
            this.lblNameproduct.Size = new System.Drawing.Size(57, 13);
            this.lblNameproduct.TabIndex = 25;
            this.lblNameproduct.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "# Client";
            // 
            // lblNumberclient
            // 
            this.lblNumberclient.AutoSize = true;
            this.lblNumberclient.Location = new System.Drawing.Point(209, 24);
            this.lblNumberclient.Name = "lblNumberclient";
            this.lblNumberclient.Size = new System.Drawing.Size(27, 13);
            this.lblNumberclient.TabIndex = 33;
            this.lblNumberclient.Text = "*****";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.GridClient.Location = new System.Drawing.Point(10, 127);
            this.GridClient.Name = "GridClient";
            this.GridClient.Size = new System.Drawing.Size(349, 121);
            this.GridClient.TabIndex = 35;
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
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Compagnie.Person);
            // 
            // Addperso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 281);
            this.Controls.Add(this.GridClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNumberclient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnAddperson);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNameproduct);
            this.Name = "Addperso";
            this.Text = "Addperso";
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnAddperson;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNameproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberclient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
    }
}