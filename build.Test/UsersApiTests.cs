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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<UsersApi> (instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test EditUser
        /// </summary>
        [Test]
        public void EditUserTest()
        {
            // TODO: add unit test for the method 'EditUser'
            string firstname = null; // TODO: replace null with proper value
            string lastname = null; // TODO: replace null with proper value
            string newemail = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            string format = null; // TODO: replace null with proper value
            
            var response = instance.EditUser(firstname, lastname, newemail, email, password, token, format);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
        /// <summary>
        /// Test ForgotPassword
        /// </summary>
        [Test]
        public void ForgotPasswordTest()
        {
            // TODO: add unit test for the method 'ForgotPassword'
            string email = null; // TODO: replace null with proper value
            string format = null; // TODO: replace null with proper value
            
            var response = instance.ForgotPassword(email, format);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public void GetUserTest()
        {
            // TODO: add unit test for the method 'GetUser'
            string token = null; // TODO: replace null with proper value
            string userid = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            
            var response = instance.GetUser(token, userid, email);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test IsAuthorized
        /// </summary>
        [Test]
        public void IsAuthorizedTest()
        {
            // TODO: add unit test for the method 'IsAuthorized'
            string right = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            
            var response = instance.IsAuthorized(right, token);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
        /// <summary>
        /// Test NewUser
        /// </summary>
        [Test]
        public void NewUserTest()
        {
            // TODO: add unit test for the method 'NewUser'
            string firstname = null; // TODO: replace null with proper value
            string lastname = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            
            var response = instance.NewUser(firstname, lastname, email, password);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
        /// <summary>
        /// Test ResetPassword
        /// </summary>
        [Test]
        public void ResetPasswordTest()
        {
            // TODO: add unit test for the method 'ResetPassword'
            string newpassword = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            
            var response = instance.ResetPassword(newpassword, email, password, token);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
        /// <summary>
        /// Test SetPassword
        /// </summary>
        [Test]
        public void SetPasswordTest()
        {
            // TODO: add unit test for the method 'SetPassword'
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            string resetToken = null; // TODO: replace null with proper value
            string format = null; // TODO: replace null with proper value
            
            var response = instance.SetPassword(email, password, resetToken, format);
            Assert.IsInstanceOf<Outcome> (response, "response is Outcome"); 
        }
        
    }

}
