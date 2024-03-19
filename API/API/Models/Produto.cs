using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace API.Models
{
    
    public class Produto
    {
        [Key]
        public int cod_pro { get; set; }

        [StringLength(200, MinimumLength = 5)]
        public string? descricao { get; set; }

        [StringLength(13)]
        public string cod_barra { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal peso_liquido { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal peso_bruto { get; set; }

        public Produto(string? descricao, string cod_barra, decimal peso_bruto, decimal peso_liquido)
        {
            this.descricao = descricao;
            this.cod_barra = cod_barra;
            this.peso_bruto = peso_bruto;
            this.peso_liquido = peso_liquido;
        }
    }
}
