/* 
 * Apprenda.DeveloperPortal.Web
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    ///  Class for testing ComponentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ComponentsApiTests
    {
        private ComponentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ComponentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ComponentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ComponentsApi
            //Assert.IsInstanceOfType(typeof(ComponentsApi), instance, "instance is a ComponentsApi");
        }

        
        /// <summary>
        /// Test ComponentsDeleteCertificate
        /// </summary>
        [Test]
        public void ComponentsDeleteCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string fileName = null;
            //instance.ComponentsDeleteCertificate(appAlias, versionAlias, componentAlias, fileName);
            
        }
        
        /// <summary>
        /// Test ComponentsGet
        /// </summary>
        [Test]
        public void ComponentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.ComponentsGet(alias, subAlias);
            //Assert.IsInstanceOf<List<InlineResponse2008>> (response, "response is List<InlineResponse2008>");
        }
        
        /// <summary>
        /// Test ComponentsGetByIDentifier
        /// </summary>
        [Test]
        public void ComponentsGetByIDentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //var response = instance.ComponentsGetByIDentifier(alias, subAlias, identifier);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test ComponentsGetBySubAlias
        /// </summary>
        [Test]
        public void ComponentsGetBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.ComponentsGetBySubAlias(alias, subAlias);
            //Assert.IsInstanceOf<List<InlineResponse2008>> (response, "response is List<InlineResponse2008>");
        }
        
        /// <summary>
        /// Test ComponentsGetCertificate
        /// </summary>
        [Test]
        public void ComponentsGetCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string fileName = null;
            //var response = instance.ComponentsGetCertificate(appAlias, versionAlias, componentAlias, fileName);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test ComponentsGetFiles
        /// </summary>
        [Test]
        public void ComponentsGetFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string path = null;
            //var response = instance.ComponentsGetFiles(appAlias, versionAlias, componentAlias, path);
            //Assert.IsInstanceOf<List<InlineResponse2006>> (response, "response is List<InlineResponse2006>");
        }
        
        /// <summary>
        /// Test ComponentsGetScaleByAlias
        /// </summary>
        [Test]
        public void ComponentsGetScaleByAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string count = null;
            //var response = instance.ComponentsGetScaleByAlias(alias, subAlias, appAlias, versionAlias, componentAlias, count);
            //Assert.IsInstanceOf<List<InlineResponse2008>> (response, "response is List<InlineResponse2008>");
        }
        
        /// <summary>
        /// Test ComponentsPost
        /// </summary>
        [Test]
        public void ComponentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //string action = null;
            //int? count = null;
            //int? minCount = null;
            //instance.ComponentsPost(alias, subAlias, identifier, action, count, minCount);
            
        }
        
        /// <summary>
        /// Test ComponentsPostActionByIdentifier
        /// </summary>
        [Test]
        public void ComponentsPostActionByIdentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //string action = null;
            //int? count = null;
            //int? minCount = null;
            //instance.ComponentsPostActionByIdentifier(alias, subAlias, identifier, action, count, minCount);
            
        }
        
        /// <summary>
        /// Test ComponentsPostCertificate
        /// </summary>
        [Test]
        public void ComponentsPostCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string url = null;
            //var response = instance.ComponentsPostCertificate(appAlias, versionAlias, componentAlias, url);
            //Assert.IsInstanceOf<List<InlineResponse2007>> (response, "response is List<InlineResponse2007>");
        }
        
        /// <summary>
        /// Test ComponentsPostScaleByIdentifier
        /// </summary>
        [Test]
        public void ComponentsPostScaleByIdentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //string action = null;
            //int? count = null;
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //int? minCount = null;
            //instance.ComponentsPostScaleByIdentifier(alias, subAlias, identifier, action, count, appAlias, versionAlias, componentAlias, minCount);
            
        }
        
        /// <summary>
        /// Test ComponentsPut
        /// </summary>
        [Test]
        public void ComponentsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //Component component = null;
            //var response = instance.ComponentsPut(alias, subAlias, identifier, component);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ComponentsPutByAlias
        /// </summary>
        [Test]
        public void ComponentsPutByAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //Component1 component = null;
            //var response = instance.ComponentsPutByAlias(alias, subAlias, identifier, component);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ComponentsPutCountByIdentifier
        /// </summary>
        [Test]
        public void ComponentsPutCountByIdentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string identifier = null;
            //Component2 component = null;
            //string appAlias = null;
            //string versionAlias = null;
            //string componentAlias = null;
            //string count = null;
            //var response = instance.ComponentsPutCountByIdentifier(alias, subAlias, identifier, component, appAlias, versionAlias, componentAlias, count);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}