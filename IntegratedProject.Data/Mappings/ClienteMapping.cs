using IntegratedProject.Business.Customer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntegratedProject.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);


            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
