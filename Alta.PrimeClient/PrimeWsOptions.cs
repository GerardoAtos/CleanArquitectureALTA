using System.Collections.Generic;

namespace Alta.PrimeClient
{
    public class PrimeWsOptions
    {
        public const string PrimeWs = "PrimeWs";
        public string Url { get; set; }
        public Dictionary<string, string> Endpoints { get; set; }
        public PrimeCredentials Credentials { get; set; }
    }
}