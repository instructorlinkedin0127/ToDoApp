using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ni_Soft.ToDoApi.Data.Entities
{
    [Table("ToDo")]
    public class TodoEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Titre { get; set; }
        public bool Active { get; set; }
    }
}
