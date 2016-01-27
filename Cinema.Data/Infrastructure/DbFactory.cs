using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CinemaContext dbContext;

        CinemaContext IDbFactory.Init()
        {
            return dbContext ?? (dbContext = new CinemaContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
