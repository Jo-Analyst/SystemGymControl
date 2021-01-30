﻿using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportReceipt : Form
    {
        int idPlan;
        string modality, package;


        public FrmReportReceipt()
        {
            InitializeComponent();
        }

        public FrmReportReceipt(int idPayment, int idPlan = 0)
        {
            InitializeComponent();

            this.idPlan = idPlan;
            this.rvReceipt.LocalReport.SetParameters(ParametersReport.SetParametersReport(new Payment().GetDataPayments(idPayment)));
            this.rvReceipt.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (idPlan > 0)
                OpenForm.ShowForm(new FrmMonthlyPayment(idPlan, package, modality), this);
            else
                OpenForm.ShowForm(new FrmPlans(), this);
        }
    }
}
