﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!DatabaseHasta.HastaTcKontrol(textTc.Text))
            {
                if (textAd.Text != "" && textSoyad.Text != "" && textTc.Text != "" && textTelNo.Text != "" &&
                textSifre.Text != "" && comboCins.Text != "" && textTc.Text.ToString().Length == 11 && textTelNo.Text.ToString().Length == 14)
                {

                    DatabaseHasta.HastaKaydiYap(textAd.Text, textSoyad.Text, textTc.Text
                        , textTelNo.Text, textSifre.Text, comboCins.Text);
                    MessageBox.Show("Hasta kaydı başarılı! Şifreniz: " + textSifre.Text, "Hasta Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Hasta Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bu hastanın kaydı bulunmaktadır, lütfen bilgileri kontrol edip tekrar deneyiniz!", "Hasta Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
