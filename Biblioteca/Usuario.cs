using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string NombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string Clave { get; set; }

        [Required]
        public Boolean Estado { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}