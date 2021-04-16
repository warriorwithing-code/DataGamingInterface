using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Repositories
{
    public class GenderRepository
    {

        public List<Domain.Entities.Gender> Get_List()
        {
            List<Domain.Entities.Gender> tablaGender = new List<Domain.Entities.Gender>();
            List<Domain.Entities.Gender> resultGenderType = new List<Domain.Entities.Gender>();
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                tablaGender = (from d in db.Gender select new Domain.Entities.Gender { Id= d.Id,Type = d.Type }).ToList();
            }
            foreach (var b in tablaGender)
            {
                resultGenderType.Add(b);
            }
                return resultGenderType;
        }

        public void add(Domain.Entities.Gender gender)
        {
            using (DataGamingInterfaceDataBaseEntities db = new DataGamingInterfaceDataBaseEntities())
            {
                Gender genderSave = new Gender();
                genderSave.Type = gender.Type;
                db.Gender.Add(genderSave);
                db.SaveChanges();
            }
        }
    }
}
