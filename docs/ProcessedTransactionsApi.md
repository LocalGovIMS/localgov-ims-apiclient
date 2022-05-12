# LocalGovImsApiClient.Api.ProcessedTransactionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessedTransactionsGet**](ProcessedTransactionsApi.md#processedtransactionsget) | **GET** /api/ProcessedTransactions/{reference} | 
[**ProcessedTransactionsPost**](ProcessedTransactionsApi.md#processedtransactionspost) | **POST** /api/ProcessedTransactions | 
[**ProcessedTransactionsSearch**](ProcessedTransactionsApi.md#processedtransactionssearch) | **GET** /api/ProcessedTransactions | 


<a name="processedtransactionsget"></a>
# **ProcessedTransactionsGet**
> ProcessedTransactionModel ProcessedTransactionsGet (string reference)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class ProcessedTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProcessedTransactionsApi(config);
            var reference = "reference_example";  // string | 

            try
            {
                ProcessedTransactionModel result = apiInstance.ProcessedTransactionsGet(reference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedTransactionsApi.ProcessedTransactionsGet: " + e.Message );
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

[**ProcessedTransactionModel**](ProcessedTransactionModel.md)

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

<a name="processedtransactionspost"></a>
# **ProcessedTransactionsPost**
> ProcessedTransactionModel ProcessedTransactionsPost (ProcessedTransactionModel processedTransactionModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class ProcessedTransactionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProcessedTransactionsApi(config);
            var processedTransactionModel = new ProcessedTransactionModel(); // ProcessedTransactionModel | 

            try
            {
                ProcessedTransactionModel result = apiInstance.ProcessedTransactionsPost(processedTransactionModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedTransactionsApi.ProcessedTransactionsPost: " + e.Message );
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
 **processedTransactionModel** | [**ProcessedTransactionModel**](ProcessedTransactionModel.md)|  | 

### Return type

[**ProcessedTransactionModel**](ProcessedTransactionModel.md)

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

<a name="processedtransactionssearch"></a>
# **ProcessedTransactionsSearch**
> List&lt;ProcessedTransactionModel&gt; ProcessedTransactionsSearch (string receiptNumber = null, List<string> fundCodes = null, string accountReference = null, decimal? amount = null, DateTime? startDate = null, DateTime? endDate = null, string appReference = null, List<string> mopCodes = null, string narrative = null, string internalReference = null, string pspReference = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class ProcessedTransactionsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProcessedTransactionsApi(config);
            var receiptNumber = "receiptNumber_example";  // string |  (optional) 
            var fundCodes = new List<string>(); // List<string> |  (optional) 
            var accountReference = "accountReference_example";  // string |  (optional) 
            var amount = 8.14D;  // decimal? |  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var appReference = "appReference_example";  // string |  (optional) 
            var mopCodes = new List<string>(); // List<string> |  (optional) 
            var narrative = "narrative_example";  // string |  (optional) 
            var internalReference = "internalReference_example";  // string |  (optional) 
            var pspReference = "pspReference_example";  // string |  (optional) 

            try
            {
                List<ProcessedTransactionModel> result = apiInstance.ProcessedTransactionsSearch(receiptNumber, fundCodes, accountReference, amount, startDate, endDate, appReference, mopCodes, narrative, internalReference, pspReference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedTransactionsApi.ProcessedTransactionsSearch: " + e.Message );
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
 **receiptNumber** | **string**|  | [optional] 
 **fundCodes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **accountReference** | **string**|  | [optional] 
 **amount** | **decimal?**|  | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **appReference** | **string**|  | [optional] 
 **mopCodes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **narrative** | **string**|  | [optional] 
 **internalReference** | **string**|  | [optional] 
 **pspReference** | **string**|  | [optional] 

### Return type

[**List&lt;ProcessedTransactionModel&gt;**](ProcessedTransactionModel.md)

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

