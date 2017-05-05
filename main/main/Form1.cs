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

        private async void mtAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditStudent frm = new frmAddEditStudent(new Student() { Gender = false})) 
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        studentBindingSource.Add(frm.StudentInfo);
                        db.Students.Add(frm.StudentInfo);
                        await db.SaveChangesAsync();
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

        private void mtEdit_Click(object sender, EventArgs e)
        {
            Student obj = studentBindingSource.Current as Student;
            if (obj != null) 
            {
                using (frmAddEditStudent frm = new frmAddEditStudent(obj)) 
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            studentBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            {

                            }
                        }
                    }
                }
            }
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            int rows = dataGridView.RowCount;
            for(int i=rows-1; i >=0; i--)
            {
                if(dataGridView.Rows[i].Selected)
                {
                    db.Students.Remove(dataGridView.Rows[i].DataBoundItem as Student);
                    studentBindingSource.RemoveAt(dataGridView.Rows[i].Index);
                }
            }
        }

        private async void mtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    studentBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
