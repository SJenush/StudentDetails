using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetails.Models.Domains
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Stud_id { get; set; }
        public int Roll_No { get; set; }
        public string Stud_Name { get; set; }
        public int School_Code { get;set; }
        public string Dob { get; set; }
        public string Acd_Year { get; set; }
        public int Class { get;set; }
        public string Contact_no { get; set; }
        public string Gender { get; set; }
        [ForeignKey("School_Code")]
        public School School { get; set; }
    }
}
