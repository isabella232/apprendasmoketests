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
    ///  Class for testing ContextApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContextApiTests
    {
        private ContextApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContextApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContextApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContextApi
            //Assert.IsInstanceOfType(typeof(ContextApi), instance, "instance is a ContextApi");
        }

        
        /// <summary>
        /// Test ContextGet
        /// </summary>
        [Test]
        public void ContextGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnAddress = null;
            //var response = instance.ContextGet(returnAddress);
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
        /// <summary>
        /// Test ContextGetBySubAlias
        /// </summary>
        [Test]
        public void ContextGetBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //string returnAddress = null;
            //var response = instance.ContextGetBySubAlias(alias, subAlias, returnAddress);
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
    }

}