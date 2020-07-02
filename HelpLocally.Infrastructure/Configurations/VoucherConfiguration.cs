using HelpLocally.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpLocally.Infrastructure.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Vouchers");

            builder.Property(x => x.StartAmount).IsRequired();
            builder.Property(x => x.ExpirationDate).IsRequired();
            
            builder.HasOne(x => x.Offer)
                .WithMany(x=>x.Vouchers);
        }
    }
}