﻿using Newtonsoft.Json;

namespace UnitTestEx.Xunit.Test.Model
{
    class Person2
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }
}