using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappers
{
    public class EventMapper : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");
            builder.HasKey(m => m.EventId);
            builder.Property(m => m.EventDate).HasColumnName("EventDate");
            builder.Property(m => m.EventTitle).HasColumnName("EventTitle");
        }
    }
}
