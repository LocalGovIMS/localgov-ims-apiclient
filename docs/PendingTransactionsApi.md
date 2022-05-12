# LocalGovImsApiClient.Api.PendingTransactionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PendingTransactionsAuthorise**](PendingTransactionsApi.md#pendingtransactionsauthorise) | **POST** /api/PendingTransaction/{reference}/Authorise | 
[**PendingTransactionsGet**](PendingTransactionsApi.md#pendingtransactionsget) | **GET** /api/PendingTransactions/{reference} | 
[**PendingTransactionsPost**](PendingTransactionsApi.md#pendingtransactionspost) | **POST** /api/PendingTransactions | 
[**PendingTransactionsProcessFee**](PendingTransactionsApi.md#pendingtransactionsprocessfee) | **POST** /api/ProcessedTransactions/{reference}/ProcessFee | 
[**PendingTransactionsProcessPayment**](PendingTransactionsApi.md#pendingtransactionsprocesspayment) | **POST** /api/PendingTransaction/{reference}/ProcessPayment | 


<a name="pendingtransactionsauthorise"></a>
# **PendingTransactionsAuthorise**
> void PendingTransactionsAuthorise (string reference, AuthoriseModel authoriseModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class PendingTransactionsAuthoriseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PendingTransactionsApi(config);
            var reference = "reference_example";  // string | 
            var authoriseModel = new AuthoriseModel(); // AuthoriseModel | 

            try
            {
                apiInstance.PendingTransactionsAuthorise(reference, authoriseModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PendingTransactionsApi.PendingTransactionsAuthorise: " + e.Message );
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
 **authoriseModel** | [**AuthoriseModel**](AuthoriseModel.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pendingtransactionsget"></a>
# **PendingTransactionsGet**
> List&lt;PendingTransactionModel&gt; PendingTransactionsGet (string reference)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class PendingTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PendingTransactionsApi(config);
            var reference = "reference_example";  // string | 

            try
            {
                List<PendingTransactionModel> result = apiInstance.PendingTransactionsGet(reference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PendingTransactionsApi.PendingTransactionsGet: " + e.Message );
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

[**List&lt;PendingTransactionModel&gt;**](PendingTransactionModel.md)

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

<a name="pendingtransactionspost"></a>
# **PendingTransactionsPost**
> List&lt;PendingTransactionModel&gt; PendingTransactionsPost (PendingTransactionModel pendingTransactionModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class PendingTransactionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PendingTransactionsApi(config);
            var pendingTransactionModel = new PendingTransactionModel(); // PendingTransactionModel | 

            try
            {
                List<PendingTransactionModel> result = apiInstance.PendingTransactionsPost(pendingTransactionModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PendingTransactionsApi.PendingTransactionsPost: " + e.Message );
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
 **pendingTransactionModel** | [**PendingTransactionModel**](PendingTransactionModel.md)|  | 

### Return type

[**List&lt;PendingTransactionModel&gt;**](PendingTransactionModel.md)

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

<a name="pendingtransactionsprocessfee"></a>
# **PendingTransactionsProcessFee**
> void PendingTransactionsProcessFee (string reference, ProcessFeeModel processFeeModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class PendingTransactionsProcessFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PendingTransactionsApi(config);
            var reference = "reference_example";  // string | 
            var processFeeModel = new ProcessFeeModel(); // ProcessFeeModel | 

            try
            {
                apiInstance.PendingTransactionsProcessFee(reference, processFeeModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PendingTransactionsApi.PendingTransactionsProcessFee: " + e.Message );
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
 **processFeeModel** | [**ProcessFeeModel**](ProcessFeeModel.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pendingtransactionsprocesspayment"></a>
# **PendingTransactionsProcessPayment**
> ProcessPaymentResponse PendingTransactionsProcessPayment (string reference, ProcessPaymentModel processPaymentModel)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class PendingTransactionsProcessPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PendingTransactionsApi(config);
            var reference = "reference_example";  // string | 
            var processPaymentModel = new ProcessPaymentModel(); // ProcessPaymentModel | 

            try
            {
                ProcessPaymentResponse result = apiInstance.PendingTransactionsProcessPayment(reference, processPaymentModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PendingTransactionsApi.PendingTransactionsProcessPayment: " + e.Message );
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
 **processPaymentModel** | [**ProcessPaymentModel**](ProcessPaymentModel.md)|  | 

### Return type

[**ProcessPaymentResponse**](ProcessPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

