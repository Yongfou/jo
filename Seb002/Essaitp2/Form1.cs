using mnemoTIC.Programmation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essaitp2
{
    public partial class Form1 : Form
    {
        // Déclaration des constantes :
        const byte VALEUR_MIN = 0;
        const byte VALEUR_MAX = 4;
        const byte ROCHE = 0;
        const byte PAPIER = 1;
        const byte CISEAUX = 2;
        const byte ALLUMETTE = 3;

        // Déclaration des variables locales :
        Random _rnd = new Random();
        byte _byConf = 20;
        byte _byVic_jo = 0;
        byte _byVic_or = 0;
        byte _byNul = 0;
        byte _byCh_jo = 0;
        byte _byChor = 0;
        byte _byNbimg = 0;
        string _sNom = "";

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Auteur :Sébastien Paquet
        /// Description : Fait le choix de l'image ordinateur selon la piege au sort.
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="_Chor"></param>
        private void Aff_img(byte _byChor)
        {
            if (_byChor == ROCHE)
                imgOrdi.Image = global::Essaitp2.Properties.Resources.roche;
            else if (_byChor == PAPIER)
                imgOrdi.Image = global::Essaitp2.Properties.Resources.papier;
            else if (_byChor == CISEAUX)
                imgOrdi.Image = global::Essaitp2.Properties.Resources.ciseaux;
            else
                imgOrdi.Image = global::Essaitp2.Properties.Resources.allumette;
        }
        /// <summary>
        /// Auteur : Sébastien Paquet
        /// Description : Vérification du gagnant selon le choix du joueur.
        /// Date : 2016-09-18 
        /// </summary>
        private void Verification_gagnant()
        {
            //Si le choix du joueur est ROCHE
            if (_byCh_jo == ROCHE)
            {
                if (_byChor == PAPIER)
                {
                    _byVic_or++;
                    lblGagperdnul.Text = ("Vous avez PERDU!!!");
                }
                else if (_byChor == ROCHE)
                {
                    _byNul++;
                    lblGagperdnul.Text = ("Confrontation nulle!!!");
                }

                else
                {
                    _byVic_jo++;
                    lblGagperdnul.Text = ("Vous avez GAGNÉ!!!");
                }
            }

            // Si le choix du joueur est PAPIER 
            if (_byCh_jo == PAPIER)
            {
                if (_byChor == ROCHE)
                {
                    _byVic_jo++;
                    lblGagperdnul.Text = ("Vous avez GAGNÉ!!!");
                }
                else if (_byChor == PAPIER)
                {
                    _byNul++;
                    lblGagperdnul.Text = ("Confrontation nulle!!!");
                }
                else
                {
                    _byVic_or++;
                    lblGagperdnul.Text = ("Vous avez PERDU!!!");
                }
            }

            //Si le choix du joueur est CISEAUX
            if (_byCh_jo == CISEAUX)
            {
                if (_byChor == ROCHE)
                {
                    _byVic_or++;
                    lblGagperdnul.Text = ("Vous avez PERDU!!!");
                }
                else if (_byChor == CISEAUX)
                {
                    _byNul++;
                    lblGagperdnul.Text = ("Confrontation nulle!!!");
                }
                else
                {
                    _byVic_jo++;
                    lblGagperdnul.Text = ("Vous avez GAGNÉ!!!");
                }
            }
            // Si le choix du joueur est ALLUMETTE
            if (_byCh_jo == ALLUMETTE)
            {
                if (_byChor == PAPIER)
                {
                    _byVic_jo++;
                    lblGagperdnul.Text = ("Vous avez GAGNÉ!!!");
                }
                else if (_byChor == ALLUMETTE)
                {
                    _byNul++;
                    lblGagperdnul.Text = ("Confrontation nulle!!!");
                }
                else
                    _byVic_or++;
            }

            //Affichage label
            lblVictoireordi.Text = (_byVic_or.ToString());
            lblVictoirejoueur.Text = (_byVic_jo.ToString());
            lblconfrontation.Text = (_byConf.ToString());
            lblNul.Text = (_byNul.ToString());
        }
        /// <summary>
        /// Auteur : Sébastien PAquet
        /// Description : Demander nom du joueur, attiver l'animation, activer le timer et diminuer le nombre de tour 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJouer_Click(object sender, EventArgs e)
        {
            // Demander nom du joueur 
            if (_sNom == "")
            {
                _sNom = Formulaires.DemanderValeur("Quel est votre nom ?", "Nom joueur");
                lblVictoireNom.Text = ("Victoires " + _sNom.ToString());
            }
            else
            {
                //Traitement de l'information

                if (_byConf != 0)
                {
                    // Vérifier si le checkbox est cochée
                    if (chkAnimation.Checked == true)
                    {
                        // Activer l'animation
                        _byNbimg = 20;
                    }
                    else
                    {
                        // Activer l'animation
                        _byNbimg = 1;
                    }

                    // Démarer le timer
                    timer1.Enabled = true;

                    // Diminuer les confrontations
                    _byConf -= 1;
                }

                // Affichage du gagnant ou un partie nulle
                else if (_byConf == 0)
                {
                    if (_byVic_jo > _byVic_or)
                        MessageBox.Show("Le gagnant est " + _sNom + " avec " + _byVic_jo + " vicoires!", "Gagnant!");
                    else if (_byVic_or == _byVic_jo)
                        MessageBox.Show("Une confrontation supplémentaire est nécessaire!");
                    else
                        MessageBox.Show(" Le gagant est l'ordinateur avec " + _byVic_or + " victoires!");
                }
            }
         
        }
        /// <summary>
        /// Auteur : Sébastien Paquet
        /// Description : Remettre tous les variable à leur valeur de départ, ainsi que les labels
        /// Date : 2016-19-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            _byConf = 20;
            _byVic_jo = 0;
            _byVic_or = 0;
            _byNul = 0;
            _byCh_jo = 0;
            _sNom = "";

            lblVictoirejoueur.Text = ("0");
            lblVictoireordi.Text = ("0");
            lblconfrontation.Text = ("20");
            lblNul.Text = ("0");
            lblVictoireNom.Text = ("Victoires Joueur");
            lblGagperdnul.Text = ("Nouvelle Partie");
        }
        /// <summary>
        /// Auteur : SÉbastien Paquet
        /// Description : Fusionner le RadioBouton à l'image Roche et définir le choix du joueur.
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optRoche_CheckedChanged(object sender, EventArgs e)
        {
            imgJoueur.Image = global::Essaitp2.Properties.Resources.roche;
            _byCh_jo = ROCHE;
        }
        /// <summary>
        /// Auteur : SÉbastien Paquet
        /// Description : Fusionner le RadioBouton à l'image Papier et définir le choix du joueur.
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optPapier_CheckedChanged(object sender, EventArgs e)
        {
            imgJoueur.Image = global::Essaitp2.Properties.Resources.papier;
            _byCh_jo = PAPIER;
        }
        /// <summary>
        /// Auteur : SÉbastien Paquet
        /// Description : Fusionner le RadioBouton à l'image Ciseaux et définir le choix du joueur.
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optCiseaux_CheckedChanged(object sender, EventArgs e)
        {
            imgJoueur.Image = global::Essaitp2.Properties.Resources.ciseaux;
            _byCh_jo = CISEAUX;
        }
        /// <summary>
        /// Auteur : SÉbastien Paquet
        /// Description : Fusionner le RadioBouton à l'image Allumette et définir le choix du joueur.
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optAllumette_CheckedChanged(object sender, EventArgs e)
        {
            imgJoueur.Image = global::Essaitp2.Properties.Resources.allumette;
            _byCh_jo = ALLUMETTE;
        }
        /// <summary>
        /// Auteur : Sébastien Paquet
        /// Description : Timer qui permet de procéder è une animation, ajuster les points, arrêter le timer
        /// Date : 2016-09-18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Procéder à l'animation
            if (_byNbimg > 0)
            {
                //Random
                _byChor = (byte)_rnd.Next(VALEUR_MIN, VALEUR_MAX);
                Aff_img(_byChor);
                _byNbimg--;
            }
            else
            {
                // Ajuste les points
                Verification_gagnant();

                // Arrêter timer
                timer1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
