namespace Compagnie
{
    partial class Addproduct
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
            this.lblNameproduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtidproduct = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameproduct
            // 
            this.lblNameproduct.AutoSize = true;
            this.lblNameproduct.Location = new System.Drawing.Point(30, 37);
            this.lblNameproduct.Name = "lblNameproduct";
            this.lblNameproduct.Size = new System.Drawing.Size(75, 13);
            this.lblNameproduct.TabIndex = 0;
            this.lblNameproduct.Text = "Name Product";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID Product";
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Bleu",
            "Red",
            "Brown ",
            "Yellow",
            "Orange",
            "Pink",
            "Black",
            "White",
            "Purple",
            "Green"});
            this.cmbcolor.Location = new System.Drawing.Point(33, 187);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(33, 53);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(149, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtidproduct
            // 
            this.txtidproduct.Location = new System.Drawing.Point(33, 101);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.Size = new System.Drawing.Size(149, 20);
            this.txtidproduct.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(33, 140);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(55, 20);
            this.txtprice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeeProduct
            // 
            this.btnSeeProduct.Location = new System.Drawing.Point(144, 227);
            this.btnSeeProduct.Name = "btnSeeProduct";
            this.btnSeeProduct.Size = new System.Drawing.Size(88, 23);
            this.btnSeeProduct.TabIndex = 9;
            this.btnSeeProduct.Text = "View Product";
            this.btnSeeProduct.UseVisualStyleBackColor = true;
            this.btnSeeProduct.Click += new System.EventHandler(this.btnSeeProduct_Click);
            // 
            // Addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 273);
            this.Controls.Add(this.btnSeeProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtidproduct);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameproduct);
            this.Name = "Addproduct";
            this.Text = "Add product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameproduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtidproduct;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeeProduct;
    }
}