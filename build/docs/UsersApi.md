# CellStore.Api.UsersApi

All URIs are relative to *http://fix-aid-cardinality.28.io/v1/_queries/public*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditUser**](UsersApi.md#edituser) | **POST** /users/edit | Change a user firstname and lastname, and, optionally, his email.
[**ForgotPassword**](UsersApi.md#forgotpassword) | **POST** /users/forgotPassword | Send an email with the reset password token.
[**GetUser**](UsersApi.md#getuser) | **GET** /users/get | Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
[**IsAuthorized**](UsersApi.md#isauthorized) | **POST** /users/isAuthorized | Checks to see if the current logged in user has a particular right
[**NewUser**](UsersApi.md#newuser) | **POST** /users/new | Create a new user record
[**ResetPassword**](UsersApi.md#resetpassword) | **POST** /users/resetPassword | Change a user password
[**SetPassword**](UsersApi.md#setpassword) | **POST** /users/setPassword | Set the password for a user based on email and the reset password token


# **EditUser**
> Outcome EditUser (string firstname, string lastname, string token, string newemail = null, string email = null, string password = null)

Change a user firstname and lastname, and, optionally, his email.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class EditUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var firstname = firstname_example;  // string | The user new first name (default to null)
            var lastname = lastname_example;  // string | The user new last name (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var newemail = newemail_example;  // string | The user new email (optional)  (default to null)
            var email = email_example;  // string | Current email of the authorized user (needed if changing the email) (optional)  (default to null)
            var password = password_example;  // string | Current password of the authorized user (needed if changing the email) (optional)  (default to null)

            try
            {
                // Change a user firstname and lastname, and, optionally, his email.
                Outcome result = apiInstance.EditUser(firstname, lastname, token, newemail, email, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.EditUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstname** | **string**| The user new first name | [default to null]
 **lastname** | **string**| The user new last name | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **newemail** | **string**| The user new email | [optional] [default to null]
 **email** | **string**| Current email of the authorized user (needed if changing the email) | [optional] [default to null]
 **password** | **string**| Current password of the authorized user (needed if changing the email) | [optional] [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ForgotPassword**
> Outcome ForgotPassword (string email)

Send an email with the reset password token.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class ForgotPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var email = email_example;  // string | The user email (default to null)

            try
            {
                // Send an email with the reset password token.
                Outcome result = apiInstance.ForgotPassword(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ForgotPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The user email | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetUser**
> Object GetUser (string token, string userid = null, string email = null)

Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var userid = userid_example;  // string | A user ID (optional)  (default to null)
            var email = email_example;  // string | A user email address (optional)  (default to null)

            try
            {
                // Retrieve user record by user ID or email. If no user ID or email is specified, the record of the current user is returned.
                Object result = apiInstance.GetUser(token, userid, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **userid** | **string**| A user ID | [optional] [default to null]
 **email** | **string**| A user email address | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **IsAuthorized**
> Outcome IsAuthorized (string right, string token)

Checks to see if the current logged in user has a particular right

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class IsAuthorizedExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var right = right_example;  // string | The right id (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // Checks to see if the current logged in user has a particular right
                Outcome result = apiInstance.IsAuthorized(right, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.IsAuthorized: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **right** | **string**| The right id | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **NewUser**
> Outcome NewUser (string firstname, string lastname, string email, string password)

Create a new user record

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class NewUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var firstname = firstname_example;  // string | The new user first name (default to null)
            var lastname = lastname_example;  // string | The new user last name (default to null)
            var email = email_example;  // string | The new user email (default to null)
            var password = password_example;  // string | The new user password (default to null)

            try
            {
                // Create a new user record
                Outcome result = apiInstance.NewUser(firstname, lastname, email, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.NewUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstname** | **string**| The new user first name | [default to null]
 **lastname** | **string**| The new user last name | [default to null]
 **email** | **string**| The new user email | [default to null]
 **password** | **string**| The new user password | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ResetPassword**
> Outcome ResetPassword (string newpassword, string email, string password, string token)

Change a user password

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var newpassword = newpassword_example;  // string | New password (default to null)
            var email = email_example;  // string | Email of the authorized user (default to null)
            var password = password_example;  // string | Password of the authorized user (default to null)
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)

            try
            {
                // Change a user password
                Outcome result = apiInstance.ResetPassword(newpassword, email, password, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ResetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newpassword** | **string**| New password | [default to null]
 **email** | **string**| Email of the authorized user | [default to null]
 **password** | **string**| Password of the authorized user | [default to null]
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SetPassword**
> Outcome SetPassword (string email, string password, string resetToken)

Set the password for a user based on email and the reset password token

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class SetPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var email = email_example;  // string | The email of the user to set the password (default to null)
            var password = password_example;  // string | The new password (default to null)
            var resetToken = resetToken_example;  // string | The reset password token (default to null)

            try
            {
                // Set the password for a user based on email and the reset password token
                Outcome result = apiInstance.SetPassword(email, password, resetToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email of the user to set the password | [default to null]
 **password** | **string**| The new password | [default to null]
 **resetToken** | **string**| The reset password token | [default to null]

### Return type

[**Outcome**](Outcome.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

