using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Data;
using StudentDetails.Models.Domains;
using StudentDetails.Models.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StudentDetails.Pages.Account
{
    public class GetStudentModel : PageModel
    {
        private readonly  DataContext dataContext;

        public GetStudentModel(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [BindProperty]
        public Add_Student addStudent { get; set; }
        public void OnGet()
        {
        }
        public string Name="",PhoneNumber;
        public int Class, Roll;
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_STUD_DET;Integrated Security=True;Connect Timeout=30;"; // Replace with your database connection string
        public IActionResult OnPost()
        {
            Verification();
            // return Redirect("/ShowResult?Roll="+addStudent.Roll_No.ToString());
            return Page();
        }
        private void Verification()
        {          
            var student=dataContext.Stud_detail.FirstOrDefault(e =>e.Roll_No==addStudent.Roll_No);
            Name = student.Stud_Name;
            PhoneNumber = student.Contact_no;
            Class = student.Class;
            Roll = student.Roll_No;
        }
       
    }
}
