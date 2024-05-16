using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BloodBankPR.Models
{
    public partial class User
    {
        public User()
        {
           
           
            Login = new HashSet<Login>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }     
        public DateTime BirthDate { get; set; }
        public int? UserTypeId { get; set; }
        public string Address { get; set; }
        public double? Lataitude { get; set; }
        public double? Longatuide { get; set; }

        public virtual Book BloodType { get; set; }
        public virtual UserType UserType { get; set; }      
      
        public virtual ICollection<DonationRequest> DonationRequest { get; set; }
     
        public virtual ICollection<Login> Login { get; set; }
    }
}
