using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Week3Exercises.Data;
using Week3Exercises.Models;

namespace Week3Exercises.Pages.BankAccounts
{
    public class CreateModel : PageModel
    {
        private readonly Week3Exercises.Data.Week3ExercisesContext _context;

        public CreateModel(Week3Exercises.Data.Week3ExercisesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountHolderId"] = new SelectList(_context.AccountHolder, "AccountHolderId", "FullName");
            return Page();
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BankAccount.Add(BankAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
