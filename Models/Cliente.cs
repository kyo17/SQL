using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente
    {
        public Cliente()
        {
        }
        [Key]
        public Guid idCliente { get; set; }
        [Required(ErrorMessage = "Este campo es requerido"), MaxLength(40)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido"), MaxLength(40), EmailAddress]
        public string email { get; set; }
    }
}
