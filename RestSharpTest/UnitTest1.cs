using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using NUnit;
using SpecFlow;
using RestSharpTest;
using FluentAssertions;

namespace RestSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cliente = new RestClient("https://portal-qa.qarti.com.br/Api");

            var request = new RestRequest("departamentos/{id}", Method.Get);
            request.AddUrlSegment("id", 22);

            var response = cliente.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);

            var result = output["Ativo"];

            response.StatusCode.Should().Be((System.Net.HttpStatusCode?)200);

            Assert.IsTrue(result.Contains("1"));
        }
    }
}
