using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
using Microsoft.AspNetCore.Identity;

namespace SignalR.DBRepo
{
    public class User : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        
        public override string UserName { get; set; }
        [EmailAddress]
        public override string Email { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public virtual List<Message> Messages { get; set; }
    }
}
