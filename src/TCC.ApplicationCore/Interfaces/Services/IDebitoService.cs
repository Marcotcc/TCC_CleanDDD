using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;

namespace TCC.ApplicationCore.Interfaces.Services
{
    public interface IDebitoService
    {
        Debito Adicionar(Debito entity);

        void Atualizar(Debito entity);

        IEnumerable<Debito> ObterTodos();

        Debito ObterPorId(int id);

        IEnumerable<Debito> Buscar(Expression<Func<Debito, bool>> predicado);

        void Remover(Debito entity);
    }
}
