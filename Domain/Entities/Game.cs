using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Game
    {
        public int Id;
        public string Name;
        public int GenderId;
        public string Info;

        #region Id
        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }
        #endregion

        #region Name
        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }
        #endregion

        #region GennderId
        public int getGenderId()
        {
            return GenderId;
        }

        public void setGenderId(int genderId)
        {
            GenderId = genderId;
        }
        #endregion

        #region Info
        public string getInfo()
        {
            return Info;
        }

        public void setInfo(string info)
        {
            Info = info;
        }
        #endregion

    }
}
