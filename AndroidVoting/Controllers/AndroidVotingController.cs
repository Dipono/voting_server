using Android.Voting.Data.Models;
using Android.Voting.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AndroidVoting.Controllers
{
    [Route("api/[controller]/[action]")]
    [EnableCors("ReactPolicy")]
    //[ApiController]

    public class AndroidVotingController : ControllerBase
    {
        private IVotingService _votingService;
        public AndroidVotingController(IVotingService votingService)
        {
            _votingService = votingService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Employee employee) {
            var responseWrapper = new ResponseWrapper();
            if(!_votingService.ExistingEmail(employee.EmailAddress))
            {
                responseWrapper = new ResponseWrapper
                {
                    Message = "Email or password is incorrect",
                    Success = false,
                };
                return Ok(responseWrapper);
            }

            var results  = await _votingService.LoginAsync(employee.EmailAddress, employee.Password);
            if(results.Id == 0)
            {
                responseWrapper = new ResponseWrapper
                {
                    Message = "Email or password is incorrect",
                    Success = false,
                };
                return Ok(responseWrapper);
            }

            responseWrapper = new ResponseWrapper
            {
                Message = "Successfully lgged in",
                Success = true,
                Results = results
            };
            return Ok(responseWrapper);
        }

        [HttpPost]
        public async Task<IActionResult> Issue([FromBody] Issue issue)
        {
            var responseWrapper = new ResponseWrapper();
           
            var successfullyAdded = await _votingService.AddIssueAsync(issue);
            if(successfullyAdded== null) {
                responseWrapper = new ResponseWrapper
                {
                    Message = "Unable publish the issue ",
                    Success = false
                };

                return Ok(responseWrapper);
            }
            responseWrapper = new ResponseWrapper
            {
                Message = "Issue published successfully",
                Results = successfullyAdded,
                Success = true
            };

            return Ok(responseWrapper);
        }

        [HttpGet]
        public async Task<IActionResult> LatestIssues()
        {
            var latestIssues = await _votingService.LatestIssuesAsync();

            return Ok(latestIssues);
        }

        [HttpGet]
        public async Task<IActionResult> TotalVotes()
        {
            var totalVotes = await _votingService.TotalVotesAsync();

            return Ok(totalVotes);
        }

        [HttpPost]
        public IEnumerable<Vote> UnCastVotes([FromBody] Vote vote)
        {
            var totalVotes =   _votingService.UncastedVotes(vote.EmpId);

            return totalVotes;
        }

        [HttpGet]
       

        [HttpPost]
        public IActionResult EmployeeVote([FromBody] Vote vote)
        {
            _votingService.EmployeeVoted(vote);
            var responseWrapper = new ResponseWrapper
            {
                Message = "you have successfully cast your vote",
                Success = true
            };
            return Ok(responseWrapper);
        }
    
    }
}