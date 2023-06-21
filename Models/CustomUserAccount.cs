using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace FileTransferService.Spa.Models
{
    public class CustomUserAccount : RemoteUserAccount
    {
        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }

        [JsonPropertyName("wids")]
        public List<string>? Wids { get; set; }

        [JsonPropertyName("oid")]
        public string? Oid { get; set; }
    }
}
