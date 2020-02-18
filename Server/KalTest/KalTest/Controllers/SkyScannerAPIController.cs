using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using CalTest.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkyScanner;
using unirest_net.http;

namespace CalTest.Controllers
{
    public class SkyScannerAPIController : ApiController
    {


        [HttpGet]
        public string GetSkyScannerCreateSession()
        {
            //string key = "";

            //var json = new JavaScriptSerializer().Serialize(Unirest.post("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/v1.0")
            //                                        .header("X-RapidAPI-Host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com")
            //                                        .header("X-RapidAPI-Key", "Q3qPXNLGeumshnlj2d9QZv5jIHXYp10xOGwjsnYD15P5EECXmN")
            //                                        .header("Content-Type", "application/x-www-form-urlencoded")
            //                                        .field("inboundDate", "2019-09-10")
            //                                        .field("cabinClass", "business")
            //                                        .field("children", 0)
            //                                        .field("infants", 0)
            //                                        .field("country", "US")
            //                                        .field("currency", "USD")
            //                                        .field("locale", "en-US")
            //                                        .field("originPlace", "SFO-sky")
            //                                        .field("destinationPlace", "LHR-sky")
            //                                        .field("outboundDate", "2019-09-01")
            //                                        .field("adults", 1));

            //var data = (JObject)JsonConvert.DeserializeObject(json);
            //key = data["Headers"]["X-RapidAPI-Key"].Value<string>();

            //var json2 = new JavaScriptSerializer().Serialize(Unirest.get("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/uk2/v1.0/Q3qPXNLGeumshnlj2d9QZv5jIHXYp10xOGwjsnYD15P5EECXmN?pageIndex=0&pageSize=10")
            //                .header("X-RapidAPI-Host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com")
            //                .header("X-RapidAPI-Key", key));








            //RootObject account = JsonConvert.DeserializeObject<RootObject>(json);
            //return json;
            return "";


        }
    }

    internal class TimeOut
    {
        public int Ticks { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Milliseconds { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double TotalDays { get; set; }
        public double TotalHours { get; set; }
        public int TotalMilliseconds { get; set; }
        public double TotalMinutes { get; set; }
        public int TotalSeconds { get; set; }
    }

    internal class HttpMethod
    {
        public string Method { get; set; }
    }

   // internal class Headers
   // {
   //     public string __invalid_name__X-RapidAPI-Host { get; set; }
   //     public string __invalid_name__X-RapidAPI-Key { get; set; }
   //     public string __invalid_name__Content-Type { get; set; }
   //}

internal class Header
{
    public string Key { get; set; }
    public List<string> Value { get; set; }
}

internal class Body
{
    public List<Header> Headers { get; set; }
}

internal class RootObject
{
    public TimeOut TimeOut { get; set; }
    public object NetworkCredentials { get; set; }
    public object Filter { get; set; }
    public string URL { get; set; }
    public System.Net.Http.HttpMethod HttpMethod { get; set; }
  //  public Headers Headers { get; set; }
    public List<Body> Body { get; set; }
}

}
