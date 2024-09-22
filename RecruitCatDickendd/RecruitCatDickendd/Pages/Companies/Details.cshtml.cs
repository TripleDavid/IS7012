using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDickendd.Data;
using RecruitCatDickendd.Models;

namespace RecruitCatDickendd.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatDickendd.Data.RecruitCatDickenddContext _context;

        public DetailsModel(RecruitCatDickendd.Data.RecruitCatDickenddContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Company
                .Include(x => x.Industry)
                .Include(x => x.Candidates)
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            else
            {
                Company = company;
            }
            return Page();
        }
    }
}
