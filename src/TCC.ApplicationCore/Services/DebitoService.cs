using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.ApplicationCore.Interfaces.Services;

namespace TCC.ApplicationCore.Services
{
    public class DebitoService : IDebitoService
    {
        private readonly IDebitoRepository _debitoRepository;

        public DebitoService(IDebitoRepository debitoRepository)
        {
            _debitoRepository = debitoRepository;
        }

        public Debito Adicionar(Debito entity)
        {
            return _debitoRepository.Adicionar(entity);
        }

        public void Atualizar(Debito entity)
        {
            _debitoRepository.Atualizar(entity);
        }

        public IEnumerable<Debito> Buscar(Expression<Func<Debito, bool>> predicado)
        {
            return _debitoRepository.Buscar(predicado);
        }

        public Debito ObterPorId(int id)
        {
            return _debitoRepository.ObterPorId(id);
        }

        public IEnumerable<Debito> ObterTodos()
        {
            return _debitoRepository.ObterTodos();
        }

        public void Remover(Debito entity)
        {
            _debitoRepository.Remover(entity);
        }
    }
}
