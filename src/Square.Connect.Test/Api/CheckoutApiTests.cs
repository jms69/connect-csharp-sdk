/* 
 * Square Connect API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
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

using Square.Connect.Client;
using Square.Connect.Api;
using Square.Connect.Model;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing CheckoutApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CheckoutApiTests
    {
        private CheckoutApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CheckoutApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CheckoutApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CheckoutApi
            //Assert.IsInstanceOfType(typeof(CheckoutApi), instance, "instance is a CheckoutApi");
        }

        
        /// <summary>
        /// Test CreateCheckout
        /// </summary>
        [Test]
        public void CreateCheckoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string locationId = null;
            //CreateCheckoutRequest body = null;
            //var response = instance.CreateCheckout(authorization, locationId, body);
            //Assert.IsInstanceOf<CreateCheckoutResponse> (response, "response is CreateCheckoutResponse");
        }
        
    }

}