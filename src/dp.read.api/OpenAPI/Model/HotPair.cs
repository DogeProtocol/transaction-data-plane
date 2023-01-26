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
  public class HotPair {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Token0
    /// </summary>
    [DataMember(Name="token0", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token0")]
    public Token Token0 { get; set; }

    /// <summary>
    /// Gets or Sets Token1
    /// </summary>
    [DataMember(Name="token1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token1")]
    public Token Token1 { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platform")]
    public Platform Platform { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotPair {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Token0: ").Append(Token0).Append("\n");
      sb.Append("  Token1: ").Append(Token1).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
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
