namespace AspNetMvcEF6ContactManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AspNetMvcEF6ContactManager.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<PostalAddress> PostalAddresses { get; set; }
    }

    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public virtual List<PhoneNumber> PhoneNumbers { get; set; }
        public virtual List<Email> Emails { get; set; }
        public virtual List<PostalAddress> PostalAddresses { get; set; }
    }

    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public virtual Contact Contact { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
    }

    public class Email
    {
        public int EmailId { get; set; }
        public virtual Contact Contact { get; set; }
        public string Description { get; set; }
        public string EmailAddress { get; set; }
    }

    public class PostalAddress
    {
        public int PostalAddressId { get; set; }
        public virtual Contact Contact { get; set; }
        public string Description { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string ZipOrPostalCode { get; set; }
        public string Country { get; set; }
    }
}
