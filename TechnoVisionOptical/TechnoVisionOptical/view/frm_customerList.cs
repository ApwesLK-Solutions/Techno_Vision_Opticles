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
using TechnoVisionOptical.model;
namespace TechnoVisionOptical.view
{
    public partial class frm_customerList : MetroFramework.Forms.MetroForm
    {
        private string type = null;
        public frm_customerList()
        {
            InitializeComponent();
        }
        public void refreshGrid()
        {
            this.customersTableAdapter.Fill(this.technovisionDataSet.customers);
        }
        public frm_customerList(string type)
        {
            InitializeComponent();
        }
        private void frm_customerList_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.technovisionDataSet.customers);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            customersBindingSource.Filter = ("name LIKE '%" + txt_search.Text + "%' OR phone LIKE '%" + txt_search.Text + "%'");
        }

        private void btn_addNewCustomer_Click(object sender, EventArgs e)
        {
            new frm_customer().Show();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Customer.id = int.Parse(metroGrid1.SelectedRows[0].Cells[0].ToString());
            Customer.name = metroGrid1.SelectedRows[0].Cells[1].ToString();
            Customer.address = metroGrid1.SelectedRows[0].Cells[2].ToString();
            Customer.profession = metroGrid1.SelectedRows[0].Cells[3].ToString();
            Customer.age = int.Parse(metroGrid1.SelectedRows[0].Cells[4].ToString());
            Customer.phone = metroGrid1.SelectedRows[0].Cells[5].ToString();
            Customer.email = metroGrid1.SelectedRows[0].Cells[6].ToString();
            if(type == "S")
            {
                new frm_specs().Show();
            }
            else
            {
                new frm_contactlenses().Show();
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }


    }
}
