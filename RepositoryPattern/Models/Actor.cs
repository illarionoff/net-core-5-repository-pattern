using RepositoryPattern.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Actor: IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string FirstName { get; set; }


        [StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }

        public bool HasOscar { get; set; }
    }
}
