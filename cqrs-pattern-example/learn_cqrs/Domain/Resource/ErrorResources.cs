using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Resource
{
    public class ErrorResources
    {
        public bool Success => false;
        public List<string> Message { get; private set; }
        public ErrorResources(List<string> messages)
        {
            Message = messages ?? new List<string>();
        }
    }
}
