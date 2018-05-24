namespace ModelsFull
{
    public class Venda
    {
        public long VendaId { get; set; }

        public string DescricaoVenda { get; set; }

        public int QuantidadeProduto { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal ValorUnitario { get; set; }

        public string FormaPagamento { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DataVenda { get; set; }

        public long ProdutoId { get; set; }
        public long ClienteId { get; set; }
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
    }
}