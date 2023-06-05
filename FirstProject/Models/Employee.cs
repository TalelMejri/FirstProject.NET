using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
    public class Employee
    {

        [Required]
        public string Name { get; set; }

        public string Prenom { get; set; }
        public bool isActive { get; set;}

        public DateTime birthday { get; set; }

        public string JobTitel { get;set; }
        public string Email { get; set; }
    }
}
