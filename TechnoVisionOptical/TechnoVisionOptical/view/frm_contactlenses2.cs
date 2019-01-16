using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.model;

namespace TechnoVisionOptical.view
{
    public partial class frm_contactlenses2 : MetroFramework.Forms.MetroForm
    {
        private bool newCustomer;
        public frm_contactlenses2(bool newCustomer)
        {
            InitializeComponent();
            this.newCustomer = newCustomer;
        }

        private void frm_contactlenses2_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {           
              Customer.saveCustomer(this);  
        }      
    }
}