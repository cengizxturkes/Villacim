﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Owner : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}