# LocalGovImsApiClient - the C# library for the LocalGovImsApi

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LocalGovImsApiClient.Api;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountHoldersApi.AccountHoldersGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountHoldersApi* | [**AccountHoldersGet**](docs/AccountHoldersApi.md#accountholdersget) | **GET** /api/AccountHolders/{reference} | 
*AccountHoldersApi* | [**AccountHoldersPatch**](docs/AccountHoldersApi.md#accountholderspatch) | **PATCH** /api/AccountHolders | 
*AccountHoldersApi* | [**AccountHoldersPost**](docs/AccountHoldersApi.md#accountholderspost) | **POST** /api/AccountHolders | 
*FundMetadataApi* | [**FundMetadataGet**](docs/FundMetadataApi.md#fundmetadataget) | **GET** /api/FundMetadata/{key}/{fundCode} | 
*FundsApi* | [**FundsGet**](docs/FundsApi.md#fundsget) | **GET** /api/Funds/{fundCode} | 
*MethodOfPaymentsApi* | [**MethodOfPaymentsSearch**](docs/MethodOfPaymentsApi.md#methodofpaymentssearch) | **GET** /api/MethodOfPayments | 
*NotificationApi* | [**NotificationPost**](docs/NotificationApi.md#notificationpost) | **POST** /api/Notification | 
*PendingTransactionsApi* | [**PendingTransactionsAuthorise**](docs/PendingTransactionsApi.md#pendingtransactionsauthorise) | **POST** /api/PendingTransaction/{reference}/Authorise | 
*PendingTransactionsApi* | [**PendingTransactionsGet**](docs/PendingTransactionsApi.md#pendingtransactionsget) | **GET** /api/PendingTransactions/{reference} | 
*PendingTransactionsApi* | [**PendingTransactionsPost**](docs/PendingTransactionsApi.md#pendingtransactionspost) | **POST** /api/PendingTransactions | 
*PendingTransactionsApi* | [**PendingTransactionsProcessPayment**](docs/PendingTransactionsApi.md#pendingtransactionsprocesspayment) | **POST** /api/PendingTransaction/{reference}/ProcessPayment | 
*ProcessedTransactionsApi* | [**ProcessedTransactionsGet**](docs/ProcessedTransactionsApi.md#processedtransactionsget) | **GET** /api/ProcessedTransactions/{reference} | 
*ProcessedTransactionsApi* | [**ProcessedTransactionsPost**](docs/ProcessedTransactionsApi.md#processedtransactionspost) | **POST** /api/ProcessedTransactions | 
*ProcessedTransactionsApi* | [**ProcessedTransactionsSearch**](docs/ProcessedTransactionsApi.md#processedtransactionssearch) | **GET** /api/ProcessedTransactions | 
*SuspenseApi* | [**SuspenseGet**](docs/SuspenseApi.md#suspenseget) | **GET** /api/Suspense/{id} | 
*SuspenseApi* | [**SuspensePost**](docs/SuspenseApi.md#suspensepost) | **POST** /api/Suspense | 
*SuspenseApi* | [**SuspenseSearch**](docs/SuspenseApi.md#suspensesearch) | **GET** /api/Suspense | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountHolderModel](docs/AccountHolderModel.md)
 - [Model.AuthoriseModel](docs/AuthoriseModel.md)
 - [Model.FundMetadataModel](docs/FundMetadataModel.md)
 - [Model.FundModel](docs/FundModel.md)
 - [Model.MethodOfPaymentModel](docs/MethodOfPaymentModel.md)
 - [Model.NotificationModel](docs/NotificationModel.md)
 - [Model.PendingTransactionModel](docs/PendingTransactionModel.md)
 - [Model.ProcessPaymentModel](docs/ProcessPaymentModel.md)
 - [Model.ProcessPaymentResponse](docs/ProcessPaymentResponse.md)
 - [Model.ProcessedTransactionModel](docs/ProcessedTransactionModel.md)
 - [Model.SuspenseModel](docs/SuspenseModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
