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
    public interface IUsersApi
    {
        
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email)</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = json);
  
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email)</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = json);
        
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome ForgotPassword (string email, string format = json);
  
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = json);
        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Object</returns>
        Object GetUser (string token, string userid = null, string email = null);
  
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null);
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        Outcome IsAuthorized (string right, string token);
  
        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> IsAuthorizedAsync (string right, string token);
        
        /// <summary>
        /// Create a new user record
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Outcome</returns>
        Outcome NewUser (string firstname, string lastname, string email, string password);
  
        /// <summary>
        /// Create a new user record
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> NewUserAsync (string firstname, string lastname, string email, string password);
        
        /// <summary>
        /// Change a user password
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        Outcome ResetPassword (string newpassword, string email, string password, string token);
  
        /// <summary>
        /// Change a user password
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> ResetPasswordAsync (string newpassword, string email, string password, string token);
        
        /// <summary>
        /// Set the password for a user based on email and the reset password token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome SetPassword (string email, string password, string resetToken, string format = json);
  
        /// <summary>
        /// Set the password for a user based on email and the reset password token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = json);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <param name="firstname">The user new first name</param> 
        /// <param name="lastname">The user new last name</param> 
        /// <param name="newemail">The user new email</param> 
        /// <param name="email">Current email of the authorized user (needed if changing the email)</param> 
        /// <param name="password">Current password of the authorized user (needed if changing the email)</param> 
        /// <param name="token">The token of the current session</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>            
        public Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = json)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling EditUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling EditUser");
            
    
            var path = "/users/edit";
    
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

            
            
            if (firstname != null) queryParams.Add("firstname", ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) queryParams.Add("newemail", ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email)</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = json)
        {
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling EditUser");
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling EditUser");
            
    
            var path = "/users/edit";
    
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

                        
            
            if (firstname != null) queryParams.Add("firstname", ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) queryParams.Add("newemail", ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>            
        public Outcome ForgotPassword (string email, string format = json)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ForgotPassword");
            
    
            var path = "/users/forgotPassword";
    
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

            
            
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForgotPassword: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForgotPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = json)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ForgotPassword");
            
    
            var path = "/users/forgotPassword";
    
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

                        
            
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForgotPassword: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="userid">A user ID</param> 
        /// <param name="email">A user email address</param> 
        /// <returns>Object</returns>            
        public Object GetUser (string token, string userid = null, string email = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetUser");
            
    
            var path = "/users/get";
    
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

            
            
            if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetUser");
            
    
            var path = "/users/get";
    
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

                        
            
            if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>Outcome</returns>            
        public Outcome IsAuthorized (string right, string token)
        {
            
            // verify the required parameter 'right' is set
            if (right == null) throw new ApiException(400, "Missing required parameter 'right' when calling IsAuthorized");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling IsAuthorized");
            
    
            var path = "/users/isAuthorized";
    
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

            
            
            if (right != null) queryParams.Add("right", ApiClient.ParameterToString(right)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IsAuthorized: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IsAuthorized: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> IsAuthorizedAsync (string right, string token)
        {
            // verify the required parameter 'right' is set
            if (right == null) throw new ApiException(400, "Missing required parameter 'right' when calling IsAuthorized");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling IsAuthorized");
            
    
            var path = "/users/isAuthorized";
    
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

                        
            
            if (right != null) queryParams.Add("right", ApiClient.ParameterToString(right)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IsAuthorized: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <param name="firstname">The new user first name</param> 
        /// <param name="lastname">The new user last name</param> 
        /// <param name="email">The new user email</param> 
        /// <param name="password">The new user password</param> 
        /// <returns>Outcome</returns>            
        public Outcome NewUser (string firstname, string lastname, string email, string password)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling NewUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling NewUser");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling NewUser");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling NewUser");
            
    
            var path = "/users/new";
    
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

            
            
            if (firstname != null) queryParams.Add("firstname", ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NewUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NewUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> NewUserAsync (string firstname, string lastname, string email, string password)
        {
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling NewUser");
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling NewUser");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling NewUser");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling NewUser");
            
    
            var path = "/users/new";
    
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

                        
            
            if (firstname != null) queryParams.Add("firstname", ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NewUser: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <param name="newpassword">New password</param> 
        /// <param name="email">Email of the authorized user</param> 
        /// <param name="password">Password of the authorized user</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>Outcome</returns>            
        public Outcome ResetPassword (string newpassword, string email, string password, string token)
        {
            
            // verify the required parameter 'newpassword' is set
            if (newpassword == null) throw new ApiException(400, "Missing required parameter 'newpassword' when calling ResetPassword");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ResetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling ResetPassword");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ResetPassword");
            
    
            var path = "/users/resetPassword";
    
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

            
            
            if (newpassword != null) queryParams.Add("newpassword", ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetPassword: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ResetPasswordAsync (string newpassword, string email, string password, string token)
        {
            // verify the required parameter 'newpassword' is set
            if (newpassword == null) throw new ApiException(400, "Missing required parameter 'newpassword' when calling ResetPassword");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ResetPassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling ResetPassword");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ResetPassword");
            
    
            var path = "/users/resetPassword";
    
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

                        
            
            if (newpassword != null) queryParams.Add("newpassword", ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetPassword: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param> 
        /// <param name="password">The new password</param> 
        /// <param name="resetToken">The reset password token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>            
        public Outcome SetPassword (string email, string password, string resetToken, string format = json)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling SetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling SetPassword");
            
            // verify the required parameter 'resetToken' is set
            if (resetToken == null) throw new ApiException(400, "Missing required parameter 'resetToken' when calling SetPassword");
            
    
            var path = "/users/setPassword";
    
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

            
            
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (resetToken != null) queryParams.Add("resetToken", ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPassword: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
    
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = json)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling SetPassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling SetPassword");
            // verify the required parameter 'resetToken' is set
            if (resetToken == null) throw new ApiException(400, "Missing required parameter 'resetToken' when calling SetPassword");
            
    
            var path = "/users/setPassword";
    
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

                        
            
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
            if (resetToken != null) queryParams.Add("resetToken", ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPassword: " + response.Content, response.Content);

            return (Outcome) ApiClient.Deserialize(response.Content, typeof(Outcome), response.Headers);
        }
        
    }
    
}
