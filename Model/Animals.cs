using System.ComponentModel.DataAnnotations;

namespace HerosWebAPI.Model
{
    public class Animals
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }

    }
}
