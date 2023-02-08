using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinal.Models
{
    public class RegistoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail não válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira o Endereço")]
        public string Endereco { get; set; }
    }
}
