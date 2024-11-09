using System.Drawing;

namespace PetShop.Models
{
    public class Empregados
    {
        public int empregadoId { get; set; }

        public string nomeEmpregado { get; set; }
        public string funcao { get; set; }

        public DateOnly dataAdmissao { get; set; }

    }
}
