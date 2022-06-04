using System;
using System.Text.Json.Serialization;

namespace XamarinAppExam.Model
{
    public class BetPlay
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("documentId")]
        public string documentId { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("StakeValue")]
        public decimal StakeValue { get; set; }

        [JsonPropertyName("GainValue")]
        public decimal GainValue { get; set; }

        [JsonPropertyName("Deduction")]
        public decimal Deduction { get; set; }

        [JsonPropertyName("TotalPayable")]
        public decimal TotalPayable { get; set; }

        [JsonPropertyName("MultiplicationFactor")]
        public decimal MultiplicationFactor { get; set; }
        

    }
}
