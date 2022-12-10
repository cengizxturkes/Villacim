using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property : Entity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int MeterSquare { get; set; }
        public int BedRoom { get; set; }
        public int BathRoom { get; set; }
        
    }
}
