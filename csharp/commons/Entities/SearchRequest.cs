using commons.Extensions;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace commons
{
    public class SearchRequest
    {

        //private string _apiCallsMade;
        //private string _apiResponseTime;

        //https://www.netztest.at/opendata/opentests/search?asn=1764&sender=a1b2c3d4e5f6
        private const string OneTest = "opentests/search?asn={0}&sender={1}&max_results={2}";


        public SearchResponse GET_OneTest(long asn, string sender, long? max_results = 100)
        {

            string url = Constants.url_interface + String.Format(OneTest, asn, sender, max_results);

            string result;
            using (var client = new CompressionEnabledWebClient())
            {
                client.Encoding = Encoding.UTF8;
                result = RequestHelpers.FormatResponse(client.DownloadString(url));
                // Set response values.
                //_apiResponseTime = client.ResponseHeaders["X-Response-Time"];
                //_apiCallsMade = client.ResponseHeaders["X-Forecast-API-Calls"];
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SearchResponse));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(result));
            SearchResponse dataObject = serializer.ReadObject(ms) as SearchResponse;

            return dataObject;
        }
        

        //public string ApiCallsMade
        //{
        //    get
        //    {
        //        if (_apiCallsMade != null)
        //        {
        //            return _apiCallsMade;
        //        }
        //        throw new Exception("Cannot retrieve API Calls Made. No calls have been made to the API yet.");
        //    }
        //}

        //public string ApiResponseTime
        //{
        //    get
        //    {
        //        if (_apiResponseTime != null)
        //        {
        //            return _apiResponseTime;
        //        }
        //        throw new Exception("Cannot retrieve API Reponse Time. No calls have been made to the API yet.");
        //    }
        //}
    }
}
