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
    public interface IReportsApi
    {
        
        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report)</param>
        /// <returns>Object</returns>
        Object AddOrReplaceOrValidateReport (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);
  
        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);
        
        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns></returns>
        void RemoveReport (string id, string token);
  
        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns></returns>
        System.Threading.Tasks.Task RemoveReportAsync (string id, string token);
        
        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Object</returns>
        Object GetParameters (string parameter = null);
  
        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null);
        
        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user = authorized user or only public-read reports of user)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable</param>
        /// <param name="_private">Filter listed reports to return only those that are private</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false)</param>
        /// <returns></returns>
        List<Object> ListReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);
  
        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user = authorized user or only public-read reports of user)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable</param>
        /// <param name="_private">Filter listed reports to return only those that are private</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false)</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<Object>> ListReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportsApi : IReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
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
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <param name="report">A JSON object containing the report</param> 
        /// <param name="token">The token of the current session</param> 
        /// <param name="publicRead">Shortcut to make a report publicly readable</param> 
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports)</param> 
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off</param> 
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account</param> 
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report</param> 
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report)</param> 
        /// <returns>Object</returns>            
        public Object AddOrReplaceOrValidateReport (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling AddOrReplaceOrValidateReport");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrReplaceOrValidateReport");
            
    
            var path = "/reports/add-report";
    
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

            
            
            if (publicRead != null) queryParams.Add("public-read", ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) queryParams.Add("validation-only", ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) queryParams.Add("import", ApiClient.ParameterToString(import)); // query parameter
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(report); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrReplaceOrValidateReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrReplaceOrValidateReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token of the current session</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling AddOrReplaceOrValidateReport");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrReplaceOrValidateReport");
            
    
            var path = "/reports/add-report";
    
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

                        
            
            if (publicRead != null) queryParams.Add("public-read", ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) queryParams.Add("validation-only", ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) queryParams.Add("import", ApiClient.ParameterToString(import)); // query parameter
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(report); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrReplaceOrValidateReport: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns></returns>            
        public void RemoveReport (string id, string token)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveReport");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling RemoveReport");
            
    
            var path = "/reports/delete-report";
    
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

            
            
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task RemoveReportAsync (string id, string token)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveReport");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling RemoveReport");
            
    
            var path = "/reports/delete-report";
    
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

                        
            
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveReport: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param> 
        /// <returns>Object</returns>            
        public Object GetParameters (string parameter = null)
        {
            
    
            var path = "/reports/parameters";
    
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

            
            
            if (parameter != null) queryParams.Add("parameter", ApiClient.ParameterToString(parameter)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParameters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParameters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null)
        {
            
    
            var path = "/reports/parameters";
    
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

                        
            
            if (parameter != null) queryParams.Add("parameter", ApiClient.ParameterToString(parameter)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParameters: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc)</param> 
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user = authorized user or only public-read reports of user)</param> 
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable</param> 
        /// <param name="_private">Filter listed reports to return only those that are private</param> 
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once</param> 
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false)</param> 
        /// <returns></returns>            
        public List<Object> ListReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReports");
            
    
            var path = "/reports/reports";
    
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

            
            
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) queryParams.Add("public-read", ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) queryParams.Add("onlyMetadata", ApiClient.ParameterToString(onlyMetadata)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user = authorized user or only public-read reports of user)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable</param>
        /// <param name="_private">Filter listed reports to return only those that are private</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false)</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<Object>> ListReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReports");
            
    
            var path = "/reports/reports";
    
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

                        
            
            if (id != null) queryParams.Add("_id", ApiClient.ParameterToString(id)); // query parameter
            if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) queryParams.Add("public-read", ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) queryParams.Add("onlyMetadata", ApiClient.ParameterToString(onlyMetadata)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.Content, response.Content);

            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
        
    }
    
}
