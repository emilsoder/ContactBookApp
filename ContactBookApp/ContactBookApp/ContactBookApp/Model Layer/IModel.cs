using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApp.Model_Layer
{
    public interface IModel
    {
        object SearchRecords(string commandtext);
        object QueryResult();
        void AddRecord(string _firstName, string _lastName, string _phoneNumber, string _email, string _birthday, string _city, string _street, string _postalCode);
        void EditRecord(int _contactID, string _firstName, string _lastName, string _phoneNumber, string _email, string _birthday, string _city, string _street, string _postalCode);
        void DeleteRecord(int _contactID);
    }
}
