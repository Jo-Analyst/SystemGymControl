﻿using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemGymControl
{
    public partial class FrmResponsiblesStudent : Form
    {
        public FrmResponsiblesStudent()
        {
            InitializeComponent();
        }

        public string name { get; set; }
        public string cpf { get; set; }
        public string kinship { get; set; }
        public string phone { get; set; }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leave;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider error = new ErrorProvider();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (!CPF.ValidateCPF(mkCPF.Text))
                {
                    MessageBox.Show("CPF inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mkCPF.Focus();
                    return;
                }

                name = txtName.Text.Trim();
                cpf = mkCPF.Text;
                kinship = cbKinship.Text;
                phone = mkPhone.Text;
                this.Close();
            }
        }

        private bool ValidateFields()
        {
            error.Clear();

            bool theFieldsHaveBeenValidated = false;

            var responsible = new ResponsibleStudent();
            responsible._name = txtName.Text.Trim();
            responsible._cpf = mkCPF.Text;
            responsible._kinship = cbKinship.Text;
            responsible._phone = mkPhone.Text;

            if (!string.IsNullOrEmpty(responsible.ValidateFields()))
            {
                if (responsible.ValidateFields() == "Campo Nome do responsável obrigatório!")
                {
                    MessageBox.Show("Campo 'Nome do responsável' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtName, "Campo 'Nome do responsável' obrigatório!");
                    txtName.Focus();
                }
                else if (responsible.ValidateFields() == "Campo CPF obrigatório!")
                {
                    MessageBox.Show("Campo 'CPF' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Campo 'CPF' obrigatório!");
                    mkCPF.Focus();
                } 
                else if (responsible.ValidateFields() == "Campo Grau de Parentesco obrigatório!")
                {
                    MessageBox.Show("Campo 'Grau de Parentesco' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(cbKinship, "Campo 'Grau de Parentesco' obrigatório!");
                    cbKinship.Focus();
                }
                else if (responsible.ValidateFields() == "Este CPF já está cadastrado!")
                {
                    MessageBox.Show("Este CPF já está cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Este CPF já está cadastrado!");
                    mkCPF.Focus();
                }
            }
            else
            {
                theFieldsHaveBeenValidated = true;
            }

            return theFieldsHaveBeenValidated;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmResponsiblesStudent_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
