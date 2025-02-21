using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("mode")]
    public string mode { get; set; }

    [JsonProperty("tone")]
    public string tone { get; set; }

    [JsonProperty("comments")]
    public string[] comments { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
