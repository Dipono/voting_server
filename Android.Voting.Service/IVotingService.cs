using Android.Voting.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.Voting.Service
{
    public interface IVotingService
    {
        bool ExistingEmail(string email);
        Task<Employee> LoginAsync(string email, string password);
        Task<Issue> AddIssueAsync(Issue issue);
        Task<List<Issue>> LatestIssuesAsync();
        Task<List<Vote>> TotalVotesAsync();
        IEnumerable<Vote> UncastedVotes(int empId);
        bool EmployeeVoted(Vote vote);
        IEnumerable<Vote> VoteBySpceficEmployee(Vote vote);


    }
}
