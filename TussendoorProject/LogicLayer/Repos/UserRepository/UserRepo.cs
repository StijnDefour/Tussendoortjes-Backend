using LogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Repos.UserRepository
{
    public class UserRepo : GenericRepository<DataContext, User>, IUserRepo
    {
    }
}
