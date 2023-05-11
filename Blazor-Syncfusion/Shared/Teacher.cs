using Newtonsoft.Json;

namespace BlazorSyncfusion.Shared
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string School { get; set; } = string.Empty;
        public bool IsTeacher { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime DateHired { get; set; } = DateTime.Now;
        public DateTime? DateLastUpdated { get; set; }
        public DateTime? DateFired { get; set; }
        [JsonIgnore]
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}