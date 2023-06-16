using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace interview.Models
{
    [Table("Respostas")]
    public class Respostas
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Pergunta")]
        public int IdPergunta { get; set; }

        public string Description { get; set; }

        public Correct IsCorrect { get; set; }

        public enum Correct
        {
            True,
            False
        }

        //public bool VerifyAnswer()
        //{
        //    // Lógica para verificar a resposta
        //    // Retorne true ou false com base na verificação
        //    // Exemplo: 
        //    // if (algumaCondicao)
        //    // {
        //    //     return true;
        //    // }
        //    // else
        //    // {
        //    //     return false;
        //    // }
        //}
    }
}