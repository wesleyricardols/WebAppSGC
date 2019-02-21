using SGC.ApplicationCore.Entity;
using System.Linq;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
                return;

            Cliente[] clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "76664173735"
                },
                new Cliente
                {
                    Nome = "Beltrano da Silva",
                    CPF = "54589486377"
                }
            };

            context.AddRange(clientes);

            Contato[] contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "999999999",
                    Email = "emailcontato1@teste.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "888888888",
                    Email = "emailcontato2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
