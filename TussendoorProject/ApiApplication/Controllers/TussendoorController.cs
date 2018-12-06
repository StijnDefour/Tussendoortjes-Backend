using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer.Entities;
using LogicLayer.Repos.UserRepository;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplication.Controllers
{
    public class TussendoorController : Controller
    {
        private IUserRepo _userRepo;

        public TussendoorController()
        {
            _userRepo = new UserRepo();
        }

        [HttpGet]
        [Route("api/user/getAll")]
        public IEnumerable<User> getAllUsers()
        {
            return _userRepo.GetAll();
        }
    }
}