using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Interfaces
{
    public interface IRepository
    {
        void add(Game game);
        void delete(Game game);
    }
}
