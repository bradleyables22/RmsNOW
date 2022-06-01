using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsNOW.Data
{
    public class Unit
    {
        [Key]
        public int UnitID { get; set; }
        [Required]
        [ForeignKey("CampId")]
        public string? CampID { get; set; }
        public string? UnitName { get; set; }
        public string? StructureType { get; set; }
        public int UnitMaxCapacity { get; set; }
    }
}
