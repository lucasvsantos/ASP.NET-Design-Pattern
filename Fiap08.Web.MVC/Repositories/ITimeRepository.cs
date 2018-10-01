using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap08.Web.MVC.Repositories
{
    public interface ITimeRepository
    {
        Time Buscar(int codigo);
        void Remover(int codigo);
        IList<Time> Listar();
        void Alterar(Time time);
        void Cadastrar(Time time);
        IList<Time> BuscarPor(Expression<Func<Time, bool>> filtro);
    }
}
