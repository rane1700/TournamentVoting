using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TournamentVoting.Models
{
    public class PreTestingExperimenterRanking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public int Image1Rank { get; set; }
        [Required]
        public int Image2Rank { get; set; }
        [Required]
        public int Image3Rank { get; set; }
        [Required]
        public int Image4Rank { get; set; }
    }
}