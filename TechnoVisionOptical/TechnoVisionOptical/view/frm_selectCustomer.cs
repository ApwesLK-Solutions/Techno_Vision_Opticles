using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoVisionOptical.view
{
    public partial class frm_selectCustomer : MetroFramework.Forms.MetroForm
    {
        private string product = null;

        public frm_selectCustomer()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            

            if(product == "L")
            {
                new frm_contactlenses().Show();
            }
            else
            {
                new frm_specs().Show();            
            }            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (product == "L")
            {
                new frm_selectCustomer().Show();
            }
            else 
            {
                new frm_selectCustomer().Show();
            }
        }
    }
}
