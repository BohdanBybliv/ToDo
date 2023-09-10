using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTOs;

namespace ToDo.BLL.Interfaces
{
    public interface IIssueService
    {
        Task Create(IssueDTO issueDTO);
    }
}
