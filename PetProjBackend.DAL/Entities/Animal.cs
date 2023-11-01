using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjBackend.DAL.Entities
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int AgeInMonths { get; set; }
        public Owner? Owner { get; set; }
        public List<Procedure>? Procedures { get; set; }
        public enum AnimalKind
        {
            Parrot,
            Dog,
            Cat,
            Hamster,
            Lizard,
            Rabbit,
            Mouse
        }
    }
}
