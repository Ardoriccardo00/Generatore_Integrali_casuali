using System;

namespace Generatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nUno = new System.Windows.Forms.Label();
            this.lbl_lineaFrazione = new System.Windows.Forms.Label();
            this.lbl_dUno = new System.Windows.Forms.Label();
            this.lbl_simboloUno = new System.Windows.Forms.Label();
            this.lbl_nDue = new System.Windows.Forms.Label();
            this.lbl_simboloDue = new System.Windows.Forms.Label();
            this.lbl_nTre = new System.Windows.Forms.Label();
            this.lbl_simboloTre = new System.Windows.Forms.Label();
            this.lbl_dDue = new System.Windows.Forms.Label();
            this.lbl_simboloQuattro = new System.Windows.Forms.Label();
            this.lbl_dTre = new System.Windows.Forms.Label();
            this.btn_Genera = new System.Windows.Forms.Button();
            this.pannelloDenominatore = new System.Windows.Forms.Panel();
            this.lbl_potenzaQuattro = new System.Windows.Forms.Label();
            this.lbl_potenzaTre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkDefiniti = new System.Windows.Forms.CheckBox();
            this.checkFrazione = new System.Windows.Forms.CheckBox();
            this.lbl_potenzaNUno = new System.Windows.Forms.Label();
            this.lbl_potenzaNDue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areaCalcolo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_definitoUno = new System.Windows.Forms.Label();
            this.lbl_definitoDue = new System.Windows.Forms.Label();
            this.lbl_calcoloUno = new System.Windows.Forms.Label();
            this.lbl_calcoloDue = new System.Windows.Forms.Label();
            this.lbl_calcoloTre = new System.Windows.Forms.Label();
            this.lbl_calcoloQuattro = new System.Windows.Forms.Label();
            this.pannelloDenominatore.SuspendLayout();
            this.panel1.SuspendLayout();
            this.areaCalcolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nUno
            // 
            this.lbl_nUno.AutoSize = true;
            this.lbl_nUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nUno.Location = new System.Drawing.Point(4, 28);
            this.lbl_nUno.Name = "lbl_nUno";
            this.lbl_nUno.Size = new System.Drawing.Size(44, 31);
            this.lbl_nUno.TabIndex = 1;
            this.lbl_nUno.Text = "00";
            // 
            // lbl_lineaFrazione
            // 
            this.lbl_lineaFrazione.AutoSize = true;
            this.lbl_lineaFrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lineaFrazione.Location = new System.Drawing.Point(3, 1);
            this.lbl_lineaFrazione.Name = "lbl_lineaFrazione";
            this.lbl_lineaFrazione.Size = new System.Drawing.Size(698, 31);
            this.lbl_lineaFrazione.TabIndex = 2;
            this.lbl_lineaFrazione.Text = "----------------------------------------------------------------------------";
            // 
            // lbl_dUno
            // 
            this.lbl_dUno.AutoSize = true;
            this.lbl_dUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dUno.Location = new System.Drawing.Point(3, 43);
            this.lbl_dUno.Name = "lbl_dUno";
            this.lbl_dUno.Size = new System.Drawing.Size(44, 31);
            this.lbl_dUno.TabIndex = 3;
            this.lbl_dUno.Text = "00";
            // 
            // lbl_simboloUno
            // 
            this.lbl_simboloUno.AutoSize = true;
            this.lbl_simboloUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simboloUno.Location = new System.Drawing.Point(46, 28);
            this.lbl_simboloUno.Name = "lbl_simboloUno";
            this.lbl_simboloUno.Size = new System.Drawing.Size(27, 31);
            this.lbl_simboloUno.TabIndex = 4;
            this.lbl_simboloUno.Text = "x";
            // 
            // lbl_nDue
            // 
            this.lbl_nDue.AutoSize = true;
            this.lbl_nDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nDue.Location = new System.Drawing.Point(113, 28);
            this.lbl_nDue.Name = "lbl_nDue";
            this.lbl_nDue.Size = new System.Drawing.Size(44, 31);
            this.lbl_nDue.TabIndex = 5;
            this.lbl_nDue.Text = "00";
            // 
            // lbl_simboloDue
            // 
            this.lbl_simboloDue.AutoSize = true;
            this.lbl_simboloDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simboloDue.Location = new System.Drawing.Point(163, 28);
            this.lbl_simboloDue.Name = "lbl_simboloDue";
            this.lbl_simboloDue.Size = new System.Drawing.Size(27, 31);
            this.lbl_simboloDue.TabIndex = 6;
            this.lbl_simboloDue.Text = "x";
            // 
            // lbl_nTre
            // 
            this.lbl_nTre.AutoSize = true;
            this.lbl_nTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nTre.Location = new System.Drawing.Point(232, 28);
            this.lbl_nTre.Name = "lbl_nTre";
            this.lbl_nTre.Size = new System.Drawing.Size(44, 31);
            this.lbl_nTre.TabIndex = 7;
            this.lbl_nTre.Text = "00";
            // 
            // lbl_simboloTre
            // 
            this.lbl_simboloTre.AutoSize = true;
            this.lbl_simboloTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simboloTre.Location = new System.Drawing.Point(43, 43);
            this.lbl_simboloTre.Name = "lbl_simboloTre";
            this.lbl_simboloTre.Size = new System.Drawing.Size(27, 31);
            this.lbl_simboloTre.TabIndex = 8;
            this.lbl_simboloTre.Text = "x";
            // 
            // lbl_dDue
            // 
            this.lbl_dDue.AutoSize = true;
            this.lbl_dDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dDue.Location = new System.Drawing.Point(108, 43);
            this.lbl_dDue.Name = "lbl_dDue";
            this.lbl_dDue.Size = new System.Drawing.Size(44, 31);
            this.lbl_dDue.TabIndex = 9;
            this.lbl_dDue.Text = "00";
            // 
            // lbl_simboloQuattro
            // 
            this.lbl_simboloQuattro.AutoSize = true;
            this.lbl_simboloQuattro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simboloQuattro.Location = new System.Drawing.Point(151, 43);
            this.lbl_simboloQuattro.Name = "lbl_simboloQuattro";
            this.lbl_simboloQuattro.Size = new System.Drawing.Size(27, 31);
            this.lbl_simboloQuattro.TabIndex = 10;
            this.lbl_simboloQuattro.Text = "x";
            // 
            // lbl_dTre
            // 
            this.lbl_dTre.AutoSize = true;
            this.lbl_dTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dTre.Location = new System.Drawing.Point(229, 43);
            this.lbl_dTre.Name = "lbl_dTre";
            this.lbl_dTre.Size = new System.Drawing.Size(44, 31);
            this.lbl_dTre.TabIndex = 11;
            this.lbl_dTre.Text = "00";
            // 
            // btn_Genera
            // 
            this.btn_Genera.Location = new System.Drawing.Point(51, 112);
            this.btn_Genera.Name = "btn_Genera";
            this.btn_Genera.Size = new System.Drawing.Size(106, 44);
            this.btn_Genera.TabIndex = 12;
            this.btn_Genera.Text = "Genera";
            this.btn_Genera.UseVisualStyleBackColor = true;
            this.btn_Genera.Click += new System.EventHandler(this.btn_Genera_Click);
            // 
            // pannelloDenominatore
            // 
            this.pannelloDenominatore.Controls.Add(this.lbl_calcoloQuattro);
            this.pannelloDenominatore.Controls.Add(this.lbl_calcoloTre);
            this.pannelloDenominatore.Controls.Add(this.lbl_potenzaQuattro);
            this.pannelloDenominatore.Controls.Add(this.lbl_potenzaTre);
            this.pannelloDenominatore.Controls.Add(this.lbl_dUno);
            this.pannelloDenominatore.Controls.Add(this.lbl_simboloTre);
            this.pannelloDenominatore.Controls.Add(this.lbl_dTre);
            this.pannelloDenominatore.Controls.Add(this.lbl_dDue);
            this.pannelloDenominatore.Controls.Add(this.lbl_simboloQuattro);
            this.pannelloDenominatore.Controls.Add(this.lbl_lineaFrazione);
            this.pannelloDenominatore.Location = new System.Drawing.Point(3, 62);
            this.pannelloDenominatore.Name = "pannelloDenominatore";
            this.pannelloDenominatore.Size = new System.Drawing.Size(294, 94);
            this.pannelloDenominatore.TabIndex = 13;
            // 
            // lbl_potenzaQuattro
            // 
            this.lbl_potenzaQuattro.AutoSize = true;
            this.lbl_potenzaQuattro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenzaQuattro.Location = new System.Drawing.Point(167, 32);
            this.lbl_potenzaQuattro.Name = "lbl_potenzaQuattro";
            this.lbl_potenzaQuattro.Size = new System.Drawing.Size(20, 24);
            this.lbl_potenzaQuattro.TabIndex = 18;
            this.lbl_potenzaQuattro.Text = "x";
            // 
            // lbl_potenzaTre
            // 
            this.lbl_potenzaTre.AutoSize = true;
            this.lbl_potenzaTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenzaTre.Location = new System.Drawing.Point(60, 32);
            this.lbl_potenzaTre.Name = "lbl_potenzaTre";
            this.lbl_potenzaTre.Size = new System.Drawing.Size(20, 24);
            this.lbl_potenzaTre.TabIndex = 18;
            this.lbl_potenzaTre.Text = "x";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkDefiniti);
            this.panel1.Controls.Add(this.checkFrazione);
            this.panel1.Controls.Add(this.btn_Genera);
            this.panel1.Location = new System.Drawing.Point(478, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 170);
            this.panel1.TabIndex = 14;
            // 
            // checkDefiniti
            // 
            this.checkDefiniti.AutoSize = true;
            this.checkDefiniti.Checked = true;
            this.checkDefiniti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDefiniti.Location = new System.Drawing.Point(3, 23);
            this.checkDefiniti.Name = "checkDefiniti";
            this.checkDefiniti.Size = new System.Drawing.Size(58, 17);
            this.checkDefiniti.TabIndex = 18;
            this.checkDefiniti.Text = "Definiti";
            this.checkDefiniti.UseVisualStyleBackColor = true;
            // 
            // checkFrazione
            // 
            this.checkFrazione.AutoSize = true;
            this.checkFrazione.Checked = true;
            this.checkFrazione.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFrazione.Location = new System.Drawing.Point(3, 3);
            this.checkFrazione.Name = "checkFrazione";
            this.checkFrazione.Size = new System.Drawing.Size(85, 17);
            this.checkFrazione.TabIndex = 17;
            this.checkFrazione.Text = "Con frazione";
            this.checkFrazione.UseVisualStyleBackColor = true;
            this.checkFrazione.CheckedChanged += new System.EventHandler(this.checkFrazione_CheckedChanged);
            // 
            // lbl_potenzaNUno
            // 
            this.lbl_potenzaNUno.AutoSize = true;
            this.lbl_potenzaNUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenzaNUno.Location = new System.Drawing.Point(63, 8);
            this.lbl_potenzaNUno.Name = "lbl_potenzaNUno";
            this.lbl_potenzaNUno.Size = new System.Drawing.Size(20, 24);
            this.lbl_potenzaNUno.TabIndex = 15;
            this.lbl_potenzaNUno.Text = "x";
            // 
            // lbl_potenzaNDue
            // 
            this.lbl_potenzaNDue.AutoSize = true;
            this.lbl_potenzaNDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenzaNDue.Location = new System.Drawing.Point(179, 8);
            this.lbl_potenzaNDue.Name = "lbl_potenzaNDue";
            this.lbl_potenzaNDue.Size = new System.Drawing.Size(20, 24);
            this.lbl_potenzaNDue.TabIndex = 16;
            this.lbl_potenzaNDue.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "dx";
            // 
            // areaCalcolo
            // 
            this.areaCalcolo.Controls.Add(this.lbl_calcoloUno);
            this.areaCalcolo.Controls.Add(this.lbl_calcoloDue);
            this.areaCalcolo.Controls.Add(this.pannelloDenominatore);
            this.areaCalcolo.Controls.Add(this.label2);
            this.areaCalcolo.Controls.Add(this.lbl_nUno);
            this.areaCalcolo.Controls.Add(this.lbl_simboloUno);
            this.areaCalcolo.Controls.Add(this.lbl_potenzaNDue);
            this.areaCalcolo.Controls.Add(this.lbl_nDue);
            this.areaCalcolo.Controls.Add(this.lbl_potenzaNUno);
            this.areaCalcolo.Controls.Add(this.lbl_simboloDue);
            this.areaCalcolo.Controls.Add(this.lbl_nTre);
            this.areaCalcolo.Location = new System.Drawing.Point(100, 44);
            this.areaCalcolo.Name = "areaCalcolo";
            this.areaCalcolo.Size = new System.Drawing.Size(348, 170);
            this.areaCalcolo.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Generatore.Properties.Resources._220px_Integral_Uprightness_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 163);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_definitoUno
            // 
            this.lbl_definitoUno.AutoSize = true;
            this.lbl_definitoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_definitoUno.Location = new System.Drawing.Point(77, 10);
            this.lbl_definitoUno.Name = "lbl_definitoUno";
            this.lbl_definitoUno.Size = new System.Drawing.Size(27, 31);
            this.lbl_definitoUno.TabIndex = 19;
            this.lbl_definitoUno.Text = "x";
            // 
            // lbl_definitoDue
            // 
            this.lbl_definitoDue.AutoSize = true;
            this.lbl_definitoDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_definitoDue.Location = new System.Drawing.Point(55, 169);
            this.lbl_definitoDue.Name = "lbl_definitoDue";
            this.lbl_definitoDue.Size = new System.Drawing.Size(27, 31);
            this.lbl_definitoDue.TabIndex = 21;
            this.lbl_definitoDue.Text = "x";
            // 
            // lbl_calcoloUno
            // 
            this.lbl_calcoloUno.AutoSize = true;
            this.lbl_calcoloUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcoloUno.Location = new System.Drawing.Point(79, 28);
            this.lbl_calcoloUno.Name = "lbl_calcoloUno";
            this.lbl_calcoloUno.Size = new System.Drawing.Size(30, 31);
            this.lbl_calcoloUno.TabIndex = 21;
            this.lbl_calcoloUno.Text = "+";
            // 
            // lbl_calcoloDue
            // 
            this.lbl_calcoloDue.AutoSize = true;
            this.lbl_calcoloDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcoloDue.Location = new System.Drawing.Point(196, 28);
            this.lbl_calcoloDue.Name = "lbl_calcoloDue";
            this.lbl_calcoloDue.Size = new System.Drawing.Size(30, 31);
            this.lbl_calcoloDue.TabIndex = 19;
            this.lbl_calcoloDue.Text = "+";
            // 
            // lbl_calcoloTre
            // 
            this.lbl_calcoloTre.AutoSize = true;
            this.lbl_calcoloTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcoloTre.Location = new System.Drawing.Point(76, 43);
            this.lbl_calcoloTre.Name = "lbl_calcoloTre";
            this.lbl_calcoloTre.Size = new System.Drawing.Size(30, 31);
            this.lbl_calcoloTre.TabIndex = 22;
            this.lbl_calcoloTre.Text = "+";
            // 
            // lbl_calcoloQuattro
            // 
            this.lbl_calcoloQuattro.AutoSize = true;
            this.lbl_calcoloQuattro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcoloQuattro.Location = new System.Drawing.Point(193, 43);
            this.lbl_calcoloQuattro.Name = "lbl_calcoloQuattro";
            this.lbl_calcoloQuattro.Size = new System.Drawing.Size(30, 31);
            this.lbl_calcoloQuattro.TabIndex = 22;
            this.lbl_calcoloQuattro.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 415);
            this.Controls.Add(this.lbl_definitoDue);
            this.Controls.Add(this.lbl_definitoUno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.areaCalcolo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pannelloDenominatore.ResumeLayout(false);
            this.pannelloDenominatore.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.areaCalcolo.ResumeLayout(false);
            this.areaCalcolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkFrazione_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lbl_nUno;
        private System.Windows.Forms.Label lbl_lineaFrazione;
        private System.Windows.Forms.Label lbl_dUno;
        private System.Windows.Forms.Label lbl_simboloUno;
        private System.Windows.Forms.Label lbl_nDue;
        private System.Windows.Forms.Label lbl_simboloDue;
        private System.Windows.Forms.Label lbl_nTre;
        private System.Windows.Forms.Label lbl_simboloTre;
        private System.Windows.Forms.Label lbl_dDue;
        private System.Windows.Forms.Label lbl_simboloQuattro;
        private System.Windows.Forms.Label lbl_dTre;
        private System.Windows.Forms.Button btn_Genera;
        private System.Windows.Forms.Panel pannelloDenominatore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkFrazione;
        private System.Windows.Forms.Label lbl_potenzaNUno;
        private System.Windows.Forms.Label lbl_potenzaNDue;
        private System.Windows.Forms.Label lbl_potenzaQuattro;
        private System.Windows.Forms.Label lbl_potenzaTre;
        private System.Windows.Forms.CheckBox checkDefiniti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel areaCalcolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_definitoUno;
        private System.Windows.Forms.Label lbl_definitoDue;
        private System.Windows.Forms.Label lbl_calcoloQuattro;
        private System.Windows.Forms.Label lbl_calcoloTre;
        private System.Windows.Forms.Label lbl_calcoloUno;
        private System.Windows.Forms.Label lbl_calcoloDue;
    }
}

