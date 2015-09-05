using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace commons
{
    //Documentation: https://www.netztest.at/en/OpenDataSpecification.html#quality-of-service

    [DataContract]
    public class QosResponse
    {
        [DataMember]
        public List<string> error { get; set; }

        [DataMember]
        public List<testresultdetail_testdesc_item> testresultdetail_testdesc { get; set; }

        [DataMember]
        public List<testresultdetail_item> testresultdetail { get; set; }

        [DataMember]
        public List<testresultdetail_desc_item> testresultdetail_desc { get; set; }
    }

 


    [DataContract]
    public class testresultdetail_testdesc_item
    {

        [DataMember]
        public string desc { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string test_type { get; set; }

    }

    [DataContract]
    public class result_item
    {

        [DataMember]
        public string dns_objective_dns_record { get; set; }

        [DataMember]
        public string dns_objective_host { get; set; }

        [DataMember]
        public string dns_objective_resolver { get; set; }

        [DataMember]
        public string dns_objective_timeout { get; set; }


        [DataMember]
        public string dns_result_duration { get; set; }

        [DataMember]
        public string dns_result_entries { get; set; }

        [DataMember]
        public string dns_result_entries_found { get; set; }

        [DataMember]
        public string dns_result_info { get; set; }



        [DataMember]
        public string dns_result_status { get; set; }

        [DataMember]
        public string duration_ns { get; set; }

        [DataMember]
        public string http_objective_range { get; set; }

        [DataMember]
        public string http_objective_url { get; set; }


        [DataMember]
        public string http_result_hash { get; set; }

        [DataMember]
        public string http_result_header { get; set; }

        [DataMember]
        public string http_result_length { get; set; }

        [DataMember]
        public string http_result_status { get; set; }


        [DataMember]
        public string nontransproxy_objective_port { get; set; }

        [DataMember]
        public string nontransproxy_objective_request { get; set; }

        [DataMember]
        public string nontransproxy_objective_timeout { get; set; }

        [DataMember]
        public string nontransproxy_result { get; set; }


        [DataMember]
        public string nontransproxy_result_response { get; set; }

        [DataMember]
        public string start_time_ns { get; set; }

        [DataMember]
        public string tcp_objective_out_port { get; set; }

        [DataMember]
        public string tcp_objective_timeout { get; set; }


        [DataMember]
        public string tcp_result_out { get; set; }

        [DataMember]
        public string tcp_result_out_response { get; set; }

        [DataMember]
        public string test_type { get; set; }

        [DataMember]
        public string udp_objective_delay { get; set; }


        [DataMember]
        public string udp_objective_out_num_packets { get; set; }

        [DataMember]
        public string udp_objective_out_port { get; set; }

        [DataMember]
        public string udp_objective_timeout { get; set; }

        [DataMember]
        public string udp_result_out_num_packets { get; set; }


        [DataMember]
        public string udp_result_out_packet_loss_rate { get; set; }

        [DataMember]
        public string udp_result_out_response_num_packets { get; set; }

        [DataMember]
        public string website_objective_timeout { get; set; }

        [DataMember]
        public string website_objective_url { get; set; }


        [DataMember]
        public string website_result_duration { get; set; }

        [DataMember]
        public string website_result_info { get; set; }

        [DataMember]
        public string website_result_rx_bytes { get; set; }

        [DataMember]
        public string website_result_status { get; set; }

        [DataMember]
        public string website_result_tx_bytes { get; set; }

    }


    [DataContract]
    public class testresultdetail_item
    {
        [DataMember]
        public decimal? failure_count { get; set; }

        [DataMember]
        public decimal? uid { get; set; }

        [DataMember]
        public List<result_item> result { get; set; }

        [DataMember]
        public string test_summary { get; set; }

        [DataMember]
        public decimal? success_count { get; set; }

        [DataMember]
        public string test_desc { get; set; }

        [DataMember]
        public string test_type { get; set; }

    }

    [DataContract]
    public class testresultdetail_desc_item
    {
        [DataMember]
        public List<decimal> uid { get; set; }

        [DataMember]
        public string desc { get; set; }

        [DataMember]
        public string test { get; set; }

        [DataMember]
        public string status { get; set; }

    }



}
