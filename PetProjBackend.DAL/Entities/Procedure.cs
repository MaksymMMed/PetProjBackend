using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjBackend.DAL.Entities
{
    public class Procedure
    {
        public Guid Id { get; set; }
        public Animal? Animal { get; set; }
        public Doctor? Doctor { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Price { get; set; }
        public enum ProcedureType
        {
            Vaccination,
            Spaying,
            Dental_Cleaning,
            Worming,
            Check_up,
            Microchipping,
            Grooming,
            X_Ray,
            Surgery
        }
    }
}
