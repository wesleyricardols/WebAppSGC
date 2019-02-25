using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;

namespace SGC.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoService;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoService = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            return _contatoService.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            _contatoService.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoService.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoService.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoService.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoService.Remover(entity);
        }
    }
}
