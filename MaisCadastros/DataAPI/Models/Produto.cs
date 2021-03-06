﻿namespace Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }

        public string Name { get; set; }

        public string DescricaoProduto { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime? DataValidade { get; set; }

        public string MarcaId { get; set; }
        public Marca Marca { get; set; }

        public string SetorId { get; set; }
        public Setor Setor { get; set; }

        public long? FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public long? LojaId { get; set; }
        public Loja Loja { get; set; }
        
        public virtual System.Collections.Generic.ICollection<Venda> Vendas { get; set; }
    }
}