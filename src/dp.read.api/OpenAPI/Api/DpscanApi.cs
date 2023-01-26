using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDpscanApi
    {
        /// <summary>
        /// Get accounts info by address 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <returns>Account</returns>
        Account GetAccount (Platform platform, string address);
        /// <summary>
        /// Get blocks info by blocknumber 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="blockNumber"></param>
        /// <returns>Block</returns>
        Block GetBlock (Platform platform, string blockNumber);
        /// <summary>
        /// Get token info by token address 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <returns>Token</returns>
        Token GetTokens (Platform platform, string address);
        /// <summary>
        /// Get transactions info by transactionHash 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="transactionHash"></param>
        /// <returns>Transaction</returns>
        Transaction GetTransaction (Platform platform, string transactionHash);
        /// <summary>
        /// Get validator info by address 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <returns>ValidatorSummary</returns>
        ValidatorSummary GetValidator (Platform platform, string address);
        /// <summary>
        /// List account token transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>AccountTokenTransactionSummaryResponse</returns>
        AccountTokenTransactionSummaryResponse ListAccountTokenTransactions (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List account token info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>AccountTokenSummaryResponse</returns>
        AccountTokenSummaryResponse ListAccountTokens (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List account transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>AccountTransactionSummaryResponse</returns>
        AccountTransactionSummaryResponse ListAccountTransactions (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List blocks info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="pageIndex"></param>
        /// <returns>BlockSummaryResponse</returns>
        BlockSummaryResponse ListBlocks (Platform platform, long? pageIndex);
        /// <summary>
        /// List token holder info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>TokenHolderSummaryResponse</returns>
        TokenHolderSummaryResponse ListTokenHolders (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List  token transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>TokenTransactionSummaryResponse</returns>
        TokenTransactionSummaryResponse ListTokenTransactions (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List tokens info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="pageIndex"></param>
        /// <returns>TokenSummaryResponse</returns>
        TokenSummaryResponse ListTokens (Platform platform, long? pageIndex);
        /// <summary>
        /// List transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="pageIndex"></param>
        /// <returns>TransactionSummaryResponse</returns>
        TransactionSummaryResponse ListTransactions (Platform platform, long? pageIndex);
        /// <summary>
        /// List transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="blockNumber"></param>
        /// <param name="pageIndex"></param>
        /// <returns>TransactionSummaryResponse</returns>
        TransactionSummaryResponse ListTransactionsBlock (Platform platform, string blockNumber, long? pageIndex);
        /// <summary>
        /// List validator transactions info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="address"></param>
        /// <param name="pageIndex"></param>
        /// <returns>ValidatorTransactionSummaryResponse</returns>
        ValidatorTransactionSummaryResponse ListValidatorTransactions (Platform platform, string address, long? pageIndex);
        /// <summary>
        /// List validator info by page 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="pageIndex"></param>
        /// <returns>ValidatorSummaryResponse</returns>
        ValidatorSummaryResponse ListValidators (Platform platform, long? pageIndex);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DpscanApi : IDpscanApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpscanApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DpscanApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DpscanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DpscanApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get accounts info by address 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <returns>Account</returns>            
        public Account GetAccount (Platform platform, string address)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetAccount");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetAccount");
            
    
            var path = "/api/{platform}/accounts/{address}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Account) ApiClient.Deserialize(response.Content, typeof(Account), response.Headers);
        }
    
        /// <summary>
        /// Get blocks info by blocknumber 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="blockNumber"></param> 
        /// <returns>Block</returns>            
        public Block GetBlock (Platform platform, string blockNumber)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetBlock");
            
            // verify the required parameter 'blockNumber' is set
            if (blockNumber == null) throw new ApiException(400, "Missing required parameter 'blockNumber' when calling GetBlock");
            
    
            var path = "/api/{platform}/blocks/{blockNumber}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "blockNumber" + "}", ApiClient.ParameterToString(blockNumber));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlock: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Block) ApiClient.Deserialize(response.Content, typeof(Block), response.Headers);
        }
    
        /// <summary>
        /// Get token info by token address 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <returns>Token</returns>            
        public Token GetTokens (Platform platform, string address)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetTokens");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetTokens");
            
    
            var path = "/api/{platform}/tokens/{address}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Token) ApiClient.Deserialize(response.Content, typeof(Token), response.Headers);
        }
    
        /// <summary>
        /// Get transactions info by transactionHash 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="transactionHash"></param> 
        /// <returns>Transaction</returns>            
        public Transaction GetTransaction (Platform platform, string transactionHash)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetTransaction");
            
            // verify the required parameter 'transactionHash' is set
            if (transactionHash == null) throw new ApiException(400, "Missing required parameter 'transactionHash' when calling GetTransaction");
            
    
            var path = "/api/{platform}/transactions/{transactionHash}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "transactionHash" + "}", ApiClient.ParameterToString(transactionHash));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Transaction) ApiClient.Deserialize(response.Content, typeof(Transaction), response.Headers);
        }
    
        /// <summary>
        /// Get validator info by address 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <returns>ValidatorSummary</returns>            
        public ValidatorSummary GetValidator (Platform platform, string address)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetValidator");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetValidator");
            
    
            var path = "/api/{platform}/validators/{address}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetValidator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetValidator: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ValidatorSummary) ApiClient.Deserialize(response.Content, typeof(ValidatorSummary), response.Headers);
        }
    
        /// <summary>
        /// List account token transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>AccountTokenTransactionSummaryResponse</returns>            
        public AccountTokenTransactionSummaryResponse ListAccountTokenTransactions (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListAccountTokenTransactions");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListAccountTokenTransactions");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListAccountTokenTransactions");
            
    
            var path = "/api/{platform}/accounts/tokens/{address}/transactions/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTokenTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTokenTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountTokenTransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(AccountTokenTransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List account token info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>AccountTokenSummaryResponse</returns>            
        public AccountTokenSummaryResponse ListAccountTokens (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListAccountTokens");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListAccountTokens");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListAccountTokens");
            
    
            var path = "/api/{platform}/accounts/tokens/{address}/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountTokenSummaryResponse) ApiClient.Deserialize(response.Content, typeof(AccountTokenSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List account transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>AccountTransactionSummaryResponse</returns>            
        public AccountTransactionSummaryResponse ListAccountTransactions (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListAccountTransactions");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListAccountTransactions");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListAccountTransactions");
            
    
            var path = "/api/{platform}/accounts/{address}/transactions/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccountTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountTransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(AccountTransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List blocks info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>BlockSummaryResponse</returns>            
        public BlockSummaryResponse ListBlocks (Platform platform, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListBlocks");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListBlocks");
            
    
            var path = "/api/{platform}/blocks/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBlocks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBlocks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BlockSummaryResponse) ApiClient.Deserialize(response.Content, typeof(BlockSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List token holder info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>TokenHolderSummaryResponse</returns>            
        public TokenHolderSummaryResponse ListTokenHolders (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListTokenHolders");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListTokenHolders");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListTokenHolders");
            
    
            var path = "/api/{platform}/tokens/holders/{address}/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokenHolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokenHolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenHolderSummaryResponse) ApiClient.Deserialize(response.Content, typeof(TokenHolderSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List  token transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>TokenTransactionSummaryResponse</returns>            
        public TokenTransactionSummaryResponse ListTokenTransactions (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListTokenTransactions");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListTokenTransactions");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListTokenTransactions");
            
    
            var path = "/api/{platform}/tokens/{address}/transactions/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokenTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokenTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenTransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(TokenTransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List tokens info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>TokenSummaryResponse</returns>            
        public TokenSummaryResponse ListTokens (Platform platform, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListTokens");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListTokens");
            
    
            var path = "/api/{platform}/tokens/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenSummaryResponse) ApiClient.Deserialize(response.Content, typeof(TokenSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>TransactionSummaryResponse</returns>            
        public TransactionSummaryResponse ListTransactions (Platform platform, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListTransactions");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListTransactions");
            
    
            var path = "/api/{platform}/transactions/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(TransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="blockNumber"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>TransactionSummaryResponse</returns>            
        public TransactionSummaryResponse ListTransactionsBlock (Platform platform, string blockNumber, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListTransactionsBlock");
            
            // verify the required parameter 'blockNumber' is set
            if (blockNumber == null) throw new ApiException(400, "Missing required parameter 'blockNumber' when calling ListTransactionsBlock");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListTransactionsBlock");
            
    
            var path = "/api/{platform}/transactions/block/page/{blockNumber}/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "blockNumber" + "}", ApiClient.ParameterToString(blockNumber));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactionsBlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactionsBlock: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(TransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List validator transactions info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="address"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>ValidatorTransactionSummaryResponse</returns>            
        public ValidatorTransactionSummaryResponse ListValidatorTransactions (Platform platform, string address, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListValidatorTransactions");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ListValidatorTransactions");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListValidatorTransactions");
            
    
            var path = "/api/{platform}/validators/{address}/transactions/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListValidatorTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListValidatorTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ValidatorTransactionSummaryResponse) ApiClient.Deserialize(response.Content, typeof(ValidatorTransactionSummaryResponse), response.Headers);
        }
    
        /// <summary>
        /// List validator info by page 
        /// </summary>
        /// <param name="platform"></param> 
        /// <param name="pageIndex"></param> 
        /// <returns>ValidatorSummaryResponse</returns>            
        public ValidatorSummaryResponse ListValidators (Platform platform, long? pageIndex)
        {
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling ListValidators");
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) throw new ApiException(400, "Missing required parameter 'pageIndex' when calling ListValidators");
            
    
            var path = "/api/{platform}/validators/page/{pageIndex}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "pageIndex" + "}", ApiClient.ParameterToString(pageIndex));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListValidators: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListValidators: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ValidatorSummaryResponse) ApiClient.Deserialize(response.Content, typeof(ValidatorSummaryResponse), response.Headers);
        }
    
    }
}
