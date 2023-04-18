using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interview.Models
{
    
    public class Usuario
    {
        
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        user
    }

}
        
