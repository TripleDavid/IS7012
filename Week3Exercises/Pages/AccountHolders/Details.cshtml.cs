using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Exercises.Data;
using Week3Exercises.Models;

namespace Week3Exercises.Pages.AccountHolders
{
    public class DetailsModel : PageModel
    {
        private readonly Week3Exercises.Data.Week3ExercisesContext _context;

        public DetailsModel(Week3Exercises.Data.Week3ExercisesContext context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder
                .Include(x => x.BankAccounts)
                .FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            else
            {
                AccountHolder = accountholder;
            }
            return Page();
        }
    }
}
