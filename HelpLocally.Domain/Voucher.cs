using System;

namespace HelpLocally.Domain
{
    public class Voucher
    {
        public int Id { get; set; }
        public Offer Offer { get; set; }
        public int OfferId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public decimal StartAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Voucher()
        {
        }

        public Voucher(Offer offer, int offerId, User user, int userId, decimal startAmount, decimal currentAmount, DateTime expirationDate)
        {
            Offer = offer;
            OfferId = offerId;
            User = user;
            UserId = userId;
            StartAmount = startAmount;
            CurrentAmount = currentAmount;
            ExpirationDate = expirationDate;
        }
    }
}