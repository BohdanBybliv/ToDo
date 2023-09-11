using Microsoft.AspNetCore.Mvc;
using ToDo.BLL.DTOs;
using ToDo.BLL.Interfaces;

namespace ToDo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueService _issueService;
        public IssuesController(IIssueService issueService)
        {
            _issueService = issueService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IssueDTO>>> GetAllIssues()
        {
            var response = await _issueService.GetAllAsync();

            return Ok(response);
        }
        [HttpPost]
        [Route("newissue")]
        public async Task<ActionResult<int>> AddIssue(IssueDTO issueDTO)
        {
            var response = await _issueService.Create(issueDTO);

            if (response == 404) return NotFound();

            return Ok(response);
        }
        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<int>> UpdateIssue(IssueDTO issueDTO)
        {
            var response = await _issueService.Update(issueDTO);

            if (response == 404) return NotFound();

            return Ok(response);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<int>> DeleteIssue(int id)
        {
            var response = await _issueService.Delete(id);

            if (response == 404) return NotFound();

            return Ok(response);
        }
    }
}
