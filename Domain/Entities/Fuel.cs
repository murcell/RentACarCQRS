﻿using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Fuel:Entity<Guid>
{
    public Fuel()
    {
        Models = new HashSet<Model>();
    }
    public Fuel(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }
    public virtual ICollection<Model> Models { get; set; }

}
