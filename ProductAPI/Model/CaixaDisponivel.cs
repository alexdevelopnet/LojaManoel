namespace ProductAPI.Model
{
    public class CaixaDisponivel
    {
        public string CaixaId { get; set; }   
        public int DimensoesId { get; set; }   
        public Dimensoes Dimensoes { get; set; }   
    }

}
