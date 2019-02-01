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
    public partial class frm_testersList : MetroFramework.Forms.MetroForm
    {
        public frm_testersList()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            testersTableAdapter.Insert(txt_emp_name.Text);
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
        }

        private void frm_testersList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //testersTableAdapter.dele
        }
    }
}
