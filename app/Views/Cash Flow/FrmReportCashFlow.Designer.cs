﻿namespace SystemGymControl
{
    partial class FrmReportCashFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDataBox = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxClosure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxExit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBalancePrevious = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataBank = new System.Windows.Forms.DataGridView();
            this.bankDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBankEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBankExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBankClosure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankEntry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankBalancePrevious = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBalanceBankWhithBox = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBank)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDataBox);
            this.groupBox1.Controls.Add(this.txtBoxClosure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBalanceCurrent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxExit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxEntry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxBalancePrevious);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, -25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa";
            // 
            // dgvDataBox
            // 
            this.dgvDataBox.AllowUserToAddRows = false;
            this.dgvDataBox.AllowUserToDeleteRows = false;
            this.dgvDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBox.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataBox.ColumnHeadersHeight = 35;
            this.dgvDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.description,
            this.valueEntry,
            this.ValueExit});
            this.dgvDataBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataBox.EnableHeadersVisualStyles = false;
            this.dgvDataBox.Location = new System.Drawing.Point(29, 109);
            this.dgvDataBox.MultiSelect = false;
            this.dgvDataBox.Name = "dgvDataBox";
            this.dgvDataBox.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvDataBox.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataBox.Size = new System.Drawing.Size(684, 145);
            this.dgvDataBox.TabIndex = 19;
            this.dgvDataBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBox_CellClick);
            this.dgvDataBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBox_CellDoubleClick);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 52;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Descrição";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 91;
            // 
            // valueEntry
            // 
            this.valueEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueEntry.HeaderText = "Valor de Entrada";
            this.valueEntry.Name = "valueEntry";
            this.valueEntry.ReadOnly = true;
            this.valueEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueEntry.Width = 143;
            // 
            // ValueExit
            // 
            this.ValueExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValueExit.HeaderText = "Valor da Saída";
            this.ValueExit.Name = "ValueExit";
            this.ValueExit.ReadOnly = true;
            this.ValueExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValueExit.Width = 124;
            // 
            // txtBoxClosure
            // 
            this.txtBoxClosure.Location = new System.Drawing.Point(581, 66);
            this.txtBoxClosure.Name = "txtBoxClosure";
            this.txtBoxClosure.ReadOnly = true;
            this.txtBoxClosure.Size = new System.Drawing.Size(132, 29);
            this.txtBoxClosure.TabIndex = 9;
            this.txtBoxClosure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(577, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fechamento";
            // 
            // txtBalanceCurrent
            // 
            this.txtBalanceCurrent.Location = new System.Drawing.Point(443, 66);
            this.txtBalanceCurrent.Name = "txtBalanceCurrent";
            this.txtBalanceCurrent.ReadOnly = true;
            this.txtBalanceCurrent.Size = new System.Drawing.Size(132, 29);
            this.txtBalanceCurrent.TabIndex = 7;
            this.txtBalanceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(439, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo atual";
            // 
            // txtBoxExit
            // 
            this.txtBoxExit.Location = new System.Drawing.Point(305, 66);
            this.txtBoxExit.Name = "txtBoxExit";
            this.txtBoxExit.ReadOnly = true;
            this.txtBoxExit.Size = new System.Drawing.Size(132, 29);
            this.txtBoxExit.TabIndex = 5;
            this.txtBoxExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(305, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saída";
            // 
            // txtBoxEntry
            // 
            this.txtBoxEntry.Location = new System.Drawing.Point(167, 66);
            this.txtBoxEntry.Name = "txtBoxEntry";
            this.txtBoxEntry.ReadOnly = true;
            this.txtBoxEntry.Size = new System.Drawing.Size(132, 29);
            this.txtBoxEntry.TabIndex = 3;
            this.txtBoxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // txtBoxBalancePrevious
            // 
            this.txtBoxBalancePrevious.Location = new System.Drawing.Point(29, 66);
            this.txtBoxBalancePrevious.Name = "txtBoxBalancePrevious";
            this.txtBoxBalancePrevious.ReadOnly = true;
            this.txtBoxBalancePrevious.Size = new System.Drawing.Size(132, 29);
            this.txtBoxBalancePrevious.TabIndex = 1;
            this.txtBoxBalancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo anterior";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDataBank);
            this.groupBox2.Controls.Add(this.txtBankClosure);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBankBalanceCurrent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBankEntry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBankBalancePrevious);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(24, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 284);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banco";
            // 
            // dgvDataBank
            // 
            this.dgvDataBank.AllowUserToAddRows = false;
            this.dgvDataBank.AllowUserToDeleteRows = false;
            this.dgvDataBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBank.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataBank.ColumnHeadersHeight = 35;
            this.dgvDataBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankDateEntry,
            this.bankDescription,
            this.valueBankEntry,
            this.valueBankExit});
            this.dgvDataBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataBank.EnableHeadersVisualStyles = false;
            this.dgvDataBank.Location = new System.Drawing.Point(29, 110);
            this.dgvDataBank.MultiSelect = false;
            this.dgvDataBank.Name = "dgvDataBank";
            this.dgvDataBank.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBank.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvDataBank.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataBank.Size = new System.Drawing.Size(684, 168);
            this.dgvDataBank.TabIndex = 20;
            this.dgvDataBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBank_CellClick);
            this.dgvDataBank.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBank_CellDoubleClick);
            // 
            // bankDateEntry
            // 
            this.bankDateEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bankDateEntry.HeaderText = "Data";
            this.bankDateEntry.Name = "bankDateEntry";
            this.bankDateEntry.ReadOnly = true;
            this.bankDateEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bankDateEntry.Width = 52;
            // 
            // bankDescription
            // 
            this.bankDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bankDescription.HeaderText = "Descrição";
            this.bankDescription.Name = "bankDescription";
            this.bankDescription.ReadOnly = true;
            this.bankDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bankDescription.Width = 91;
            // 
            // valueBankEntry
            // 
            this.valueBankEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueBankEntry.HeaderText = "Valor da Entrada";
            this.valueBankEntry.Name = "valueBankEntry";
            this.valueBankEntry.ReadOnly = true;
            this.valueBankEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueBankEntry.Width = 143;
            // 
            // valueBankExit
            // 
            this.valueBankExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueBankExit.HeaderText = "Valor da Saída";
            this.valueBankExit.Name = "valueBankExit";
            this.valueBankExit.ReadOnly = true;
            this.valueBankExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueBankExit.Width = 124;
            // 
            // txtBankClosure
            // 
            this.txtBankClosure.Location = new System.Drawing.Point(443, 65);
            this.txtBankClosure.Name = "txtBankClosure";
            this.txtBankClosure.ReadOnly = true;
            this.txtBankClosure.Size = new System.Drawing.Size(132, 29);
            this.txtBankClosure.TabIndex = 9;
            this.txtBankClosure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(439, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fechamento";
            // 
            // txtBankBalanceCurrent
            // 
            this.txtBankBalanceCurrent.Location = new System.Drawing.Point(305, 65);
            this.txtBankBalanceCurrent.Name = "txtBankBalanceCurrent";
            this.txtBankBalanceCurrent.ReadOnly = true;
            this.txtBankBalanceCurrent.Size = new System.Drawing.Size(132, 29);
            this.txtBankBalanceCurrent.TabIndex = 7;
            this.txtBankBalanceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(301, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo atual";
            // 
            // txtBankEntry
            // 
            this.txtBankEntry.Location = new System.Drawing.Point(167, 65);
            this.txtBankEntry.Name = "txtBankEntry";
            this.txtBankEntry.ReadOnly = true;
            this.txtBankEntry.Size = new System.Drawing.Size(132, 29);
            this.txtBankEntry.TabIndex = 3;
            this.txtBankEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(163, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Entrada";
            // 
            // txtBankBalancePrevious
            // 
            this.txtBankBalancePrevious.Location = new System.Drawing.Point(29, 65);
            this.txtBankBalancePrevious.Name = "txtBankBalancePrevious";
            this.txtBankBalancePrevious.ReadOnly = true;
            this.txtBankBalancePrevious.Size = new System.Drawing.Size(132, 29);
            this.txtBankBalancePrevious.TabIndex = 1;
            this.txtBankBalancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Saldo anterior";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Disponibilidade do dia (Caixa + banco): ";
            // 
            // lblBalanceBankWhithBox
            // 
            this.lblBalanceBankWhithBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalanceBankWhithBox.AutoSize = true;
            this.lblBalanceBankWhithBox.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblBalanceBankWhithBox.Location = new System.Drawing.Point(361, 539);
            this.lblBalanceBankWhithBox.Name = "lblBalanceBankWhithBox";
            this.lblBalanceBankWhithBox.Size = new System.Drawing.Size(0, 22);
            this.lblBalanceBankWhithBox.TabIndex = 29;
            // 
            // FrmReportCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(797, 572);
            this.Controls.Add(this.lblBalanceBankWhithBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportCashFlow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxBalancePrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxClosure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalanceCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDataBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDataBank;
        private System.Windows.Forms.TextBox txtBankClosure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankBalanceCurrent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankEntry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankBalancePrevious;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBankEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBankExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBalanceBankWhithBox;
    }
}