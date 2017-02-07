﻿namespace Contour.Testing.Plumbing
{

    public class Capabilities
    {
        public bool publisher_confirms { get; set; }

        public bool exchange_exchange_bindings { get; set; }

        //Unsupported
        //public bool basic.nack { get; set; }

        public bool consumer_cancel_notify { get; set; }

        //Unsupported
        //public bool connection.blocked { get; set; }

        public bool authentication_failure_close { get; set; }
    }

    public class ClientProperties
    {
        public string Endpoint { get; set; }
        public string Machine { get; set; }
        public string Location { get; set; }
        public Capabilities capabilities { get; set; }
    }

    public class GarbageCollection
    {
        public int max_heap_size { get; set; }
        public int min_bin_vheap_size { get; set; }
        public int min_heap_size { get; set; }
        public int fullsweep_after { get; set; }
        public int minor_gcs { get; set; }
    }

    public class RecvOctDetails
    {
        public double rate { get; set; }
    }

    public class SendOctDetails
    {
        public double rate { get; set; }
    }

    public class ReductionsDetails
    {
        public double rate { get; set; }
    }

    public class Connection
    {
        public long connected_at { get; set; }
        public ClientProperties client_properties { get; set; }
        public int channel_max { get; set; }
        public int frame_max { get; set; }
        public int timeout { get; set; }
        public string vhost { get; set; }
        public string user { get; set; }
        public string protocol { get; set; }
        public object ssl_hash { get; set; }
        public object ssl_cipher { get; set; }
        public object ssl_key_exchange { get; set; }
        public object ssl_protocol { get; set; }
        public string auth_mechanism { get; set; }
        public object peer_cert_validity { get; set; }
        public object peer_cert_issuer { get; set; }
        public object peer_cert_subject { get; set; }
        public bool ssl { get; set; }
        public string peer_host { get; set; }
        public string host { get; set; }
        public int peer_port { get; set; }
        public int port { get; set; }
        public string name { get; set; }
        public string node { get; set; }
        public string type { get; set; }
        public GarbageCollection garbage_collection { get; set; }
        public int reductions { get; set; }
        public int channels { get; set; }
        public string state { get; set; }
        public int send_pend { get; set; }
        public int send_cnt { get; set; }
        public int recv_cnt { get; set; }
        public RecvOctDetails recv_oct_details { get; set; }
        public int recv_oct { get; set; }
        public SendOctDetails send_oct_details { get; set; }
        public int send_oct { get; set; }
        public ReductionsDetails reductions_details { get; set; }
    }
}
