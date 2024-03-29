﻿
namespace SystemGymControl
{
    partial class FrmEffectPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEffectPayment));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaysOfDelay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuedate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValueInterest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValuePenalty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValuePlan = new System.Windows.Forms.TextBox();
            this.cbCalculateInaterastAndPenalty = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountReceivable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFormOfPayment = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValueWithDiscount = new System.Windows.Forms.TextBox();
            this.txtPaidOut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(770, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(363, 450);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(136, 40);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finalizar";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(665, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdStudent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 93);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Código";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdStudent.BackColor = System.Drawing.Color.White;
            this.txtIdStudent.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtIdStudent.Location = new System.Drawing.Point(91, 42);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.ReadOnly = true;
            this.txtIdStudent.Size = new System.Drawing.Size(100, 33);
            this.txtIdStudent.TabIndex = 4;
            this.txtIdStudent.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(197, 43);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(507, 33);
            this.txtName.TabIndex = 5;
            this.txtName.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbCalculateInaterastAndPenalty);
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 223);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDaysOfDelay);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPayDay);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDuedate);
            this.groupBox4.Location = new System.Drawing.Point(386, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 166);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Dias de atraso";
            // 
            // txtDaysOfDelay
            // 
            this.txtDaysOfDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaysOfDelay.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysOfDelay.Location = new System.Drawing.Point(146, 123);
            this.txtDaysOfDelay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDaysOfDelay.Name = "txtDaysOfDelay";
            this.txtDaysOfDelay.ReadOnly = true;
            this.txtDaysOfDelay.Size = new System.Drawing.Size(148, 33);
            this.txtDaysOfDelay.TabIndex = 12;
            this.txtDaysOfDelay.TabStop = false;
            this.txtDaysOfDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Data de Pag.";
            // 
            // txtPayDay
            // 
            this.txtPayDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayDay.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayDay.Location = new System.Drawing.Point(146, 81);
            this.txtPayDay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPayDay.Name = "txtPayDay";
            this.txtPayDay.ReadOnly = true;
            this.txtPayDay.Size = new System.Drawing.Size(148, 33);
            this.txtPayDay.TabIndex = 11;
            this.txtPayDay.TabStop = false;
            this.txtPayDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 60;
            this.label8.Text = "Data de Venc.";
            // 
            // txtDuedate
            // 
            this.txtDuedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuedate.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuedate.Location = new System.Drawing.Point(146, 38);
            this.txtDuedate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDuedate.Name = "txtDuedate";
            this.txtDuedate.ReadOnly = true;
            this.txtDuedate.Size = new System.Drawing.Size(148, 33);
            this.txtDuedate.TabIndex = 10;
            this.txtDuedate.TabStop = false;
            this.txtDuedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtValueInterest);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtValuePenalty);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtValuePlan);
            this.groupBox3.Location = new System.Drawing.Point(50, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 166);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Juros diários";
            // 
            // txtValueInterest
            // 
            this.txtValueInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueInterest.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueInterest.Location = new System.Drawing.Point(146, 123);
            this.txtValueInterest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValueInterest.Name = "txtValueInterest";
            this.txtValueInterest.ReadOnly = true;
            this.txtValueInterest.Size = new System.Drawing.Size(148, 33);
            this.txtValueInterest.TabIndex = 9;
            this.txtValueInterest.TabStop = false;
            this.txtValueInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Multa por atraso";
            // 
            // txtValuePenalty
            // 
            this.txtValuePenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValuePenalty.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuePenalty.Location = new System.Drawing.Point(146, 81);
            this.txtValuePenalty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValuePenalty.Name = "txtValuePenalty";
            this.txtValuePenalty.ReadOnly = true;
            this.txtValuePenalty.Size = new System.Drawing.Size(148, 33);
            this.txtValuePenalty.TabIndex = 8;
            this.txtValuePenalty.TabStop = false;
            this.txtValuePenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Valor do plano";
            // 
            // txtValuePlan
            // 
            this.txtValuePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValuePlan.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuePlan.Location = new System.Drawing.Point(146, 38);
            this.txtValuePlan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValuePlan.Name = "txtValuePlan";
            this.txtValuePlan.ReadOnly = true;
            this.txtValuePlan.Size = new System.Drawing.Size(148, 33);
            this.txtValuePlan.TabIndex = 7;
            this.txtValuePlan.TabStop = false;
            this.txtValuePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCalculateInaterastAndPenalty
            // 
            this.cbCalculateInaterastAndPenalty.AutoSize = true;
            this.cbCalculateInaterastAndPenalty.Checked = true;
            this.cbCalculateInaterastAndPenalty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCalculateInaterastAndPenalty.ForeColor = System.Drawing.Color.White;
            this.cbCalculateInaterastAndPenalty.Location = new System.Drawing.Point(80, 18);
            this.cbCalculateInaterastAndPenalty.Name = "cbCalculateInaterastAndPenalty";
            this.cbCalculateInaterastAndPenalty.Size = new System.Drawing.Size(202, 26);
            this.cbCalculateInaterastAndPenalty.TabIndex = 6;
            this.cbCalculateInaterastAndPenalty.Text = "Calcular multas e juros";
            this.cbCalculateInaterastAndPenalty.UseVisualStyleBackColor = true;
            this.cbCalculateInaterastAndPenalty.CheckedChanged += new System.EventHandler(this.cbCalculateInaterastAndPenalty_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 22);
            this.label9.TabIndex = 66;
            this.label9.Text = "Valor a Receber";
            // 
            // txtAmountReceivable
            // 
            this.txtAmountReceivable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountReceivable.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceivable.Location = new System.Drawing.Point(19, 391);
            this.txtAmountReceivable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAmountReceivable.Name = "txtAmountReceivable";
            this.txtAmountReceivable.ReadOnly = true;
            this.txtAmountReceivable.Size = new System.Drawing.Size(148, 33);
            this.txtAmountReceivable.TabIndex = 13;
            this.txtAmountReceivable.TabStop = false;
            this.txtAmountReceivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(638, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 77;
            this.label10.Text = "Troco - R$";
            // 
            // txtChange
            // 
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtChange.Location = new System.Drawing.Point(642, 391);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(148, 33);
            this.txtChange.TabIndex = 1;
            this.txtChange.TabStop = false;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(171, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 22);
            this.label12.TabIndex = 79;
            this.label12.Text = "Desconto - R$";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtDiscount.Location = new System.Drawing.Point(175, 390);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(148, 33);
            this.txtDiscount.TabIndex = 78;
            this.txtDiscount.Text = "0,00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 22);
            this.label13.TabIndex = 80;
            this.label13.Text = "Formas de Pagamento";
            // 
            // cbFormOfPayment
            // 
            this.cbFormOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormOfPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFormOfPayment.Font = new System.Drawing.Font("Open Sans", 14F);
            this.cbFormOfPayment.FormattingEnabled = true;
            this.cbFormOfPayment.Location = new System.Drawing.Point(19, 456);
            this.cbFormOfPayment.Name = "cbFormOfPayment";
            this.cbFormOfPayment.Size = new System.Drawing.Size(207, 34);
            this.cbFormOfPayment.Sorted = true;
            this.cbFormOfPayment.TabIndex = 81;
            this.cbFormOfPayment.SelectedIndexChanged += new System.EventHandler(this.cbFormOfPayment_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(483, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 22);
            this.label14.TabIndex = 85;
            this.label14.Text = "Valor c/ desconto";
            // 
            // txtValueWithDiscount
            // 
            this.txtValueWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueWithDiscount.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtValueWithDiscount.Location = new System.Drawing.Point(487, 391);
            this.txtValueWithDiscount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValueWithDiscount.Name = "txtValueWithDiscount";
            this.txtValueWithDiscount.ReadOnly = true;
            this.txtValueWithDiscount.Size = new System.Drawing.Size(148, 33);
            this.txtValueWithDiscount.TabIndex = 84;
            this.txtValueWithDiscount.TabStop = false;
            this.txtValueWithDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaidOut
            // 
            this.txtPaidOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidOut.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtPaidOut.Location = new System.Drawing.Point(331, 391);
            this.txtPaidOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPaidOut.Name = "txtPaidOut";
            this.txtPaidOut.Size = new System.Drawing.Size(148, 33);
            this.txtPaidOut.TabIndex = 0;
            this.txtPaidOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidOut_KeyPress);
            this.txtPaidOut.Leave += new System.EventHandler(this.txtPaidOut_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(327, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 22);
            this.label11.TabIndex = 73;
            this.label11.Text = "Valor Pago - R$";
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnGenerateReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReceipt.FlatAppearance.BorderSize = 0;
            this.btnGenerateReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnGenerateReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReceipt.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReceipt.Location = new System.Drawing.Point(505, 450);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(154, 40);
            this.btnGenerateReceipt.TabIndex = 86;
            this.btnGenerateReceipt.TabStop = false;
            this.btnGenerateReceipt.Text = "Gerar recibo";
            this.btnGenerateReceipt.UseVisualStyleBackColor = false;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // FrmEffectPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(803, 509);
            this.Controls.Add(this.btnGenerateReceipt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValueWithDiscount);
            this.Controls.Add(this.cbFormOfPayment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPaidOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAmountReceivable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmEffectPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento à vista";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEffectPayment_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCashInPayment_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaysOfDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDuedate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValueInterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValuePenalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValuePlan;
        private System.Windows.Forms.CheckBox cbCalculateInaterastAndPenalty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmountReceivable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFormOfPayment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValueWithDiscount;
        private System.Windows.Forms.TextBox txtPaidOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGenerateReceipt;
    }
}