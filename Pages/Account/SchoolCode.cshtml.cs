using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;
using StudentDetails.Models.Domains;

namespace StudentDetails.Pages.Account
{
    public class SchoolCodeModel : PageModel
    {
        private readonly DataContext dataContext;

        public SchoolCodeModel(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
       // public List<School> Schools { get; set; }
        public IActionResult OnGet()
        {
            var SchoolCode = Request.Query["Code"];
            int code = Convert.ToInt16(SchoolCode);
            var school = dataContext.M_School.FirstOrDefault(e => e.School_Code == code);
            return Content(school.School_Name);
        }
    }
}
