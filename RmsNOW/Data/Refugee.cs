using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsNOW.Data
{
    public class Refugee
    {
        [Key]
        public string? RefId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? RefPhoto { get; set; }
        public string? OriginCountry { get; set; }
        public string? OriginRegion { get; set; }
        public DateTime DateDOB { get; set; }
        public string? AgeGroup { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? PrimaryLang { get; set; }
        public string? SecondaryLang { get; set; }
        public string? Healthstatus { get; set; }
        public int AggressionLvl { get; set; }

        [Required]
        [ForeignKey("CampId")]
        public int CampID { get; set; }
        [Required]
        [ForeignKey("UnitId")]
        public int UnitID { get; set; }
    }
}
