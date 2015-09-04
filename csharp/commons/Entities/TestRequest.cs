using commons.Extensions;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace commons
{
    public class TestRequest
    {

        //https://www.netztest.at/opendata/opentests/O211ec703-71db-4c32-b61a-77fc1bbf1705?sender=m7n8o9p10q11
        private const string OneTest = "opentests/{0}?sender={1}&verbose={2}";
        

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
            TestResponse dataObject = serializer.ReadObject(ms) as TestResponse;

            return dataObject;
        }
        
    }
}
