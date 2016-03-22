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
        Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);
  
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> EditUserWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);

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
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> EditUserAsyncWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);
        
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Outcome</returns>
        Outcome ForgotPassword (string email, string format = null);
  
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> ForgotPasswordWithHttpInfo (string email, string format = null);

        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = null);

        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> ForgotPasswordAsyncWithHttpInfo (string email, string format = null);
        
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
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetUserWithHttpInfo (string token, string userid = null, string email = null);

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null);

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserAsyncWithHttpInfo (string token, string userid = null, string email = null);
        
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> IsAuthorizedWithHttpInfo (string right, string token);

        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> IsAuthorizedAsync (string right, string token);

        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> IsAuthorizedAsyncWithHttpInfo (string right, string token);
        
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> NewUserWithHttpInfo (string firstname, string lastname, string email, string password);

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
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> NewUserAsync (string firstname, string lastname, string email, string password);

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> NewUserAsyncWithHttpInfo (string firstname, string lastname, string email, string password);
        
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> ResetPasswordWithHttpInfo (string newpassword, string email, string password, string token);

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
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> ResetPasswordAsync (string newpassword, string email, string password, string token);

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> ResetPasswordAsyncWithHttpInfo (string newpassword, string email, string password, string token);
        
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
        Outcome SetPassword (string email, string password, string resetToken, string format = null);
  
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
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> SetPasswordWithHttpInfo (string email, string password, string resetToken, string format = null);

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
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = null);

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> SetPasswordAsyncWithHttpInfo (string email, string password, string resetToken, string format = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        public Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
             ApiResponse<Outcome> response = EditUserWithHttpInfo(firstname, lastname, newemail, email, password, token, format);
             return response.Data;
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
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > EditUserWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling EditUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling EditUser");
            
    
            var path_ = "/users/edit";
    
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

            
            
            if (firstname != null) queryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) queryParams.Add("newemail", Configuration.ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
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
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
             ApiResponse<Outcome> response = await EditUserAsyncWithHttpInfo(firstname, lastname, newemail, email, password, token, format);
             return response.Data;

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
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> EditUserAsyncWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling EditUser");
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling EditUser");
            
    
            var path_ = "/users/edit";
    
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

                        
            
            if (firstname != null) queryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) queryParams.Add("newemail", Configuration.ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>
        public Outcome ForgotPassword (string email, string format = null)
        {
             ApiResponse<Outcome> response = ForgotPasswordWithHttpInfo(email, format);
             return response.Data;
        }

        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > ForgotPasswordWithHttpInfo (string email, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ForgotPassword");
            
    
            var path_ = "/users/forgotPassword";
    
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

            
            
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ForgotPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ForgotPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = null)
        {
             ApiResponse<Outcome> response = await ForgotPasswordAsyncWithHttpInfo(email, format);
             return response.Data;

        }

        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> ForgotPasswordAsyncWithHttpInfo (string email, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ForgotPassword");
            
    
            var path_ = "/users/forgotPassword";
    
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

                        
            
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ForgotPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ForgotPassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
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
             ApiResponse<Object> response = GetUserWithHttpInfo(token, userid, email);
             return response.Data;
        }

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="userid">A user ID</param> 
        /// <param name="email">A user email address</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetUserWithHttpInfo (string token, string userid = null, string email = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetUser");
            
    
            var path_ = "/users/get";
    
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

            
            
            if (userid != null) queryParams.Add("userid", Configuration.ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
    
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null)
        {
             ApiResponse<Object> response = await GetUserAsyncWithHttpInfo(token, userid, email);
             return response.Data;

        }

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID</param>
        /// <param name="email">A user email address</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetUserAsyncWithHttpInfo (string token, string userid = null, string email = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetUser");
            
    
            var path_ = "/users/get";
    
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

                        
            
            if (userid != null) queryParams.Add("userid", Configuration.ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>Outcome</returns>
        public Outcome IsAuthorized (string right, string token)
        {
             ApiResponse<Outcome> response = IsAuthorizedWithHttpInfo(right, token);
             return response.Data;
        }

        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > IsAuthorizedWithHttpInfo (string right, string token)
        {
            
            // verify the required parameter 'right' is set
            if (right == null) throw new ApiException(400, "Missing required parameter 'right' when calling IsAuthorized");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling IsAuthorized");
            
    
            var path_ = "/users/isAuthorized";
    
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

            
            
            if (right != null) queryParams.Add("right", Configuration.ApiClient.ParameterToString(right)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling IsAuthorized: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling IsAuthorized: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> IsAuthorizedAsync (string right, string token)
        {
             ApiResponse<Outcome> response = await IsAuthorizedAsyncWithHttpInfo(right, token);
             return response.Data;

        }

        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> IsAuthorizedAsyncWithHttpInfo (string right, string token)
        {
            // verify the required parameter 'right' is set
            if (right == null) throw new ApiException(400, "Missing required parameter 'right' when calling IsAuthorized");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling IsAuthorized");
            
    
            var path_ = "/users/isAuthorized";
    
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

                        
            
            if (right != null) queryParams.Add("right", Configuration.ApiClient.ParameterToString(right)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling IsAuthorized: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling IsAuthorized: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
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
             ApiResponse<Outcome> response = NewUserWithHttpInfo(firstname, lastname, email, password);
             return response.Data;
        }

        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <param name="firstname">The new user first name</param> 
        /// <param name="lastname">The new user last name</param> 
        /// <param name="email">The new user email</param> 
        /// <param name="password">The new user password</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > NewUserWithHttpInfo (string firstname, string lastname, string email, string password)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling NewUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling NewUser");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling NewUser");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling NewUser");
            
    
            var path_ = "/users/new";
    
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

            
            
            if (firstname != null) queryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling NewUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NewUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> NewUserAsync (string firstname, string lastname, string email, string password)
        {
             ApiResponse<Outcome> response = await NewUserAsyncWithHttpInfo(firstname, lastname, email, password);
             return response.Data;

        }

        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> NewUserAsyncWithHttpInfo (string firstname, string lastname, string email, string password)
        {
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling NewUser");
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling NewUser");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling NewUser");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling NewUser");
            
    
            var path_ = "/users/new";
    
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

                        
            
            if (firstname != null) queryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) queryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling NewUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NewUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
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
             ApiResponse<Outcome> response = ResetPasswordWithHttpInfo(newpassword, email, password, token);
             return response.Data;
        }

        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <param name="newpassword">New password</param> 
        /// <param name="email">Email of the authorized user</param> 
        /// <param name="password">Password of the authorized user</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > ResetPasswordWithHttpInfo (string newpassword, string email, string password, string token)
        {
            
            // verify the required parameter 'newpassword' is set
            if (newpassword == null) throw new ApiException(400, "Missing required parameter 'newpassword' when calling ResetPassword");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ResetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling ResetPassword");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ResetPassword");
            
    
            var path_ = "/users/resetPassword";
    
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

            
            
            if (newpassword != null) queryParams.Add("newpassword", Configuration.ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ResetPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ResetPasswordAsync (string newpassword, string email, string password, string token)
        {
             ApiResponse<Outcome> response = await ResetPasswordAsyncWithHttpInfo(newpassword, email, password, token);
             return response.Data;

        }

        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> ResetPasswordAsyncWithHttpInfo (string newpassword, string email, string password, string token)
        {
            // verify the required parameter 'newpassword' is set
            if (newpassword == null) throw new ApiException(400, "Missing required parameter 'newpassword' when calling ResetPassword");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ResetPassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling ResetPassword");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ResetPassword");
            
    
            var path_ = "/users/resetPassword";
    
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

                        
            
            if (newpassword != null) queryParams.Add("newpassword", Configuration.ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ResetPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResetPassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param> 
        /// <param name="password">The new password</param> 
        /// <param name="resetToken">The reset password token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>Outcome</returns>
        public Outcome SetPassword (string email, string password, string resetToken, string format = null)
        {
             ApiResponse<Outcome> response = SetPasswordWithHttpInfo(email, password, resetToken, format);
             return response.Data;
        }

        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param> 
        /// <param name="password">The new password</param> 
        /// <param name="resetToken">The reset password token</param> 
        /// <param name="format">The result format</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > SetPasswordWithHttpInfo (string email, string password, string resetToken, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling SetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling SetPassword");
            
            // verify the required parameter 'resetToken' is set
            if (resetToken == null) throw new ApiException(400, "Missing required parameter 'resetToken' when calling SetPassword");
            
    
            var path_ = "/users/setPassword";
    
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

            
            
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (resetToken != null) queryParams.Add("resetToken", Configuration.ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling SetPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
    
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = null)
        {
             ApiResponse<Outcome> response = await SetPasswordAsyncWithHttpInfo(email, password, resetToken, format);
             return response.Data;

        }

        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> SetPasswordAsyncWithHttpInfo (string email, string password, string resetToken, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling SetPassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling SetPassword");
            // verify the required parameter 'resetToken' is set
            if (resetToken == null) throw new ApiException(400, "Missing required parameter 'resetToken' when calling SetPassword");
            
    
            var path_ = "/users/setPassword";
    
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

                        
            
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (resetToken != null) queryParams.Add("resetToken", Configuration.ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling SetPassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SetPassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Outcome>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(response, typeof(Outcome)));
            
        }
        
    }
    
}
