using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models.Domains
{
    public class School
    {
        [Key]
        public int School_Code { get; set; }
        public string School_Name { get; set;}
       

    }
}
