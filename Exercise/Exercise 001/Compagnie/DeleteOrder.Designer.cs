namespace Compagnie
{
    partial class DeleteOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeleteOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(109, 90);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeleteOrder
            // 
            this.txtDeleteOrder.Location = new System.Drawing.Point(9, 54);
            this.txtDeleteOrder.Name = "txtDeleteOrder";
            this.txtDeleteOrder.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteOrder.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quelle command voulez-vous suprimer? ";
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 145);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeleteOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteOrder";
            this.Text = "DeleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeleteOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}