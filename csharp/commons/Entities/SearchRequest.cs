﻿using commons.Extensions;
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

        //https://www.netztest.at/opendata/opentests/search?asn=1764&sender=a1b2c3d4e5f6
        private const string Search = "opentests/search?asn={0}&sender={1}&max_results={2}";


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
            SearchResponse dataObject = serializer.ReadObject(ms) as SearchResponse;

            return dataObject;
        }
        
    }
}
