using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Exercises.Data;
using Week3Exercises.Models;

namespace Week3Exercises.Pages.BankAccounts
{
    public class DeleteModel : PageModel
    {
        private readonly Week3Exercises.Data.Week3ExercisesContext _context;

        public DeleteModel(Week3Exercises.Data.Week3ExercisesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount
                .Include(x => x.AccountHolder)
                .FirstOrDefaultAsync(m => m.BankAccountId == id);

            if (bankaccount == null)
            {
                return NotFound();
            }
            else
            {
                BankAccount = bankaccount;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FindAsync(id);
            if (bankaccount != null)
            {
                BankAccount = bankaccount;
                _context.BankAccount.Remove(BankAccount);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
