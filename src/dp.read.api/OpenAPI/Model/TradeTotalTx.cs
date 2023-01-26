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
  public class TradeTotalTx {
    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets BuysCount
    /// </summary>
    [DataMember(Name="buysCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buysCount")]
    public int? BuysCount { get; set; }

    /// <summary>
    /// Gets or Sets SellsCount
    /// </summary>
    [DataMember(Name="sellsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellsCount")]
    public int? SellsCount { get; set; }

    /// <summary>
    /// Gets or Sets BuysPrice
    /// </summary>
    [DataMember(Name="buysPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buysPrice")]
    public double? BuysPrice { get; set; }

    /// <summary>
    /// Gets or Sets SellsPrice
    /// </summary>
    [DataMember(Name="sellsPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellsPrice")]
    public double? SellsPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeTotalTx {\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  BuysCount: ").Append(BuysCount).Append("\n");
      sb.Append("  SellsCount: ").Append(SellsCount).Append("\n");
      sb.Append("  BuysPrice: ").Append(BuysPrice).Append("\n");
      sb.Append("  SellsPrice: ").Append(SellsPrice).Append("\n");
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
