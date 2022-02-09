# LocalGovImsApiClient.Api.FundMetadataApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FundMetadataGet**](FundMetadataApi.md#fundmetadataget) | **GET** /api/FundMetadata/{key}/{fundCode} | 


<a name="fundmetadataget"></a>
# **FundMetadataGet**
> FundMetadataModel FundMetadataGet (string fundCode, string key)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class FundMetadataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FundMetadataApi(config);
            var fundCode = "fundCode_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                FundMetadataModel result = apiInstance.FundMetadataGet(fundCode, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundMetadataApi.FundMetadataGet: " + e.Message );
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
 **fundCode** | **string**|  | 
 **key** | **string**|  | 

### Return type

[**FundMetadataModel**](FundMetadataModel.md)

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

