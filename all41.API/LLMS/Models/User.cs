using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LLMS.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserRole { get; set; }

        
        public ICollection<Classroom> Classrooms { get; set; }

        //public ICollection<ClassroomUser> UserClassrooms { get; set; }


    }
}
