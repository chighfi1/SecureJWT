using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecureJWT.EntityClasses
{
    [Table("Category", Schema = "dbo")]
    public partial class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
