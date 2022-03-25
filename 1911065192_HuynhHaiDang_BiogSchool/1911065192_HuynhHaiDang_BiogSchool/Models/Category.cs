using System.ComponentModel.DataAnnotations;

namespace _1911065192_HuynhHaiDang_BiogSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}