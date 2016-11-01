using System;
using ContactBookApp.Model_Layer;
using System.Windows.Forms;

namespace ContactBookApp.View_Layer
{
    public partial class NewContactView : Form
    {
        private readonly Model model;
        private readonly IMainView mainView;
        private int DialogType;
        private int SelectedContactID;

        //_dialogType: 1 = add / 2 = edit
        public NewContactView(Model _model, IMainView _mainView, int _dialogType, int _selectedContactID)
        {
            InitializeComponent();
            model = _model;
            mainView = _mainView;
            DialogType = _dialogType;
            SelectedContactID = _selectedContactID;
        }

        public string birthday
        {
            set
            {
                txtBirthday.Text = value;
            }
        }
        public string city
        {
            set
            {
                txtCity.Text = value;
            }
        }
        public string phoneNumber
        {            
            set
            {
                txtPhoneNumber.Text = value;
            }
        }
        public string postalCode
        {
            set
            {
                txtPostalCode.Text = value;
            }
        }
        public string street
        {
            set
            {
                txtStreet.Text = value;
            }
        }
        public string email
        {
            set
            {
                txtEmail.Text = value;
            }
        }
        public string firstName
        {
            set
            {
                txtFirstName.Text = value;
            }
        }
        public string lastName
        {
            set
            {
                txtLastName.Text = value;
            }
        }
        public int selectedRowIndex
        {
            get;
            set;
        }

        private void AddContactView()
        {
            btnCommit.Text = "Add new contact";
            this.Text = "New contact";
        }

        private void EditContactView()
        {
            btnCommit.Text = "Save changes";
            this.Text = "Edit contact";
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogType == 1)
                {
                    model.AddRecord(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                        txtEmail.Text, txtBirthday.Text, txtCity.Text, txtStreet.Text, txtPostalCode.Text);
                }
                else if (DialogType == 2)
                {
                    model.EditRecord(SelectedContactID, txtFirstName.Text, txtLastName.Text,
                        txtPhoneNumber.Text, txtEmail.Text, txtBirthday.Text,
                        txtCity.Text, txtStreet.Text, txtPostalCode.Text);
                }
                this.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void NewContactView_Load(object sender, EventArgs e)
        {
            if (DialogType == 1)
            {
                AddContactView();
            }
            else if (DialogType == 2)
            {
                EditContactView();
            }
        }

        private void NewContactView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainView.GridViewDataSource = model.QueryResult();
            mainView.SelectCurrentRow(selectedRowIndex);
        }
    }
}
