using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjBackend.DAL.Entities
{
    public class Owner : BaseUser
    {
        public string Email { get; set; }
        public List<Animal>? Animals { get; set; }
    }
}
