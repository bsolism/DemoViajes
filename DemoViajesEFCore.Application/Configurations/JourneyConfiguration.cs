
namespace DemoViajesEFCore.Application.Configurations
{
    internal class JourneyConfiguration : IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Distance).HasPrecision(8, 2);
        }
    }
}
