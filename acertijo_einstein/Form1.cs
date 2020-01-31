using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acertijo_einstein
{
    public partial class Form1 : Form
    {
        int paso = 0;
        public Form1()
        {
            InitializeComponent();
        }

        #region Pasos
        private void lblStep1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paso = 1;
            pnlNorway.Visible = true;
            lblStep1.LinkVisited = true;
        }

        private void lblStep2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep1.LinkVisited == true)
            {
                paso = 2;
                lblStep2.LinkVisited = true;
                pictureBox2.BackColor = Color.LightSteelBlue;
            }
            else
            {
                recargarForm();
            }
            
        }

        private void lblStep3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep1.LinkVisited == true && lblStep2.LinkVisited == true)
            {
                paso = 3;
                lblStep3.LinkVisited = true;
                pnlMilk.Visible = true;
            }
            else
            {
                recargarForm();
            }
        }

        private void lblStep4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep2.LinkVisited == true && lblStep3.LinkVisited == true)
            {
                paso = 4;
                lblStep4.LinkVisited = true;

                if (lblStep5.LinkVisited == true)
                {
                    pnlCoffee.Visible = true;
                    pnlCoffee.BackColor = Color.DarkSeaGreen;
                    return;
                }
                
                rmdr1 rmdrOne = new rmdr1();
                rmdrOne.Show();
            }
            else
            {
                recargarForm();
            }
        }

        private void lblStep5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep2.LinkVisited == true && lblStep3.LinkVisited == true)
            {
                paso = 5;
                lblStep5.LinkVisited = true;

                const string mensaje = "Elija la casa que sería de color verde.";
                const string caption = "Elegir Casa Verde";
                var result = MessageBox.Show(mensaje, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    verBotones();
                }
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep4.LinkVisited == true && lblStep5.LinkVisited == true)
            {
                paso = 6;
                lblStep6.LinkVisited = true;
                const string mensaje = "Elija la casa que sería de color rojo.";
                const string caption = "Elegir Casa Rojo";
                var result = MessageBox.Show(mensaje, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    verBotones();
                }
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep5.LinkVisited == true && lblStep6.LinkVisited == true)
            {
                paso = 7;
                lblStep7.LinkVisited = true;

                pnlDunhill.Visible = true;
                pnlDunhill.BackColor = Color.LemonChiffon;
            }
            else
            {
                recargarForm();
            }
        }
        private void lblStep8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep6.LinkVisited == true && lblStep7.LinkVisited == true)
            {
                paso = 8;
                lblStep8.LinkVisited = true;

                pnlHorse.Visible = true;
                pnlHorse.BackColor = Color.LightSteelBlue;

                //const string mensaje = "A partir de este momento hay dos opciones posibles. Aunque al final, sólo una será la correcta";
                //const string caption = "ALERTA!!!";
                //MessageBox.Show(mensaje, caption,
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Asterisk);
            }
            else
            {
                recargarForm();
            }
        }
        private void lblStep9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep7.LinkVisited == true && lblStep8.LinkVisited == true)
            {
                paso = 9;
                lblStep9.LinkVisited = true;

                MessageBox.Show("¿En qué casa vive el Danés?", "Casa del Danés");

                verBotones();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep8.LinkVisited == true && lblStep9.LinkVisited == true)
            {
                paso = 10;
                lblStep10.LinkVisited = true;

                MessageBox.Show("¿Cuál es la casa de la persona que fuma bluemasters y toma cerveza?", "Bluemasters y Cerveza");
                verBotones();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep9.LinkVisited == true && lblStep10.LinkVisited == true)
            {
                paso = 11;
                lblStep11.LinkVisited = true;

                MessageBox.Show("¿Cuál es la casa del alemán?", "Casa del Alemán");
                verBotones();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep10.LinkVisited == true && lblStep11.LinkVisited == true)
            {
                paso = 12;
                lblStep12.LinkVisited = true;

                MessageBox.Show("¿Cuál es la casa de la persona que fuma Pall Mall y tiene un pájaro", "Pal Mall");

                verBotones();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep11.LinkVisited == true && lblStep12.LinkVisited == true)
            {
                paso = 13;
                lblStep13.LinkVisited = true;

                MessageBox.Show("¿Cuál es la casa del sueco?", "Casa del sueco");

                verBotones();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep11.LinkVisited == true && lblStep12.LinkVisited == true)
            {
                paso = 14;
                lblStep14.LinkVisited = true;

                pnlBrends.Visible = true;
                pnlBrends.BackColor = Color.LightSteelBlue;

                pnlWater.Visible = true;
                pnlWater.BackColor = Color.LemonChiffon;

                felicidades();
            }
            else
            {
                recargarForm();
            }
            
        }
        private void lblStep15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblStep11.LinkVisited == true && lblStep12.LinkVisited == true)
            {
                paso = 15;
                lblStep15.LinkVisited = true;

                pnlBrends.Visible = true;
                pnlBrends.BackColor = Color.LightSteelBlue;

                pnlCat.Visible = true;
                pnlCat.BackColor = Color.LemonChiffon;

                felicidades();
            }
            else
            {
                recargarForm();
            }
            
        }
        #endregion

        #region Botones_Eleccion
        private void btnOne_Click(object sender, EventArgs e)
        {
            recargarForm();
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            switch (paso)
            {
                case 9:
                    pnlDenmark.Visible = true;
                    pnlDenmark.BackColor = Color.LightSteelBlue;
                    pnlTea.Visible = true;
                    pnlTea.BackColor = Color.LightSteelBlue;

                    ocultarBotones();
                    break;
                default:
                    recargarForm();
                    break;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            switch (paso)
            {
                case 6:
                    ocultarBotones();

                    pictureBox3.BackColor = Color.Tomato;
                    pnlMilk.BackColor = Color.Tomato;

                    pnlUk.Visible = true;
                    pnlUk.BackColor = Color.Tomato;

                    pictureBox1.BackColor = Color.LemonChiffon;
                    pnlNorway.BackColor = Color.LemonChiffon;
                    MessageBox.Show("Ya tienes los colores de todas las casas", "BIEN HECHO");
                    break;
                case 12:
                    ocultarBotones();

                    pnlPall.Visible = true;
                    pnlPall.BackColor = Color.Tomato;

                    pnlBird.Visible = true;
                    pnlBird.BackColor = Color.Tomato;

                    break;
                default:
                    recargarForm();
                    break;
            }
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            switch (paso)
            {
                case 5:
                    ocultarBotones();

                    if (lblStep4.LinkVisited == true)
                    {
                        pictureBox4.BackColor = Color.DarkSeaGreen;
                        pictureBox5.BackColor = Color.White;

                        pnlCoffee.Visible = true;
                        pnlCoffee.BackColor = Color.DarkSeaGreen;

                        break;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.DarkSeaGreen;
                        pictureBox5.BackColor = Color.White;
                        break;
                    }
                    
                case 11:
                    pnlGermany.Visible = true;
                    pnlGermany.BackColor = Color.DarkSeaGreen;
                    pnlPrince.Visible = true;
                    pnlPrince.BackColor = Color.DarkSeaGreen;
                    ocultarBotones();
                    break;
                default:
                    recargarForm();
                    break;
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            switch (paso)
            {
                case 10:
                    ocultarBotones();

                    pnlMasters.Visible = true;
                    pnlMasters.BackColor = Color.White;
                    pnlBeer.Visible = true;
                    pnlBeer.BackColor = Color.White;
                    break;
                case 13:
                    ocultarBotones();

                    pnlDog.Visible = true;
                    pnlDog.BackColor = Color.White;

                    pnlSweden.Visible = true;
                    pnlSweden.BackColor = Color.White;

                    break;
                default:
                    recargarForm();
                    break;
            }
        }
        #endregion

        #region Metodos
        void recargarForm()
        {
            const string mensaje = "Elección incorrecta. Tendrá que volver a iniciar";
            var result = MessageBox.Show(mensaje);
            if (result == DialogResult.OK)
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }
        void verBotones()
        {
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFive.Visible = true;
            btnFour.Visible = true;
        }
        void ocultarBotones()
        {
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = false;
            btnFive.Visible = false;
            btnFour.Visible = false;
        }
        void felicidades()
        {
            if (lblStep14.LinkVisited == true && lblStep15.LinkVisited == true)
            {
                pnlFish.Visible = true;
                pnlFish.BackColor = Color.DarkSeaGreen;
                MessageBox.Show("Felicidades!!! Descubriste quién es el dueño del pececillo.");
            }
        }
        #endregion
    }
}
