using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace commons
{
    [DataContract]
    public class SearchResponse
    {
        [DataMember]
        public decimal? next_cursor { get; set; }
        [DataMember]
        public List<SearchTestResponse> results { get; set; }
        [DataMember]
        public decimal? duration_ms { get; set; }
       
    }


    [DataContract]
    public class SearchTestResponse
    {
        [DataMember]
        public string platform { get; set; }
        [DataMember]
        public string model { get; set; }
        [DataMember]
        public string time { get; set; }

        [DataMember]
        public string provider_name { get; set; }

        [DataMember]
        public string open_test_uuid { get; set; }

        [DataMember]
        public string open_uuid { get; set; }

        [DataMember]
        public decimal? upload_kbit { get; set; }

        [DataMember]
        public decimal? download_kbit { get; set; }

        [DataMember]
        public decimal? ping_ms { get; set; }

        [DataMember]
        public decimal? signal_strength { get; set; }

        [DataMember]
        public decimal? lte_rsrp { get; set; }

        [DataMember(Name = "lat")]
        public decimal? latitude { get; set; }

        [DataMember(Name = "long")]
        public decimal? longitude { get; set; }

    }


}
