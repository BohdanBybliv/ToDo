using AutoMapper;
using ToDo.BLL.DTOs;
using ToDo.DAL.Entities;

namespace ToDo.BLL.Mapping
{
    public class IssueProfile : Profile
    {
        public IssueProfile()
        {
            CreateMap<Issue, IssueDTO>().ReverseMap();
        }
    }
}
