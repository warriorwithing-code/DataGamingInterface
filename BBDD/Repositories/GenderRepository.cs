using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Repositories
{
    public class GenderRepository
    {

        public List<string> Get_List()
        {
            List<Domain.Entities.Gender> tablaGender = new List<Domain.Entities.Gender>();
            List<string> resultGenderType = new List<string>();
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                tablaGender = (from d in db.Gender select new Domain.Entities.Gender { Type = d.Type }).ToList();
            }
            foreach (var b in tablaGender)
            {
                resultGenderType.Add(b.Type);
            }
                return resultGenderType;
        }
    }
}
