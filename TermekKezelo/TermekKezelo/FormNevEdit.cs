using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermekKezelo
{
    public partial class FormNewEditF : Form
    {
        private Gun g;

        public FormNewEditF(Gun g)
        {
            InitializeComponent();
            this.g = g;
            showData();
        }

        private void showData()
        {
            tBID.Text = g.getId().ToString();
            tBGyarto.Text = g.getGyarto();
            tBNev.Text = g.getNev();
            tBTipus.Text = g.getTipus().ToString();
            tBFPS.Text = g.getFPS().ToString();
            tBSuly.Text = g.getSuly().ToString();
            tBAnyag.Text = g.getAnyag();
            tbAr.Text = g.getAr().ToString();
            tBVarians.Text = g.getVarians().ToString();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
           // g.setId(Convert.ToInt32(tBID.Text));
            g.setGyarto(tBGyarto.Text);
            g.setNev(tBNev.Text);
            g.setTipus(Convert.ToInt32(tBTipus.Text));
            g.setFPS(Convert.ToInt32(tBFPS.Text));
            g.setSuly(Convert.ToInt32(tBSuly.Text));
            g.setAnyag(tBAnyag.Text);
            g.setAr(Convert.ToInt32(tbAr.Text));
            g.setVarians(Convert.ToInt32(tBVarians.Text));
            this.Close();
        }

        public Gun editedGun()
        {
            return g;
        }
    }
}
