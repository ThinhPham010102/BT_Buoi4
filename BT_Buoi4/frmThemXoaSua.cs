using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BT_Buoi4
{
    public partial class frmThemXoaSua : Form
    {
        private frmThongTin frmCha;
        private bool them;
        private ListViewItem itemSua;

        public frmThemXoaSua(frmThongTin cha, bool them, ListViewItem itemSua = null)
        {
            InitializeComponent();
            this.frmCha = cha;
            this.them = them;
            this.itemSua = itemSua;

            if (!them && itemSua != null)
            {
               txtMSNV.Text = itemSua.SubItems[0].Text;
                txtTenNV.Text = itemSua.SubItems[1].Text;
                txtLuongCB.Text = itemSua.SubItems[2].Text;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            frmCha.capNhatListView(txtMSNV.Text, txtTenNV.Text, txtLuongCB.Text, them);
            //this.Close();
        }


        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
