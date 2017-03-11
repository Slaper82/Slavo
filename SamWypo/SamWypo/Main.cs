﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo
{
    public partial class Main : Form
    {
        Helper data;
        public Main()
        {
            InitializeComponent();
            data = new Helper(DateTime.Now,DateTime.Now,dtpStart,dtpStop);
            data.UstawDate();
        }

        private void btnDodSam_Click(object sender, EventArgs e)
        {
            frmDodSamo nowy = new frmDodSamo();
            nowy.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKlient nowy = new frmKlient();
            nowy.Text = "Nowy Klient";
            nowy.ShowDialog();
        }
    }
}
