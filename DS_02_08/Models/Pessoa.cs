using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DS_02_08.Models

{
    public class Pessoa
    {

        [Display(Name = "Código")]
        [Range(1, 200, ErrorMessage = "O id deve ser entre 1 e 200")]
        public int? Codigo { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomePessoa { get; set; }

        [Display(Name = "Observação")]
        [Required(ErrorMessage = "A observação é obrigatória")]
        public string Obs { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
        
        [Display(Name = "Login")]
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "A senhas são diferentes")]
        [Required(ErrorMessage = "A confirmação é obrigatória")]
        public string ConfirmarSenha { get; set; }
    }
}
