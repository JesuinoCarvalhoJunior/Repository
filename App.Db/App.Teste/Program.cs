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
            //Teste AutoCommit
            //Processo Add
            using (Repository<Pessoa> RepPessoa = new RepositoryPessoa())
            {
                //Add
                //Pessoa p1 = new Pessoa();
                //p1.Nome = "Aluno 1";
                //RepPessoa.Add(p1);

                //AddList
                //Pessoa p2 = new Pessoa();
                //p2.Nome = "Aluno 2";
                //Pessoa p3 = new Pessoa();
                //p3.Nome = "Aluno 3";
                //IList<Pessoa> ps = new List<Pessoa>();
                //ps.Add(p2);
                //ps.Add(p3);
                //RepPessoa.Add(ps);

                //Edit
                //Pessoa p1e = RepPessoa.Find(13);
                //if (p1e != null)
                //{
                //    p1e.Nome = "Aluno 1 - Modo Edição";
                //    RepPessoa.Edit(p1e);
                //}
                //EditList
                //Pessoa p2e = RepPessoa.Find(14);                
                //Pessoa p3e = RepPessoa.Find(15);
                //IList<Pessoa> pse = new List<Pessoa>();
                //if (p2e != null)
                //{
                //    p2e.Nome = "Aluno 2 - Modo Edição";
                //    pse.Add(p2e);
                //}
                //if (p3e != null)
                //{
                //    p3e.Nome = "Aluno 3 - Modo Edição";
                //    pse.Add(p3e);
                //}
                //RepPessoa.Edit(pse);

                //Delete
                //Pessoa p1x = RepPessoa.Find(13);
                //if (p1x != null)
                //{                    
                //    RepPessoa.Delete(p1x);
                //}
                ////DeleteList
                //Pessoa p2x = RepPessoa.Find(14);
                //Pessoa p3x = RepPessoa.Find(15);
                //IList<Pessoa> psx = new List<Pessoa>();
                //if (p2x != null)
                //{                 
                //    psx.Add(p2x);
                //}
                //if (p3x != null)
                //{                    
                //    psx.Add(p3x);
                //}
                //RepPessoa.Delete(psx);

                //Insert
                //Pessoa pins1 = new Pessoa();
                //pins1.Nome = "Insert 1";
                //RepPessoa.Insert(pins1);
                //RepPessoa.Save();

                //Pessoa pins2 = new Pessoa();
                //pins2.Nome = "Insert 2";
                //Pessoa pins3 = new Pessoa();
                //pins3.Nome = "Insert 3";
                //RepPessoa.Insert(new List<Pessoa>()
                //{
                //    pins2, pins3
                //});
                //RepPessoa.Save();

                //Update
                //Pessoa pup1 = RepPessoa.Find(16);
                //if (pup1 != null)
                //{
                //    pup1.Nome = "Insert 1.1, modo Update";
                //}
                //RepPessoa.Edit(pup1);
                //RepPessoa.Save();

                //UpdateList
                //Pessoa pup2 = RepPessoa.Find(17);
                //if (pup2 != null)
                //{
                //    pup2.Nome = "Insert 2, modo Update";
                //}
                //Pessoa pup3 = RepPessoa.Find(18);
                //if (pup3 != null)
                //{
                //    pup3.Nome = "Insert 3, modo Update";
                //}
                //RepPessoa.Update(new List<Pessoa>()
                //{
                //    pup2, pup3
                //});
                //RepPessoa.Save();
                
                //Remove
                //Pessoa pur1 = RepPessoa.Find(16);
                //if (pur1 != null)
                //{
                //    RepPessoa.Remove(pur1);
                //}                
                //RepPessoa.Save();

                //RemoveList
                //Pessoa pur2 = RepPessoa.Find(17);               
                //Pessoa pur3 = RepPessoa.Find(18);                
                //RepPessoa.Remove(new List<Pessoa>()
                //{
                //    pur2, pur3
                //});
                //RepPessoa.Save();


                //Add With Telephone
                //Pessoa pt1 = new Pessoa();
                //pt1.Nome = "Pessoa Telefone 1";
                //pt1.Telefone.Add(new Telefone() { Ddd = "999", Numero = "0999-9999" });
                //pt1.Telefone.Add(new Telefone() { Ddd = "888", Numero = "0888-8888" });                
                //RepPessoa.Add(pt1);


                //Pessoa pt11 = new Pessoa();
                //pt11.Nome = "Pessoa Telefone 11";
                //pt11.Telefone.Add(new Telefone() { Ddd = "777", Numero = "0777-7777" });
                //pt11.Telefone.Add(new Telefone() { Ddd = "666", Numero = "0666-6666" });
                //RepPessoa.Insert(pt11);
                //RepPessoa.Save();

                //Update With Telephone
                //Pessoa pu1 = RepPessoa.Find(21);
                //IList<Telefone> tu1 = pu1.Telefone.ToList<Telefone>();
                //pu1.Nome = "Pessoa Telefone 1, Update 1";
                //for (int i = 0; i < tu1.Count(); i++)
                //{
                //    tu1[i].Ddd = "000";
                //    tu1[i].Numero = string.Format("{0}000-0001", i);
                //}
                ////RepPessoa.Update(pu1);
                //RepPessoa.Save();

                //Remove With Telephone
                //Pessoa pr1 = RepPessoa.Find(22);
                //IList<Telefone> tr1 = pr1.Telefone.ToList<Telefone>();
                //Repository<Telefone> RepTelefone = new RepositoryTelefone(RepPessoa.Contexto);
                //RepTelefone.Remove(tr1);
                //RepTelefone.Save();

                //RepPessoa.Remove(pr1);
                //RepPessoa.Save();
            }
        }
    }
}
