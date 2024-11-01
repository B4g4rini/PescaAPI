using System.ComponentModel.DataAnnotations;

namespace PescaAPI.Models
{
    public class Venda
    {
        [Key]
        public Guid VendaId { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}
