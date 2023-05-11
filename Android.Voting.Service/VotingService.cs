using Android.Voting.Data;
using Android.Voting.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Android.Voting.Service
{
    public class VotingService : IVotingService
    {
        private readonly AndroidVotindDbContext _dbContext;
        public VotingService(AndroidVotindDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Issue> AddIssueAsync(Issue issue)
        {
            
            await _dbContext.Issues.AddAsync(issue);
            await _dbContext.SaveChangesAsync();
            return issue;    
        }
        public bool ExistingEmail(string email)
        {
            return _dbContext.Employees.Any(x => x.EmailAddress == email);
        }
        public async Task<Employee> LoginAsync(string email, string password)
        {
            var employ = await _dbContext.Employees.SingleAsync(x => x.EmailAddress == email);
            if(employ.Password == password)
            {
                return employ;
            }
            return await Task.FromResult(new Employee());
        }

        public async Task<List<Issue>> LatestIssuesAsync()
        {
            var latestIssues = new List<Issue>();
            var allIssues = await _dbContext.Issues.ToListAsync();            

            for(int i = 0;i < allIssues.Count; i++)
            {
                latestIssues.Add(allIssues[i]);
            }

            return latestIssues;
        }

        public IEnumerable<Vote> VoteBySpceficEmployee(Vote vote)
        {
            var castedVoteByEmployee = _dbContext.Votes.Where(x => x.EmpId == vote.EmpId).ToList();

            return castedVoteByEmployee;
        }

        public bool EmployeeVoted(Vote vote)
        {
            _dbContext.Votes.Add(vote);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<List<Vote>> TotalVotesAsync()
        {
            var totalVotes = new List<Vote>();
            var allVotes = await _dbContext.Votes.ToListAsync();

            for (int i = 0; i < allVotes.Count; i++)
            {
                totalVotes.Add(allVotes[i]);
            }

            return totalVotes;
        }

        public IEnumerable<Vote> UncastedVotes(int empId)
        {
            var casted = _dbContext.Votes.Where(x => x.EmpId == empId).ToList();

            return casted;
        }
    }
}