using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp.write.transaction.Entities
{
    public class TransactionEntity
    {
        public string Id { get; set; }
        public string JsonDocument { get; set; }
        public DateTime DateAdded { get; set; }
        public string State { get; set; }
    }
}
