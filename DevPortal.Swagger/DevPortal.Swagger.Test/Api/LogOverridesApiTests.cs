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
    ///  Class for testing LogOverridesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LogOverridesApiTests
    {
        private LogOverridesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LogOverridesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LogOverridesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LogOverridesApi
            //Assert.IsInstanceOfType(typeof(LogOverridesApi), instance, "instance is a LogOverridesApi");
        }

        
        /// <summary>
        /// Test LogOverridesDelete
        /// </summary>
        [Test]
        public void LogOverridesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.LogOverridesDelete(id);
            
        }
        
        /// <summary>
        /// Test LogOverridesDeleteById
        /// </summary>
        [Test]
        public void LogOverridesDeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string alias = null;
            //string subAlias = null;
            //instance.LogOverridesDeleteById(id, alias, subAlias);
            
        }
        
        /// <summary>
        /// Test LogOverridesGet
        /// </summary>
        [Test]
        public void LogOverridesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LogOverridesGet();
            //Assert.IsInstanceOf<List<InlineResponse20016>> (response, "response is List<InlineResponse20016>");
        }
        
        /// <summary>
        /// Test LogOverridesGetById
        /// </summary>
        [Test]
        public void LogOverridesGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.LogOverridesGetById(id);
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test LogOverridesGetBySubAlias
        /// </summary>
        [Test]
        public void LogOverridesGetBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.LogOverridesGetBySubAlias(alias, subAlias);
            //Assert.IsInstanceOf<List<InlineResponse20016>> (response, "response is List<InlineResponse20016>");
        }
        
        /// <summary>
        /// Test LogOverridesPost
        /// </summary>
        [Test]
        public void LogOverridesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Ovr ovr = null;
            //instance.LogOverridesPost(ovr);
            
        }
        
        /// <summary>
        /// Test LogOverridesPostBySubAlias
        /// </summary>
        [Test]
        public void LogOverridesPostBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Ovr1 ovr = null;
            //string alias = null;
            //string subAlias = null;
            //instance.LogOverridesPostBySubAlias(ovr, alias, subAlias);
            
        }
        
    }

}