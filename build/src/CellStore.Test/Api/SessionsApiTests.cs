/* 
 * Cellstore API
 *
 * <h3>CellStore API</h3>
 *
 * OpenAPI spec version: vX.X.X
 * Contact: support@28.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    ///  Class for testing SessionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SessionsApiTests
    {
        private SessionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SessionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SessionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SessionsApi
            //Assert.IsInstanceOfType(typeof(SessionsApi), instance, "instance is a SessionsApi");
        }

        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string password = null;
            //var response = instance.Login(email, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.Logout(token);
            //Assert.IsInstanceOf<Outcome> (response, "response is Outcome");
        }
        
        /// <summary>
        /// Test Revoke
        /// </summary>
        [Test]
        public void RevokeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string password = null;
            //string token = null;
            //var response = instance.Revoke(email, password, token);
            //Assert.IsInstanceOf<Outcome> (response, "response is Outcome");
        }
        
        /// <summary>
        /// Test Token
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string password = null;
            //string expiration = null;
            //var response = instance.Token(email, password, expiration);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Tokens
        /// </summary>
        [Test]
        public void TokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.Tokens(token);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
