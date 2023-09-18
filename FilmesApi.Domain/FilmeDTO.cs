using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Domain

{
    public class FilmeDTO
    {
        [Required(ErrorMessage = "O título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório!")]        
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração é obrigatório!")]
        public double Duracao { get; set; }

        public FilmeDTO()
        {
                
        }
    }

}
