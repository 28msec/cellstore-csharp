# CellStore.Api.DefaultApi

All URIs are relative to *http://secxbrl-24-2-0.28.io/v1/_queries/public*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDocs**](DefaultApi.md#getdocs) | **GET** /api/docs | Get the documentation of the CellStore API.


# **GetDocs**
> Object GetDocs ()

Get the documentation of the CellStore API.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetDocsExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();

            try
            {
                // Get the documentation of the CellStore API.
                Object result = apiInstance.GetDocs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDocs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

