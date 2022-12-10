using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Villa.Dtos
{
    public class CreatedVillaDto
    {
        public int Id { get; set; }
        public string VillaName { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public virtual Owner Owner { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Property Property { get; set; }
    }
}
