namespace PetShop.Models
{
    public class Servicos
    {
        public int servicoId { get; set; }
        public string tipoServico { get; set; }
        public int preco { get; set; }
        public DateOnly data {  get; set; }


    }
}
