using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.controller;
namespace TechnoVisionOptical.view
{
    public partial class frm_customerList : MetroFramework.Forms.MetroForm
    {
        private string type = null;
        public frm_customerList()
        {
            InitializeComponent();
        }
        public frm_customerList(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void frm_customerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.technovisionDataSet.customers);

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            customersBindingSource.Filter = ("name LIKE '%" + metroTextBox1.Text + "%' OR phone LIKE '%" + metroTextBox1.Text + "%'");
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if(type == "L")
            {
                customerController.fillLenseFormDataByCustomerID(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), this);
            }
            else
            {
                customerController.fillSpecFormDataByCustomerID(int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()), this);
            }
        }
    }
}
