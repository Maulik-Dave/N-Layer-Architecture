using DotNetCoreApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreApi.Data.Configurations
{
    public class EmployeeMasterConfig : IEntityTypeConfiguration<EmployeeMasterModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeMasterModel> builder)
        {
            builder.ToTable("EmployeeMaster");
            builder.HasKey(e => e.EmployeeMasterID);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
        }
    }
}