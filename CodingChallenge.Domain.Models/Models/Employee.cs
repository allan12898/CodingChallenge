using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Domain.Models.Models
{
    public class Employee : EntityBase
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateHired { get; set; }

        public ICollection<TimekeepingTransaction> TimekeepingTransaction { get; set; }
    }
}
