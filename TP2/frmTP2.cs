using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mnemoTIC.Programmation;

namespace TP2
{
    // Ajouter les commentaires (Auteur, Description, Date)
    public partial class frmTP2 : Form
    {
        // Déclaration des constantes

        const byte valeur_min = 1;
        const byte valeur_max = 5;
        const byte byRoche = 1;
        const byte byPapier = 2;
        const byte byCiseaux = 3;
        const byte byAllumette = 4;

        // Déclaration des variables globales (champs).
        Random _rnd = new Random();
        byte _Ntour = 0;
        byte _VicPlayer = 0;
        byte _VicOrdi = 0;
        byte _Nul = 0;
        byte _Chplayer = 0;

        public frmTP2()
        {
            InitializeComponent();
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void btnJouer_Click(object sender, EventArgs e)
        {
            //Définir les variables locale

            byte byCoupOrdi = 0;
            string sNom = "";

            //Collecte d'information

            //ICI ICI demander nom juste au premier tour

            // sNom = Formulaires.DemanderValeur("Quel est votre nom ?", "Nom joueur");




            //Traitement de l'information

            //Ne pas dépasser les 20 tour

            if (_Ntour < 20)
            {
                //Random

                byCoupOrdi = (byte)_rnd.Next(valeur_min, valeur_max);

                // Affiche image Ordi

                if (byCoupOrdi == byRoche)
                    imgActionOrdinateur.Image = global::TP2.Properties.Resources.roche;

                else if (byCoupOrdi == byPapier)
                    imgActionOrdinateur.Image = global::TP2.Properties.Resources.papier;

                else if (byCoupOrdi == byCiseaux)
                    imgActionOrdinateur.Image = global::TP2.Properties.Resources.ciseau;

                else
                    imgActionOrdinateur.Image = global::TP2.Properties.Resources.allumette;

                // Possibilité

                //Roche

                if (_Chplayer == byRoche)
                {
                    if (byCoupOrdi == byPapier)
                        _VicOrdi += 1;

                    else if (byCoupOrdi == byRoche)
                        _Nul += 1;

                    else
                        _VicPlayer += 1;
                }

                //Papier

                if (_Chplayer == byPapier)
                {
                    if (byCoupOrdi == byRoche)
                        _VicPlayer += 1;

                    else if (byCoupOrdi == byPapier)
                        _Nul += 1;

                    else
                        _VicOrdi += 1;
                }

                // Ciseaux

                if (_Chplayer == byCiseaux)
                {
                    if (byCoupOrdi == byRoche)
                        _VicOrdi += 1;

                    else if (byCoupOrdi == byCiseaux)
                        _Nul += 1;

                    else
                        _VicPlayer += 1;
                }

                // Allumette

                if (_Chplayer == byAllumette)
                {
                    if (byCoupOrdi == byPapier)
                        _VicPlayer += 1;

                    else if (byCoupOrdi == byAllumette)
                        _Nul += 1;

                    else
                        _VicOrdi += 1;
                }

                // Ajoute de tour
                _Ntour += 1;

                // Affiche label

                lblVictoiresOrdinateur.Text = (_VicOrdi.ToString());
                lblVictoiresJoueur.Text = (_VicPlayer.ToString());
                lblNbConfrontations.Text = (_Ntour.ToString());
                lblPartiesNulles.Text = (_Nul.ToString());
            }

            // Afficher le résultat
            else
            {
                if (_VicPlayer > _VicOrdi)
                    MessageBox.Show("Le gagnant est " + sNom + " avec " + _VicPlayer + " vicoires!", "Gagnant!");
                else if (_VicOrdi == _VicPlayer)
                    MessageBox.Show("Une confrontation supplémentaire est nécessaire!");
                else
                    MessageBox.Show(" Le gagant est l'ordinateur avec " + _VicOrdi + " victoires!");
            }
        }   
            
     

        // Ajouter les commentaires (Auteur, Description, Date)
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            // Code à ajouter ici ...
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void optRoche_CheckedChanged(object sender, EventArgs e)
        {
            imgActionJoueur.Image = global::TP2.Properties.Resources.roche;
            _Chplayer = byRoche;
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void optPapier_CheckedChanged(object sender, EventArgs e)
        {
            imgActionJoueur.Image = global::TP2.Properties.Resources.papier;
            _Chplayer = byPapier;
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void optCiseau_CheckedChanged(object sender, EventArgs e)
        {
            imgActionJoueur.Image = global::TP2.Properties.Resources.ciseau;
            _Chplayer = byCiseaux;
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void optAllumette_CheckedChanged(object sender, EventArgs e)
        {
            imgActionJoueur.Image = global::TP2.Properties.Resources.allumette;
            _Chplayer = byAllumette;
        }
    }

}
