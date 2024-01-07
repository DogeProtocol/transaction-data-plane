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
  public class NewPairsResponse {
    /// <summary>
    /// Gets or Sets Creates
    /// </summary>
    [DataMember(Name="creates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creates")]
    public List<NewPairs> Creates { get; set; }

    /// <summary>
    /// Gets or Sets Updates
    /// </summary>
    [DataMember(Name="updates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updates")]
    public List<UpdatedPairs> Updates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewPairsResponse {\n");
      sb.Append("  Creates: ").Append(Creates).Append("\n");
      sb.Append("  Updates: ").Append(Updates).Append("\n");
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
