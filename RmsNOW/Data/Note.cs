using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsNOW.Data
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        public DateTime EntryDate { get; set; }
        public string? EnteredBy { get; set; }

        [StringLength(500)]
        public string? Message { get; set; }

        [ForeignKey("CampID")]
        public int RefId { get; set; }
        public Refugee? Refugee { get; set; }
    }
}
