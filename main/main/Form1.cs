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
            using (frmAddEditStudent frm = new frmAddEditStudent(new Student() { Gender = false})) 
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            studentBindingSource.DataSource = db.Students.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
            Cursor.Current = Cursors.Default;
        }
        stdproEntities db;

        private void Students_Load(object sender, EventArgs e)
        {
            db = new stdproEntities();
            studentBindingSource.DataSource = db.Students.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
        }
    }
}
