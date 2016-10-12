namespace Compagnie
{
    partial class MenuPerson
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
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnViewPersons = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnListAllPersons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(69, 237);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Edit Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Delete Product";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 109);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 13);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Add Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "View Persons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "List All Persons";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(109, 198);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(75, 23);
            this.btnEditPerson.TabIndex = 15;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Location = new System.Drawing.Point(109, 149);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDelProduct.TabIndex = 14;
            this.btnDelProduct.Text = "Delete";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnViewPersons
            // 
            this.btnViewPersons.Location = new System.Drawing.Point(109, 57);
            this.btnViewPersons.Name = "btnViewPersons";
            this.btnViewPersons.Size = new System.Drawing.Size(75, 23);
            this.btnViewPersons.TabIndex = 13;
            this.btnViewPersons.Text = "Person";
            this.btnViewPersons.UseVisualStyleBackColor = true;
            this.btnViewPersons.Click += new System.EventHandler(this.btnViewPersons_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(109, 104);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 12;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click_1);
            // 
            // btnListAllPersons
            // 
            this.btnListAllPersons.Location = new System.Drawing.Point(109, 15);
            this.btnListAllPersons.Name = "btnListAllPersons";
            this.btnListAllPersons.Size = new System.Drawing.Size(75, 23);
            this.btnListAllPersons.TabIndex = 11;
            this.btnListAllPersons.Text = "All Persons";
            this.btnListAllPersons.UseVisualStyleBackColor = true;
            this.btnListAllPersons.Click += new System.EventHandler(this.btnListAllPersons_Click);
            // 
            // MenuPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 270);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnViewPersons);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnListAllPersons);
            this.Name = "MenuPerson";
            this.Text = "MenuPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnViewPersons;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnListAllPersons;
    }
}