using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LLMS.Models
{
    public class Classroom
    {
        public string ClassroomId { get; set; }
        //public string UniqueId { get; set; }
        public string Language { get; set; }
        public string LanguageLevel { get; set; }
        public bool IsActive { get; set; }
        
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
        //[JsonIgnore]
        //public ICollection<ClassroomUser> UserClassrooms { get; set; }
    }
}
