using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxPractice.Models.Entity
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ad")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Soyad")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Müəssisə")]
        [StringLength(100)]
        public string Organisation { get; set; }

        [Required]
        [DisplayName("Nömrə")]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string Phone { get; set; }

        [DisplayName("Elektron poçt")]
        public string Email { get; set; }
    }
}