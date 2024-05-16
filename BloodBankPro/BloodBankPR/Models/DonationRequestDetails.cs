namespace BloodBankPR.Models
{
    public class DonationRequestDetails
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DonationRequest DonationRequests { get; set; }
    }
}
