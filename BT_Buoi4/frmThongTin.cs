using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemXoaSua frm = new frmThemXoaSua(this, true);
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                ListViewItem item = lvThongTin.SelectedItems[0];
                frmThemXoaSua frm = new frmThemXoaSua(this, false, item);
                frm.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                lvThongTin.Items.Remove(lvThongTin.SelectedItems[0]);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void capNhatListView(string maNV, string tenNV, string luongCB, bool isAdd)
        {
            if (isAdd)
            {
                ListViewItem item = new ListViewItem(maNV);
                item.SubItems.Add(tenNV);
                item.SubItems.Add(luongCB);
                lvThongTin.Items.Add(item);
            }
            else
            {
                ListViewItem item = lvThongTin.SelectedItems[0];
                item.SubItems[0].Text = maNV;
                item.SubItems[1].Text = tenNV;
                item.SubItems[2].Text = luongCB;
            }
        }
    }
}
