using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;

namespace Fiap08.Web.MVC.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        private FutebolContext _context;

        //Construtor
        public TimeRepository(FutebolContext context)
        {
            _context = context;
        }

        public void Alterar(Time time)
        {
            _context.Entry(time).State = EntityState.Modified;
        }

        public Time Buscar(int codigo)
        {
            return _context.Times.Find(codigo);
        }

        public IList<Time> BuscarPor(Expression<Func<Time, bool>> filtro)
        {
            return _context.Times.Where(filtro).ToList();
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public IList<Time> Listar()
        {
            return _context.Times.ToList();
        }

        public void Remover(int codigo)
        {
            var time = Buscar(codigo);
            _context.Times.Remove(time);
        }
    }
}