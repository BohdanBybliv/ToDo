using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ToDo.BLL.DTOs;
using ToDo.BLL.Interfaces;
using ToDo.DAL;
using ToDo.DAL.Entities;

namespace ToDo.BLL.Services
{
    public class IssueService : IIssueService
    {
        private readonly IMapper _mapper;
        private readonly ToDoContext _context;

        public IssueService(IMapper mapper, ToDoContext context) 
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<IEnumerable<IssueDTO>> GetAllAsync()
        {
            var issues = _context.Issues.AsNoTracking();

            return await issues.Select(i => _mapper.Map<IssueDTO>(i)).ToListAsync();
        }
        public async Task<int> Create(IssueDTO issueDTO)
        {
            var issue = _mapper.Map<Issue>(issueDTO);

            await _context.Issues.AddAsync(issue);

            await _context.SaveChangesAsync();

            return issue.Id;
        }
        public async Task<int> Update(IssueDTO issueDTO)
        {
            var issue = await _context.Issues.FindAsync(issueDTO.Id);

            if (issue is null)
                return 404;

            _mapper.Map(issueDTO, issue);

            await _context.SaveChangesAsync();

            return issue.Id;
        }
        public async Task<int> Delete(int id)
        {
            var issue = _context.Issues.Find(id);

            if (issue is null)
                return 404;

            _context.Remove(issue);

            await _context.SaveChangesAsync();

            return id;
        }
    }
}
