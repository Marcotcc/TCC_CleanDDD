using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.ApplicationCore.Interfaces.Services;

namespace TCC.ApplicationCore.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public Veiculo Adicionar(Veiculo entity)
        {
            return _veiculoRepository.Adicionar(entity);
        }

        public void Atualizar(Veiculo entity)
        {
            _veiculoRepository.Atualizar(entity);
        }

        public IEnumerable<Veiculo> Buscar(Expression<Func<Veiculo, bool>> predicado)
        {
            return _veiculoRepository.Buscar(predicado);
        }

        public Veiculo ObterPorId(int id)
        {
            return _veiculoRepository.ObterPorId(id);
        }

        public IEnumerable<Veiculo> ObterTodos()
        {
            return _veiculoRepository.ObterTodos();
        }

        public void Remover(Veiculo entity)
        {
            _veiculoRepository.Remover(entity);
        }
    }
}
