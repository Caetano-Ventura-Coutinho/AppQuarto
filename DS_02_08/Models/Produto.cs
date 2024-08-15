using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace DS_02_08.Models
    
{
    
    public class Produto
    {
        [Display(Name = "Código")]
        [Range(1, 200, ErrorMessage = "O id deve ser entre 1 e 200")]
        public int? Codigo { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomeProduto { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição é obrigatória")]

        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço é obrigatório")]
        [RegularExpression("^\\d+(,\\d{2})", ErrorMessage = "Preço inválido")]
        public decimal Preco { get; set;}

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "A marca é obrigatório")]
        public string Marca { get; set; }

    }
}
