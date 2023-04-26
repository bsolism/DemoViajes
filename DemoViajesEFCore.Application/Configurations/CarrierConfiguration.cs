namespace DemoViajesEFCore.Application.Configurations
{
    internal class CarrierConfiguration : IEntityTypeConfiguration<Carrier>
    {
        public void Configure(EntityTypeBuilder<Carrier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PricePerKM).HasPrecision(8, 2);
        }
    }
}
