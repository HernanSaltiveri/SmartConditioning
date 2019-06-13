using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;

namespace Admin.Models
{
    public class AspNetUser : IdentityUser
    {
        public List<IdentityUser> Users { get; set; }
    }
 //   public class AspNetUser : IdentityUser
 //   {
 //       public List<IdentityUserRole<string>> Roles { get; set; }

 //       public string Id { get; set; }
 //       public string UserName { get; set; }
 //       public string NormalizedUserName { get; set; }
 //       public string Email { get; set; }
 //       public string NormalizedEmail { get; set; }
 //       public int EmailConfirmed { get; set; }

 //       public string PasswordHash { get; set; }
 //       public string SecurityStamp { get; set; }
 //       public string ConcurrencyStamp { get; set; }
 //       public string PhoneNumber { get; set; }

 //       public int PhoneNumberConfirmed { get; set; }
 //       public int TwoFactorEnabled { get; set; }
 //       public string LockoutEnd { get; set; }
 //       public int LockoutEnabled { get; set; }
 //       public int AccessFailedCount { get; set; }

 ////       "Id"	TEXT NOT NULL,
	////"UserName"	TEXT,
	////"NormalizedUserName"	TEXT,
	////"Email"	TEXT,
	////"NormalizedEmail"	TEXT,
	////"EmailConfirmed"	INTEGER NOT NULL,
	////"PasswordHash"	TEXT,
	////"SecurityStamp"	TEXT,
	////"ConcurrencyStamp"	TEXT,
	////"PhoneNumber"	TEXT,

	////"PhoneNumberConfirmed"	INTEGER NOT NULL,
	////"TwoFactorEnabled"	INTEGER NOT NULL,
	////"LockoutEnd"	TEXT,
	////"LockoutEnabled"	INTEGER NOT NULL,
	////"AccessFailedCount"	INTEGER NOT NULL,
 //   }
}
