using System;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(55)]
        [Required]
        public string Name { get; set; }


        [Required]
        public DateTime Date { get; set; } 

        [Required]
        [StringLength(55)]
        public string Contact { get; set; } 
    }
}
