# LocalGovImsApiClient.Api.AccountHoldersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountHoldersGet**](AccountHoldersApi.md#accountholdersget) | **GET** /api/AccountHolders/{reference} | 
[**AccountHoldersPatch**](AccountHoldersApi.md#accountholderspatch) | **PATCH** /api/AccountHolders | 
[**AccountHoldersPost**](AccountHoldersApi.md#accountholderspost) | **POST** /api/AccountHolders | 


<a name="accountholdersget"></a>
# **AccountHoldersGet**
> AccountHolderModel AccountHoldersGet (string reference)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class AccountHoldersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountHoldersApi(config);
            var reference = "reference_example";  // string | 

            try
            {
                AccountHolderModel result = apiInstance.AccountHoldersGet(reference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountHoldersApi.AccountHoldersGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**|  | 

### Return type

[**AccountHolderModel**](AccountHolderModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not found |  -  |
| **200** | OK |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountholderspatch"></a>
# **AccountHoldersPatch**
> AccountHolderModel AccountHoldersPatch (AccountHolderModel accountHolderModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class AccountHoldersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountHoldersApi(config);
            var accountHolderModel = new AccountHolderModel(); // AccountHolderModel | 

            try
            {
                AccountHolderModel result = apiInstance.AccountHoldersPatch(accountHolderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountHoldersApi.AccountHoldersPatch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountHolderModel** | [**AccountHolderModel**](AccountHolderModel.md)|  | 

### Return type

[**AccountHolderModel**](AccountHolderModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountholderspost"></a>
# **AccountHoldersPost**
> AccountHolderModel AccountHoldersPost (AccountHolderModel accountHolderModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class AccountHoldersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountHoldersApi(config);
            var accountHolderModel = new AccountHolderModel(); // AccountHolderModel | 

            try
            {
                AccountHolderModel result = apiInstance.AccountHoldersPost(accountHolderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountHoldersApi.AccountHoldersPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountHolderModel** | [**AccountHolderModel**](AccountHolderModel.md)|  | 

### Return type

[**AccountHolderModel**](AccountHolderModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

