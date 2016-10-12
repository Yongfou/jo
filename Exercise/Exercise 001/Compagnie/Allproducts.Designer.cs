namespace Compagnie
{
    partial class Allproducts
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
            this.myGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myGrid
            // 
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Location = new System.Drawing.Point(12, 12);
            this.myGrid.Name = "myGrid";
            this.myGrid.Size = new System.Drawing.Size(782, 566);
            this.myGrid.TabIndex = 11;
            // 
            // Allproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 589);
            this.Controls.Add(this.myGrid);
            this.Name = "Allproducts";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Allproducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myGrid;
    }
}