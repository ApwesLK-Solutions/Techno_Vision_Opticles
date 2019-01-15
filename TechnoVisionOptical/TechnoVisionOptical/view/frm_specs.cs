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
    public partial class frm_specs : MetroFramework.Forms.MetroForm
    {
        public frm_specs()
        {
            InitializeComponent();
        }
        public frm_specs(string _name, string _address, string _phone, string _email, string _profession, int _age)
        {
            InitializeComponent();
            txt_address.Text = _address;
            txt_name.Text = _name;
            txt_phone.Text = _phone;
            txt_email.Text = _email;
            txt_proffession.Text = _profession;
            txt_age.Text = _age.ToString();
        }

        private void frm_specs_Load(object sender, EventArgs e)
        {

        }
    }
}
