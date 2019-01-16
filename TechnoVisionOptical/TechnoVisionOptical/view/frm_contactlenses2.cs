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
       
        public frm_contactlenses2()
        {
            InitializeComponent();
        }

        private void frm_contactlenses2_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NewContactLenseInvoice.fillFormTwo(txt_right_old_sph.Text, txt_right_old_cyl.Text, txt_right_old_axis.Text, txt_right_old_add.Text, txt_left_old_sph.Text, txt_left_old_cyl.Text, txt_left_old_axis.Text, txt_left_old_add.Text, txt_left_present_sph.Text, txt_left_present_cyl.Text, txt_left_present_axis.Text, txt_left_present_add.Text, txt_right_present_sph.Text, txt_right_present_cyl.Text, txt_right_present_axis.Text, txt_right_present_add.Text, txt_right_bc.Text, txt_right_pow.Text, txt_right_dia.Text, txt_right_desz.Text, txt_left_bc.Text, txt_left_pow.Text, txt_left_dia.Text, txt_left_desz.Text, txt_trail.Text, txt_refract.Text, txt_special.Text, txt_remarks.Text, txt_kread.Text, txt_blink.Text, txt_r_before.Text, txt_l_after.Text);
            NewContactLenseInvoice.save(this);
        }      
    }
}