using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modin.Model
{
    [Table("Pharmacy")]
    public class Pharmacy
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
    }
}
