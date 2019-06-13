using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;
using Admin.ViewModels;
using System.Data;//.Entity;

namespace Admin.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public UserRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public UserListViewModel Users
        {
            get {
                UserListViewModel rtn = new UserListViewModel();
                rtn.Users = _appDbContext.Users;
                return rtn;
            }
        }

       
    }
}
