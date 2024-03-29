﻿namespace SystemGymControl
{
    partial class FrmOptionsSave
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
            this.pnStudent = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.pcStudent = new System.Windows.Forms.PictureBox();
            this.pnPackage = new System.Windows.Forms.Panel();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnSavePackage = new System.Windows.Forms.Button();
            this.pcPackage = new System.Windows.Forms.PictureBox();
            this.pnUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.pcUser = new System.Windows.Forms.PictureBox();
            this.pnStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).BeginInit();
            this.pnPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPackage)).BeginInit();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStudent
            // 
            this.pnStudent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnStudent.Controls.Add(this.lblStudent);
            this.pnStudent.Controls.Add(this.btnSaveStudent);
            this.pnStudent.Controls.Add(this.pcStudent);
            this.pnStudent.Location = new System.Drawing.Point(31, 157);
            this.pnStudent.Name = "pnStudent";
            this.pnStudent.Size = new System.Drawing.Size(230, 245);
            this.pnStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudent.AutoSize = true;
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblStudent.Location = new System.Drawing.Point(88, 100);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(54, 22);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Aluno";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStudent.FlatAppearance.BorderSize = 0;
            this.btnSaveStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSaveStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudent.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.ForeColor = System.Drawing.Color.White;
            this.btnSaveStudent.Location = new System.Drawing.Point(9, 159);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(210, 42);
            this.btnSaveStudent.TabIndex = 1;
            this.btnSaveStudent.Text = "Ir para a tela";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // pcStudent
            // 
            this.pcStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcStudent.Image = global::SystemGymControl.Properties.Resources.icons8_client_management_64px_1;
            this.pcStudent.Location = new System.Drawing.Point(81, 28);
            this.pcStudent.Name = "pcStudent";
            this.pcStudent.Size = new System.Drawing.Size(64, 64);
            this.pcStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcStudent.TabIndex = 0;
            this.pcStudent.TabStop = false;
            // 
            // pnPackage
            // 
            this.pnPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPackage.Controls.Add(this.lblPackage);
            this.pnPackage.Controls.Add(this.btnSavePackage);
            this.pnPackage.Controls.Add(this.pcPackage);
            this.pnPackage.Location = new System.Drawing.Point(295, 157);
            this.pnPackage.Name = "pnPackage";
            this.pnPackage.Size = new System.Drawing.Size(230, 245);
            this.pnPackage.TabIndex = 2;
            // 
            // lblPackage
            // 
            this.lblPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPackage.AutoSize = true;
            this.lblPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblPackage.Location = new System.Drawing.Point(82, 100);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(62, 22);
            this.lblPackage.TabIndex = 3;
            this.lblPackage.Text = "Pacote";
            // 
            // btnSavePackage
            // 
            this.btnSavePackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSavePackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePackage.FlatAppearance.BorderSize = 0;
            this.btnSavePackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSavePackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSavePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePackage.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePackage.ForeColor = System.Drawing.Color.White;
            this.btnSavePackage.Location = new System.Drawing.Point(9, 159);
            this.btnSavePackage.Name = "btnSavePackage";
            this.btnSavePackage.Size = new System.Drawing.Size(210, 42);
            this.btnSavePackage.TabIndex = 2;
            this.btnSavePackage.Text = "Ir para a tela";
            this.btnSavePackage.UseVisualStyleBackColor = false;
            this.btnSavePackage.Click += new System.EventHandler(this.btnSavePackage_Click);
            // 
            // pcPackage
            // 
            this.pcPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcPackage.Image = global::SystemGymControl.Properties.Resources.icons8_handle_with_care_64px_1;
            this.pcPackage.Location = new System.Drawing.Point(81, 28);
            this.pcPackage.Name = "pcPackage";
            this.pcPackage.Size = new System.Drawing.Size(64, 64);
            this.pcPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPackage.TabIndex = 1;
            this.pcPackage.TabStop = false;
            // 
            // pnUser
            // 
            this.pnUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnUser.Controls.Add(this.lblUser);
            this.pnUser.Controls.Add(this.btnSaveUser);
            this.pnUser.Controls.Add(this.pcUser);
            this.pnUser.Location = new System.Drawing.Point(556, 157);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(230, 245);
            this.pnUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(74, 100);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 22);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(9, 159);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(201, 42);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "Ir para a tela";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pcUser
            // 
            this.pcUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcUser.Image = global::SystemGymControl.Properties.Resources.icons8_user_64px;
            this.pcUser.Location = new System.Drawing.Point(77, 28);
            this.pcUser.Name = "pcUser";
            this.pcUser.Size = new System.Drawing.Size(64, 64);
            this.pcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcUser.TabIndex = 1;
            this.pcUser.TabStop = false;
            // 
            // FrmOptionsSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 570);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.pnPackage);
            this.Controls.Add(this.pnStudent);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOptionsSave";
            this.Text = "FrmOptionsSave";
            this.pnStudent.ResumeLayout(false);
            this.pnStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).EndInit();
            this.pnPackage.ResumeLayout(false);
            this.pnPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPackage)).EndInit();
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnStudent;
        private System.Windows.Forms.PictureBox pcStudent;
        private System.Windows.Forms.Panel pnPackage;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnSavePackage;
        private System.Windows.Forms.PictureBox pcPackage;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.PictureBox pcUser;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblUser;
    }
}