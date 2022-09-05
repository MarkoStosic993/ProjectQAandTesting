using JsonPlaceholderApi.Test.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace JsonPlaceholderApi.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("posts", HttpStatusCode.OK)]
        [InlineData("comments", HttpStatusCode.OK)]
        [InlineData("photos", HttpStatusCode.OK)]
        [InlineData("comments?postId=1", HttpStatusCode.OK)]
        public void StatusCodeCheck(string addUrl, HttpStatusCode statusCode)
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest request = new RestRequest($"{addUrl}", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.Equal(statusCode, response.StatusCode);
        }

        [Theory]
        [InlineData("posts")]
        [InlineData("comments")]
        [InlineData("photos")]
        [InlineData("comments?postId=1")]
        public void ContentNotEmptyCheck(string addUrl)
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest request = new RestRequest($"{addUrl}", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            

            Assert.NotEqual("[]", response.Content);

        }
        [Fact]
        public void CheckNumbersOfComments()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest request = new RestRequest("comments?postId=1", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            var objResponse = JsonConvert.DeserializeObject<List<Commentspostid>>(response.Content);

            //Assert


            Assert.Equal(5, objResponse.Count);

        }
    }
}