using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappers
{
    public class ParticipantMapper : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.ToTable("Participant");
            builder.HasKey(m => m.ParticipantId);
            builder.Property(m => m.FirstName).HasColumnName("FirstName");
            builder.Property(m => m.LastName).HasColumnName("LastName");
            builder.Property(m => m.Age).HasColumnName("Age");
            builder.Property(m => m.Gender).HasColumnName("Gender");
            builder.Property(m => m.University).HasColumnName("University");
            builder.Property(m => m.Faculty).HasColumnName("Facullty");
            builder.Property(m => m.Course).HasColumnName("Course");
            builder.Property(m => m.Degree).HasColumnName("Degree");
            builder.Property(m => m.DepartmentId).HasColumnName("DepartmentId");
        }
    }
}
