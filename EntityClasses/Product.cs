using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecureJWT.EntityClasses
{
    [Table("Product", Schema = "dbo")]
    public partial class Product
    {
        public int ProductId { get; set; }

        public required string ProductName { get; set; }

        public DateTime? IntroductionDate { get; set; }

        public decimal? Price { get; set; }

        public required string Url { get; set; }

        public int? CategoryId { get; set; }
    }
}
