using ContactBookApp.Model_Layer;
using ContactBookApp.View_Layer;

namespace ContactBookApp.Presenter_Layer
{
    public class Presenter
    {
        private IMainView view;
        private IModel model;

        public Presenter(IMainView iView, Model iDataService)
        {
            view = iView;
            model = iDataService;
        }

        public void RequestData()
        {
            view.GridViewDataSource = model.QueryResult();
        }

        public void Search(string inputText)
        {
            view.GridViewDataSource = model.SearchRecords(inputText);
        }

        public void EditView(NewContactView _newContactView, int _selectedRowIndex, string _firstName, string _lastName, 
            string _birthday, string _phoneNumber, string _email, string _street, string _postalCode, string _city)
        {
            _newContactView.selectedRowIndex = _selectedRowIndex;

            _newContactView.firstName = _firstName;
            _newContactView.lastName = _lastName;
            _newContactView.phoneNumber = _phoneNumber;
            _newContactView.email = _email;
            _newContactView.birthday = _birthday;
            _newContactView.street = _street;
            _newContactView.postalCode = _postalCode;
            _newContactView.city = _city;
        }

        public void DeleteRequest(int contactID)
        {
            model.DeleteRecord(contactID);
            RequestData();
        }
    }
}