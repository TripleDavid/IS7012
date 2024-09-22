using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDickendd.Data;
using RecruitCatDickendd.Models;

namespace RecruitCatDickendd.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatDickendd.Data.RecruitCatDickenddContext _context;

        public DetailsModel(RecruitCatDickendd.Data.RecruitCatDickenddContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .Include(x => x.JobTitle)
                .Include(x => x.Industry)
                .Include(x => x.Company)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
