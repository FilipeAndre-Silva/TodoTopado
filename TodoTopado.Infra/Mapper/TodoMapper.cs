using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoTopado.Domain.Entities;

namespace TodoTopado.Infra.Mapper
{
    public class TodoMapper : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todo");
        
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.Status)
                .IsRequired();

            builder.Property(p => p.IsActive)
                .IsRequired();

            builder.Property(p => p.DeadLine)
                .IsRequired();

            builder.Property(p => p.CreationDate)
                .IsRequired();

            builder.Property(p => p.ChangeDate)
                .IsRequired();
        }
    }
}