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
            this.panelAddContact = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.panelAddContact.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddContact
            // 
            this.panelAddContact.BackColor = System.Drawing.Color.Silver;
            this.panelAddContact.Controls.Add(this.gradientPanel1);
            this.panelAddContact.Controls.Add(this.lblSearch);
            this.panelAddContact.Controls.Add(this.txtSearch);
            this.panelAddContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddContact.Location = new System.Drawing.Point(0, 0);
            this.panelAddContact.Name = "panelAddContact";
            this.panelAddContact.Size = new System.Drawing.Size(954, 42);
            this.panelAddContact.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.btnAddContact);
            this.gradientPanel1.Controls.Add(this.btnEditContact);
            this.gradientPanel1.Controls.Add(this.btnDeleteContact);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel1.Location = new System.Drawing.Point(671, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(283, 42);
            this.gradientPanel1.TabIndex = 2;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnAddContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddContact.Location = new System.Drawing.Point(10, 8);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(83, 23);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "New contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnEditContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditContact.Location = new System.Drawing.Point(99, 8);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(83, 23);
            this.btnEditContact.TabIndex = 1;
            this.btnEditContact.Text = "Edit selected";
            this.btnEditContact.UseVisualStyleBackColor = false;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnDeleteContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteContact.Location = new System.Drawing.Point(188, 8);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteContact.TabIndex = 2;
            this.btnDeleteContact.Text = "Delete selected";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(14, 9);
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
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Location = new System.Drawing.Point(12, 8);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.dgvContacts.Size = new System.Drawing.Size(954, 420);
            this.dgvContacts.TabIndex = 1;
            this.dgvContacts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_RowEnter);
            // 
            // MainView
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(954, 462);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.panelAddContact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "Contact records";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panelAddContact.ResumeLayout(false);
            this.panelAddContact.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel gradientPanel1;
    }
}