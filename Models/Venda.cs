using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PescaAPI.Models
{
    public class Venda
    {
        [Key]
        public Guid VendaId { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("ProdutoId")]
        public Guid ProdutoId {  get; set; }
        public Produto Produto { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}
