using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Genera_Click(object sender, EventArgs e)
        {
            if (checkFrazione.Checked == true) { lbl_lineaFrazione.Visible = true; pannelloDenominatore.Visible = true; } 

            else { lbl_lineaFrazione.Visible = false; pannelloDenominatore.Visible = false; }

            if (checkDefiniti.Checked == true) { lbl_definitoUno.Visible = true; lbl_definitoDue.Visible = true; }
            else { lbl_definitoUno.Visible = false; lbl_definitoDue.Visible = false; }

            Random rnd = new Random();
         
            int potenzaTre = rnd.Next(0,3);
            int potenzaDenominatore = rnd.Next(0, 3);
            int definito = rnd.Next(0, 3);
            

            label1.Text = Convert.ToString(potenzaTre);
            label3.Text = Convert.ToString(potenzaDenominatore);
            label4.Text = Convert.ToString(definito);

            lbl_nUno.Text = Convert.ToString(rnd.Next(1, 12));
            lbl_nDue.Text = Convert.ToString(rnd.Next(1, 12));
            lbl_nTre.Text = Convert.ToString(rnd.Next(1, 12));
            lbl_dUno.Text = Convert.ToString(rnd.Next(1, 12));
            lbl_dDue.Text = Convert.ToString(rnd.Next(1, 12));
            lbl_dTre.Text = Convert.ToString(rnd.Next(1, 12));

            switch (potenzaTre) {

                case 2:
                    lbl_potenzaNUno.Text = "3";
                    lbl_potenzaNDue.Text = "2";
                    break;
                case 1:
                    lbl_potenzaNUno.Text = "2";
                    lbl_potenzaNDue.Text = "1";
                    break;
                case 0:
                    lbl_potenzaNUno.Text = "";
                    lbl_potenzaNDue.Text = "";
                    break;
             }

            switch (potenzaDenominatore)
            {

                case 2:
                    lbl_potenzaTre.Text = "3";
                    lbl_potenzaQuattro.Text = "2";
                    break;
                case 1:
                    lbl_potenzaTre.Text = "2";
                    lbl_potenzaQuattro.Text = "1";
                    break;
                case 0:
                    lbl_potenzaTre.Text = "";
                    lbl_potenzaQuattro.Text = "";
                    break;
            }

            switch (definito)
            {
                case 2:
                    lbl_definitoUno.Text = "3";
                    lbl_definitoDue.Text = "2";
                    break;

                case 1:
                    lbl_definitoUno.Text = "2";
                    lbl_definitoDue.Text = "1";
                    break;

                case 0:
                    lbl_definitoUno.Text = "1";
                    lbl_definitoDue.Text = "0";
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }

 }
