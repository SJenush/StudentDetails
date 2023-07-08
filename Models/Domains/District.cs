using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models.Domains
{
    public class District
    {
        [Key]
        public int District_Code { get; set; }
        public string District_Name { get; set; }
    }
}
