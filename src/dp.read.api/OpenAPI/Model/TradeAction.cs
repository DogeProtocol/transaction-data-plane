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
  public class TradeAction {
    /// <summary>
    /// Gets or Sets Bot
    /// </summary>
    [DataMember(Name="bot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bot")]
    public bool? Bot { get; set; }

    /// <summary>
    /// Gets or Sets TradeTotal
    /// </summary>
    [DataMember(Name="tradeTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeTotal")]
    public TradeTotalTx TradeTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeAction {\n");
      sb.Append("  Bot: ").Append(Bot).Append("\n");
      sb.Append("  TradeTotal: ").Append(TradeTotal).Append("\n");
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
