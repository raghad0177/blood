using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BloodBankPR.Models
{
    public partial class Book
    {
        public Book()
        {
                     
            DonationRequest = new HashSet<DonationRequest>();
            User = new HashSet<User>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Qnt { get; set; }

        public virtual ICollection<DonationRequest> DonationRequest { get; set; }
        public virtual ICollection<User> User { get; set; }

        public static implicit operator Book(string v)
        {
            throw new NotImplementedException();
        }
    }
}
