using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BloodBankPR.Models
{
    public partial class Verification
    {
        public int VerificationCodeId { get; set; }
        public string Code { get; set; }
        public string UserEmail { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
