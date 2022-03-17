using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.EFCore
{
    public class EfCoreActorsRepository : EfCoreRepository<Actor, MyMDBContext>
    {
        public EfCoreActorsRepository(MyMDBContext context) : base(context)
        {

        }
    }
}
