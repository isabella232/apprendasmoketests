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
    ///  Class for testing RegistryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RegistryApiTests
    {
        private RegistryApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RegistryApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RegistryApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RegistryApi
            //Assert.IsInstanceOfType(typeof(RegistryApi), instance, "instance is a RegistryApi");
        }

        
        /// <summary>
        /// Test RegistryGet
        /// </summary>
        [Test]
        public void RegistryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RegistryGet();
            //Assert.IsInstanceOf<List<RegistrySettingBase>> (response, "response is List<RegistrySettingBase>");
        }
        
        /// <summary>
        /// Test RegistryGetByAlias
        /// </summary>
        [Test]
        public void RegistryGetByAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alias = null;
            //string subAlias = null;
            //var response = instance.RegistryGetByAlias(alias, subAlias);
            //Assert.IsInstanceOf<List<RegistrySettingBase>> (response, "response is List<RegistrySettingBase>");
        }
        
        /// <summary>
        /// Test RegistryGetById
        /// </summary>
        [Test]
        public void RegistryGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.RegistryGetById(id);
            //Assert.IsInstanceOf<RegistrySettingBase> (response, "response is RegistrySettingBase");
        }
        
    }

}
