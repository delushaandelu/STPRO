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
    public partial class frmAddEditStudent : MetroFramework.Forms.MetroForm
    {
        public frmAddEditStudent(Student obj)
        {
            InitializeComponent();
            bindingSourceStdPro.DataSource = obj;
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Male";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Female";
            else
                chkGender.Text = "???";
        }

        public Student StudentInfo { get { return bindingSourceStdPro.Current as Student; } }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceStdPro.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void frmAddEditStudent_Load(object sender, EventArgs e)
        {
            cboCity.DisplayMember = "CityName";
            cboCity.ValueMember = "CityId";
            using (stdproEntities db = new stdproEntities()) 
            {
                cboCity.DataSource = db.Cities.ToList();
            }
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Male";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Female";
            else
                chkGender.Text = "???";
        }
    }
}
