using Sispar.Core.Contracts;
using Sispar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispar.Core.EF.Repositories
{
    public class UserRepository : Repository<User>, IUser
    {
        public User GetByUserName(string userName)
        {
            var user = _ctx.Users.Where(u => u.UserName.Contains(userName));
            return user.FirstOrDefault<User>();
        }
    }
}
