using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace commons
{

    //Documentation: https://www.netztest.at/en/OpenDataSpecification.html#response-2

    [DataContract]
    public class TestResponse
    {
        [DataMember]
        public decimal? asn { get; set; }

        [DataMember]
        public decimal? bytes_download { get; set; }

        [DataMember]
        public decimal? bytes_upload { get; set; }

        [DataMember]
        public string cat_technology { get; set; }

        [DataMember]
        public string client_version { get; set; }

        [DataMember]
        public string country_asn { get; set; }


        [DataMember]
        public string country_geoip { get; set; }


        [DataMember]
        public string country_location { get; set; }

        [DataMember]
        public string connection { get; set; }


        [DataMember]
        public decimal? distance { get; set; }

        [DataMember]
        public decimal? download_classification { get; set; }

        [DataMember]
        public decimal? download_kbit { get; set; }


        [DataMember]
        public decimal? duration_download_ms { get; set; }

        [DataMember]
        public decimal? duration_upload_ms { get; set; }

        [DataMember]
        public bool implausible { get; set; }

        [DataMember]
        public string ip_anonym { get; set; }

        [DataMember(Name = "lat")]
        public decimal? latitude { get; set; }

        [DataMember(Name = "long")]
        public decimal? longitude { get; set; }

        [DataMember]
        public string loc_src { get; set; }

        [DataMember]
        public decimal? loc_accuracy { get; set; }


        [DataMember]
        public decimal? lte_rsrp { get; set; }

        [DataMember]
        public decimal? lte_rsrq { get; set; }

        [DataMember]
        public string model { get; set; }

        [DataMember]
        public string model_native { get; set; }

        [DataMember]
        public decimal? ndt_download_kbit { get; set; }

        [DataMember]
        
        public decimal? ndt_upload_kbit { get; set; }
        
        [DataMember]
        public string network_country { get; set; }


        [DataMember]
        public string network_mcc_mnc { get; set; }

        [DataMember]
        public string network_name { get; set; }

        [DataMember]
        public string network_type { get; set; }

        [DataMember]
        public decimal? num_threads { get; set; }

        [DataMember]
        public decimal? num_threads_requested { get; set; }

        [DataMember]
        public decimal? num_theads_ul { get; set; }

        [DataMember]
        public string open_test_uuid { get; set; }

        [DataMember]
        public string open_uuid { get; set; }

        [DataMember]
        public decimal? ping_classification { get; set; }

        [DataMember]
        public decimal? ping_ms { get; set; }


        [DataMember]
        public string platform { get; set; }

        [DataMember]
        public string product { get; set; }

        [DataMember]
        public string provider_name { get; set; }

        [DataMember]
        public string public_ip_as_name { get; set; }

        [DataMember]
        public long? roaming_type { get; set; }

        [DataMember]
        public string server_name { get; set; }

        [DataMember]
        public decimal? signal_classification { get; set; }

        [DataMember]
        public decimal? signal_strength { get; set; }

        [DataMember]
        public string sim_country { get; set; }

        [DataMember]
        public string sim_mcc_mnc { get; set; }

        //todo 2x!!


        [DataMember]
        public decimal? test_if_bytes_download { get; set; }

        [DataMember]
        public decimal? test_if_bytes_upload { get; set; }

        [DataMember]
        public decimal? testdl_if_bytes_download { get; set; }

        [DataMember]
        public decimal? testdl_if_bytes_upload { get; set; }


        [DataMember]
        public decimal? testul_if_bytes_download { get; set; }

        [DataMember]
        public decimal? testul_if_bytes_upload { get; set; }

        [DataMember]
        public decimal? test_duration { get; set; }


        [DataMember]
        public string Time { get; set; }

        [DataMember]
        public decimal? time_dl_ms { get; set; }

        [DataMember]
        public decimal? time_ul_ms { get; set; }

        [DataMember]
        public decimal? upload_classification { get; set; }


        [DataMember]
        public decimal? upload_kbit { get; set; }

        [DataMember]
        public decimal? wifi_link_speed { get; set; }

        [DataMember]
        public decimal? zip_code { get; set; }

    }


}
