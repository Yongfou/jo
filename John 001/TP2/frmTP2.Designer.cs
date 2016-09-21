namespace TP2
{
    partial class frmTP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTP2));
            this.grpJoueur1 = new System.Windows.Forms.GroupBox();
            this.optAllumette = new System.Windows.Forms.RadioButton();
            this.optCiseau = new System.Windows.Forms.RadioButton();
            this.optPapier = new System.Windows.Forms.RadioButton();
            this.optRoche = new System.Windows.Forms.RadioButton();
            this.lblVictoiresJoueur = new System.Windows.Forms.Label();
            this.lblVictoiresJ1Static = new System.Windows.Forms.Label();
            this.imgActionJoueur = new System.Windows.Forms.PictureBox();
            this.grpJoueur2 = new System.Windows.Forms.GroupBox();
            this.lblVictoiresOrdinateur = new System.Windows.Forms.Label();
            this.lblVictoiresJ2Static = new System.Windows.Forms.Label();
            this.imgActionOrdinateur = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNbConfrontations = new System.Windows.Forms.Label();
            this.lblPartiesNulles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.chkAnime = new System.Windows.Forms.CheckBox();
            this.grpJoueur1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActionJoueur)).BeginInit();
            this.grpJoueur2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActionOrdinateur)).BeginInit();
            this.SuspendLayout();
            // 
            // grpJoueur1
            // 
            this.grpJoueur1.BackColor = System.Drawing.Color.Transparent;
            this.grpJoueur1.Controls.Add(this.optAllumette);
            this.grpJoueur1.Controls.Add(this.optCiseau);
            this.grpJoueur1.Controls.Add(this.optPapier);
            this.grpJoueur1.Controls.Add(this.optRoche);
            this.grpJoueur1.Controls.Add(this.lblVictoiresJoueur);
            this.grpJoueur1.Controls.Add(this.lblVictoiresJ1Static);
            this.grpJoueur1.Controls.Add(this.imgActionJoueur);
            this.grpJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJoueur1.ForeColor = System.Drawing.Color.White;
            this.grpJoueur1.Location = new System.Drawing.Point(20, 14);
            this.grpJoueur1.Name = "grpJoueur1";
            this.grpJoueur1.Size = new System.Drawing.Size(215, 296);
            this.grpJoueur1.TabIndex = 0;
            this.grpJoueur1.TabStop = false;
            this.grpJoueur1.Text = "Joueur:";
            // 
            // optAllumette
            // 
            this.optAllumette.AutoSize = true;
            this.optAllumette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAllumette.Location = new System.Drawing.Point(111, 236);
            this.optAllumette.Name = "optAllumette";
            this.optAllumette.Size = new System.Drawing.Size(90, 20);
            this.optAllumette.TabIndex = 6;
            this.optAllumette.Text = "Allumette";
            this.optAllumette.UseVisualStyleBackColor = true;
            this.optAllumette.CheckedChanged += new System.EventHandler(this.optAllumette_CheckedChanged);
            // 
            // optCiseau
            // 
            this.optCiseau.AutoSize = true;
            this.optCiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCiseau.Location = new System.Drawing.Point(111, 205);
            this.optCiseau.Name = "optCiseau";
            this.optCiseau.Size = new System.Drawing.Size(74, 20);
            this.optCiseau.TabIndex = 5;
            this.optCiseau.Text = "Ciseau";
            this.optCiseau.UseVisualStyleBackColor = true;
            this.optCiseau.CheckedChanged += new System.EventHandler(this.optCiseau_CheckedChanged);
            // 
            // optPapier
            // 
            this.optPapier.AutoSize = true;
            this.optPapier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPapier.Location = new System.Drawing.Point(16, 236);
            this.optPapier.Name = "optPapier";
            this.optPapier.Size = new System.Drawing.Size(72, 20);
            this.optPapier.TabIndex = 4;
            this.optPapier.Text = "Papier";
            this.optPapier.UseVisualStyleBackColor = true;
            this.optPapier.CheckedChanged += new System.EventHandler(this.optPapier_CheckedChanged);
            // 
            // optRoche
            // 
            this.optRoche.AutoSize = true;
            this.optRoche.Checked = true;
            this.optRoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRoche.Location = new System.Drawing.Point(16, 205);
            this.optRoche.Name = "optRoche";
            this.optRoche.Size = new System.Drawing.Size(71, 20);
            this.optRoche.TabIndex = 3;
            this.optRoche.TabStop = true;
            this.optRoche.Text = "Roche";
            this.optRoche.UseVisualStyleBackColor = true;
            this.optRoche.CheckedChanged += new System.EventHandler(this.optRoche_CheckedChanged);
            // 
            // lblVictoiresJoueur
            // 
            this.lblVictoiresJoueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVictoiresJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictoiresJoueur.Location = new System.Drawing.Point(108, 264);
            this.lblVictoiresJoueur.Name = "lblVictoiresJoueur";
            this.lblVictoiresJoueur.Size = new System.Drawing.Size(83, 20);
            this.lblVictoiresJoueur.TabIndex = 2;
            this.lblVictoiresJoueur.Text = "0";
            this.lblVictoiresJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVictoiresJ1Static
            // 
            this.lblVictoiresJ1Static.AutoSize = true;
            this.lblVictoiresJ1Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictoiresJ1Static.Location = new System.Drawing.Point(15, 265);
            this.lblVictoiresJ1Static.Name = "lblVictoiresJ1Static";
            this.lblVictoiresJ1Static.Size = new System.Drawing.Size(73, 16);
            this.lblVictoiresJ1Static.TabIndex = 1;
            this.lblVictoiresJ1Static.Text = "Victoires:";
            // 
            // imgActionJoueur
            // 
            this.imgActionJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgActionJoueur.Image = global::TP2.Properties.Resources.roche;
            this.imgActionJoueur.Location = new System.Drawing.Point(24, 22);
            this.imgActionJoueur.Name = "imgActionJoueur";
            this.imgActionJoueur.Size = new System.Drawing.Size(167, 167);
            this.imgActionJoueur.TabIndex = 0;
            this.imgActionJoueur.TabStop = false;
            // 
            // grpJoueur2
            // 
            this.grpJoueur2.BackColor = System.Drawing.Color.Transparent;
            this.grpJoueur2.Controls.Add(this.lblVictoiresOrdinateur);
            this.grpJoueur2.Controls.Add(this.lblVictoiresJ2Static);
            this.grpJoueur2.Controls.Add(this.imgActionOrdinateur);
            this.grpJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJoueur2.ForeColor = System.Drawing.Color.White;
            this.grpJoueur2.Location = new System.Drawing.Point(241, 14);
            this.grpJoueur2.Name = "grpJoueur2";
            this.grpJoueur2.Size = new System.Drawing.Size(215, 296);
            this.grpJoueur2.TabIndex = 1;
            this.grpJoueur2.TabStop = false;
            this.grpJoueur2.Text = "Ordinateur:";
            // 
            // lblVictoiresOrdinateur
            // 
            this.lblVictoiresOrdinateur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVictoiresOrdinateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictoiresOrdinateur.Location = new System.Drawing.Point(107, 261);
            this.lblVictoiresOrdinateur.Name = "lblVictoiresOrdinateur";
            this.lblVictoiresOrdinateur.Size = new System.Drawing.Size(83, 20);
            this.lblVictoiresOrdinateur.TabIndex = 4;
            this.lblVictoiresOrdinateur.Text = "0";
            this.lblVictoiresOrdinateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVictoiresJ2Static
            // 
            this.lblVictoiresJ2Static.AutoSize = true;
            this.lblVictoiresJ2Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictoiresJ2Static.Location = new System.Drawing.Point(20, 264);
            this.lblVictoiresJ2Static.Name = "lblVictoiresJ2Static";
            this.lblVictoiresJ2Static.Size = new System.Drawing.Size(73, 16);
            this.lblVictoiresJ2Static.TabIndex = 3;
            this.lblVictoiresJ2Static.Text = "Victoires:";
            // 
            // imgActionOrdinateur
            // 
            this.imgActionOrdinateur.Image = global::TP2.Properties.Resources.papier;
            this.imgActionOrdinateur.Location = new System.Drawing.Point(23, 22);
            this.imgActionOrdinateur.Name = "imgActionOrdinateur";
            this.imgActionOrdinateur.Size = new System.Drawing.Size(167, 167);
            this.imgActionOrdinateur.TabIndex = 1;
            this.imgActionOrdinateur.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confrontations:";
            // 
            // lblNbConfrontations
            // 
            this.lblNbConfrontations.BackColor = System.Drawing.Color.Transparent;
            this.lblNbConfrontations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNbConfrontations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbConfrontations.ForeColor = System.Drawing.Color.White;
            this.lblNbConfrontations.Location = new System.Drawing.Point(222, 317);
            this.lblNbConfrontations.Name = "lblNbConfrontations";
            this.lblNbConfrontations.Size = new System.Drawing.Size(55, 22);
            this.lblNbConfrontations.TabIndex = 3;
            this.lblNbConfrontations.Text = "20";
            this.lblNbConfrontations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartiesNulles
            // 
            this.lblPartiesNulles.BackColor = System.Drawing.Color.Transparent;
            this.lblPartiesNulles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartiesNulles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartiesNulles.ForeColor = System.Drawing.Color.White;
            this.lblPartiesNulles.Location = new System.Drawing.Point(401, 317);
            this.lblPartiesNulles.Name = "lblPartiesNulles";
            this.lblPartiesNulles.Size = new System.Drawing.Size(55, 22);
            this.lblPartiesNulles.TabIndex = 5;
            this.lblPartiesNulles.Text = "0";
            this.lblPartiesNulles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parties nulles:";
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(20, 345);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(215, 42);
            this.btnJouer.TabIndex = 6;
            this.btnJouer.Text = "&Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.Location = new System.Drawing.Point(241, 345);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(215, 42);
            this.btnRecommencer.TabIndex = 7;
            this.btnRecommencer.Text = "&Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // chkAnime
            // 
            this.chkAnime.AutoSize = true;
            this.chkAnime.BackColor = System.Drawing.Color.Transparent;
            this.chkAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnime.ForeColor = System.Drawing.Color.White;
            this.chkAnime.Location = new System.Drawing.Point(20, 320);
            this.chkAnime.Name = "chkAnime";
            this.chkAnime.Size = new System.Drawing.Size(70, 20);
            this.chkAnime.TabIndex = 8;
            this.chkAnime.Text = "Animé";
            this.chkAnime.UseVisualStyleBackColor = false;
            // 
            // frmTP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 398);
            this.Controls.Add(this.chkAnime);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.lblPartiesNulles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNbConfrontations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpJoueur2);
            this.Controls.Add(this.grpJoueur1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTP2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu - Roche, papier, ciseau, allumette!";
            this.grpJoueur1.ResumeLayout(false);
            this.grpJoueur1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActionJoueur)).EndInit();
            this.grpJoueur2.ResumeLayout(false);
            this.grpJoueur2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActionOrdinateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpJoueur1;
        private System.Windows.Forms.Label lblVictoiresJoueur;
        private System.Windows.Forms.Label lblVictoiresJ1Static;
        private System.Windows.Forms.PictureBox imgActionJoueur;
        private System.Windows.Forms.GroupBox grpJoueur2;
        private System.Windows.Forms.Label lblVictoiresOrdinateur;
        private System.Windows.Forms.Label lblVictoiresJ2Static;
        private System.Windows.Forms.PictureBox imgActionOrdinateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNbConfrontations;
        private System.Windows.Forms.Label lblPartiesNulles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.CheckBox chkAnime;
        private System.Windows.Forms.RadioButton optAllumette;
        private System.Windows.Forms.RadioButton optCiseau;
        private System.Windows.Forms.RadioButton optPapier;
        private System.Windows.Forms.RadioButton optRoche;
    }
}

