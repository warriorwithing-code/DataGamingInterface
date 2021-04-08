using BBDD.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Repositories
{
    public class GamesRepository : IRepository
    {
        public void add(Game game)
        {
            using (DataGamingInterfaceDataBaseEntities db =new DataGamingInterfaceDataBaseEntities())
            {
                Games gameSave = new Games();
                gameSave.Name = game.getName();
                gameSave.Info = game.getInfo();

                db.Games.Add(gameSave);
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
