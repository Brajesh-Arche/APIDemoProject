using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomainLayer
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_customerid");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id").HasColumnType("INT");
            builder.Property(x => x.ProductName).HasColumnName("ProductName").HasColumnType("NVARCHAR(100)").IsRequired();
            builder.Property(x => x.CustomerName).HasColumnName("CustomerName").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.CustomerLocation).HasColumnName("CustomerLocation").HasColumnType("NVARCHAR(100)").IsRequired();
            builder.Property(x => x.ProductName).HasColumnName("ProductName").HasColumnType("NVARCHAR(100)").IsRequired();
            builder.Property(x => x.PaymentType).HasColumnName("PaymentType").HasColumnType("NVARCHAR(100)").IsRequired();
        }
    }
}
