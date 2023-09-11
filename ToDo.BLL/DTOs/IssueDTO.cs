using ToDo.DAL.Enums;

namespace ToDo.BLL.DTOs
{
    public class IssueDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
