﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar_1120
{
    public partial class Form1 : Form
    {
        Color renk = Color.Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.uzunKenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.kısaKenar = Convert.ToInt32(txtSayi2.Text);
            //sekil1.Karesi

            sekil1.SekilCiz(btnSekil, Color.Sienna);

            btnSekil.Width = Convert.ToInt32(txtSayi1.Text);
            btnSekil.Height = Convert.ToInt32(txtSayi2.Text);

            sekil1.mesajDegistir(btnSekil, txtMesaj.Text);



        }
    }
}
