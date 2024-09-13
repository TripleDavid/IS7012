using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatDickendd.Models;

namespace RecruitCatDickendd.Data
{
    public class RecruitCatDickenddContext : DbContext
    {
        public RecruitCatDickenddContext (DbContextOptions<RecruitCatDickenddContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatDickendd.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatDickendd.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatDickendd.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatDickendd.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
