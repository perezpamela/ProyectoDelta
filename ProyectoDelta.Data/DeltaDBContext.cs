using Microsoft.EntityFrameworkCore;
using System;

namespace ProyectoDelta.Data
{
    public class DeltaDBContext : DbContext
    {
        public DeltaDBContext(DbContextOptions<DeltaDBContext> options) : base (options)
        {

        }


    }
}
