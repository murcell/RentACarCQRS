﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Transmission:Entity<Guid>
{
    public Transmission()
    {
        Models = new HashSet<Model>();
    }
    public Transmission(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }
    public virtual ICollection<Model> Models { get; set; }
    

}
