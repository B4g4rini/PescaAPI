using System.ComponentModel.DataAnnotations;

namespace PescaAPI.Models
{
    public class Produto
    {
        [Key]
        internal int produtosId;

        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public Guid QuantidadeEstoque { get; set; }
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
