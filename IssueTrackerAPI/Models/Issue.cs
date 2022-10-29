using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonConverterAttribute = System.Text.Json.Serialization.JsonConverterAttribute;

namespace IssueTrackerAPI.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; } 
        [Required]
        public string? Description { get; set; } 
        public Priority Priority { get; set; } = Priority.Medium;
        public IssueType IssueType { get; set; } = IssueType.Bug;
        public DateTime Created { get; set; }
        public bool Completed { get; set; } = false;


    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Priority
    {
        Low = 1 , Medium = 2, High = 3 
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IssueType
    {
        Feature = 1  ,Bug = 2 ,Documentation = 3
    }
}
