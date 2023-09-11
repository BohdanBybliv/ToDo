using ToDo.BLL.DTOs;

namespace ToDo.BLL.Interfaces
{
    public interface IIssueService
    {
        Task<IEnumerable<IssueDTO>> GetAllAsync();
        Task<int> Create(IssueDTO issueDTO);
        Task<int> Update(IssueDTO issueDTO);
        Task<int> Delete(int id);
    }
}
