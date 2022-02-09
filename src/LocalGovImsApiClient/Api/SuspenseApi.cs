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
    public interface ISuspenseApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>SuspenseModel</returns>
        SuspenseModel SuspenseGet(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of SuspenseModel</returns>
        ApiResponse<SuspenseModel> SuspenseGetWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <returns>SuspenseModel</returns>
        SuspenseModel SuspensePost(SuspenseModel suspenseModel);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <returns>ApiResponse of SuspenseModel</returns>
        ApiResponse<SuspenseModel> SuspensePostWithHttpInfo(SuspenseModel suspenseModel);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <returns>List&lt;SuspenseModel&gt;</returns>
        List<SuspenseModel> SuspenseSearch(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SuspenseModel&gt;</returns>
        ApiResponse<List<SuspenseModel>> SuspenseSearchWithHttpInfo(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISuspenseApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspenseModel</returns>
        System.Threading.Tasks.Task<SuspenseModel> SuspenseGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspenseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspenseModel>> SuspenseGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspenseModel</returns>
        System.Threading.Tasks.Task<SuspenseModel> SuspensePostAsync(SuspenseModel suspenseModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspenseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspenseModel>> SuspensePostWithHttpInfoAsync(SuspenseModel suspenseModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SuspenseModel&gt;</returns>
        System.Threading.Tasks.Task<List<SuspenseModel>> SuspenseSearchAsync(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SuspenseModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SuspenseModel>>> SuspenseSearchWithHttpInfoAsync(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISuspenseApi : ISuspenseApiSync, ISuspenseApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SuspenseApi : ISuspenseApi
    {
        private LocalGovImsApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspenseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuspenseApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspenseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuspenseApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SuspenseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SuspenseApi(LocalGovImsApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SuspenseApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SuspenseApi(LocalGovImsApiClient.Client.ISynchronousClient client, LocalGovImsApiClient.Client.IAsynchronousClient asyncClient, LocalGovImsApiClient.Client.IReadableConfiguration configuration)
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
        /// <param name="id"></param>
        /// <returns>SuspenseModel</returns>
        public SuspenseModel SuspenseGet(int id)
        {
            LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> localVarResponse = SuspenseGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of SuspenseModel</returns>
        public LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> SuspenseGetWithHttpInfo(int id)
        {
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

            localVarRequestOptions.PathParameters.Add("id", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<SuspenseModel>("/api/Suspense/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspenseGet", localVarResponse);
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
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspenseModel</returns>
        public async System.Threading.Tasks.Task<SuspenseModel> SuspenseGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> localVarResponse = await SuspenseGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspenseModel)</returns>
        public async System.Threading.Tasks.Task<LocalGovImsApiClient.Client.ApiResponse<SuspenseModel>> SuspenseGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("id", LocalGovImsApiClient.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SuspenseModel>("/api/Suspense/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspenseGet", localVarResponse);
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
        /// <param name="suspenseModel"></param>
        /// <returns>SuspenseModel</returns>
        public SuspenseModel SuspensePost(SuspenseModel suspenseModel)
        {
            LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> localVarResponse = SuspensePostWithHttpInfo(suspenseModel);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <returns>ApiResponse of SuspenseModel</returns>
        public LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> SuspensePostWithHttpInfo(SuspenseModel suspenseModel)
        {
            // verify the required parameter 'suspenseModel' is set
            if (suspenseModel == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'suspenseModel' when calling SuspenseApi->SuspensePost");
            }

            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.Data = suspenseModel;


            // make the HTTP request
            var localVarResponse = this.Client.Post<SuspenseModel>("/api/Suspense", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspensePost", localVarResponse);
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
        /// <param name="suspenseModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspenseModel</returns>
        public async System.Threading.Tasks.Task<SuspenseModel> SuspensePostAsync(SuspenseModel suspenseModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            LocalGovImsApiClient.Client.ApiResponse<SuspenseModel> localVarResponse = await SuspensePostWithHttpInfoAsync(suspenseModel, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="suspenseModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspenseModel)</returns>
        public async System.Threading.Tasks.Task<LocalGovImsApiClient.Client.ApiResponse<SuspenseModel>> SuspensePostWithHttpInfoAsync(SuspenseModel suspenseModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'suspenseModel' is set
            if (suspenseModel == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'suspenseModel' when calling SuspenseApi->SuspensePost");
            }


            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.Data = suspenseModel;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<SuspenseModel>("/api/Suspense", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspensePost", localVarResponse);
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
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <returns>List&lt;SuspenseModel&gt;</returns>
        public List<SuspenseModel> SuspenseSearch(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?))
        {
            LocalGovImsApiClient.Client.ApiResponse<List<SuspenseModel>> localVarResponse = SuspenseSearchWithHttpInfo(createdAtDateFrom, createdAtDateTo);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SuspenseModel&gt;</returns>
        public LocalGovImsApiClient.Client.ApiResponse<List<SuspenseModel>> SuspenseSearchWithHttpInfo(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?))
        {
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

            if (createdAtDateFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(LocalGovImsApiClient.Client.ClientUtils.ParameterToMultiMap("", "CreatedAtDateFrom", createdAtDateFrom));
            }
            if (createdAtDateTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(LocalGovImsApiClient.Client.ClientUtils.ParameterToMultiMap("", "CreatedAtDateTo", createdAtDateTo));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<SuspenseModel>>("/api/Suspense", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspenseSearch", localVarResponse);
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
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SuspenseModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<SuspenseModel>> SuspenseSearchAsync(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            LocalGovImsApiClient.Client.ApiResponse<List<SuspenseModel>> localVarResponse = await SuspenseSearchWithHttpInfoAsync(createdAtDateFrom, createdAtDateTo, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdAtDateFrom"> (optional)</param>
        /// <param name="createdAtDateTo"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SuspenseModel&gt;)</returns>
        public async System.Threading.Tasks.Task<LocalGovImsApiClient.Client.ApiResponse<List<SuspenseModel>>> SuspenseSearchWithHttpInfoAsync(DateTime? createdAtDateFrom = default(DateTime?), DateTime? createdAtDateTo = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            if (createdAtDateFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(LocalGovImsApiClient.Client.ClientUtils.ParameterToMultiMap("", "CreatedAtDateFrom", createdAtDateFrom));
            }
            if (createdAtDateTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(LocalGovImsApiClient.Client.ClientUtils.ParameterToMultiMap("", "CreatedAtDateTo", createdAtDateTo));
            }


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<SuspenseModel>>("/api/Suspense", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuspenseSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}