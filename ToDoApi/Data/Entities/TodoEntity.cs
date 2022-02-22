using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ni_Soft.ToDoApi.Data.Entities
{
    /// <summary>
    /// Database table of tasks
    /// </summary>
    [Table("ToDo")]
    public class TodoEntity
    {
        /// <summary>
        /// The unique identifier number
        /// </summary>
        [Key]
        public int Id { get; set; }
        // The title of the task
        [Required]
        public string? Titre { get; set; }
        //Indicate whether a task is active or  not
        public bool Active { get; set; }
    }
}
