using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Students : MetroFramework.Forms.MetroForm
    {
        public Students()
        {
            InitializeComponent();
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditStudent frm = new frmAddEditStudent()) 
            {
                frm.ShowDialog();
            }
        }
    }
}
