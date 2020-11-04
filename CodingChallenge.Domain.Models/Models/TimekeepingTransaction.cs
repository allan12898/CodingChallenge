using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Domain.Models.Models
{
    public class TimekeepingTransaction : EntityBase
    {
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        public int TransactionTypeId { get; set; }
        public TransactionType TransactionType { get; set; }
        [Required]
        public DateTime TransactionDateTime { get; set; }
    }
}
