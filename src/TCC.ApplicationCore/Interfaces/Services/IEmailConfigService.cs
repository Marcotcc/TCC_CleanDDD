using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;

namespace TCC.ApplicationCore.Interfaces.Services
{
    public interface IEmailConfigService 
    {
        EmailConfig Adicionar(EmailConfig entity);

        void Atualizar(EmailConfig entity);

        IEnumerable<EmailConfig> ObterTodos();

        EmailConfig ObterPorId(int id);

        IEnumerable<EmailConfig> Buscar(Expression<Func<EmailConfig, bool>> predicado);

        void Remover(EmailConfig entity);
    }
}
