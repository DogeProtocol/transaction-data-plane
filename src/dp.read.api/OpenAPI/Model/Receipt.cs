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
  public class Receipt {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public Object Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public Object Status { get; set; }

    /// <summary>
    /// Gets or Sets LogsBloom
    /// </summary>
    [DataMember(Name="logsBloom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logsBloom")]
    public string LogsBloom { get; set; }

    /// <summary>
    /// Gets or Sets ContractAddress
    /// </summary>
    [DataMember(Name="contractAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractAddress")]
    public string ContractAddress { get; set; }

    /// <summary>
    /// Gets or Sets GasUsed
    /// </summary>
    [DataMember(Name="gasUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasUsed")]
    public Object GasUsed { get; set; }

    /// <summary>
    /// Gets or Sets CumulativeGasUsed
    /// </summary>
    [DataMember(Name="cumulativeGasUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cumulativeGasUsed")]
    public Object CumulativeGasUsed { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveGasPrice
    /// </summary>
    [DataMember(Name="effectiveGasPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effectiveGasPrice")]
    public Object EffectiveGasPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Receipt {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  LogsBloom: ").Append(LogsBloom).Append("\n");
      sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
      sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
      sb.Append("  CumulativeGasUsed: ").Append(CumulativeGasUsed).Append("\n");
      sb.Append("  EffectiveGasPrice: ").Append(EffectiveGasPrice).Append("\n");
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
