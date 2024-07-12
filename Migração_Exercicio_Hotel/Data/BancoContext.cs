using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Migração_Exercicio_Hotel.Models;

namespace Migração_Exercicio_Hotel.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<HotelModel> Hotel { get; set; }
    }
}
