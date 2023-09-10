using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task Create(IssueDTO issueDTO)
        {
            var issue = _mapper.Map<Issue>(issueDTO);

            await _context.Issues.AddAsync(issue);

            await _context.SaveChangesAsync();
        }
    }
}
