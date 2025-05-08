using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_back_end.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil")]
        public Perfil Perfil { get; set; }


    }
    public enum Perfil
    {
        Admin,
        User
    }
}