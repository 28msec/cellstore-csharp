using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        #region Synchronous Operations
        
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Outcome</returns>
        Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);
  
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> EditUserWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);
        
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Outcome</returns>
        Outcome ForgotPassword (string email, string format = null);
  
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> ForgotPasswordWithHttpInfo (string email, string format = null);
        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>Object</returns>
        Object GetUser (string token, string userid = null, string email = null);
  
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetUserWithHttpInfo (string token, string userid = null, string email = null);
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> IsAuthorizedWithHttpInfo (string right, string token);
        
        /// <summary>
        /// Create a new user record
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> NewUserWithHttpInfo (string firstname, string lastname, string email, string password);
        
        /// <summary>
        /// Change a user password
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> ResetPasswordWithHttpInfo (string newpassword, string email, string password, string token);
        
        /// <summary>
        /// Set the password for a user based on email and the reset password token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Outcome</returns>
        Outcome SetPassword (string email, string password, string resetToken, string format = null);
  
        /// <summary>
        /// Set the password for a user based on email and the reset password token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> SetPasswordWithHttpInfo (string email, string password, string resetToken, string format = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);

        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> EditUserAsyncWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null);
        
        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = null);

        /// <summary>
        /// Send an email with the reset password token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> ForgotPasswordAsyncWithHttpInfo (string email, string format = null);
        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null);

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserAsyncWithHttpInfo (string token, string userid = null, string email = null);
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = null);

        /// <summary>
        /// Set the password for a user based on email and the reset password token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> SetPasswordAsyncWithHttpInfo (string email, string password, string resetToken, string format = null);
        
        #endregion Asynchronous Operations
        
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param> 
        /// <param name="lastname">The user new last name</param> 
        /// <param name="newemail">The user new email (optional, default to null)</param> 
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param> 
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param> 
        /// <param name="token">The token of the current session (optional, default to null)</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>Outcome</returns>
        public Outcome EditUser (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = EditUserWithHttpInfo(firstname, lastname, newemail, email, password, token, format);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param> 
        /// <param name="lastname">The user new last name</param> 
        /// <param name="newemail">The user new email (optional, default to null)</param> 
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param> 
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param> 
        /// <param name="token">The token of the current session (optional, default to null)</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > EditUserWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null)
                throw new ApiException(400, "Missing required parameter 'firstname' when calling UsersApi->EditUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null)
                throw new ApiException(400, "Missing required parameter 'lastname' when calling UsersApi->EditUser");
            
    
            var localVarPath = "/users/edit";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            
            
            if (firstname != null) localVarQueryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) localVarQueryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) localVarQueryParams.Add("newemail", Configuration.ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EditUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EditUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> EditUserAsync (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = await EditUserAsyncWithHttpInfo(firstname, lastname, newemail, email, password, token, format);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change a user firstname and lastname, and, optionally, his email. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The user new first name</param>
        /// <param name="lastname">The user new last name</param>
        /// <param name="newemail">The user new email (optional, default to null)</param>
        /// <param name="email">Current email of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="password">Current password of the authorized user (needed if changing the email) (optional, default to null)</param>
        /// <param name="token">The token of the current session (optional, default to null)</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> EditUserAsyncWithHttpInfo (string firstname, string lastname, string newemail = null, string email = null, string password = null, string token = null, string format = null)
        {
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling EditUser");
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling EditUser");
            
    
            var localVarPath = "/users/edit";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

                        
            
            if (firstname != null) localVarQueryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) localVarQueryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (newemail != null) localVarQueryParams.Add("newemail", Configuration.ApiClient.ParameterToString(newemail)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EditUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EditUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>Outcome</returns>
        public Outcome ForgotPassword (string email, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = ForgotPasswordWithHttpInfo(email, format);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > ForgotPasswordWithHttpInfo (string email, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->ForgotPassword");
            
    
            var localVarPath = "/users/forgotPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ForgotPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ForgotPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ForgotPasswordAsync (string email, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = await ForgotPasswordAsyncWithHttpInfo(email, format);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email with the reset password token. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> ForgotPasswordAsyncWithHttpInfo (string email, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling ForgotPassword");
            
    
            var localVarPath = "/users/forgotPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ForgotPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ForgotPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param> 
        /// <param name="userid">A user ID (optional, default to null)</param> 
        /// <param name="email">A user email address (optional, default to null)</param> 
        /// <returns>Object</returns>
        public Object GetUser (string token, string userid = null, string email = null)
        {
             ApiResponse<Object> localVarResponse = GetUserWithHttpInfo(token, userid, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param> 
        /// <param name="userid">A user ID (optional, default to null)</param> 
        /// <param name="email">A user email address (optional, default to null)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetUserWithHttpInfo (string token, string userid = null, string email = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UsersApi->GetUser");
            
    
            var localVarPath = "/users/get";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            
            
            if (userid != null) localVarQueryParams.Add("userid", Configuration.ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetUserAsync (string token, string userid = null, string email = null)
        {
             ApiResponse<Object> localVarResponse = await GetUserAsyncWithHttpInfo(token, userid, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned. 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token of the current session</param>
        /// <param name="userid">A user ID (optional, default to null)</param>
        /// <param name="email">A user email address (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetUserAsyncWithHttpInfo (string token, string userid = null, string email = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetUser");
            
    
            var localVarPath = "/users/get";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

                        
            
            if (userid != null) localVarQueryParams.Add("userid", Configuration.ApiClient.ParameterToString(userid)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="right">The right id</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>Outcome</returns>
        public Outcome IsAuthorized (string right, string token)
        {
             ApiResponse<Outcome> localVarResponse = IsAuthorizedWithHttpInfo(right, token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="right">The right id</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > IsAuthorizedWithHttpInfo (string right, string token)
        {
            
            // verify the required parameter 'right' is set
            if (right == null)
                throw new ApiException(400, "Missing required parameter 'right' when calling UsersApi->IsAuthorized");
            
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UsersApi->IsAuthorized");
            
    
            var localVarPath = "/users/isAuthorized";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            
            
            if (right != null) localVarQueryParams.Add("right", Configuration.ApiClient.ParameterToString(right)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IsAuthorized: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IsAuthorized: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> IsAuthorizedAsync (string right, string token)
        {
             ApiResponse<Outcome> localVarResponse = await IsAuthorizedAsyncWithHttpInfo(right, token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Checks to see if the current logged in user has a particular right 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="right">The right id</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> IsAuthorizedAsyncWithHttpInfo (string right, string token)
        {
            // verify the required parameter 'right' is set
            if (right == null) throw new ApiException(400, "Missing required parameter 'right' when calling IsAuthorized");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling IsAuthorized");
            
    
            var localVarPath = "/users/isAuthorized";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

                        
            
            if (right != null) localVarQueryParams.Add("right", Configuration.ApiClient.ParameterToString(right)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IsAuthorized: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IsAuthorized: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The new user first name</param> 
        /// <param name="lastname">The new user last name</param> 
        /// <param name="email">The new user email</param> 
        /// <param name="password">The new user password</param> 
        /// <returns>Outcome</returns>
        public Outcome NewUser (string firstname, string lastname, string email, string password)
        {
             ApiResponse<Outcome> localVarResponse = NewUserWithHttpInfo(firstname, lastname, email, password);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The new user first name</param> 
        /// <param name="lastname">The new user last name</param> 
        /// <param name="email">The new user email</param> 
        /// <param name="password">The new user password</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > NewUserWithHttpInfo (string firstname, string lastname, string email, string password)
        {
            
            // verify the required parameter 'firstname' is set
            if (firstname == null)
                throw new ApiException(400, "Missing required parameter 'firstname' when calling UsersApi->NewUser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null)
                throw new ApiException(400, "Missing required parameter 'lastname' when calling UsersApi->NewUser");
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->NewUser");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UsersApi->NewUser");
            
    
            var localVarPath = "/users/new";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            
            
            if (firstname != null) localVarQueryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) localVarQueryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NewUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NewUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstname">The new user first name</param>
        /// <param name="lastname">The new user last name</param>
        /// <param name="email">The new user email</param>
        /// <param name="password">The new user password</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> NewUserAsync (string firstname, string lastname, string email, string password)
        {
             ApiResponse<Outcome> localVarResponse = await NewUserAsyncWithHttpInfo(firstname, lastname, email, password);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user record 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/users/new";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

                        
            
            if (firstname != null) localVarQueryParams.Add("firstname", Configuration.ApiClient.ParameterToString(firstname)); // query parameter
            if (lastname != null) localVarQueryParams.Add("lastname", Configuration.ApiClient.ParameterToString(lastname)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NewUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NewUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newpassword">New password</param> 
        /// <param name="email">Email of the authorized user</param> 
        /// <param name="password">Password of the authorized user</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>Outcome</returns>
        public Outcome ResetPassword (string newpassword, string email, string password, string token)
        {
             ApiResponse<Outcome> localVarResponse = ResetPasswordWithHttpInfo(newpassword, email, password, token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newpassword">New password</param> 
        /// <param name="email">Email of the authorized user</param> 
        /// <param name="password">Password of the authorized user</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > ResetPasswordWithHttpInfo (string newpassword, string email, string password, string token)
        {
            
            // verify the required parameter 'newpassword' is set
            if (newpassword == null)
                throw new ApiException(400, "Missing required parameter 'newpassword' when calling UsersApi->ResetPassword");
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->ResetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UsersApi->ResetPassword");
            
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UsersApi->ResetPassword");
            
    
            var localVarPath = "/users/resetPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            
            
            if (newpassword != null) localVarQueryParams.Add("newpassword", Configuration.ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newpassword">New password</param>
        /// <param name="email">Email of the authorized user</param>
        /// <param name="password">Password of the authorized user</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> ResetPasswordAsync (string newpassword, string email, string password, string token)
        {
             ApiResponse<Outcome> localVarResponse = await ResetPasswordAsyncWithHttpInfo(newpassword, email, password, token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change a user password 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/users/resetPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

                        
            
            if (newpassword != null) localVarQueryParams.Add("newpassword", Configuration.ApiClient.ParameterToString(newpassword)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (password != null) localVarQueryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param> 
        /// <param name="password">The new password</param> 
        /// <param name="resetToken">The reset password token</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>Outcome</returns>
        public Outcome SetPassword (string email, string password, string resetToken, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = SetPasswordWithHttpInfo(email, password, resetToken, format);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param> 
        /// <param name="password">The new password</param> 
        /// <param name="resetToken">The reset password token</param> 
        /// <param name="format">The result format (optional, default to json)</param> 
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > SetPasswordWithHttpInfo (string email, string password, string resetToken, string format = null)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->SetPassword");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UsersApi->SetPassword");
            
            // verify the required parameter 'resetToken' is set
            if (resetToken == null)
                throw new ApiException(400, "Missing required parameter 'resetToken' when calling UsersApi->SetPassword");
            
    
            var localVarPath = "/users/setPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            if (resetToken != null) localVarQueryParams.Add("resetToken", Configuration.ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }

        
        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> SetPasswordAsync (string email, string password, string resetToken, string format = null)
        {
             ApiResponse<Outcome> localVarResponse = await SetPasswordAsyncWithHttpInfo(email, password, resetToken, format);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set the password for a user based on email and the reset password token 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The email of the user to set the password</param>
        /// <param name="password">The new password</param>
        /// <param name="resetToken">The reset password token</param>
        /// <param name="format">The result format (optional, default to json)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> SetPasswordAsyncWithHttpInfo (string email, string password, string resetToken, string format = null)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling SetPassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling SetPassword");
            // verify the required parameter 'resetToken' is set
            if (resetToken == null) throw new ApiException(400, "Missing required parameter 'resetToken' when calling SetPassword");
            
    
            var localVarPath = "/users/setPassword";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            if (resetToken != null) localVarQueryParams.Add("resetToken", Configuration.ApiClient.ParameterToString(resetToken)); // query parameter
            if (format != null) localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Outcome) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)));
            
        }
        
    }
    
}
