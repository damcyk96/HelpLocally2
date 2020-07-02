using System.Collections.Generic;

namespace HelpLocally.Domain
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual OfferType OfferType { get; set; }
        public int OfferTypeId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public virtual IEnumerable<Voucher> Vouchers { get; set; }
    }
}