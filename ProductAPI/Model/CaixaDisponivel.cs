namespace ProductAPI.Model
{
    public class CaixaDisponivel
    {
       // public int Id { get; set; }
        public string CaixaId { get; set; }   
        public int DimensaoId { get; set; }   
        public Dimensao Dimensao { get; set; }   
    }

}
