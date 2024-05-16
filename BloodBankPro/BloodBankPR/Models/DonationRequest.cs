using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BloodBankPR.Models
{
    public partial class DonationRequest
    {
        public DonationRequest()
        {
         
        }

        public int DonatRequestionId { get; set; }
        
        
           
        public int UserId { get; set; }      
        public bool IsApproved { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
        public virtual Book BookName { get; set; }

    }
}
