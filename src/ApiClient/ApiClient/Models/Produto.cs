namespace ApiClient.Models
{
    public class Produto
    {
        public Produto()
        {

        }
        public Produto(string nome, string descricao, decimal valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
