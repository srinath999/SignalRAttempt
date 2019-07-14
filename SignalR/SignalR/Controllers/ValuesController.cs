using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DBRepo;

namespace SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public UserContext Context { get; set; }
        public ValuesController(UserContext context)
        {
            Context = context; 
        }
        
        public object Get()
        {
            return Context.Users.Select(m=>m.UserName).ToList();
        }

    }
}
