using commons.Extensions;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace commons
{
    public class QosRequest
    {

        //https://www.netztest.at/opendata/qos/O56b5cc79-5669-4457-bce2-0aeaf3b7242f
        private const string Qos = "qos/{0}";
        

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
            QosResponse dataObject = serializer.ReadObject(ms) as QosResponse;

            return dataObject;
        }
        
    }
}
