using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPlaceholderApi.Test.Model
{
    public class Posts
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

}
