using System.ComponentModel.DataAnnotations;

namespace IdeaAppBlazor.Models
{
    public class Idea
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
