using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Models.Domains;

namespace StudentDetails.Pages.Account
{
    public class ViewMarkModel : PageModel
    {
        private readonly Data.DataContext context;

        public ViewMarkModel(Data.DataContext context)
        {
            this.context = context;
        }
        [BindProperty]
      public Marks Marks { get; set; }  //Binding values to domain
      public string StudentName { get;set; }
       
        public List<Marks> MarksList { get; set; }
        public  IActionResult OnGet()
        {
          
            return Page();
        }
        public IActionResult OnPost()
        {
            ModelState.Clear();
            StudentName = GetStudentName();
            var list = context.Stud_Marks.Where(x => x.RollNumber == Marks.RollNumber).ToList();
            MarksList = list;
            return Page();
        }
        private string GetStudentName()
        {
            var name = context.Stud_detail.FirstOrDefault(e => e.Roll_No == Marks.RollNumber);
            if(name== null)
            {
                ModelState.AddModelError("Marks.RollNumber", "Roll Number not found.");
                return null;
            }
            else
            {
                ModelState.Clear();
                return name.Stud_Name;
            }
        }
       
    }
}
