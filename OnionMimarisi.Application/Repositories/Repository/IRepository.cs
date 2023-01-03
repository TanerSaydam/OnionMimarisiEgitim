using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Repositories.Repository
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Entity { get; }
    }
}
