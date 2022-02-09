# LocalGovImsApiClient.Api.MethodOfPaymentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MethodOfPaymentsSearch**](MethodOfPaymentsApi.md#methodofpaymentssearch) | **GET** /api/MethodOfPayments | 


<a name="methodofpaymentssearch"></a>
# **MethodOfPaymentsSearch**
> List&lt;MethodOfPaymentModel&gt; MethodOfPaymentsSearch (string type = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class MethodOfPaymentsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MethodOfPaymentsApi(config);
            var type = "type_example";  // string |  (optional) 

            try
            {
                List<MethodOfPaymentModel> result = apiInstance.MethodOfPaymentsSearch(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MethodOfPaymentsApi.MethodOfPaymentsSearch: " + e.Message );
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
 **type** | **string**|  | [optional] 

### Return type

[**List&lt;MethodOfPaymentModel&gt;**](MethodOfPaymentModel.md)

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

