using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ControleEstoque1
{
    public class Model
    {
        //produto
        public void SetProduto(DtoProduto p)
        {
            Context db = new Context();
            db.produto.Add(p);
            db.SaveChanges();
        }

        //usuario
        public void SetUsuario(DtoUsuario u)
        {
            Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
        }
        //produto
        public void EditProduto(DtoProduto prod)
        {
            Context db = new Context();
            DtoProduto p = db.produto.FirstOrDefault(produt => produt.Codprod == prod.Codprod);

            p.Codprod = prod.Codprod;
            p.CodigoBarras = prod.CodigoBarras;
            p.Nome = prod.Nome;
            p.Fabricante = prod.Fabricante;
            p.Validade = prod.Validade;

            db.SaveChanges();
        }
        //usuario
        public void EditUsuario(DtoUsuario u)
        {
            Context db = new Context();
            DtoUsuario e = db.usuario.FirstOrDefault(user => user.id == u.id);
            e.nome = u.nome;
            e.login = u.login;
            e.senha = u.senha;

            db.SaveChanges();
        }
        //produto
        public List<DtoProduto> ListProdutos()
            {
            Context db=new Context();
            List<DtoProduto> result1 = (from p in db.produto
                                        select new DtoProduto
                                        {
                                            Codprod = p.Codprod,
                                            CodigoBarras = p.CodigoBarras,
                                            Nome = p.Nome,
                                            Fabricante = p.Fabricante,
                                            Validade = p.Validade
                                        }).ToList();
            return new List<DtoProduto>(result1);

            }

      //usuario
        public List<DtoUsuario2> ListUsuarios()
        {
            Context db = new Context();
            List<DtoUsuario2> result = (from a in db.usuario
                                  select new DtoUsuario2
                                  {
                                      id = a.id,
                                      nome = a.nome
                                  }).ToList();

            return new List<DtoUsuario2>(result);


        }
        //produto
        public DtoProduto GetProdutoCodProd ( int Codprod)
        {
            Context db = new Context ();
            var result1 = (from p in db.produto
                           where p.Codprod == Codprod
                           select new DtoProduto
                           {
                               Codprod = p.Codprod,
                               CodigoBarras = p.CodigoBarras,
                               Nome = p.Nome,
                               Validade = p.Validade,
                               Fabricante = p.Fabricante
                           }).FirstOrDefault();
            var result2 = db.produto.Where(p => p.Codprod == Codprod).FirstOrDefault();
            return result1;
        }
        //usuario
        public DtoUsuario2 GetUsuarioId(int id)
        {
            Context db = new Context();
            var result = (from a in db.usuario
                             where a.id == id
                                   select new DtoUsuario2
                                   {
                                       id = a.id,
                                       nome = a.nome
                                   }).FirstOrDefault();

            var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

            return result;
        }
        //produto
        public void DeletarProduto( int Codprod)
        {
            Context db=new Context ();
            DtoProduto p = db.produto.FirstOrDefault(prod => prod.Codprod == Codprod);
            db.produto.Remove(p);
            db.SaveChanges();

        }

        //usuario
        public void DeletarUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }
    }
}
