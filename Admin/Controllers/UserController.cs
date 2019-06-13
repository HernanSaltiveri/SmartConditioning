using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Admin.ViewModels;
using Admin.Data.Repositories;
using Admin.Data.Interfaces;
using Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var vm = new UserListViewModel();
            vm = _userRepository.Users;
            return View(vm);
        }

    }
}