using System.ComponentModel.DataAnnotations;

namespace HerosWebAPI.Model
{
    public class Fruits
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int count { get; set; }
        public string country { get; set; }
        public string taste { get; set; }
    }
}
