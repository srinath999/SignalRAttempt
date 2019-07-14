using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 


namespace SignalR.DBRepo
{
    public class Message 
    {
        [Key]
        public int Id { get; set; }
        
        public User From { get; set; }
        public User To { get; set; }
        public string  Text  { get; set; }
        public DateTime Created { get; set; }
    }
}
