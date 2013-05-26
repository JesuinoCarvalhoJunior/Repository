using App.Db.Abstract;
using App.Db.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Db.Repositories
{
    public sealed class RepositoryPessoa : Repository<Pessoa> 
    {
        public RepositoryPessoa() { }
        public RepositoryPessoa(AppEntities Contexto): base(Contexto) { }
    }
    public sealed class RepositoryTelefone : Repository<Telefone>
    {
        public RepositoryTelefone() { }
        public RepositoryTelefone(AppEntities Contexto) : base(Contexto) { }
    }
}
