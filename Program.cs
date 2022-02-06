using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookTable addressBookTable = new AddressBookTable();
            DataTable data = addressBookTable.CreateAddressBookDataTable();
            addressBookTable.DisplayContacts(data);
        }
    }
}
