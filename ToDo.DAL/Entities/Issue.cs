namespace ToDo.DAL.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime EndDate { get; set; }
    }
}
