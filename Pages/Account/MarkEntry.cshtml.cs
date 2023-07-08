using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentDetails.Data;
using StudentDetails.Models.Domains;

namespace StudentDetails.Pages.Account
{
    public class CreateModel : PageModel
    {
        private readonly DataContext dataContext;

        public CreateModel(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IActionResult OnGet()
        {
            var roll = Request.Query["Roll"];
            if (String.IsNullOrEmpty(roll))
                return Page();
            else
            {
                try
                {
                    var Name = dataContext.Stud_detail.FirstOrDefault(e => e.Roll_No == Convert.ToInt16(roll));
                    if (Name == null)
                        return Content("Roll Number not found");
                    else
                    return Content("Name: "+Name.Stud_Name);
                }
                catch (Exception ex)
                {
                    return Content("Roll Number not found");
                }
            }
        }

        [BindProperty]
        public Marks Marks { get; set; } = default!;
        public string msg="";

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Clear();
            CheckForOverPost();
            if (!ModelState.IsValid || dataContext.Stud_Marks == null || Marks == null)
            {
                msg = "Could not update";
                return Page();
            }
            else
            {
                try
                {
                    dataContext.Stud_Marks.Add(Marks);
                    await dataContext.SaveChangesAsync();
                    msg = "Mark updated Successfully";
                }
                catch (Exception ex)
                {
                    msg = "Roll number not found! Could not update,something went wrong";
                }
            }

            return Page();
        }
        private void CheckForOverPost()
        {
            var check = dataContext.Stud_Marks.FirstOrDefault(e => e.RollNumber == Marks.RollNumber&& e.Subject==Marks.Subject);
          if(check !=null)
            {
                ModelState.AddModelError("Marks.RollNumber", "Already exists");
            }
           
        }
    }
}
