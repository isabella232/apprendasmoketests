/* 
 * Account Management REST API
 *
 * The Account Management REST API can be used to manage user accounts, roles, and securables for applications on the Platform. The endpoints of this API allow you to perform the same the functionality of the Platform's Account Portal for your Tenant's applications.   For more information, see our documentation on the [Account Portal](/current/account).     ## Authentication    Before making a request, you must be authenticated. Follow these instuctions [to get authenticated](/restapi/accountmanagement/v1/authentication). ## Making a Request   ### Prerequisites    * Installed Platform of version 6.6.0 or later    * An active user account assigned to an active Tenant Account or Developer Team    * Authentication token   ### Request URL    All requests must use **https**.       The URL for every request you make is the URL of your Platform followed by \"/account\" and the path structure of the endpoint. For example, if your Platform URL is https://apps.apprenda.harp and you want to get a list of all user accounts for your Tenant, the request URL will be https://apps.apprenda.harp/account/api/v1/users.     For more information, see our documentation on [using api resources](/restapi/accountmanagement/v1/using-resources) and [finding your Cloud URI](/current/clouduri).    ### Request Headers  Your authenication token must be passed in the header of all requests using the key **ApprendaSessionToken** (not case sensitive).    
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Body4
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Body4Tests
    {
        // TODO uncomment below to declare an instance variable for Body4
        //private Body4 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Body4
            //instance = new Body4();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Body4
        /// </summary>
        [Test]
        public void Body4InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Body4
            //Assert.IsInstanceOfType<Body4> (instance, "variable 'instance' is a Body4");
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'Href'
        /// </summary>
        [Test]
        public void HrefTest()
        {
            // TODO unit test for the property 'Href'
        }
        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Test]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }
        /// <summary>
        /// Test the property 'IsEnabled'
        /// </summary>
        [Test]
        public void IsEnabledTest()
        {
            // TODO unit test for the property 'IsEnabled'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'MiddleName'
        /// </summary>
        [Test]
        public void MiddleNameTest()
        {
            // TODO unit test for the property 'MiddleName'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Prefix'
        /// </summary>
        [Test]
        public void PrefixTest()
        {
            // TODO unit test for the property 'Prefix'
        }
        /// <summary>
        /// Test the property 'Roles'
        /// </summary>
        [Test]
        public void RolesTest()
        {
            // TODO unit test for the property 'Roles'
        }
        /// <summary>
        /// Test the property 'Subscriptions'
        /// </summary>
        [Test]
        public void SubscriptionsTest()
        {
            // TODO unit test for the property 'Subscriptions'
        }
        /// <summary>
        /// Test the property 'Suffix'
        /// </summary>
        [Test]
        public void SuffixTest()
        {
            // TODO unit test for the property 'Suffix'
        }

    }

}
