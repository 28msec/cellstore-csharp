# CellStore.Api.ReportsApi

All URIs are relative to *http://secxbrl.28.io/v1/_queries/public*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrReplaceOrValidateReport**](ReportsApi.md#addorreplaceorvalidatereport) | **POST** /reports/add-report | Add a new, update an existing report or validates a report on the fly
[**GetParameters**](ReportsApi.md#getparameters) | **POST** /reports/parameters | Retrieve a list of all Report Parameters
[**GetReports**](ReportsApi.md#getreports) | **GET** /reports/reports | Retrieve a list of all Reports
[**RemoveReport**](ReportsApi.md#removereport) | **POST** /reports/delete-report | Delete an existing report


# **AddOrReplaceOrValidateReport**
> Object AddOrReplaceOrValidateReport (Object report, string token, bool? publicRead = null, bool? _private = null, bool? validationOnly = null, bool? import = null, string id = null, string label = null)

Add a new, update an existing report or validates a report on the fly

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddOrReplaceOrValidateReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var report = ;  // Object | A JSON object containing the report (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var publicRead = true;  // bool? | Shortcut to make a report publicly readable (optional)  (default to null)
            var _private = true;  // bool? | Will make this report private (not readable for others; default for newly created reports) (optional)  (default to null)
            var validationOnly = true;  // bool? | This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off (optional)  (default to null)
            var import = true;  // bool? | If set to true, the body of the request will be treated as binary report and imported into the users account (optional)  (default to null)
            var id = id_example;  // string | A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report (optional)  (default to null)
            var label = label_example;  // string | A report label (e.g. 'Key Value Indicators'). Will overwrite the Label of the report given in the body (binary report as well as json report) (optional)  (default to null)

            try
            {
                // Add a new, update an existing report or validates a report on the fly
                Object result = apiInstance.AddOrReplaceOrValidateReport(report, token, publicRead, _private, validationOnly, import, id, label);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.AddOrReplaceOrValidateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | **Object**| A JSON object containing the report | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **publicRead** | **bool?**| Shortcut to make a report publicly readable | [optional] [default to null]
 **_private** | **bool?**| Will make this report private (not readable for others; default for newly created reports) | [optional] [default to null]
 **validationOnly** | **bool?**| This parameter is either given without any value (means: on) or absent (means: off) or its value is castable to a boolean. Turns validation-only mode on or off | [optional] [default to null]
 **import** | **bool?**| If set to true, the body of the request will be treated as binary report and imported into the users account | [optional] [default to null]
 **id** | **string**| A report id (e.g. FundamentalAccountingConcepts). For example, when importing a report the id can be provided to create a new report | [optional] [default to null]
 **label** | **string**| A report label (e.g. &#39;Key Value Indicators&#39;). Will overwrite the Label of the report given in the body (binary report as well as json report) | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetParameters**
> Object GetParameters (string parameter = null)

Retrieve a list of all Report Parameters

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetParametersExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var parameter = parameter_example;  // string | Only retrieve values for this parameter (optional)  (default to null)

            try
            {
                // Retrieve a list of all Report Parameters
                Object result = apiInstance.GetParameters(parameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameter** | **string**| Only retrieve values for this parameter | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReports**
> List<Object> GetReports (string token, string id = null, string user = null, bool? publicRead = null, bool? _private = null, bool? export = null, bool? onlyMetadata = null)

Retrieve a list of all Reports

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetReportsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var id = id_example;  // string | A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) (optional)  (default to null)
            var user = user_example;  // string | A user's email address to filter reports owned by this user (i.e. all reports if user = authorized user or only public-read reports of user) (optional)  (default to null)
            var publicRead = true;  // bool? | Filter listed reports to return only those that are publicly readable (optional)  (default to null)
            var _private = true;  // bool? | Filter listed reports to return only those that are private (optional)  (default to null)
            var export = true;  // bool? | If set to true a report will be retrieved in a binary format. Only a single report can be exported at once (optional)  (default to null)
            var onlyMetadata = true;  // bool? | If set to true will return only the metadata of reports instead of the complete reports. (default: false) (optional)  (default to null)

            try
            {
                // Retrieve a list of all Reports
                List&lt;Object&gt; result = apiInstance.GetReports(token, id, user, publicRead, _private, export, onlyMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **id** | **string**| A report id (e.g. 1fueA5hrxIHxvRf7Btr_J6efDJ3qp-s9KV731wDc4OOc) | [optional] [default to null]
 **user** | **string**| A user&#39;s email address to filter reports owned by this user (i.e. all reports if user &#x3D; authorized user or only public-read reports of user) | [optional] [default to null]
 **publicRead** | **bool?**| Filter listed reports to return only those that are publicly readable | [optional] [default to null]
 **_private** | **bool?**| Filter listed reports to return only those that are private | [optional] [default to null]
 **export** | **bool?**| If set to true a report will be retrieved in a binary format. Only a single report can be exported at once | [optional] [default to null]
 **onlyMetadata** | **bool?**| If set to true will return only the metadata of reports instead of the complete reports. (default: false) | [optional] [default to null]

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **RemoveReport**
> void RemoveReport (string id, string token)

Delete an existing report

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class RemoveReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | A report id (e.g. FundamentalAccountingConcepts) (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // Delete an existing report
                apiInstance.RemoveReport(id, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.RemoveReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A report id (e.g. FundamentalAccountingConcepts) | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

