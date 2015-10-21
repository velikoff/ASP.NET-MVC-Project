
using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhotoContest.Model
{
    

    public class Contest
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string CreatorId { get; set; }
        public virtual User Creator { get; set; }

        [Required]
        public virtual RewardStrategy RewardStrategy { get; set; }

        [Required]
        public virtual VotingStrategy VotingStrategy { get; set; }

        [Required]
        public virtual ParticipationStrategy ParticipationStrategy { get; set; }

        [Required]
        public virtual DeadlineStrategy DeadlineStrategy { get; set; }
    }
}
