using System;
using System.Data.Entity;

namespace EF.Infrastructure
{
    public interface IContext<T> : IDisposable where T : class 
    {
        DbContext DbContext { get; }
        IDbSet<T> DbSet { get; }
    }
}
