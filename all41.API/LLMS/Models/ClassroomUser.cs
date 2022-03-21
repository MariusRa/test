

namespace LLMS.Models
{
    public class ClassroomUser
    {
        public string UserId { get; set; }
        public string ClassroomId { get; set; }
        
        public User User { get; set; }
        public Classroom Classroom { get; set; }
    }
}
