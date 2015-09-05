using commons.Extensions;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace commons
{
    public class Request
    {

        //https://www.netztest.at/opendata/opentests/O211ec703-71db-4c32-b61a-77fc1bbf1705?sender=m7n8o9p10q11
        private const string OneTest = "opentests/{0}?sender={1}&verbose={2}";

        //https://www.netztest.at/opendata/qos/O56b5cc79-5669-4457-bce2-0aeaf3b7242f
        private const string Qos = "qos/{0}";

        //https://www.netztest.at/opendata/opentests/search?asn=1764&sender=a1b2c3d4e5f6
        private const string Search = "opentests/search?asn={0}&sender={1}&max_results={2}";



        public TestResponse GET_OneTest(string open_test_uuid, string sender, string verbose = "0")
        {

            string url = Constants.url_interface + String.Format(OneTest, open_test_uuid, sender, verbose);

            string result;
            using (var client = new CompressionEnabledWebClient())
            {
                client.Encoding = Encoding.UTF8;
                result = RequestHelpers.FormatResponse(client.DownloadString(url));
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TestResponse));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(result));

            return serializer.ReadObject(ms) as TestResponse;
        }

        

        public QosResponse GET_Qos(string open_test_uuid)
        {

            string url = Constants.url_interface + String.Format(Qos, open_test_uuid);

            string result;
            using (var client = new CompressionEnabledWebClient())
            {
                client.Encoding = Encoding.UTF8;
                result = RequestHelpers.FormatResponse(client.DownloadString(url));
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(QosResponse));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(result));

            return serializer.ReadObject(ms) as QosResponse;
        }

    
        public SearchResponse GET_Search(long asn, string sender, long? max_results = 100)
        {

            string url = Constants.url_interface + String.Format(Search, asn, sender, max_results);

            string result;
            using (var client = new CompressionEnabledWebClient())
            {
                client.Encoding = Encoding.UTF8;
                result = RequestHelpers.FormatResponse(client.DownloadString(url));
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SearchResponse));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(result));

            return serializer.ReadObject(ms) as SearchResponse;
        }


    }
}
