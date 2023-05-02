using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace interview.Models
{
    [Table("Temas")]
    public class Tema
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Titulo obrigatório!")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória!")]
        public string? Descricao { get; set; }
    }
}