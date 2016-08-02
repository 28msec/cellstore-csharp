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
    public interface IReportsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Object</returns>
        Object AddOrReplaceOrValidateReport (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);

        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AddOrReplaceOrValidateReportWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);
        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Object</returns>
        Object GetParameters (string parameter = null);

        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetParametersWithHttpInfo (string parameter = null);
        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);

        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> GetReportsWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);
        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns></returns>
        void RemoveReport (string id, string token);

        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveReportWithHttpInfo (string id, string token);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);

        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrReplaceOrValidateReportAsyncWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null);
        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null);

        /// <summary>
        /// Retrieve a list of all Report Parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetParametersAsyncWithHttpInfo (string parameter = null);
        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> GetReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);

        /// <summary>
        /// Retrieve a list of all Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> GetReportsAsyncWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null);
        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveReportAsync (string id, string token);

        /// <summary>
        /// Delete an existing report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReportAsyncWithHttpInfo (string id, string token);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Object</returns>
        public Object AddOrReplaceOrValidateReport (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
             ApiResponse<Object> localVarResponse = AddOrReplaceOrValidateReportWithHttpInfo(report, token, publicRead, _private, validationOnly, import, id, label);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AddOrReplaceOrValidateReportWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            // verify the required parameter 'report' is set
            if (report == null)
                throw new ApiException(400, "Missing required parameter 'report' when calling ReportsApi->AddOrReplaceOrValidateReport");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->AddOrReplaceOrValidateReport");

            var localVarPath = "/reports/add-report";
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

                        if (publicRead != null) localVarQueryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) localVarQueryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) localVarQueryParams.Add("validation-only", Configuration.ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) localVarQueryParams.Add("import", Configuration.ApiClient.ParameterToString(import)); // query parameter
            if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (label != null) localVarQueryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
                        if (report != null && report.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(report); // http body (model) parameter
            }
            else
            {
                localVarPostBody = report; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddOrReplaceOrValidateReport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrReplaceOrValidateReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AddOrReplaceOrValidateReportAsync (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
             ApiResponse<Object> localVarResponse = await AddOrReplaceOrValidateReportAsyncWithHttpInfo(report, token, publicRead, _private, validationOnly, import, id, label);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new, update an existing report or validates a report on the fly 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="report">A JSON object containing the report</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="publicRead">Shortcut to make a report publicly readable (optional, default to null)</param>
        /// <param name="_private">Will make this report private (not readable for others; default for newly created reports) (optional, default to null)</param>
        /// <param name="validationOnly">This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional, default to null)</param>
        /// <param name="import">If set to true, the body of the request will be treated as binary report and imported into the users account (optional, default to null)</param>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional, default to null)</param>
        /// <param name="label">A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrReplaceOrValidateReportAsyncWithHttpInfo (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)
        {
            // verify the required parameter 'report' is set
            if (report == null)
                throw new ApiException(400, "Missing required parameter 'report' when calling ReportsApi->AddOrReplaceOrValidateReport");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->AddOrReplaceOrValidateReport");

            var localVarPath = "/reports/add-report";
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

                        if (publicRead != null) localVarQueryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) localVarQueryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (validationOnly != null) localVarQueryParams.Add("validation-only", Configuration.ApiClient.ParameterToString(validationOnly)); // query parameter
            if (import != null) localVarQueryParams.Add("import", Configuration.ApiClient.ParameterToString(import)); // query parameter
            if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (label != null) localVarQueryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
                        if (report != null && report.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(report); // http body (model) parameter
            }
            else
            {
                localVarPostBody = report; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddOrReplaceOrValidateReport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrReplaceOrValidateReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Object</returns>
        public Object GetParameters (string parameter = null)
        {
             ApiResponse<Object> localVarResponse = GetParametersWithHttpInfo(parameter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetParametersWithHttpInfo (string parameter = null)
        {

            var localVarPath = "/reports/parameters";
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

                        if (parameter != null) localVarQueryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetParameters: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParameters: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetParametersAsync (string parameter = null)
        {
             ApiResponse<Object> localVarResponse = await GetParametersAsyncWithHttpInfo(parameter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all Report Parameters 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parameter">Only retrieve values for this parameter (optional, default to null)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetParametersAsyncWithHttpInfo (string parameter = null)
        {

            var localVarPath = "/reports/parameters";
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

                        if (parameter != null) localVarQueryParams.Add("parameter", Configuration.ApiClient.ParameterToString(parameter)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetParameters: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParameters: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
             ApiResponse<List<Object>> localVarResponse = GetReportsWithHttpInfo(token, id, user, publicRead, _private, export, onlyMetadata);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > GetReportsWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->GetReports");

            var localVarPath = "/reports/reports";
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

                        if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) localVarQueryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) localVarQueryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) localVarQueryParams.Add("export", Configuration.ApiClient.ParameterToString(export)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) localVarQueryParams.Add("onlyMetadata", Configuration.ApiClient.ParameterToString(onlyMetadata)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReports: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReports: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> GetReportsAsync (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
             ApiResponse<List<Object>> localVarResponse = await GetReportsAsyncWithHttpInfo(token, id, user, publicRead, _private, export, onlyMetadata);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all Reports 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="id">A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional, default to null)</param>
        /// <param name="user">A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) (optional, default to null)</param>
        /// <param name="publicRead">Filter listed reports to return only those that are publicly readable (optional, default to null)</param>
        /// <param name="_private">Filter listed reports to return only those that are private (optional, default to null)</param>
        /// <param name="export">If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional, default to null)</param>
        /// <param name="onlyMetadata">If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional, default to null)</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> GetReportsAsyncWithHttpInfo (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)
        {
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->GetReports");

            var localVarPath = "/reports/reports";
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

                        if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (publicRead != null) localVarQueryParams.Add("public-read", Configuration.ApiClient.ParameterToString(publicRead)); // query parameter
            if (_private != null) localVarQueryParams.Add("private", Configuration.ApiClient.ParameterToString(_private)); // query parameter
            if (export != null) localVarQueryParams.Add("export", Configuration.ApiClient.ParameterToString(export)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (onlyMetadata != null) localVarQueryParams.Add("onlyMetadata", Configuration.ApiClient.ParameterToString(onlyMetadata)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReports: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReports: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns></returns>
        public void RemoveReport (string id, string token)
        {
             RemoveReportWithHttpInfo(id, token);
        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveReportWithHttpInfo (string id, string token)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ReportsApi->RemoveReport");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->RemoveReport");

            var localVarPath = "/reports/delete-report";
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

                        if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RemoveReport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RemoveReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveReportAsync (string id, string token)
        {
             await RemoveReportAsyncWithHttpInfo(id, token);

        }

        /// <summary>
        /// Delete an existing report 
        /// </summary>
        /// <exception cref="CellStore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A report id (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReportAsyncWithHttpInfo (string id, string token)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ReportsApi->RemoveReport");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling ReportsApi->RemoveReport");

            var localVarPath = "/reports/delete-report";
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

                        if (id != null) localVarQueryParams.Add("_id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RemoveReport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RemoveReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
