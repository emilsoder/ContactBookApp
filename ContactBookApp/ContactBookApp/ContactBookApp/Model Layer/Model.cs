using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using ContactBookApp.Data_Layer;

namespace ContactBookApp.Model_Layer
{
    public class Model : IModel
    {
        private ContactsDBContext dbContext;

        public object QueryResult()
        {
            using (dbContext = new ContactsDBContext())
            {
                var contactQuery = from contacts in dbContext.Contacts
                                   select contacts;

                return contactQuery.ToList();
            }
        }        

        public object SearchRecords(string commandtext)
        {
            using (dbContext = new ContactsDBContext())
            {
                return dbContext.Database.SqlQuery<Contacts>("[dbo].[SearchRecordsProcedure] @UserInput = {0} ", commandtext).ToList();
            }
        }

        public void AddRecord(string _firstName, string _lastName, string _phoneNumber, string _email, string _birthday, string _city, string _street, string _postalCode)
        {
            using (dbContext = new ContactsDBContext())
            {
                Contacts contact = new Contacts();

                contact.FirstName = _firstName;
                contact.LastName = _lastName;
                contact.PhoneNumber = _phoneNumber;
                contact.Email = _email;
                contact.Birthday = _birthday;
                contact.City = _city;
                contact.Street = _street;
                contact.PostalCode = _postalCode;

                dbContext.Contacts.Add(contact);
                dbContext.SaveChanges();
            }
        }

        public void EditRecord(int _contactID, string _firstName, string _lastName, string _phoneNumber, string _email, string _birthday, string _city, string _street, string _postalCode)
        {
            using (dbContext = new ContactsDBContext())
            {
                Contacts contact = dbContext.Contacts.Find(_contactID);

                contact.FirstName = _firstName;
                contact.LastName = _lastName;
                contact.PhoneNumber = _phoneNumber;
                contact.Email = _email;
                contact.Birthday = _birthday;
                contact.City = _city;
                contact.Street = _street;
                contact.PostalCode = _postalCode;
                dbContext.SaveChanges();
            }
        }

        public void DeleteRecord(int _contactID)
        {
            using (dbContext = new ContactsDBContext())
            {
                Contacts contact = dbContext.Contacts.Find(_contactID);
                dbContext.Contacts.Remove(contact);                             
                dbContext.SaveChanges();
            }
        }
    }
}