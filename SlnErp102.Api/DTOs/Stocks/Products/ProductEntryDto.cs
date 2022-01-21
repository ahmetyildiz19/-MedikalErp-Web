using SlnErp102.Core.Models.Stocks.Products;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SlnErp102.Api.DTOs.Stocks.Products
{
    public class ProductEntryDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductId { get; set; }
        public string LotSerial { get; set; }
        public int Quantity { get; set; }
        public int EntryTypeId { get; set; }

        [DisplayName("Product Code"),Required]
        public string ProductProductCode { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        //public virtual Product Product { get; set; } //deneme
    }

    public class ProductEntryDistinctDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime EntryDate { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
