using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models.Domains
{
    public class Marks
    {
        [Key]
        public int Id { get; set; }
        public int RollNumber { get; set; }       
        public string Subject { get; set; }
        public int Mark { get;set; }
    }
}
