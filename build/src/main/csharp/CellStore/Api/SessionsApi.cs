using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
        Object Login (string email, string password, string format = null);
  
        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LoginWithHttpInfo (string email, string password, string format = null);

        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LoginAsync (string email, string password, string format = null);

        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LoginAsyncWithHttpInfo (string email, string password, string format = null);
        
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome Logout (string token, string format = null);
  
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> LogoutWithHttpInfo (string token, string format = null);

        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> LogoutAsync (string token, string format = null);

        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> LogoutAsyncWithHttpInfo (string token, string format = null);
        
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
        Outcome Revoke (string email, string password, string token, string format = null);
  
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> RevokeWithHttpInfo (string email, string password, string token, string format = null);

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
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> RevokeAsync (string email, string password, string token, string format = null);

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> RevokeAsyncWithHttpInfo (string email, string password, string token, string format = null);
        
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
        Object Token (string email, string password, string expiration, string format = null);
  
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
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> TokenWithHttpInfo (string email, string password, string expiration, string format = null);

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
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration, string format = null);

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
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TokenAsyncWithHttpInfo (string email, string password, string expiration, string format = null);
        
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Object</returns>
        Object Tokens (string token, string format = null);
  
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> TokensWithHttpInfo (string token, string format = null);

        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> TokensAsync (string token, string format = null);

        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TokensAsyncWithHttpInfo (string token, string format = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionsApi : ISessionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SessionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param> 
        /// <param name="password">Password of user to login</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>
        public Object Login (string email, string password, string format = null)
        {
             ApiResponse<Object> response = LoginWithHttpInfo(email, password, format);
             return response.Data;
        }

        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param> 
        /// <param name="password">Password of user to login</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LoginWithHttpInfo (string email, string password, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Login");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
    
            var path_ = "/session/login";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Login: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
    
        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LoginAsync (string email, string password, string format = null)
        {
             ApiResponse<Object> response = await LoginAsyncWithHttpInfo(email, password, format);
             return response.Data;

        }

        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LoginAsyncWithHttpInfo (string email, string password, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Login");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
    
            var path_ = "/session/login";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Login: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
        
        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>
        public Outcome Logout (string token, string format = null)
        {
             ApiResponse<Outcome> response = LogoutWithHttpInfo(token, format);
             return response.Data;
        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > LogoutWithHttpInfo (string token, string format = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Logout");
            
    
            var path_ = "/session/logout";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Logout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Logout: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> LogoutAsync (string token, string format = null)
        {
             ApiResponse<Outcome> response = await LogoutAsyncWithHttpInfo(token, format);
             return response.Data;

        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <param name="token">API token of the current user</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> LogoutAsyncWithHttpInfo (string token, string format = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Logout");
            
    
            var path_ = "/session/logout";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Logout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Logout: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param> 
        /// <param name="password">Password of user that owns the token</param> 
        /// <param name="token">API token to revoke</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>
        public Outcome Revoke (string email, string password, string token, string format = null)
        {
             ApiResponse<Outcome> response = RevokeWithHttpInfo(email, password, token, format);
             return response.Data;
        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param> 
        /// <param name="password">Password of user that owns the token</param> 
        /// <param name="token">API token to revoke</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > RevokeWithHttpInfo (string email, string password, string token, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Revoke");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Revoke");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Revoke");
            
    
            var path_ = "/session/revoke";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Revoke: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Revoke: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">API token to revoke</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> RevokeAsync (string email, string password, string token, string format = null)
        {
             ApiResponse<Outcome> response = await RevokeAsyncWithHttpInfo(email, password, token, format);
             return response.Data;

        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">API token to revoke</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> RevokeAsyncWithHttpInfo (string email, string password, string token, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Revoke");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Revoke");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Revoke");
            
    
            var path_ = "/session/revoke";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Revoke: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Revoke: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param> 
        /// <param name="password">Password of user that creates the token</param> 
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>
        public Object Token (string email, string password, string expiration, string format = null)
        {
             ApiResponse<Object> response = TokenWithHttpInfo(email, password, expiration, format);
             return response.Data;
        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param> 
        /// <param name="password">Password of user that creates the token</param> 
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > TokenWithHttpInfo (string email, string password, string expiration, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Token");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Token");
            
            // verify the required parameter 'expiration' is set
            if (expiration == null) throw new ApiException(400, "Missing required parameter 'expiration' when calling Token");
            
    
            var path_ = "/session/token";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) queryParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Token: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Token: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
    
        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration, string format = null)
        {
             ApiResponse<Object> response = await TokenAsyncWithHttpInfo(email, password, expiration, format);
             return response.Data;

        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TokenAsyncWithHttpInfo (string email, string password, string expiration, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Token");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Token");
            // verify the required parameter 'expiration' is set
            if (expiration == null) throw new ApiException(400, "Missing required parameter 'expiration' when calling Token");
            
    
            var path_ = "/session/token";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) queryParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Token: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Token: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
        
        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Object</returns>
        public Object Tokens (string token, string format = null)
        {
             ApiResponse<Object> response = TokensWithHttpInfo(token, format);
             return response.Data;
        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > TokensWithHttpInfo (string token, string format = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tokens");
            
    
            var path_ = "/session/tokens";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Tokens: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Tokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
    
        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> TokensAsync (string token, string format = null)
        {
             ApiResponse<Object> response = await TokensAsyncWithHttpInfo(token, format);
             return response.Data;

        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <param name="token">A valid API token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TokensAsyncWithHttpInfo (string token, string format = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tokens");
            
    
            var path_ = "/session/tokens";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Tokens: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Tokens: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
        
    }
    
}
