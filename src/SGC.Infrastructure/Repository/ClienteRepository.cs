using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;
using System.Linq;

namespace SGC.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public Cliente ObterPorProfissao(int clienteId)
        {
            return 
                Buscar(__cliente => __cliente.ProfissoesClientes
                .Any(__profissaoCliente => __cliente.ClienteId == clienteId))
                .FirstOrDefault();
        }
    }
}
