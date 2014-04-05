using System;
using System.Configuration;
using System.Data.Entity;

namespace EF.Infrastructure
{
    public class Context<T>: IContext<T> where T : class 
    {
        public Context()
        {
            DbContext = new DbContext(ConfigurationManager.ConnectionStrings[" "].ConnectionString);
            DbSet = DbContext.Set<T>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DbContext DbContext { get; private set; }
        public IDbSet<T> DbSet { get; private set; }
    }
}
