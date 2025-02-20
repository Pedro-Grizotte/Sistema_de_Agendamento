using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_Agendamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Agendamento.Data
{
    public class ProgramDbContext : DbContext
    {
        public ProgramDbContext(DbContextOptions<ProgramDbContext> options) : base(options) {}
    
        public DbSet<User_register> Users { get; set; }
    }
}