using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
