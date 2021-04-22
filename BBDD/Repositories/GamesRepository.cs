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
                gameSave.Id = game.getId();
                gameSave.Name = game.getName();
                gameSave.Info = game.getInfo();
                gameSave.GenderId = game.getGenderId();

                db.Games.Add(gameSave);
                db.SaveChanges();
            }
        }

        public void delete(Game game)
        {
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                Games gameDeleted = new Games();
                gameDeleted = db.Games.Where(b => b.Id == game.Id).ToList().First();
                db.Games.Remove(gameDeleted);
            }
        }

        public List<Domain.Entities.Game> GetGamesList()
        {
            List<Domain.Entities.Game> listGames = new List<Domain.Entities.Game>();
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                listGames = (from d in db.Games select new Domain.Entities.Game { Id = d.Id, Name = d.Name, GenderId = d.GenderId, Info= d.Info}).ToList();
            }
            return listGames;
        }


        public void EditGame(Game game)
        {
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                Games gameModified = new Games();
                gameModified = db.Games.Where(b => b.Id == game.Id).First();
                if (gameModified != null)
                {
                    gameModified.Info = game.Info;
                    db.SaveChanges();
                }
            }
        }
    }
}
