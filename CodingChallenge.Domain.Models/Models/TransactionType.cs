using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Domain.Models.Models
{
    public class TransactionType : EntityBase
    {
        public string Name { get; set; }
        public ICollection<TimekeepingTransaction> TimekeepingTransaction { get; set; }
    }
}
