﻿using System;
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
    public partial class frm_newPayment : MetroFramework.Forms.MetroForm
    {
        public frm_newPayment()
        {
            InitializeComponent();
        }

        public frm_newPayment(Customer c) 
        {
            InitializeComponent();        
        }
    }
}
