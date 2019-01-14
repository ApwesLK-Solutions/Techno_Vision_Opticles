using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;

namespace TechnoVisionOptical
{
    class MSG
    {
        public static void SUCCESS(MetroFramework.Forms.MetroForm ui ,  string msg)
        {
            MetroMessageBox.Show(ui, msg.ToString(), "Success", MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
        public static void ERROR(MetroFramework.Forms.MetroForm ui, string msg)
        {
            MetroMessageBox.Show(ui, msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
