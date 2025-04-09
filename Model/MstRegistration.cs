using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseRepository.Models
{
    public class MstRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationId { get; set; }
        public int UserTypeId { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Email { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? Phone { get; set; }

        [Column(TypeName = "varchar(120)")]
        public string? Address { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string? Message { get; set; }
    }
}
