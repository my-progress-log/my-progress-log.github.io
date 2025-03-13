using System.Globalization;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;

namespace BlazorPortfolio.Models {
    public class Post
    {
        public string Id { get; set; } = "";
        [JsonPropertyName("contentStartIndex")]
        public int ContentStartIndex { get; set; }

        [JsonPropertyName("date")]
        public string Date { 
            get => _date; 
            set {
                _date = value;
                Id = DateAsIdString;
            }
        }

        [JsonPropertyName("hours")]
        public int Hours { get; set; }

        [JsonPropertyName("satisfaction")]
        public int Satisfaction { get; set; }
        public MarkupString Content { get; set; } = new MarkupString("");

        private string _date = "";

        public DateTime DateAsDateTime {
            get {
                return DateTime.ParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        public string DateAsUriString {
            get {
                return DateAsDateTime.ToString(@"yyyy/MM/dd");
            }
        }

        private string DateAsIdString {
            get {
                return DateAsDateTime.ToString("dd-MM-yyyy");
            }
        }
    }
}