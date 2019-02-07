// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DownloadEvent
    {
        /// <summary>
        /// Initializes a new instance of the DownloadEvent class.
        /// </summary>
        public DownloadEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DownloadEvent class.
        /// </summary>
        /// <param name="progress">Possible values include: 'Portion',
        /// 'Complete'</param>
        /// <param name="level">Possible values include: 'Silent', 'Info',
        /// 'Warning', 'Highlight', 'Error'</param>
        /// <param name="type">Possible values include: 'Normal',
        /// 'Download'</param>
        public DownloadEvent(string fileName = default(string), string fileContents = default(string), DownloadProgress? progress = default(DownloadProgress?), int? id = default(int?), System.DateTime? time = default(System.DateTime?), string message = default(string), EventLevel? level = default(EventLevel?), EventType? type = default(EventType?), string context = default(string))
        {
            FileName = fileName;
            FileContents = fileContents;
            Progress = progress;
            Id = id;
            Time = time;
            Message = message;
            Level = level;
            Type = type;
            Context = context;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileContents")]
        public string FileContents { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Portion', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public DownloadProgress? Progress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Silent', 'Info', 'Warning',
        /// 'Highlight', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public EventLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Normal', 'Download'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EventType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

    }
}
