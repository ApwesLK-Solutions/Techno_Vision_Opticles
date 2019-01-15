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
    public partial class frm_specs2 : MetroFramework.Forms.MetroForm
    {
        private bool newCustomer = false;
        public frm_specs2(bool newCustomer)
        {
            InitializeComponent();
            this.newCustomer = newCustomer;
        }

        private void frm_specs2_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(newCustomer)
            {
                if (Customer.saveCustomer(this))
                {
                    NewSpectaclesInvoice.FillFormTwo(txt_dist_sph_right.Text, txt_dist_cyl_right.Text, txt_dist_axis_right.Text, txt_dist_sph_left.Text, txt_dist_cyl_left.Text, txt_dist_axis_left.Text, txt_add_sph_right.Text, txt_add_cyl_right.Text, txt_add_axis_right.Text, txt_add_sph_left.Text, txt_add_cyl_left.Text, txt_add_axis_left.Text, txt_lense_type.Text, cmb_frame.Text, txt_PD.Text, txt_seg_height.Text, txt_specialInc.Text, txt_remarks.Text);
                }
            }
        }
    }
}
