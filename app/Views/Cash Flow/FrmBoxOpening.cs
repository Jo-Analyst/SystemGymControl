﻿using Bussiness;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmBoxOpening : Form
    {
        public FrmBoxOpening()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void txtValueInitial_Leave(object sender, EventArgs e)
        {
            txtValueInitial.Text = FormatTextBox.FormatValueDecimal(txtValueInitial.Text);
        }

        private void txtValueInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtValueInitial, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                CashFlow cashFlow = new CashFlow();

                if (string.IsNullOrWhiteSpace(txtValueInitial.Text))
                    cashFlow._cashValueTotal = 0.00M;
                else
                    cashFlow._cashValueTotal = decimal.Parse(txtValueInitial.Text);

                cashFlow._closingDate = "";
                cashFlow._closingTime = "";
                cashFlow._openingTime = DateTime.Now.ToLongTimeString();
                cashFlow._outputValueTotal = 0.00M;
                cashFlow._openingDate = DateTime.Now.ToShortDateString();

                IcomingCashFlow icomingCashFlow = new IcomingCashFlow()
                {
                    _valueCard = 0.00M,
                    _entryDate = DateTime.Now.ToShortDateString(),
                    _entryTime = DateTime.Now.ToLongTimeString(),
                    _descriptionIcoming = "Valor inicial",
                    _valueMoney = cashFlow._cashValueTotal
                };

                cashFlow.Save(icomingCashFlow);

                this.Visible = false;
                new FrmGymControl(cashFlow._id).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmBoxOpening_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}