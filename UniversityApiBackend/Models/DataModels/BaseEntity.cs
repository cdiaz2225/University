using System.ComponentModel.DataAnnotations;
namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required, Key] 
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User CreatedBy { get; set; } = new User();
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public User UpdatedBy { get; set; } = new User();
        public DateTime UpdateAt { get; set; }
        public User DeletedBy { get; set; } = new User();
        public DateTime DeletedAt { get; set;}
        public bool IsDeleted { get; set; } = false;
    }
}
