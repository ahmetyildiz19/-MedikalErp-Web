using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Configuration.Stocks.Products
{
    public class ProductEntryConfig : IEntityTypeConfiguration<ProductEntry>
    {
        public void Configure(EntityTypeBuilder<ProductEntry> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            //builder.Property(s => s.CompanyId).IsRequired();
            //builder.Property(s => s.ProductId).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(350);
            builder.Property(s => s.InvoiceNumber).HasMaxLength(150);
            builder.Property(s => s.LotSerial).HasMaxLength(150);
            builder.Property(s => s.Barcode).IsRequired().HasMaxLength(100);
         
            builder.Property<DateTime>(s => s.CreatedOn).HasColumnType("date");
            builder.Property<DateTime>(s => s.ModifiedOn).HasColumnType("date");
            builder.Property<DateTime>(s => s.EntryDate).HasColumnType("date");
            builder.Property(s => s.ModifiedUser).HasMaxLength(50);
            builder.ToTable("tblProductEntries");
        }
    }
}
