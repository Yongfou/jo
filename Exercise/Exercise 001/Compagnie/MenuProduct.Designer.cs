namespace Compagnie
{
    partial class MenuProduct
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
            this.btnListAllProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListAllProducts
            // 
            this.btnListAllProducts.Location = new System.Drawing.Point(104, 7);
            this.btnListAllProducts.Name = "btnListAllProducts";
            this.btnListAllProducts.Size = new System.Drawing.Size(75, 23);
            this.btnListAllProducts.TabIndex = 0;
            this.btnListAllProducts.Text = "All Products";
            this.btnListAllProducts.UseVisualStyleBackColor = true;
            this.btnListAllProducts.Click += new System.EventHandler(this.btnListAllProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(104, 96);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(104, 49);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnViewProduct.TabIndex = 2;
            this.btnViewProduct.Text = "Product";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Location = new System.Drawing.Point(104, 141);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDelProduct.TabIndex = 3;
            this.btnDelProduct.Text = "Delete";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(104, 190);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "List All Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Produst";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(32, 106);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Add Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delete Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edit Product";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(64, 229);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // MenuProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 264);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnViewProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnListAllProducts);
            this.Name = "MenuProduct";
            this.Text = "Menu Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListAllProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
    }
}