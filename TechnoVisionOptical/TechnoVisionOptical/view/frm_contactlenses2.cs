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
        MetroFramework.Forms.MetroForm contactLense;
       
        public frm_contactlenses2(MetroFramework.Forms.MetroForm ui)
        {
            InitializeComponent();
            contactLense = ui;
        }

        private void frm_contactlenses2_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_right_old_sph.Text =="" || txt_right_old_cyl.Text =="" || txt_right_old_axis.Text =="" || txt_right_old_add.Text=="" || txt_left_old_sph.Text =="" || txt_left_old_cyl.Text =="" || txt_left_old_axis.Text=="" || txt_left_old_add.Text =="" || txt_left_present_sph.Text =="" || txt_left_present_cyl.Text =="" || txt_left_present_axis.Text =="" || txt_left_present_add.Text =="" || txt_right_present_sph.Text== "" || txt_right_present_cyl.Text =="" ||txt_right_present_axis.Text =="" || txt_right_present_add.Text =="" || txt_right_bc.Text =="" || txt_right_pow.Text=="" || txt_right_dia.Text =="" || txt_right_desz.Text =="" || txt_left_bc.Text =="" || txt_left_pow.Text =="" || txt_left_dia.Text=="" || txt_left_desz.Text=="" || txt_trail.Text=="" || txt_refract.Text=="" || txt_special.Text==""|| txt_remarks.Text=="" || txt_kread.Text =="" || txt_blink.Text=="")
                {
                    MSG.ERROR(this, "Fields can no be empty.If you want to leave a empty field please put (-) into text fields");
                }
                else
                {
                     NewContactLenseInvoice.fillFormTwo(txt_right_old_sph.Text, txt_right_old_cyl.Text, txt_right_old_axis.Text, txt_right_old_add.Text, txt_left_old_sph.Text, txt_left_old_cyl.Text, txt_left_old_axis.Text, txt_left_old_add.Text, txt_left_present_sph.Text, txt_left_present_cyl.Text, txt_left_present_axis.Text, txt_left_present_add.Text, txt_right_present_sph.Text, txt_right_present_cyl.Text, txt_right_present_axis.Text, txt_right_present_add.Text, txt_right_bc.Text, txt_right_pow.Text, txt_right_dia.Text, txt_right_desz.Text, txt_left_bc.Text, txt_left_pow.Text, txt_left_dia.Text, txt_left_desz.Text, txt_trail.Text, txt_refract.Text, txt_special.Text, txt_remarks.Text, txt_kread.Text, txt_blink.Text);
                NewContactLenseInvoice.save(this);
                new frm_orderComplete(Customer.id, NewContactLenseInvoice.OrderNumber, "LENSE").Show();
                contactLense.Close();
                this.Close();
                }
               
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MSG.ERROR(this, "Can not Save Please try again...");
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            contactLense.Show();
            this.Close();
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            txt_right_old_sph.Text="";
            txt_right_old_cyl.Text="";
            txt_right_old_axis.Text="";
            txt_right_old_add.Text= "";
            txt_left_old_sph.Text="" ;
            txt_left_old_cyl.Text="";
            txt_left_old_axis.Text="";
            txt_left_old_add.Text="";
            txt_left_present_sph.Text="";
            txt_left_present_cyl.Text="";
            txt_left_present_axis.Text= "";
            txt_left_present_add.Text="";
            txt_right_present_sph.Text= "";
            txt_right_present_cyl.Text= "";
            txt_right_present_axis.Text="";
            txt_right_present_add.Text= "";
            txt_right_bc.Text="";
            txt_right_pow.Text="";
            txt_right_dia.Text= "";
            txt_right_desz.Text= "";
            txt_left_bc.Text= "";
            txt_left_pow.Text="";
            txt_left_dia.Text="";
            txt_left_desz.Text= "";
            txt_trail.Text= "";
            txt_refract.Text= "";
            txt_special.Text= "";
            txt_remarks.Text= "";
            txt_kread.Text= "";
            txt_blink.Text = "";
            
        }      
    }
}