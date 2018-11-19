using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DinhNghiaDL
{
    public class Customers
    {
        private string _customerID;
        private string _companyName;
        private string _contactName;
        private string _contactTitle;
        private string _address;
        private string _city;
        private string _region;
        private string _postalCode;
        private string _country;
        private string _phone;
        private string _fax;

        public string CustomerID { get => _customerID; set => _customerID = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string ContactName { get => _contactName; set => _contactName = value; }
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Region { get => _region; set => _region = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string Country { get => _country; set => _country = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public Customers() { }
        public Customers(string customerID,string companyName,string contactName,string contactTitle,string address,string city,string region,string postalCode,string country,string phone,string fax)
        {
            this.CustomerID = customerID;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.ContactTitle = contactTitle;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country =  country;
            this.Phone =  phone;
            this.Fax = fax;
        }
    }
}
