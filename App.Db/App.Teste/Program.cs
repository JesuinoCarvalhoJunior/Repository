using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Db.Persistencia;
using App.Db.Abstract;
using App.Db.Interfaces;
using App.Db.Repositories;
namespace App.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Repository<Pessoa> reppessoa = new RepositoryPessoa())
            //{
            //    //reppessoa.Insert(new Pessoa() { Nome = "Insert" });
            //    //reppessoa.Save();
            //    //IList<Telefone> Telefones = reppessoa.Find(6).Telefone.ToList<Telefone>();
            //    //using (Repository<Telefone> reptelefone = new RepositoryTelefone(reppessoa.Contexto))
            //    //{
            //    //    reptelefone.DeleteAll(Telefones);
            //    //}
            //    //Pessoa rp6 = reppessoa.Find(6);
            //    //rp6.Nome = "Fúlvio C. C. Dias";
                

            //    //Pessoa rp7 = reppessoa.Find(7);
            //    //rp7.Nome = "Hugo L. C. Dias";

            //    Pessoa rp8 = new Pessoa();
            //    rp8.Codigo = 8;
            //    rp8.Nome = "Cezario C. Dias";

            //    reppessoa.Edit(rp8);
            //}
            //System.Console.ReadKey();

            using (AppEntities ctx = new AppEntities())
            {
                Repository<Pessoa> reppessoa = new RepositoryPessoa(ctx);
                Repository<Telefone> reptelefone = new RepositoryTelefone(ctx);

                //Pessoa p1 = new Pessoa();
                //p1.Nome = "Fúlvio Cezar Canducci Dias";

                //Telefone t1 = new Telefone();
                //t1.Pessoa = p1;
                //t1.CodigoPessoa = p1.Codigo;
                //t1.Ddd = "018";
                //t1.Numero = "3269-5189";

                ////reppessoa.Add(p1);
                //reptelefone.Add(t1);

                //IList<Telefone> tels = reppessoa.Find(12).Telefone.ToList();
                //reptelefone.DeleteAll(tels);

                //Pessoa p1 = reppessoa.Find(11);
                //reptelefone.DeleteAll(reppessoa.Find(11).Telefone.ToList<Telefone>());
                reppessoa.Delete(11);
                
            }
        }
    }
}
