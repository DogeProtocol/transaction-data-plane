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
  public class TokenHolderSummary {
    /// <summary>
    /// Gets or Sets HolderAddress
    /// </summary>
    [DataMember(Name="holderAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderAddress")]
    public string HolderAddress { get; set; }

    /// <summary>
    /// Gets or Sets TokenAddress
    /// </summary>
    [DataMember(Name="tokenAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenAddress")]
    public string TokenAddress { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Object Balance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenHolderSummary {\n");
      sb.Append("  HolderAddress: ").Append(HolderAddress).Append("\n");
      sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
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
