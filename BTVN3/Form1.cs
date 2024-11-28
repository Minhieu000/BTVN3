using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN3
{
    public partial class From : Form
    {
        public From()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTVN_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem (txtLast.Text);
            lvi.SubItems.Add(txtFirst.Text);
            lvi.SubItems.Add (txtPhone.Text);
            lvStudent.Items.Add(lvi);
      
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0) 
            {
                lvStudent.Items.Remove(lvStudent.SelectedItems[0]); 
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (lvStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Xóa mục được chọn
            foreach (ListViewItem selectedItem in lvStudent.SelectedItems)
            {
                lvStudent.Items.Remove(selectedItem); // Xóa dựa trên đối tượng
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0) 
            {
                ListViewItem selectedItem = lvStudent.SelectedItems[0];
                selectedItem.Text = txtLast.Text; 
                selectedItem.SubItems[1].Text = txtFirst.Text; 
                selectedItem.SubItems[2].Text = txtPhone.Text; 
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0) 
            {
                ListViewItem selected = lvStudent.SelectedItems[0];
                txtLast.Text = selected.Text; 
                txtFirst.Text = selected.SubItems[1].Text; 
                txtPhone.Text = selected.SubItems[2].Text; 
            }
        }
        private void from_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát?", " Tiêu đề thông báo ",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

