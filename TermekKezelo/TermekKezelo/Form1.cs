using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using ConnectToMysqlDatabase;

namespace TermekKezelo
{
    public partial class FormTK : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable tableGun;

        public FormTK()
        {
            InitializeComponent();
            dTGVF.ReadOnly = true;
            dTGVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dTGVF.AllowUserToDeleteRows = false;
        }

        private void loadGun()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            tableGun = mdi.getToDataTable("SELECT * FROM fegyverek");
            dTGVF.DataSource = tableGun;
            mdi.close();
        }

        private void betöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGun();
        }
    }
}
