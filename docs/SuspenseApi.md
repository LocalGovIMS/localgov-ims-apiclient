# LocalGovImsApiClient.Api.SuspenseApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SuspenseGet**](SuspenseApi.md#suspenseget) | **GET** /api/Suspense/{id} | 
[**SuspensePost**](SuspenseApi.md#suspensepost) | **POST** /api/Suspense | 
[**SuspenseSearch**](SuspenseApi.md#suspensesearch) | **GET** /api/Suspense | 


<a name="suspenseget"></a>
# **SuspenseGet**
> SuspenseModel SuspenseGet (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class SuspenseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SuspenseApi(config);
            var id = 56;  // int | 

            try
            {
                SuspenseModel result = apiInstance.SuspenseGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuspenseApi.SuspenseGet: " + e.Message );
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
 **id** | **int**|  | 

### Return type

[**SuspenseModel**](SuspenseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suspensepost"></a>
# **SuspensePost**
> SuspenseModel SuspensePost (SuspenseModel suspenseModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class SuspensePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SuspenseApi(config);
            var suspenseModel = new SuspenseModel(); // SuspenseModel | 

            try
            {
                SuspenseModel result = apiInstance.SuspensePost(suspenseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuspenseApi.SuspensePost: " + e.Message );
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
 **suspenseModel** | [**SuspenseModel**](SuspenseModel.md)|  | 

### Return type

[**SuspenseModel**](SuspenseModel.md)

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

<a name="suspensesearch"></a>
# **SuspenseSearch**
> List&lt;SuspenseModel&gt; SuspenseSearch (DateTime? createdAtDateFrom = null, DateTime? createdAtDateTo = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class SuspenseSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SuspenseApi(config);
            var createdAtDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var createdAtDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                List<SuspenseModel> result = apiInstance.SuspenseSearch(createdAtDateFrom, createdAtDateTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuspenseApi.SuspenseSearch: " + e.Message );
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
 **createdAtDateFrom** | **DateTime?**|  | [optional] 
 **createdAtDateTo** | **DateTime?**|  | [optional] 

### Return type

[**List&lt;SuspenseModel&gt;**](SuspenseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

