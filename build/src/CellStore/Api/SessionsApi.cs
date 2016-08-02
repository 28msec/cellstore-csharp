using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CellStore.Client;

namespace CellStore.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Object</returns>
        Object Login (string email, string password);

        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LoginWithHttpInfo (string email, string password);
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        Object Logout (string token);

        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LogoutWithHttpInfo (string token);
        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        Object Revoke (string email, string password, string token);

        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> RevokeWithHttpInfo (string email, string password, string token);
        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Object</returns>
        Object Token (string email, string password, string expiration);

        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> TokenWithHttpInfo (string email, string password, string expiration);
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        Object Tokens (string token);

        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> TokensWithHttpInfo (string token);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LoginAsync (string email, string password);

        /// <summary>
        /// Login with email and password in order to retrieve a token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LoginAsyncWithHttpInfo (string email, string password);
        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LogoutAsync (string token);

        /// <summary>
        /// Logout the user identified by the given API key.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LogoutAsyncWithHttpInfo (string token);
        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> RevokeAsync (string email, string password, string token);

        /// <summary>
        /// Revoke a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RevokeAsyncWithHttpInfo (string email, string password, string token);
        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration);

        /// <summary>
        /// Create a token having a custom expiration duration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TokenAsyncWithHttpInfo (string email, string password, string expiration);
        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> TokensAsync (string token);

        /// <summary>
        /// List tokens of a user identified by its token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TokensAsyncWithHttpInfo (string token);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Object</returns>
        public Object Login (string email, string password)
        {
             ApiResponse<Object> localVarResponse = LoginWithHttpInfo(email, password);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LoginWithHttpInfo (string email, string password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Login");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Login");

            var localVarPath = "/session/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Login: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Login: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LoginAsync (string email, string password)
        {
             ApiResponse<Object> localVarResponse = await LoginAsyncWithHttpInfo(email, password);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Login with email and password in order to retrieve a token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user to login</param>
        /// <param name="password">Password of user to login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LoginAsyncWithHttpInfo (string email, string password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Login");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Login");

            var localVarPath = "/session/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Login: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Login: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        public Object Logout (string token)
        {
             ApiResponse<Object> localVarResponse = LogoutWithHttpInfo(token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LogoutWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Logout");

            var localVarPath = "/session/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Logout: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Logout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LogoutAsync (string token)
        {
             ApiResponse<Object> localVarResponse = await LogoutAsyncWithHttpInfo(token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Logout the user identified by the given API key. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LogoutAsyncWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Logout");

            var localVarPath = "/session/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Logout: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Logout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        public Object Revoke (string email, string password, string token)
        {
             ApiResponse<Object> localVarResponse = RevokeWithHttpInfo(email, password, token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > RevokeWithHttpInfo (string email, string password, string token)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Revoke");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Revoke");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Revoke");

            var localVarPath = "/session/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Revoke: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Revoke: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> RevokeAsync (string email, string password, string token)
        {
             ApiResponse<Object> localVarResponse = await RevokeAsyncWithHttpInfo(email, password, token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Revoke a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that owns the token</param>
        /// <param name="password">Password of user that owns the token</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RevokeAsyncWithHttpInfo (string email, string password, string token)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Revoke");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Revoke");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Revoke");

            var localVarPath = "/session/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Revoke: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Revoke: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Object</returns>
        public Object Token (string email, string password, string expiration)
        {
             ApiResponse<Object> localVarResponse = TokenWithHttpInfo(email, password, expiration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > TokenWithHttpInfo (string email, string password, string expiration)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Token");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Token");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling SessionsApi->Token");

            var localVarPath = "/session/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) localVarQueryParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> TokenAsync (string email, string password, string expiration)
        {
             ApiResponse<Object> localVarResponse = await TokenAsyncWithHttpInfo(email, password, expiration);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a token having a custom expiration duration. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email of user that creates the token</param>
        /// <param name="password">Password of user that creates the token</param>
        /// <param name="expiration">Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TokenAsyncWithHttpInfo (string email, string password, string expiration)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling SessionsApi->Token");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling SessionsApi->Token");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling SessionsApi->Token");

            var localVarPath = "/session/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (expiration != null) localVarQueryParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Object</returns>
        public Object Tokens (string token)
        {
             ApiResponse<Object> localVarResponse = TokensWithHttpInfo(token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > TokensWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Tokens");

            var localVarPath = "/session/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Tokens: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Tokens: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> TokensAsync (string token)
        {
             ApiResponse<Object> localVarResponse = await TokensAsyncWithHttpInfo(token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List tokens of a user identified by its token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TokensAsyncWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling SessionsApi->Tokens");

            var localVarPath = "/session/tokens";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, List<String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                        if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Tokens: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Tokens: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

    }
}
