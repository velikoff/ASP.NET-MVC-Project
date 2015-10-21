using Microsoft.AspNet.Identity.EntityFramework;
using PhotoContest.Model;
using System.Data.Entity;

namespace PhotoContest.Data
{
    class PhotoContestDbContext 
    {
        public virtual IDbSet<Contest> Contests { get; set; }
        public virtual IDbSet<RewardStrategy> RewardStrategies { get; set; }
        public virtual IDbSet<VotingStrategy> VotingStrategies { get; set; }
        public virtual IDbSet<ParticipationStrategy> ParticipationStrategies { get; set; }
        public virtual IDbSet<DeadlineStrategy> DeadlineStrategies { get; set; }
    }
}
