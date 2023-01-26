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
  public class TradeHistory {
    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public List<TradeItem> Result { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeHistory {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  Token0: ").Append(Token0).Append("\n");
      sb.Append("  Token1: ").Append(Token1).Append("\n");
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
