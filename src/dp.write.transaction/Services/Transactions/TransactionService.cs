﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;
using Org.BouncyCastle.Utilities.Encoders;
using System.Xml.Linq;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using Nethereum.Contracts.QueryHandlers.MultiCall;

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
    
        public virtual async Task<string?> SendTransactionAsync(string id, string txData)
        {
            //Log.Info("Send  transaction on httpClient");

            var url = DP_CLIENT_URL;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";
       
            StreamReader sr = new StreamReader("data.json");
            var data = sr.ReadToEnd();            
            data = Regex.Replace(data, "<params>", txData);
            data = Regex.Replace(data, "<id>", id);
            
            //Console.Write("data : " + data);

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);               
            }          

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                //Console.WriteLine(result);
                return result;
            }

            ////return httpResponse.StatusCode.ToString();           
        }


        #endregion
    }
}
