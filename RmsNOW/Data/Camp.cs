using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsNOW.Data
{
    public class Camp
    {
        [Key]
        public int CampId { get; set; }
        public string? CampName { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        public string? County { get; set; }
        [StringLength(5)]
        public string? Zip { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        [Required]
        [ForeignKey("Id")]
        public string? CampManager { get; set; }

    }
}
