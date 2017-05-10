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
    ///  Class for testing SecurablesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurablesApiTests
    {
        private SecurablesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurablesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurablesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurablesApi
            //Assert.IsInstanceOfType(typeof(SecurablesApi), instance, "instance is a SecurablesApi");
        }

        
        /// <summary>
        /// Test SecurablesGet
        /// </summary>
        [Test]
        public void SecurablesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurablesGet();
            //Assert.IsInstanceOf<List<SecurableAccess>> (response, "response is List<SecurableAccess>");
        }
        
        /// <summary>
        /// Test SecurablesGetById
        /// </summary>
        [Test]
        public void SecurablesGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.SecurablesGetById(id);
            //Assert.IsInstanceOf<SecurableAccess> (response, "response is SecurableAccess");
        }
        
        /// <summary>
        /// Test SecurablesGetBySubAlias
        /// </summary>
        [Test]
        public void SecurablesGetBySubAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.SecurablesGetBySubAlias(alias, subAlias);
            //Assert.IsInstanceOf<List<SecurableAccess>> (response, "response is List<SecurableAccess>");
        }
        
    }

}
