using System.ComponentModel.DataAnnotations;

namespace CursoNET.FilmeContext.Model
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração é obrigatório!")]
        public double Duracao { get; set; }
    }
}
