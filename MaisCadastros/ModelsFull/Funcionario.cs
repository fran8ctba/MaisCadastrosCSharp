namespace ModelsFull
{
    public class Funcionario
    {
        public long FuncionarioId { get; set; }

        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Endereco { get; set; }

        public long Telefone { get; set; }

        public string Email { get; set; }

        public long CPF { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(1, MinimumLength = 1)]
        [System.ComponentModel.DefaultValue("F")]
        public string Gerente { get; set; }

        public long? LojaId { get; set; }
        public Loja Loja { get; set; }
    }
}