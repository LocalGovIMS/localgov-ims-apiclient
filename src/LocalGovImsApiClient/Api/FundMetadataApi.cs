/*
 * LocalGovImsApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Model;

namespace LocalGovImsApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFundMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FundMetadataModel</returns>
        FundMetadataModel FundMetadataGet(string fundCode, string key, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FundMetadataModel</returns>
        ApiResponse<FundMetadataModel> FundMetadataGetWithHttpInfo(string fundCode, string key, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFundMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FundMetadataModel</returns>
        System.Threading.Tasks.Task<FundMetadataModel> FundMetadataGetAsync(string fundCode, string key, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FundMetadataModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<FundMetadataModel>> FundMetadataGetWithHttpInfoAsync(string fundCode, string key, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFundMetadataApi : IFundMetadataApiSync, IFundMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FundMetadataApi : IFundMetadataApi
    {
        private LocalGovImsApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FundMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundMetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundMetadataApi(string basePath)
        {
            this.Configuration = LocalGovImsApiClient.Client.Configuration.MergeConfigurations(
                LocalGovImsApiClient.Client.GlobalConfiguration.Instance,
                new LocalGovImsApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new LocalGovImsApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new LocalGovImsApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = LocalGovImsApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundMetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FundMetadataApi(LocalGovImsApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = LocalGovImsApiClient.Client.Configuration.MergeConfigurations(
                LocalGovImsApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new LocalGovImsApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new LocalGovImsApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = LocalGovImsApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundMetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FundMetadataApi(LocalGovImsApiClient.Client.ISynchronousClient client, LocalGovImsApiClient.Client.IAsynchronousClient asyncClient, LocalGovImsApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = LocalGovImsApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public LocalGovImsApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public LocalGovImsApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public LocalGovImsApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public LocalGovImsApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FundMetadataModel</returns>
        public FundMetadataModel FundMetadataGet(string fundCode, string key, int operationIndex = 0)
        {
            LocalGovImsApiClient.Client.ApiResponse<FundMetadataModel> localVarResponse = FundMetadataGetWithHttpInfo(fundCode, key);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FundMetadataModel</returns>
        public LocalGovImsApiClient.Client.ApiResponse<FundMetadataModel> FundMetadataGetWithHttpInfo(string fundCode, string key, int operationIndex = 0)
        {
            // verify the required parameter 'fundCode' is set
            if (fundCode == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'fundCode' when calling FundMetadataApi->FundMetadataGet");
            }

            // verify the required parameter 'key' is set
            if (key == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'key' when calling FundMetadataApi->FundMetadataGet");
            }

            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = LocalGovImsApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = LocalGovImsApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("fundCode", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(fundCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("key", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(key)); // path parameter

            localVarRequestOptions.Operation = "FundMetadataApi.FundMetadataGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<FundMetadataModel>("/api/FundMetadata/{key}/{fundCode}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FundMetadataGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FundMetadataModel</returns>
        public async System.Threading.Tasks.Task<FundMetadataModel> FundMetadataGetAsync(string fundCode, string key, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            LocalGovImsApiClient.Client.ApiResponse<FundMetadataModel> localVarResponse = await FundMetadataGetWithHttpInfoAsync(fundCode, key, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fundCode"></param>
        /// <param name="key"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FundMetadataModel)</returns>
        public async System.Threading.Tasks.Task<LocalGovImsApiClient.Client.ApiResponse<FundMetadataModel>> FundMetadataGetWithHttpInfoAsync(string fundCode, string key, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'fundCode' is set
            if (fundCode == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'fundCode' when calling FundMetadataApi->FundMetadataGet");
            }

            // verify the required parameter 'key' is set
            if (key == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'key' when calling FundMetadataApi->FundMetadataGet");
            }


            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = LocalGovImsApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = LocalGovImsApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("fundCode", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(fundCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("key", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(key)); // path parameter

            localVarRequestOptions.Operation = "FundMetadataApi.FundMetadataGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<FundMetadataModel>("/api/FundMetadata/{key}/{fundCode}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FundMetadataGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
