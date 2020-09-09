using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Insira o formato correto")]
        [Required(ErrorMessage = "O campo Data de lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLacamento { get; set; }
        
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }
        
        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        [Column(TypeName = "decima(18,2)")]
        public decimal Valor { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
