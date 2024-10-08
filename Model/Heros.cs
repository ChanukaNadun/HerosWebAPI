using System.ComponentModel.DataAnnotations;

namespace HerosWebAPI.Model
{
    public class Heros
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string ability { get; set; }
        public string description { get; set; }
    }
}
