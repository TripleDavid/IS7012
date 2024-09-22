using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatDickendd.Data;
using RecruitCatDickendd.Models;

namespace RecruitCatDickendd.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatDickendd.Data.RecruitCatDickenddContext _context;

        public CreateModel(RecruitCatDickendd.Data.RecruitCatDickenddContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryId"] = new SelectList(_context.Industry, "IndustryId", "IndustryName");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "JobTitleId", "Title");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
