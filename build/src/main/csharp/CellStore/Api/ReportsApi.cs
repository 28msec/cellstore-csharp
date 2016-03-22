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
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AddOrReplaceOrValidateReportWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);

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
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);

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
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrReplaceOrValidateReportAsyncWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);
        
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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveReportWithHttpInfo (string id, string token);

        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveReportAsync (string id, string token);

        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReportAsyncWithHttpInfo (string id, string token);
        
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
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetParametersWithHttpInfo (string parameter = null);

        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null);

        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetParametersAsyncWithHttpInfo (string parameter = null);
        
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
        /// <returns>List&lt;Object&gt;</returns>
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
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListReportsWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);

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
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);

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
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListReportsAsyncWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportsApi : IReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportsApi(Configuration configuration = null)
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
             ApiResponse<Object> response = AddOrReplaceOrValidateReportWithHttpInfo(report, token, publicRead, _private, validationOnly, import, id, label);
             return response.Data;
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
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AddOrReplaceOrValidateReportWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling AddOrReplaceOrValidateReport");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrReplaceOrValidateReport");
            
    
            var path_ = "/reports/add-report";
    
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

            
            
            if (publicRead != null) queryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) queryParams.Add("validation-only", Configuration.ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) queryParams.Add("import", Configuration.ApiClient.ParameterToString(import)); // query parameter
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (label != null) queryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(report); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddOrReplaceOrValidateReport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddOrReplaceOrValidateReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
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
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
             ApiResponse<Object> response = await AddOrReplaceOrValidateReportAsyncWithHttpInfo(report, token, publicRead, _private, validationOnly, import, id, label);
             return response.Data;

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
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrReplaceOrValidateReportAsyncWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling AddOrReplaceOrValidateReport");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrReplaceOrValidateReport");
            
    
            var path_ = "/reports/add-report";
    
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

                        
            
            if (publicRead != null) queryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) queryParams.Add("validation-only", Configuration.ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) queryParams.Add("import", Configuration.ApiClient.ParameterToString(import)); // query parameter
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (label != null) queryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(report); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddOrReplaceOrValidateReport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddOrReplaceOrValidateReport: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
        
        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns></returns>
        public void RemoveReport (string id, string token)
        {
             RemoveReportWithHttpInfo(id, token);
        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="token">The token of the current session</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveReportWithHttpInfo (string id, string token)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveReport");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling RemoveReport");
            
    
            var path_ = "/reports/delete-report";
    
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

            
            
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RemoveReport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RemoveReport: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveReportAsync (string id, string token)
        {
             await RemoveReportAsyncWithHttpInfo(id, token);

        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token of the current session</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReportAsyncWithHttpInfo (string id, string token)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveReport");
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling RemoveReport");
            
    
            var path_ = "/reports/delete-report";
    
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

                        
            
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RemoveReport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RemoveReport: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param> 
        /// <returns>Object</returns>
        public Object GetParameters (string parameter = null)
        {
             ApiResponse<Object> response = GetParametersWithHttpInfo(parameter);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetParametersWithHttpInfo (string parameter = null)
        {
            
    
            var path_ = "/reports/parameters";
    
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

            
            
            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetParameters: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetParameters: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
        }
    
        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null)
        {
             ApiResponse<Object> response = await GetParametersAsyncWithHttpInfo(parameter);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <param name="parameter">Only retrieve values for this parameter</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetParametersAsyncWithHttpInfo (string parameter = null)
        {
            
    
            var path_ = "/reports/parameters";
    
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

                        
            
            if (parameter != null) queryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetParameters: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetParameters: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(response, typeof(Object)));
            
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
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
             ApiResponse<List<Object>> response = ListReportsWithHttpInfo(token, id, user, publicRead, _private, export, onlyMetadata);
             return response.Data;
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
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListReportsWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReports");
            
    
            var path_ = "/reports/reports";
    
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

            
            
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (user != null) queryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) queryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) queryParams.Add("export", Configuration.ApiClient.ParameterToString(export)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) queryParams.Add("onlyMetadata", Configuration.ApiClient.ParameterToString(onlyMetadata)); // query parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListReports: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Object>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(response, typeof(List<Object>)));
            
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
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
             ApiResponse<List<Object>> response = await ListReportsAsyncWithHttpInfo(token, id, user, publicRead, _private, export, onlyMetadata);
             return response.Data;

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
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListReportsAsyncWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReports");
            
    
            var path_ = "/reports/reports";
    
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

                        
            
            if (id != null) queryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (user != null) queryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) queryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) queryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) queryParams.Add("export", Configuration.ApiClient.ParameterToString(export)); // query parameter
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) queryParams.Add("onlyMetadata", Configuration.ApiClient.ParameterToString(onlyMetadata)); // query parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListReports: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListReports: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Object>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(response, typeof(List<Object>)));
            
        }
        
    }
    
}
