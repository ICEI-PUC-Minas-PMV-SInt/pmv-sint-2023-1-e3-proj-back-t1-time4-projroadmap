using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace interview.Models
{
    [Table("Usuarios")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatorio")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [DefaultValue(Perfil.user)]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        user
    }

}
        
