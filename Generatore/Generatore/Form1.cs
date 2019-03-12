using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (checkFrazione.Checked == true)
            {
                lbl_lineaFrazione.Visible = true;
                pannelloDenominatore.Visible = true;
            }

            else {
                lbl_lineaFrazione.Visible = false;
                pannelloDenominatore.Visible = false;
            }

            Random rnd = new Random();
            Random potenza = new Random();
            var potenzaTre = potenza.Next(0,2);
            label1.Text = Convert.ToString(potenzaTre);

            lbl_nUno.Text = Convert.ToString(rnd.Next(1, 99));
            lbl_nDue.Text = Convert.ToString(rnd.Next(1, 99));
            lbl_nTre.Text = Convert.ToString(rnd.Next(1, 99));
            lbl_dUno.Text = Convert.ToString(rnd.Next(1, 99));
            lbl_dDue.Text = Convert.ToString(rnd.Next(1, 99));
            lbl_dTre.Text = Convert.ToString(rnd.Next(1, 99));

            if (potenzaTre == 2){
                lbl_potenzaNUno.Text = "3";}
            else if (potenzaTre == 1) { lbl_potenzaNUno.Text = "2"; }
            else { lbl_potenzaNUno.Text = ""; }

            if (lbl_potenzaNUno.Text == "3") { lbl_potenzaNDue.Text = "2"; }
            else if (lbl_potenzaNUno.Text == "2") { lbl_potenzaNDue.Text = "1"; }
            else if (lbl_potenzaNUno.Text == "") { lbl_potenzaNDue.Text = ""; }

        }

        private void checkFrazione_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
