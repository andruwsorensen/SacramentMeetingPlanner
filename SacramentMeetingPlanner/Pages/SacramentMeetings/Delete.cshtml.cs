﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.SacramentMeetings
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public DeleteModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
      public SacramentMeeting SacramentMeeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentmeeting = await _context.SacramentMeeting.FirstOrDefaultAsync(m => m.SacramentMeetingId == id);

            if (sacramentmeeting == null)
            {
                return NotFound();
            }
            else 
            {
                SacramentMeeting = sacramentmeeting;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }
            var sacramentmeeting = await _context.SacramentMeeting.FindAsync(id);

            if (sacramentmeeting != null)
            {
                SacramentMeeting = sacramentmeeting;
                _context.SacramentMeeting.Remove(SacramentMeeting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
