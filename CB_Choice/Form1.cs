using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        string[] SList = new string[]
        {
            "짜장면", "짬뽕", "라조기", "탕수육"
        };
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < this.SList.Length; i++)
            {
                this.cbList.Items.Add(this.SList[i]);
            }
            this.OrgStr = this.lblResult.Text;
            if(this.cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.cbList.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CheckInput();
                e.Handled = true;
            }
        }

        private void CheckInput() {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 선택하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
        }
    }
}
