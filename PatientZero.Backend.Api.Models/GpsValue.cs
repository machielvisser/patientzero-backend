using Newtonsoft.Json;

namespace PatientZero.Backend.Api.Models
{
    public class GpsValue
    {
        [JsonProperty("tracker_id")]
        public int TrackerId { get; set; }
        [JsonProperty("altitude")]
        public float Altitude { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
        [JsonProperty("lng")]
        public float Longitude { get; set; }
        [JsonProperty("angle")]
        public float Angle { get; set; }
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }
        [JsonProperty("dt")]
        public float Timestamp { get; set; }
    }
}
