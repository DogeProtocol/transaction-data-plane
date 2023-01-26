using System;
using System.Net;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;
using Org.BouncyCastle.Utilities.Encoders;

namespace dp.write.transaction.Services.Transactions
{
    /// <summary>
    /// Transaction service
    /// </summary>
    public partial class TransactionService: ITransactionService
    {

        #region Constants

        /// <summary>
        /// public method data catch for transaction(set,get,list page)
        /// </summary>
        /// 
        private string DP_CLIENT_URL = Configuration.DpClient.Url;

        #endregion

        #region Fields
        
        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public TransactionService()
        {           
           
        }

        #endregion

        #region Public Methods
    
        public virtual async Task<string> SendTransactionAsync(string txData)
        {
            Log.Info("Send  transaction on httpClient");

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), DP_CLIENT_URL))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");

                    request.Content = new StringContent(txData, Encoding.UTF8, "application/json");

                    var response = await httpClient.SendAsync(request);

                    return response.ToString();
                }
            }
        }

        #endregion
    }
}
