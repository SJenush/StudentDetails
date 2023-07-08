using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models.ViewModels
{
    public class Add_Student
    {

        [Required]
        public int Roll_No { get; set; }
        [Required]
        public string Stud_Name { get; set; }
        [Required]
        public int School_Code { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Acd_Year { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public string Contact_no { get; set; }
        [Required]
        public string Gender { get; set; }
       
        
        public string? check { get;set; }
    }
}
