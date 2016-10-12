namespace Compagnie
{
    partial class MenuOrder
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
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddorder = new System.Windows.Forms.Button();
            this.btnListAllOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(59, 233);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 32;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Edit Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Delete Order";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 105);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 13);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "Add Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "View Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "List All Orders";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(99, 194);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrder.TabIndex = 26;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(99, 145);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDelOrder.TabIndex = 25;
            this.btnDelOrder.Text = "Delete";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(99, 53);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrder.TabIndex = 24;
            this.btnViewOrder.Text = "Person";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddorder
            // 
            this.btnAddorder.Location = new System.Drawing.Point(99, 100);
            this.btnAddorder.Name = "btnAddorder";
            this.btnAddorder.Size = new System.Drawing.Size(75, 23);
            this.btnAddorder.TabIndex = 23;
            this.btnAddorder.Text = "Add";
            this.btnAddorder.UseVisualStyleBackColor = true;
            this.btnAddorder.Click += new System.EventHandler(this.btnAddorder_Click);
            // 
            // btnListAllOrders
            // 
            this.btnListAllOrders.Location = new System.Drawing.Point(99, 11);
            this.btnListAllOrders.Name = "btnListAllOrders";
            this.btnListAllOrders.Size = new System.Drawing.Size(75, 23);
            this.btnListAllOrders.TabIndex = 22;
            this.btnListAllOrders.Text = "All Orders";
            this.btnListAllOrders.UseVisualStyleBackColor = true;
            this.btnListAllOrders.Click += new System.EventHandler(this.btnListAllOrders_Click);
            // 
            // MenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 267);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnAddorder);
            this.Controls.Add(this.btnListAllOrders);
            this.Name = "MenuOrder";
            this.Text = "MenuOrder";
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
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnAddorder;
        private System.Windows.Forms.Button btnListAllOrders;
    }
}