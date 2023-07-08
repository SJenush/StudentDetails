using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDetails.Data;

using StudentDetails.Models.Domains;
using StudentDetails.Models.ViewModels;


namespace StudentDetails.Pages.Account
{
    public class AddStudentModel : PageModel
    {
        private readonly DataContext dataContext;

        public AddStudentModel(DataContext dataContext) { 
        this.dataContext = dataContext;
        }
        public List<School>Schools { get; set; }
        
        //var option = document.getElementById("Sc_code")
        //var sName = document.getElementById("SchName");
        //var selectedoption = option.value;
        public void OnGet()
        {
            Schools = dataContext.M_School.ToList();
           
        }
       
        [BindProperty]
        public Add_Student addStudent { get; set; }
        public IActionResult OnPost()
        {
            var num = RollNumber();
            var school = dataContext.M_School.FirstOrDefault(s => s.School_Code == addStudent.School_Code);
            var student = new Student
            {
                Stud_Name = addStudent.Stud_Name,
                School_Code = addStudent.School_Code,              
                Gender = addStudent.Gender,
                Acd_Year = addStudent.Acd_Year,
                Class = addStudent.Class,
                Roll_No = num,
                Contact_no = addStudent.Contact_no,
                Dob = addStudent.Dob,
                School=school
                
            };
            dataContext.Stud_detail.Add(student);
            
            dataContext.SaveChanges();
            
           
            return Redirect("/Index?Roll="+num.ToString());

        }
        private int RollNumber()
        {
            var num=dataContext.Stud_detail.OrderByDescending(e=>e.Stud_id).FirstOrDefault();
            var num_n = 0;
            if (num == null)
                num_n = 0;
            else
                num_n = num.Stud_id;
            var gender=0;
            if (addStudent.Gender == "Male") 
                gender = 1;
            else 
                gender = 2;
            string roll = addStudent.School_Code.ToString() + addStudent.Class.ToString()+gender.ToString() + num_n.ToString();
            return Convert.ToInt32(roll);
        }
    }
}
