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
    public partial class frm_customer : MetroFramework.Forms.MetroForm
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if((txt_name.Text=="")||(txt_email.Text=="")||(txt_age.Text=="")||(txt_phone.Text=="")||(txt_address.Text=="")||(txt_proffession.Text==""))
                {
                    MSG.ERROR(this, "Please Enter Required Fields...");
                }
                else
                {
                    Customer.name = txt_name.Text;
                    Customer.address = txt_address.Text;
                    Customer.age = int.Parse(txt_age.Text);
                    Customer.email = txt_email.Text;
                    Customer.phone = txt_phone.Text;
                    Customer.profession = txt_proffession.Text;
                    Customer.saveCustomer(this);
                    MSG.SUCCESS(this, "Customer Saved Successfully...Please Refresh the Customer List to Get Updated One");
                    this.Close();

                }
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MSG.ERROR(this, "Can not Save Customer");
            } 
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            decimal m;

            if (!decimal.TryParse(txt_age.Text, out m)) 
            {
                MSG.ERROR(this, "Age should be a Whole Number");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text="";
            txt_age.Text="";
            txt_email.Text="";
            txt_phone.Text="";
            txt_proffession.Text="";
        }

        
    }
}
