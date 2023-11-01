using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjBackend.DAL.Entities
{
    public class Doctor: BaseUser
    {
        public List<Procedure>? Procedures { get; set; }
    }
}
