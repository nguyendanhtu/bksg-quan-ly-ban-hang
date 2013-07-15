using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class f001_menu : Form
    {
        public f001_menu()
        {
            InitializeComponent();
        }

        public void display()
        {
            this.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f701_V_DM_NHA_CUNG_CAP v_frm = new f701_V_DM_NHA_CUNG_CAP();
            v_frm.display();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f501_V_DM_KHACH_HANG v_frm = new f501_V_DM_KHACH_HANG();
            v_frm.display();
        }
    }
}
