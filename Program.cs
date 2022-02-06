using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookTable addressBookTable = new AddressBookTable();

            DataTable dataTable = addressBookTable.CreateAddressBookDataTable();

            addressBookTable.EditContact(dataTable);

            addressBookTable.DeleteContact(dataTable);
            addressBookTable.RetrieveContactByCityOrState(dataTable);
            addressBookTable.CheckSizeByCityOrState(dataTable);

            addressBookTable.DisplayContacts(dataTable);
        }
    }
}
