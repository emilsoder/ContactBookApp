using System;
using ContactBookApp.Model_Layer;
using System.Windows.Forms;

namespace ContactBookApp.View_Layer
{
    public partial class NewContactView : Form
    {
        private readonly Model model;
        private readonly IMainView mainView;
         
        public NewContactView(Model _model, IMainView _mainView, int _dialogType, int _selectedContactID)
        {
            InitializeComponent();
            model = _model;
            mainView = _mainView;
            DialogType = _dialogType;
            SelectedContactID = _selectedContactID;
        }
        
        #region Properties for passing values
        private int DialogType;
        private int SelectedContactID;
        #endregion

        #region On form opening
        private void NewContactView_Load(object sender, EventArgs e)
        {                
            //DialogType 1 = Add new record
            if (DialogType == 1)
            {
                AddContactView();
            }
            //DialogType 2 = Edit existing record
            else if (DialogType == 2)
            {
                EditContactView();
            }
        }
        #endregion

        #region TextBox Properties
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
        #endregion

        #region Methods for User Interface according to DialogType Value
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
        #endregion

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                #region DialogType 1 = Add new record
                if (DialogType == 1)
                {
                    //Call AddRecord method in Model
                    model.AddRecord(
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtPhoneNumber.Text,
                        txtEmail.Text,
                        txtBirthday.Text,
                        txtCity.Text,
                        txtStreet.Text,
                        txtPostalCode.Text
                        );
                }
                #endregion

                #region DialogType 2 = Edit existing record
                else if (DialogType == 2)
                {               
                    //Call EditRecord method in Model
                    model.EditRecord(
                        SelectedContactID,
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtPhoneNumber.Text,
                        txtEmail.Text,
                        txtBirthday.Text,
                        txtCity.Text,
                        txtStreet.Text,
                        txtPostalCode.Text
                        );
                }
                #endregion

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        #region On form closing
        private void NewContactView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainView.GridViewDataSource = model.QueryResult();
            mainView.SelectCurrentRow(selectedRowIndex);
        }
        #endregion
    }
}
