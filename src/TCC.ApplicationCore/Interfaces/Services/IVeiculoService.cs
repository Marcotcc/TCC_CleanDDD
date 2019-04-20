using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;

namespace TCC.ApplicationCore.Interfaces.Services
{
    public interface IVeiculoService
    {
        Veiculo Adicionar(Veiculo entity);

        void Atualizar(Veiculo entity);

        IEnumerable<Veiculo> ObterTodos();

        Veiculo ObterPorId(int id);

        IEnumerable<Veiculo> Buscar(Expression<Func<Veiculo, bool>> predicado);

        void Remover(Veiculo entity);
    }
}
