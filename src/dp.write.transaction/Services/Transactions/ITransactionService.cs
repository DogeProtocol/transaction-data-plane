using System.Collections.Generic;
using System.Threading.Tasks;

namespace dp.write.transaction.Services.Transactions
{
    /// <summary>
    /// ITransactionService service
    /// </summary>
    public partial interface ITransactionService
    {
        Task<string> SendTransactionAsync(string id,string txData);
    }
}
