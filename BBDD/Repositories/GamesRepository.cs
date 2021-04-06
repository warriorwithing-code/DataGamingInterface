using BBDD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Repositories
{
    class GamesRepository : IRepository
    {
        public void add(string name, string info)
        {
            using (DataGamingInterfaceDataBaseEntities db =new DataGamingInterfaceDataBaseEntities())
            {
                Games game = new Games();
                game.Name = name;
                game.Info = info;

                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public void add()
        {
            throw new NotImplementedException();
        }

        public void add_Gender()
        {
            Gender gender = new Gender();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void load_Game()
        {

        }

        public void load_Games()
        {

        }
    }
}
