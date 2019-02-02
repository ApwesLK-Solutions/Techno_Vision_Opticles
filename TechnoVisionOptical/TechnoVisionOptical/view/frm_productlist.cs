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
    public partial class frm_productlist : MetroFramework.Forms.MetroForm
    {
        public frm_productlist()
        {
            InitializeComponent();
        }

        private void grid_frame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_productlist_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.frame' table. You can move, or remove it, as needed.
            this.frameTableAdapter.Fill(this.technovisionDataSet.frame);
            }
            catch(Exception)
            {
                MSG.ERROR(this, "Can not Load List...");
            }
            
            
           

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_model_name.Text == "")
            {
                MSG.ERROR(this, "Enter Model Number");
            }
            else
            {
                frameTableAdapter.Insert(txt_model_name.Text);
                this.frameTableAdapter.Fill(this.technovisionDataSet.frame);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                frameTableAdapter.DeleteByID(int.Parse(grid_frame.SelectedRows[0].Cells[0].Value.ToString()));
                this.frameTableAdapter.Fill(this.technovisionDataSet.frame);
            }
            catch(Exception exep)
            {
                MSG.ERROR(this, exep.Message.ToString());
            }

        }
    }
}
