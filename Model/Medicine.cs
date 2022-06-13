using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modin.Model
{
    [Table("Medicine")]
    public class Medicine
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Package { get; set; }
        public int Dosage { get; set; }
    }
}
