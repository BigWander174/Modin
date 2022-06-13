using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modin.Model
{
    [Table("MedicineInPharmacy")]
    public class MedicineInPharmacy
    {
        [Key] public int Id { get; set; }
        public int PharmacyId { get; set; }
        public int MedicineId { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
    }
}
