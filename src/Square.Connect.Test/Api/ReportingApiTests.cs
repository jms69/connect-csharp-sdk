/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

using Square.Connect.Client;
using Square.Connect.Api;
using Square.Connect.Model;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing ReportingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportingApiTests
    {
        private ReportingApi instance;
        private string locationId;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportingApi();
            var testAccounts = new TestAccounts();
            var account = testAccounts["US-Prod"];
            locationId = account.LocationId;
            Configuration.Default.AccessToken = account.AccessToken;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportingApi
            //Assert.IsInstanceOfType(typeof(ReportingApi), instance, "instance is a ReportingApi");
        }

        
        /// <summary>
        /// Test ListAdditionalRecipientReceivableRefunds
        /// </summary>
        [Test]
        public void ListAdditionalRecipientReceivableRefundsTest()
        {
            Assert.DoesNotThrow(() => instance.ListAdditionalRecipientReceivableRefunds(locationId));
        }
        
        /// <summary>
        /// Test ListAdditionalRecipientReceivables
        /// </summary>
        [Test]
        public void ListAdditionalRecipientReceivablesTest()
        {
            Assert.DoesNotThrow(() => instance.ListAdditionalRecipientReceivables(locationId));
        }
        
    }

}
