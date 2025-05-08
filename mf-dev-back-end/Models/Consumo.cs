using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mf_dev_back_end.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="É obrigatorio informara descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "É obrigatorio informar o valor")]
        public Decimal Valor { get; set; }

        [Required(ErrorMessage = "É obrigatorio informar a quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "É obrigatorio informar o veiculo")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }


        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
    }
}
