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
    public interface INotificationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <returns></returns>
        void NotificationPost(NotificationModel notificationModel);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> NotificationPostWithHttpInfo(NotificationModel notificationModel);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task NotificationPostAsync(NotificationModel notificationModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NotificationPostWithHttpInfoAsync(NotificationModel notificationModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationApi : INotificationApiSync, INotificationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NotificationApi : INotificationApi
    {
        private LocalGovImsApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="NotificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationApi(LocalGovImsApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="NotificationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NotificationApi(LocalGovImsApiClient.Client.ISynchronousClient client, LocalGovImsApiClient.Client.IAsynchronousClient asyncClient, LocalGovImsApiClient.Client.IReadableConfiguration configuration)
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
        /// <param name="notificationModel"></param>
        /// <returns></returns>
        public void NotificationPost(NotificationModel notificationModel)
        {
            NotificationPostWithHttpInfo(notificationModel);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public LocalGovImsApiClient.Client.ApiResponse<Object> NotificationPostWithHttpInfo(NotificationModel notificationModel)
        {
            // verify the required parameter 'notificationModel' is set
            if (notificationModel == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'notificationModel' when calling NotificationApi->NotificationPost");
            }

            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
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

            localVarRequestOptions.Data = notificationModel;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/Notification", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NotificationPost", localVarResponse);
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
        /// <param name="notificationModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task NotificationPostAsync(NotificationModel notificationModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await NotificationPostWithHttpInfoAsync(notificationModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LocalGovImsApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationModel"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<LocalGovImsApiClient.Client.ApiResponse<Object>> NotificationPostWithHttpInfoAsync(NotificationModel notificationModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'notificationModel' is set
            if (notificationModel == null)
            {
                throw new LocalGovImsApiClient.Client.ApiException(400, "Missing required parameter 'notificationModel' when calling NotificationApi->NotificationPost");
            }


            LocalGovImsApiClient.Client.RequestOptions localVarRequestOptions = new LocalGovImsApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
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

            localVarRequestOptions.Data = notificationModel;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/Notification", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NotificationPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}