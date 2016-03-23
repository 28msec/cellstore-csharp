using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CellStore.Client;
using CellStore.Api;
using CellStore.Model;

namespace CellStore.Test
{
    /// <summary>
    ///  Class for testing ReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportsApiTests
    {
        private ReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ReportsApi> (instance, "instance is a ReportsApi");
        }

        
        /// <summary>
        /// Test AddOrReplaceOrValidateReport
        /// </summary>
        [Test]
        public void AddOrReplaceOrValidateReportTest()
        {
            // TODO: add unit test for the method 'AddOrReplaceOrValidateReport'
            Object report = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            bool? publicRead = null; // TODO: replace null with proper value
            bool? _private = null; // TODO: replace null with proper value
            bool? validationOnly = null; // TODO: replace null with proper value
            bool? import = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            string label = null; // TODO: replace null with proper value
            
            var response = instance.AddOrReplaceOrValidateReport(report, token, publicRead, _private, validationOnly, import, id, label);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test GetParameters
        /// </summary>
        [Test]
        public void GetParametersTest()
        {
            // TODO: add unit test for the method 'GetParameters'
            string parameter = null; // TODO: replace null with proper value
            
            var response = instance.GetParameters(parameter);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test ListReports
        /// </summary>
        [Test]
        public void ListReportsTest()
        {
            // TODO: add unit test for the method 'ListReports'
            string token = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            string user = null; // TODO: replace null with proper value
            bool? publicRead = null; // TODO: replace null with proper value
            bool? _private = null; // TODO: replace null with proper value
            bool? export = null; // TODO: replace null with proper value
            bool? onlyMetadata = null; // TODO: replace null with proper value
            
            var response = instance.ListReports(token, id, user, publicRead, _private, export, onlyMetadata);
            Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>"); 
        }
        
        /// <summary>
        /// Test RemoveReport
        /// </summary>
        [Test]
        public void RemoveReportTest()
        {
            // TODO: add unit test for the method 'RemoveReport'
            string id = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            
            instance.RemoveReport(id, token);
             
        }
        
    }

}
