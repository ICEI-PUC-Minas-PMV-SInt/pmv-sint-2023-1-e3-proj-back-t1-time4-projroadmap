using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interview.Models
{

    [Table("Score")]
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public double Pontos { get; set; }
        public int  IdQuiz { get; set; }
        public int IdUsuario { get; set; }

    }
}
