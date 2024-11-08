using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(55)]
        public DateTime date { get; set; }
        [Required]
        public string contact { get; set; }

    }
}
