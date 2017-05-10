/* 
 * Account Management REST API
 *
 * The Account Management REST API can be used to manage user accounts, roles, and securables for applications on the Platform. The endpoints of this API allow you to perform the same the functionality of the Platform's Account Portal for your Tenant's applications.   For more information, see our documentation on the [Account Portal](/current/account).     ## Authentication    Before making a request, you must be authenticated. Follow these instuctions [to get authenticated](/restapi/accountmanagement/v1/authentication). ## Making a Request   ### Prerequisites    * Installed Platform of version 6.6.0 or later    * An active user account assigned to an active Tenant Account or Developer Team    * Authentication token   ### Request URL    All requests must use **https**.       The URL for every request you make is the URL of your Platform followed by \"/account\" and the path structure of the endpoint. For example, if your Platform URL is https://apps.apprenda.harp and you want to get a list of all user accounts for your Tenant, the request URL will be https://apps.apprenda.harp/account/api/v1/users.     For more information, see our documentation on [using api resources](/restapi/accountmanagement/v1/using-resources) and [finding your Cloud URI](/current/clouduri).    ### Request Headers  Your authenication token must be passed in the header of all requests using the key **ApprendaSessionToken** (not case sensitive).    
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubscriptionsApiTests
    {
        private SubscriptionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriptionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubscriptionsApi
            //Assert.IsInstanceOfType(typeof(SubscriptionsApi), instance, "instance is a SubscriptionsApi");
        }

        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsGet
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //var response = instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsGet(applicationVersionKey);
            //Assert.IsInstanceOf<UnpagedResourceBaseSubscription> (response, "response is UnpagedResourceBaseSubscription");
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoDelete
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string locator = null;
            //string userId = null;
            //instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoDelete(applicationVersionKey, locator, userId);
            
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoPost
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string locator = null;
            //string userId = null;
            //instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorAssignedtoPost(applicationVersionKey, locator, userId);
            
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorDelete
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string locator = null;
            //instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorDelete(applicationVersionKey, locator);
            
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorGet
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string locator = null;
            //var response = instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsLocatorGet(applicationVersionKey, locator);
            //Assert.IsInstanceOf<Subscription> (response, "response is Subscription");
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsPost
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //SubscriptionRequest body = null;
            //var response = instance.ApiV1ApplicationVersionsApplicationVersionKeySubscriptionsPost(applicationVersionKey, body);
            //Assert.IsInstanceOf<UnpagedResourceBaseSubscription> (response, "response is UnpagedResourceBaseSubscription");
        }
        
    }

}
