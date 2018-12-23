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
        private bool edit = false;

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
            
        }

        private void save()
        {
            if (!edit)
            {
                MessageBox.Show("Nem történt semmilyen módosítás!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mdi.updateChangesInTable(tableGun);
                dTGVF.ReadOnly = true;
                dTGVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dTGVF.AllowUserToDeleteRows = false;
            }
        }

        private void betöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGun();
            groupBox1.Enabled = true;
        }

        private void b_editF_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(dTGVF.SelectedRows[0].Cells["FID"].Value);

            Gun g = new Gun(
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["FID"].Value),
                dTGVF.SelectedRows[0].Cells["gyarto"].Value.ToString(),
                dTGVF.SelectedRows[0].Cells["nev"].Value.ToString(),
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["tipus"].Value),
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["FPS"].Value),
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["suly"].Value),
                dTGVF.SelectedRows[0].Cells["anyag"].Value.ToString(),
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["ar"].Value),
                Convert.ToInt32(dTGVF.SelectedRows[0].Cells["varians"].Value)
                );

            FormNewEditF fnef = new FormNewEditF(g);

            if (fnef.ShowDialog(this) == DialogResult.OK)
            {
                Gun editedGun = fnef.editedGun();
                int sor = dTGVF.SelectedRows[0].Index;
               // dTGVF.Rows[sor].Cells["FID"].Value = editedGun.getId();
                dTGVF.Rows[sor].Cells["gyarto"].Value = editedGun.getGyarto();
                dTGVF.Rows[sor].Cells["nev"].Value = editedGun.getNev();
                dTGVF.Rows[sor].Cells["tipus"].Value = editedGun.getTipus();
                dTGVF.Rows[sor].Cells["FPS"].Value = editedGun.getFPS();
                dTGVF.Rows[sor].Cells["suly"].Value = editedGun.getSuly();
                dTGVF.Rows[sor].Cells["anyag"].Value = editedGun.getAnyag();
                dTGVF.Rows[sor].Cells["ar"].Value = editedGun.getAr();
                dTGVF.Rows[sor].Cells["varians"].Value = editedGun.getVarians();
            }
        }

        private void b_newF_Click(object sender, EventArgs e)
        {
            dTGVF.AllowUserToAddRows = true;
            dTGVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int sor = dTGVF.Rows.Count - 1;
            Gun ng = new Gun();
            FormNewEditF fnef = new FormNewEditF(ng);

            if (fnef.ShowDialog(this) == DialogResult.OK)
            {
                Gun editedGun = fnef.editedGun();
                
                // dTGVF.Rows[sor].Cells["FID"].Value = editedGun.getId();
                dTGVF.Rows[sor].Cells["gyarto"].Value = editedGun.getGyarto();
                dTGVF.Rows[sor].Cells["nev"].Value = editedGun.getNev();
                dTGVF.Rows[sor].Cells["tipus"].Value = editedGun.getTipus();
                dTGVF.Rows[sor].Cells["FPS"].Value = editedGun.getFPS();
                dTGVF.Rows[sor].Cells["suly"].Value = editedGun.getSuly();
                dTGVF.Rows[sor].Cells["anyag"].Value = editedGun.getAnyag();
                dTGVF.Rows[sor].Cells["ar"].Value = editedGun.getAr();
                dTGVF.Rows[sor].Cells["varians"].Value = editedGun.getVarians();
                for (int i = 0; i < sor; i++)
                {
                    dTGVF.Rows[i].ReadOnly = false;
                    dTGVF.FirstDisplayedScrollingRowIndex = sor;
                }
            }
            
            dTGVF.Columns[0].ReadOnly = true;
        }

        private void dTGVF_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            Adatbazis ujID = new Adatbazis();
            MySQLDatabaseInterface mdujid = ujID.kapcsolodas();
            mdujid.open();
            int max;
            bool siker = int.TryParse(mdujid.executeScalarQuery("SELECT MAX(FID) FROM fegyverek"), out max);
            if (!siker)
            {
                MessageBox.Show("Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba.", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mdujid.close();
            e.Row.Cells[0].Value = max + 1;
        }

        private void FormTK_Load(object sender, EventArgs e)
        {
            dTGVF.ReadOnly = true;
            dTGVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dTGVF.AllowUserToDeleteRows = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void b_delF_Click(object sender, EventArgs e)
        {
            try
            {
                int sor = dTGVF.SelectedRows[0].Index;
                if (MessageBox.Show("Biztos törli az adatot?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dTGVF.Rows.RemoveAt(sor);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nincs kijelölve adat!", "Törlés", MessageBoxButtons.OK);
                return;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                if (MessageBox.Show("Nem mentett adatok! Biztos kilép?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }

        private void dTGVF_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            edit = false;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGun();
        }
    }
}
