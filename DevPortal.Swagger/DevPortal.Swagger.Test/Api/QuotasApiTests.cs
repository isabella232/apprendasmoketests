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
    ///  Class for testing QuotasApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class QuotasApiTests
    {
        private QuotasApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuotasApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuotasApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' QuotasApi
            //Assert.IsInstanceOfType(typeof(QuotasApi), instance, "instance is a QuotasApi");
        }

        
        /// <summary>
        /// Test QuotasGet
        /// </summary>
        [Test]
        public void QuotasGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.QuotasGet();
            //Assert.IsInstanceOf<List<InlineResponse20023>> (response, "response is List<InlineResponse20023>");
        }
        
        /// <summary>
        /// Test QuotasGetById
        /// </summary>
        [Test]
        public void QuotasGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.QuotasGetById(id);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
        /// <summary>
        /// Test QuotasGetBySubAlias
        /// </summary>
        [Test]
        public void QuotasGetBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.QuotasGetBySubAlias(alias, subAlias);
            //Assert.IsInstanceOf<List<InlineResponse20023>> (response, "response is List<InlineResponse20023>");
        }
        
    }

}
