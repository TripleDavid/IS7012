﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDickendd.Data;
using RecruitCatDickendd.Models;

namespace RecruitCatDickendd.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatDickendd.Data.RecruitCatDickenddContext _context;

        public DetailsModel(RecruitCatDickendd.Data.RecruitCatDickenddContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);
            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
