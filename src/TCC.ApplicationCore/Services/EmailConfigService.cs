using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.ApplicationCore.Interfaces.Services;

namespace TCC.ApplicationCore.Services
{
    public class EmailConfigService : IEmailConfigService
    {
        private readonly IEmailConfigRepository _emailConfigRepository;

        public EmailConfigService(IEmailConfigRepository emailConfigRepository)
        {
            _emailConfigRepository = emailConfigRepository;
        }

        public EmailConfig Adicionar(EmailConfig entity)
        {
            return _emailConfigRepository.Adicionar(entity);
        }

        public void Atualizar(EmailConfig entity)
        {
            _emailConfigRepository.Atualizar(entity);
        }

        public IEnumerable<EmailConfig> Buscar(Expression<Func<EmailConfig, bool>> predicado)
        {
            return _emailConfigRepository.Buscar(predicado);
        }

        public EmailConfig ObterPorId(int id)
        {
            return _emailConfigRepository.ObterPorId(id);
        }

        public IEnumerable<EmailConfig> ObterTodos()
        {
            return _emailConfigRepository.ObterTodos();
        }

        public void Remover(EmailConfig entity)
        {
            _emailConfigRepository.Remover(entity);
        }
    }
}
