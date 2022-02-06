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

            addressBookTable.DisplayContacts(dataTable);
            addressBookTable.DeleteContact(dataTable);
        }
    }
}
