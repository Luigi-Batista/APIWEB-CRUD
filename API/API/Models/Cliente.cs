using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    
    public class Cliente
    {
        [Key]
        public int cod_cli { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string nome_cli { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string fantasia { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string documento { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string endereco { get; set; }


        public Cliente(string nome_cli, string fantasia, string documento, string endereco)
        {
            this.nome_cli = nome_cli;
            this.fantasia = fantasia;
            this.documento = documento;
            this.endereco = endereco;
        }
    }
}
