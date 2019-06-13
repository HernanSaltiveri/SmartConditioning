using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Data.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;

namespace Admin.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<UserStore> Users { get; set; }

        //public string UserId { get; set; }
        //public string Username { get; set; }
        //public string Email { get; set; }
        //public string Role { get; set; }

    }
}
