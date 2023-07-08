using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Data;
using StudentDetails.Models.Domains;
using System.Threading.Tasks;

namespace StudentDetails.Pages.Account
{
    public class ViewStudentModel : PageModel
    {
        private readonly DataContext dataContext;

        public ViewStudentModel(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public   List<Student> Table { get; set; }
        public   void OnGet()
        {
           
            Table =  dataContext.Stud_detail.Include(s=>s.School).OrderBy(e=>e.Stud_id).ToList();
        }
    }
}
