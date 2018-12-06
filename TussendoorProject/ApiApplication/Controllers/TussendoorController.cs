using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer.Entities;
using LogicLayer.Repos.UserRepository;
using Microsoft.AspNetCore.Mvc;
using LogicLayer;

namespace ApiApplication.Controllers
{
    public class TussendoorController : Controller
    {
        private readonly DataContext _context;

        private IUserRepo _userRepo;

        public TussendoorController(DataContext context)
        {
            _context = context;
            _userRepo = new UserRepo();
        }

        [HttpGet]
        [Route("api/user/getAll")]
        public IEnumerable<User> getAllUsers()
        {
            return _userRepo.GetAll();
        }

        [HttpGet]
        [Route("api/user/getByID/{id}")]
        public Task<User> getUserByID(int id)
        {
            var user = _context.Users.FindAsync(id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        [HttpGet]
        [Route("api/user/getUserByLogin/{email}/{password}")]
        public User getUserByLogin(String email, String password)
        {
            var user = _userRepo.GetAll()
                            .Where(u => u.Email==email)
                            .Where(u => u.Password == password).First();

            if (user == null)
            {
                return null;
            }

            return user;
        }
    }
}