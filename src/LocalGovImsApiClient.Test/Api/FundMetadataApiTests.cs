/*
 * LocalGovImsApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using LocalGovImsApiClient.Client;
using LocalGovImsApiClient.Api;
// uncomment below to import models
//using LocalGovImsApiClient.Model;

namespace LocalGovImsApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing FundMetadataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FundMetadataApiTests : IDisposable
    {
        private FundMetadataApi instance;

        public FundMetadataApiTests()
        {
            instance = new FundMetadataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FundMetadataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FundMetadataApi
            //Assert.IsType<FundMetadataApi>(instance);
        }

        /// <summary>
        /// Test FundMetadataGet
        /// </summary>
        [Fact]
        public void FundMetadataGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fundCode = null;
            //string key = null;
            //var response = instance.FundMetadataGet(fundCode, key);
            //Assert.IsType<FundMetadataModel>(response);
        }
    }
}