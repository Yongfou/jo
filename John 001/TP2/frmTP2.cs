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

        const byte valeur_min = 0;
        const byte valeur_max = 4;
        const byte byRoche = 0;
        const byte byPapier = 1;
        const byte byCiseaux = 2;
        const byte byAllumette = 3;

        // Déclaration des variables globales (champs).

        Random _rnd = new Random();
        byte _Ntour = 20;
        byte _VicPlayer = 0;
        byte _VicOrdi = 0;
        byte _Nul = 0;
        byte _Chplayer = 0;
        string _Nom = "";
        byte byCoupOrdi = 0;
        int nombreOfChanges = 0;

        public frmTP2()
        {
            InitializeComponent();
        }

        // Function pour afficher l'image
        public void afficherImage(byte byCoupOrdi)
        {
            // Affiche image Ordi

            if (byCoupOrdi == byRoche)
                imgActionOrdinateur.Image = global::TP2.Properties.Resources.roche;

            else if (byCoupOrdi == byPapier)
                imgActionOrdinateur.Image = global::TP2.Properties.Resources.papier;

            else if (byCoupOrdi == byCiseaux)
                imgActionOrdinateur.Image = global::TP2.Properties.Resources.ciseau;

            else
                imgActionOrdinateur.Image = global::TP2.Properties.Resources.allumette;
        }

        private void checkQuiGagne()
        {
            // Possibilité

            //Roche

            if (_Chplayer == byRoche)
            {
                if (byCoupOrdi == byPapier)
                    _VicOrdi++;

                else if (byCoupOrdi == byRoche)
                    _Nul++;

                else
                    _VicPlayer++;
            }

            //Papier

            if (_Chplayer == byPapier)

            {
                if (byCoupOrdi == byRoche)
                    _VicPlayer++;

                else if (byCoupOrdi == byPapier)
                    _Nul++;

                else
                    _VicOrdi++;
            }

            // Ciseaux

            if (_Chplayer == byCiseaux)
            {
                if (byCoupOrdi == byRoche)
                    _VicOrdi++;

                else if (byCoupOrdi == byCiseaux)
                    _Nul++;

                else
                    _VicPlayer++;
            }

            // Allumette

            if (_Chplayer == byAllumette)
            {
                if (byCoupOrdi == byPapier)
                    _VicPlayer++;

                else if (byCoupOrdi == byAllumette)
                    _Nul++;

                else
                    _VicOrdi++;
            }


            // Affiche label

            lblVictoiresOrdinateur.Text = (_VicOrdi.ToString());
            lblVictoiresJoueur.Text = (_VicPlayer.ToString());
            lblNbConfrontations.Text = (_Ntour.ToString());
            lblPartiesNulles.Text = (_Nul.ToString());
        }

        // Ajouter les commentaires (Auteur, Description, Date)
        private void btnJouer_Click(object sender, EventArgs e)
        {

            //Collecte d'information

            if (_Nom == "")
                _Nom = Formulaires.DemanderValeur("Quel est votre nom ?", "Nom joueur");

            else
            {
                //Traitement de l'information

                if (_Ntour != 0)
                {

                    // Check if checkbox is checked
                    if(chkAnime.Checked == true)
                    {
                        // Activer l'animation
                        nombreOfChanges = 100;
                    } else
                    {
                        // Activer l'animation
                        nombreOfChanges = 1;
                    }

                    // Start timer
                    timer1.Enabled = true;

                    // Diminuer les tour
                    _Ntour -= 1;
                }
                else if (_Ntour == 0)
                {
                    if (_VicPlayer > _VicOrdi)
                        MessageBox.Show("Le gagnant est " + _Nom + " avec " + _VicPlayer + " vicoires!", "Gagnant!");
                    else if (_VicOrdi == _VicPlayer)
                        MessageBox.Show("Une confrontation supplémentaire est nécessaire!");
                    else
                        MessageBox.Show(" Le gagant est l'ordinateur avec " + _VicOrdi + " victoires!");
                }


            }
        }



        // Ajouter les commentaires (Auteur, Description, Date)
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            _Ntour = 20;
            _VicPlayer = 0;
            _VicOrdi = 0;
            _Nul = 0;
            _Chplayer = 0;
            _Nom = "";

            lblVictoiresOrdinateur.Text = ("0");
            lblVictoiresJoueur.Text = ("0");
            lblNbConfrontations.Text = ("20");
            lblPartiesNulles.Text = ("0");

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Loop until animation finish
            if (nombreOfChanges > 0)
            {
                //Random
                byCoupOrdi = (byte)_rnd.Next(valeur_min, valeur_max);
                afficherImage(byCoupOrdi);
                nombreOfChanges--;
            } else
            {
                // Ajuste les points
                checkQuiGagne();

                // Stop timer
                timer1.Enabled = false;
            }
        }
    }
    // Comment faire pour remettre le selecteur dans roche quand je clic sur recommencer et associer l'image ordi au random
}