using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interview.Models
{
    [Table("Testes")]
    public class Teste
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
