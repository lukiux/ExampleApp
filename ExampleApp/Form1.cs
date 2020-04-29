using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Globalization;
using Oracle.DataAccess.Client;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        BindingList<PACK_PACKING> packPacking;
        BindingList<PACK_WASHINGLABELS> packWashList;
        private int CurrentTabPage { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeEntities();
        }

        private void InitializeEntities()
        {
            using (Entities db = new Entities())
            {                  
                packPacking = new BindingList<PACK_PACKING>(db.PACK_PACKING.ToList());
                packWashList = new BindingList<PACK_WASHINGLABELS>(db.PACK_WASHINGLABELS.ToList());
                
                dataGridView1.DataSource = packPacking;
                dataGridView2.DataSource = packWashList;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTabPage = tabControl1.SelectedIndex;
        }       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString());
            if (id == 0)
            {
                id = dataGridView1.RowCount;
                int i = (int)id - 1;
                packPacking[i].ID = id;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dataGridView2.CurrentRow.Cells["iDDataGridViewTextBoxColumn1"].Value.ToString());
            if (id == 0)
            {
                id = dataGridView2.RowCount;
                int i = (int)id - 1;
                packWashList[i].ID = id;
            }
        }        
    }
}
