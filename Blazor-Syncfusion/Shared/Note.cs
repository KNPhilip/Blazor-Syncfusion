namespace BlazorSyncfusion.Shared
{
    public class Note
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public int? TeacherId { get; set; }
        public Employee? Teacher { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}