using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;

namespace TCC.ApplicationCore.Interfaces.Services
{
    public interface IProprietarioService
    {
        Proprietario Adicionar(Proprietario entity);

        void Atualizar(Proprietario entity);

        IEnumerable<Proprietario> ObterTodos();

        Proprietario ObterPorId(int id);

        IEnumerable<Proprietario> Buscar(Expression<Func<Proprietario, bool>> predicado);

        void Remover(Proprietario entity);
    }
}
