using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DbContext dbContext)
            :base(dbContext)
        {
        }
    }
}
