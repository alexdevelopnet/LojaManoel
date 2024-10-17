namespace ProductAPI.Model
{
    public class Caixa
    {
        public string CaixaId { get; set; }
        public List<string> Produtos { get; set; }
        public string Observacao { get; set; }
    }
}
