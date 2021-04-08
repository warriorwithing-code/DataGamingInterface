using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gender
    {
        private int Id { get; set; }
        private string Type { get; set; }
        public string Subtype { get; set; }

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

        public string getType()
        {
            return Type;
        }
        public void setType(string type)
        {
            Type = type;
        }
    }
}
