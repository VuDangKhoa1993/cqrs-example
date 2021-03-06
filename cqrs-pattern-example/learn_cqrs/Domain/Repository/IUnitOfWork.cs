﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        Task CompleteAsync(CancellationToken cancel);
    }
}
