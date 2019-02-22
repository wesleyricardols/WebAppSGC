using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {

        }

        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string CBO { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
