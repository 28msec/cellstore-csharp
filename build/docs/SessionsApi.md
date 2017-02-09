# CellStore.Api.SessionsApi

All URIs are relative to *http://fcavalieri.com:28080/secxbrl/v1/_queries/public*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](SessionsApi.md#login) | **POST** /session/login | Login with email and password in order to retrieve a token.
[**Logout**](SessionsApi.md#logout) | **POST** /session/logout | Logout the user identified by the given API key.
[**Revoke**](SessionsApi.md#revoke) | **POST** /session/revoke | Revoke a token having a custom expiration duration.
[**SetPermissions**](SessionsApi.md#setpermissions) | **PUT** /session/permissions | Updates the cellstore users and permissions
[**Token**](SessionsApi.md#token) | **POST** /session/token | Create a token having a custom expiration duration.
[**Tokens**](SessionsApi.md#tokens) | **GET** /session/tokens | List tokens of a user identified by its token.


<a name="login"></a>
# **Login**
> Object Login (string email, string password)

Login with email and password in order to retrieve a token.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var email = email_example;  // string | Email of user to login (default to null)
            var password = password_example;  // string | Password of user to login (default to null)

            try
            {
                // Login with email and password in order to retrieve a token.
                Object result = apiInstance.Login(email, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of user to login | [default to null]
 **password** | **string**| Password of user to login | [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> Outcome Logout (string token)

Logout the user identified by the given API key.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // Logout the user identified by the given API key.
                Outcome result = apiInstance.Logout(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revoke"></a>
# **Revoke**
> Outcome Revoke (string email, string password, string token)

Revoke a token having a custom expiration duration.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class RevokeExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var email = email_example;  // string | Email of user that owns the token (default to null)
            var password = password_example;  // string | Password of user that owns the token (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // Revoke a token having a custom expiration duration.
                Outcome result = apiInstance.Revoke(email, password, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Revoke: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of user that owns the token | [default to null]
 **password** | **string**| Password of user that owns the token | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpermissions"></a>
# **SetPermissions**
> Object SetPermissions (string token, Object permissions)

Updates the cellstore users and permissions

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class SetPermissionsExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var permissions = ;  // Object | The permissions and user definitions. (default to null)

            try
            {
                // Updates the cellstore users and permissions
                Object result = apiInstance.SetPermissions(token, permissions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.SetPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **permissions** | **Object**| The permissions and user definitions. | [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="token"></a>
# **Token**
> Object Token (string email, string password, string expiration)

Create a token having a custom expiration duration.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class TokenExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var email = email_example;  // string | Email of user that creates the token (default to null)
            var password = password_example;  // string | Password of user that creates the token (default to null)
            var expiration = expiration_example;  // string | Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z) (default to null)

            try
            {
                // Create a token having a custom expiration duration.
                Object result = apiInstance.Token(email, password, expiration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Token: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of user that creates the token | [default to null]
 **password** | **string**| Password of user that creates the token | [default to null]
 **expiration** | **string**| Expiration of the token, in ISO format (e.g.: 2014-04-29T14:32:05.0321Z) | [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokens"></a>
# **Tokens**
> Object Tokens (string token)

List tokens of a user identified by its token.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class TokensExample
    {
        public void main()
        {
            
            var apiInstance = new SessionsApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // List tokens of a user identified by its token.
                Object result = apiInstance.Tokens(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.Tokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

