using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using CellStore.Client;
using CellStore.Model;

namespace CellStore.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionsApi
    {
        
        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        Object Login (string email, string password, string format = json);
  
        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> LoginAsync (string email, string password, string format = json);
        
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome Logout (string token, string format = json);
  
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> LogoutAsync (string token, string format = json);
        
        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">API token to revoke</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome Revoke (string email, string password, string token, string format = json);
  
        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">API token to revoke</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> RevokeAsync (string email, string password, string token, string format = json);
        
        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        Object Token (string email, string password, string expiration, string format = json);
  
        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration, string format = json);
        
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        Object Tokens (string token, string format = json);
  
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> TokensAsync (string token, string format = json);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionsApi : ISessionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SessionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionsApi(String basePath)
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
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param> 
        /// <param name="password">Password of user to login</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>            
        public Object Login (string email, string password, string format = json)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Login");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
    
            var path = "/session/login";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> LoginAsync (string email, string password, string format = json)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Login");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
    
            var path = "/session/login";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>            
        public Outcome Logout (string token, string format = json)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Logout");
            
    
            var path = "/session/logout";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> LogoutAsync (string token, string format = json)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Logout");
            
    
            var path = "/session/logout";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param> 
        /// <param name="password">Password of user that owns the token</param> 
        /// <param name="token">API token to revoke</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>            
        public Outcome Revoke (string email, string password, string token, string format = json)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Revoke");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Revoke");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Revoke");
            
    
            var path = "/session/revoke";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Revoke: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Revoke: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">API token to revoke</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> RevokeAsync (string email, string password, string token, string format = json)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Revoke");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Revoke");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Revoke");
            
    
            var path = "/session/revoke";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Revoke: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param> 
        /// <param name="password">Password of user that creates the token</param> 
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>            
        public Object Token (string email, string password, string expiration, string format = json)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Token");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Token");
            
            // verify the required parameter 'expiration' is set
            if (expiration == null) throw new ApiException(400, "Missing required parameter 'expiration' when calling Token");
            
    
            var path = "/session/token";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) queryParams.Add("expiration", ApiClient.ParameterToString(expiration)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Token: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Token: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration, string format = json)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Token");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Token");
            // verify the required parameter 'expiration' is set
            if (expiration == null) throw new ApiException(400, "Missing required parameter 'expiration' when calling Token");
            
    
            var path = "/session/token";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) queryParams.Add("expiration", ApiClient.ParameterToString(expiration)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Token: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>            
        public Object Tokens (string token, string format = json)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tokens");
            
    
            var path = "/session/tokens";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Tokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Tokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> TokensAsync (string token, string format = json)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tokens");
            
    
            var path = "/session/tokens";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Tokens: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
    }
    
}
