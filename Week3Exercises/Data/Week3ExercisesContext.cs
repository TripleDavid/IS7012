using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week3Exercises.Models;

namespace Week3Exercises.Data
{
    public class Week3ExercisesContext : DbContext
    {
        public Week3ExercisesContext (DbContextOptions<Week3ExercisesContext> options)
            : base(options)
        {
        }

        public DbSet<Week3Exercises.Models.Director> Director { get; set; } = default!;
        public DbSet<Week3Exercises.Models.Movie> Movie { get; set; } = default!;
        public DbSet<Week3Exercises.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<Week3Exercises.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
