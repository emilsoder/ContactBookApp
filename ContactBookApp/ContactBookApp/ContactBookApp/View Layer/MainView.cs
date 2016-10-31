using System;
using ContactBookApp.Model_Layer;
using ContactBookApp.Presenter_Layer;
using Syncfusion.Windows.Forms;
using System.Windows.Forms;

namespace ContactBookApp.View_Layer
{
    public partial class MainView : MetroForm, IMainView
    {
        private readonly Presenter presenter;
        private readonly Model model;
        public int selectedRow { get; set; }
        private int SelectedContactID { get; set; }

        public MainView(Model _model)
        {
            InitializeComponent();
            model = _model;
            presenter = new Presenter(this, _model);
        }

        #region IVIEW INTERFACE IMPLEMENTATION
        public object GridViewDataSource
        {
            get
            {
                return dgvContacts.DataSource;
            }

            set
            {
                dgvContacts.DataSource = value;
                dgvContacts.Columns[0].Visible = false;
                dgvContacts.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           
        }

        public string SearchText
        {
            get
            {
                return txtSearch.Text;
            }
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string phoneNumber { get; set; }
        public string city { get; set; }

        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            presenter.Search(SearchText);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            presenter.RequestData();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                lblSearch.Visible = true;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            NewContactView newContactView = new NewContactView(model, this, 1, 0);

            newContactView.ShowDialog();
        }

        public void SelectCurrentRow(int _selectedRowIndex)
        {
            dgvContacts.Rows[_selectedRowIndex].Selected = true;
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            try
            {
                NewContactView newContactView = new NewContactView(model, this, 2, SelectedContactID);
                presenter.EditView(newContactView, selectedRow, firstName, lastName,
                    birthday, phoneNumber, email, street, postalCode, city);

                newContactView.ShowDialog();
            }
            catch (Exception)
            {
                MessageBoxAdv.Show("You have to select a row to edit!", "Error", MessageBoxButtons.OK);
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void dgvContacts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                firstName = dgvContacts.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastName = dgvContacts.Rows[e.RowIndex].Cells[2].Value.ToString();
                birthday = dgvContacts.Rows[e.RowIndex].Cells[3].Value.ToString();
                phoneNumber = dgvContacts.Rows[e.RowIndex].Cells[4].Value.ToString();
                email = dgvContacts.Rows[e.RowIndex].Cells[5].Value.ToString();
                street = dgvContacts.Rows[e.RowIndex].Cells[6].Value.ToString();
                postalCode = dgvContacts.Rows[e.RowIndex].Cells[7].Value.ToString();
                city = dgvContacts.Rows[e.RowIndex].Cells[8].Value.ToString();
                SelectedContactID = int.Parse(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(ex.Message);
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete selected contact?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    presenter.DeleteRequest(SelectedContactID);
                }
            }
            else
            {
                MessageBox.Show("You have to select a contact to delete.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}