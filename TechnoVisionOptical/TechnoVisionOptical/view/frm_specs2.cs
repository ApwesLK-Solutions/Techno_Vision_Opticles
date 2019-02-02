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
        private MetroFramework.Forms.MetroForm back;
   
        public frm_specs2(MetroFramework.Forms.MetroForm ui)
        {
            InitializeComponent();
            back = ui;          
        }

        private void frm_specs2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.frame' table. You can move, or remove it, as needed.
            this.frameTableAdapter.Fill(this.technovisionDataSet.frame);

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_dist_sph_right.Text=="" || txt_dist_cyl_right.Text=="" || txt_dist_axis_right.Text=="" || txt_dist_sph_left.Text=="" || txt_dist_cyl_left.Text=="" || txt_dist_axis_left.Text=="" || txt_add_sph_right.Text=="" || txt_add_cyl_right.Text=="" || txt_add_axis_right.Text=="" || txt_add_sph_left.Text=="" || txt_add_cyl_left.Text=="" || txt_add_axis_left.Text=="" || txt_lense_type.Text=="" || txt_PD.Text=="" || txt_seg_height.Text=="" || txt_specialInc.Text=="" || txt_remarks.Text=="")
                {
                    MSG.ERROR(this, "Fields can no be empty.If you want to leave a empty field please put (-) into text fields");
                }
                else
                {
                    NewSpectaclesInvoice.FillFormTwo(txt_dist_sph_right.Text, txt_dist_cyl_right.Text, txt_dist_axis_right.Text, txt_dist_sph_left.Text, txt_dist_cyl_left.Text, txt_dist_axis_left.Text, txt_add_sph_right.Text, txt_add_cyl_right.Text, txt_add_axis_right.Text, txt_add_sph_left.Text, txt_add_cyl_left.Text, txt_add_axis_left.Text, txt_lense_type.Text, cmb_frame.Text, txt_PD.Text, txt_seg_height.Text, txt_specialInc.Text, txt_remarks.Text);
                    NewSpectaclesInvoice.save(this);
                    new frm_orderComplete(Customer.id, NewSpectaclesInvoice.OrderNumber, "SPEC").ShowDialog();
                    back.Close();
                    this.Close();
                }

            }
            catch(Exception)
            {
                MSG.ERROR(this, "Can not Save Please try again...");
            }
            
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            txt_dist_sph_right.Text="";
            txt_dist_cyl_right.Text="";
            txt_dist_axis_right.Text=""; 
            txt_dist_sph_left.Text="";
            txt_dist_cyl_left.Text="";
            txt_dist_axis_left.Text="";
            txt_add_sph_right.Text="";
            txt_add_cyl_right.Text="";
            txt_add_axis_right.Text="";
            txt_add_sph_left.Text="";
            txt_add_cyl_left.Text="";
            txt_add_axis_left.Text="";
            txt_lense_type.Text="";
            cmb_frame.Text=""; 
            txt_PD.Text="";
            txt_seg_height.Text="";
            txt_specialInc.Text="";
            txt_remarks.Text="";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            back.ShowDialog();
            this.Close();
        }

       
    }
}
