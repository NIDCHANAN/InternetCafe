using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInternetCafe
{
    public partial class FrmInternetcafe : Form
    {
        public FrmInternetcafe()
        {
            InitializeComponent();
        }

        private void FrmInternetcafe_Load(object sender, EventArgs e)
        {
            cmbTypeService.Items.Add("");
            cmbTypeService.Items.Add("อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท");
            cmbTypeService.Items.Add("พิมพ์งาน ชั่วโมงละ 10.50 บาท");
            cmbTypeService.Items.Add("เล่นเกม offline ชั่วโมงละ 15.50 บาท");
            cmbTypeService.Items.Add("เล่นเกม online ชั่วโมงละ 25.50 บาท");
            cmbTypeService.SelectedIndex = 0;

            rdoMember.Checked = true;
            btnCal.Enabled = false;

        }

        private void cmbTypeService_SelectedIndexChanged(object sender, EventArgs e)
        {
           string Index_Values = cmbTypeService.SelectedIndex.ToString();
            if (Index_Values == "0")
            {
                lblShowTypeService.Text = "*";
            }
            else if (Index_Values == "1")
            {
                lblShowTypeService.Text = "* อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท";
            }
            else if (Index_Values == "2")
            {
                lblShowTypeService.Text = "* พิมพ์งาน ชั่วโมงละ 10.50 บาท";
            }
            else if (Index_Values == "3")
            {
                lblShowTypeService.Text = "* เล่นเกม offline ชั่วโมงละ 15.50 บาท";
            }
            else 
            {
                lblShowTypeService.Text = "* เล่นเกม online ชั่วโมงละ 25.50 บาท";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnNoSelect_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblShowIdCard_Click(object sender, EventArgs e)
        {

        }

        private void chkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirm.Checked)
            {
                btnCal.Enabled = true;
            }
            else
            {
                btnCal.Enabled = false;
            }
        }

        private void txtUseService_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUseService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "ยืนยันการออก", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // กระทำเมื่อผู้ใช้คลิก Yes
                Close(); // หรือใส่โค้ดที่ต้องการให้โปรแกรมปิดที่นี่
            }
            else if (result == DialogResult.No)
            {
                // กระทำเมื่อผู้ใช้คลิก No
                // ไม่ต้องทำอะไรเพื่อให้โปรแกรมยังคงทำงาน
            }
        }
    }
}
