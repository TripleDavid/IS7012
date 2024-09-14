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
    public class IndexModel : PageModel
    {
        private readonly Week3Exercises.Data.Week3ExercisesContext _context;

        public IndexModel(Week3Exercises.Data.Week3ExercisesContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
