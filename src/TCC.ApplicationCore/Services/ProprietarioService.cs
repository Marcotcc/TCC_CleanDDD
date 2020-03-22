using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.ApplicationCore.Interfaces.Services;

namespace TCC.ApplicationCore.Services
{
    public class ProprietarioService : IProprietarioService
    {
        private readonly IProprietarioRepository _proprietarioRepository;

        public ProprietarioService(IProprietarioRepository proprietarioRepository)
        {
            _proprietarioRepository = proprietarioRepository;
        }

        public Proprietario Adicionar(Proprietario entity)
        {
            return _proprietarioRepository.Adicionar(entity);
        }

        public void Atualizar(Proprietario entity)
        {
            _proprietarioRepository.Atualizar(entity);    
        }

        public IEnumerable<Proprietario> Buscar(Expression<Func<Proprietario, bool>> predicado)
        {
            return _proprietarioRepository.Buscar(predicado);
        }

        public Proprietario ObterPorId(int id)
        {
            return _proprietarioRepository.ObterPorId(id);
        }

        public IEnumerable<Proprietario> ObterTodos()
        {
            return _proprietarioRepository.ObterTodos();
        }

        public void Remover(Proprietario entity)
        {
            _proprietarioRepository.Remover(entity);
        }
    }
}
