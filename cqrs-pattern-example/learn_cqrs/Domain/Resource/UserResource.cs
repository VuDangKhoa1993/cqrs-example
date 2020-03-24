using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Resource
{
    public class UserResource
    {
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 100)]
        public byte Age { get; set; }
    }
}
