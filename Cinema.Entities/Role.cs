using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    public class Role : IEntityBase
    {
        public int ID{ get; set; }

        public string  Name { get; set; }
    }
}
