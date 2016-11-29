namespace MultiChatProgramme
{
    partial class Platforme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.BtnEnvoyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom utilisateur :";
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(16, 35);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(150, 21);
            this.lblNomUtilisateur.TabIndex = 1;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(12, 79);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(571, 276);
            this.txtPrincipal.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 373);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(466, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // BtnEnvoyer
            // 
            this.BtnEnvoyer.Location = new System.Drawing.Point(508, 370);
            this.BtnEnvoyer.Name = "BtnEnvoyer";
            this.BtnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.BtnEnvoyer.TabIndex = 4;
            this.BtnEnvoyer.Text = "Envoyer";
            this.BtnEnvoyer.UseVisualStyleBackColor = true;
            this.BtnEnvoyer.Click += new System.EventHandler(this.BtnEnvoyer_Click);
            // 
            // Platforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 412);
            this.Controls.Add(this.BtnEnvoyer);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblNomUtilisateur);
            this.Controls.Add(this.label1);
            this.Name = "Platforme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Platforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button BtnEnvoyer;
    }
}

