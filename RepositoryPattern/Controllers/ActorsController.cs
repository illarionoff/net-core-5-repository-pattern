using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data.EFCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : MyMDBController<Actor, EfCoreActorsRepository>
    {

        public ActorsController(EfCoreActorsRepository repository) : base(repository)
        {

        }

       
    }
}
