using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Candle {
    /// <summary>
    /// Gets or Sets Close
    /// </summary>
    [DataMember(Name="close", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "close")]
    public double? Close { get; set; }

    /// <summary>
    /// Gets or Sets High
    /// </summary>
    [DataMember(Name="high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "high")]
    public double? High { get; set; }

    /// <summary>
    /// Gets or Sets Low
    /// </summary>
    [DataMember(Name="low", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "low")]
    public double? Low { get; set; }

    /// <summary>
    /// Gets or Sets Open
    /// </summary>
    [DataMember(Name="open", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open")]
    public double? Open { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public long? Time { get; set; }

    /// <summary>
    /// Gets or Sets Volume
    /// </summary>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public double? Volume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Candle {\n");
      sb.Append("  Close: ").Append(Close).Append("\n");
      sb.Append("  High: ").Append(High).Append("\n");
      sb.Append("  Low: ").Append(Low).Append("\n");
      sb.Append("  Open: ").Append(Open).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
