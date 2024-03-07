using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pruevas_de_a_5.Models;

namespace pruevas_de_a_5.Data
{
    public class pruevas_de_a_5Context : DbContext
    {
        public pruevas_de_a_5Context (DbContextOptions<pruevas_de_a_5Context> options)
            : base(options)
        {
        }

        public DbSet<pruevas_de_a_5.Models.Producto> Producto { get; set; } = default!;
    }
}
