#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ContactBookApp.View_Layer
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.panelAddContact = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnDeleteContact = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEditContact = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAddContact = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem2 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem3 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem4 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem5 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem6 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem7 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem8 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem9 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelAddContact)).BeginInit();
            this.panelAddContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddContact
            // 
            this.panelAddContact.BackColor = System.Drawing.Color.Silver;
            this.panelAddContact.BorderColor = System.Drawing.Color.Gray;
            this.panelAddContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelAddContact.Controls.Add(this.gradientPanel1);
            this.panelAddContact.Controls.Add(this.lblSearch);
            this.panelAddContact.Controls.Add(this.txtSearch);
            this.panelAddContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddContact.Location = new System.Drawing.Point(0, 0);
            this.panelAddContact.Name = "panelAddContact";
            this.panelAddContact.Size = new System.Drawing.Size(904, 42);
            this.panelAddContact.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(102, 21);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search contact...";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(192, 23);
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Location = new System.Drawing.Point(12, 8);
            this.txtSearch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.txtSearch.Size = new System.Drawing.Size(192, 23);
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnDeleteContact.BeforeTouchSize = new System.Drawing.Size(83, 23);
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteContact.IsBackStageButton = false;
            this.btnDeleteContact.Location = new System.Drawing.Point(188, 8);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.btnDeleteContact.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.btnDeleteContact.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteContact.TabIndex = 2;
            this.btnDeleteContact.Text = "Delete selected";
            this.btnDeleteContact.UseVisualStyle = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnEditContact.BeforeTouchSize = new System.Drawing.Size(83, 23);
            this.btnEditContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditContact.IsBackStageButton = false;
            this.btnEditContact.Location = new System.Drawing.Point(99, 8);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.btnEditContact.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.btnEditContact.Size = new System.Drawing.Size(83, 23);
            this.btnEditContact.TabIndex = 1;
            this.btnEditContact.Text = "Edit selected";
            this.btnEditContact.UseVisualStyle = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btnAddContact.BeforeTouchSize = new System.Drawing.Size(83, 23);
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddContact.IsBackStageButton = false;
            this.btnAddContact.Location = new System.Drawing.Point(10, 8);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.btnAddContact.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.btnAddContact.Size = new System.Drawing.Size(83, 23);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "New contact";
            this.btnAddContact.UseVisualStyle = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // toolstripitem1
            // 
            this.toolstripitem1.Name = "toolstripitem1";
            this.toolstripitem1.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem1.Text = "First name";
            // 
            // toolstripitem2
            // 
            this.toolstripitem2.Name = "toolstripitem2";
            this.toolstripitem2.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem2.Text = "Last name";
            // 
            // toolstripitem3
            // 
            this.toolstripitem3.Name = "toolstripitem3";
            this.toolstripitem3.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem3.Text = "toolstripitem3";
            // 
            // toolstripitem4
            // 
            this.toolstripitem4.Name = "toolstripitem4";
            this.toolstripitem4.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem4.Text = "toolstripitem4";
            // 
            // toolstripitem5
            // 
            this.toolstripitem5.Name = "toolstripitem5";
            this.toolstripitem5.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem5.Text = "toolstripitem5";
            // 
            // toolstripitem6
            // 
            this.toolstripitem6.Name = "toolstripitem6";
            this.toolstripitem6.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem6.Text = "toolstripitem6";
            // 
            // toolstripitem7
            // 
            this.toolstripitem7.Name = "toolstripitem7";
            this.toolstripitem7.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem7.Text = "toolstripitem7";
            // 
            // toolstripitem8
            // 
            this.toolstripitem8.Name = "toolstripitem8";
            this.toolstripitem8.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem8.Text = "toolstripitem8";
            // 
            // toolstripitem9
            // 
            this.toolstripitem9.Name = "toolstripitem9";
            this.toolstripitem9.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem9.Text = "toolstripitem9";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.Location = new System.Drawing.Point(0, 42);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 26;
            this.dgvContacts.RowTemplate.Height = 46;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(904, 475);
            this.dgvContacts.TabIndex = 1;
            this.dgvContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_RowEnter);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.btnAddContact);
            this.gradientPanel1.Controls.Add(this.btnEditContact);
            this.gradientPanel1.Controls.Add(this.btnDeleteContact);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel1.Location = new System.Drawing.Point(621, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(283, 42);
            this.gradientPanel1.TabIndex = 2;
            // 
            // MainView
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderThickness = 0;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.SlateGray;
            this.CaptionBarHeight = 10;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(904, 517);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.panelAddContact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "Contact records";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelAddContact)).EndInit();
            this.panelAddContact.ResumeLayout(false);
            this.panelAddContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel panelAddContact;
        private Syncfusion.Windows.Forms.ButtonAdv btnAddContact;
        private Syncfusion.Windows.Forms.ButtonAdv btnDeleteContact;
        private Syncfusion.Windows.Forms.ButtonAdv btnEditContact;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem1;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem2;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem3;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem4;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem5;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem6;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem7;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem8;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem9;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.DataGridView dgvContacts;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
    }
}