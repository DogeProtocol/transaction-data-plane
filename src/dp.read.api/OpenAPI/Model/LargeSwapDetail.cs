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
  public class LargeSwapDetail {
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
    /// Gets or Sets CreatedAtTimestamp
    /// </summary>
    [DataMember(Name="createdAtTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAtTimestamp")]
    public long? CreatedAtTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public TradeType Type { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets TotalETH
    /// </summary>
    [DataMember(Name="totalETH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalETH")]
    public double? TotalETH { get; set; }

    /// <summary>
    /// Gets or Sets TotalUSD
    /// </summary>
    [DataMember(Name="totalUSD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalUSD")]
    public double? TotalUSD { get; set; }

    /// <summary>
    /// Gets or Sets TxnId
    /// </summary>
    [DataMember(Name="txnId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txnId")]
    public string TxnId { get; set; }

    /// <summary>
    /// Gets or Sets Percent
    /// </summary>
    [DataMember(Name="percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percent")]
    public double? Percent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LargeSwapDetail {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Token0: ").Append(Token0).Append("\n");
      sb.Append("  Token1: ").Append(Token1).Append("\n");
      sb.Append("  CreatedAtTimestamp: ").Append(CreatedAtTimestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  TotalETH: ").Append(TotalETH).Append("\n");
      sb.Append("  TotalUSD: ").Append(TotalUSD).Append("\n");
      sb.Append("  TxnId: ").Append(TxnId).Append("\n");
      sb.Append("  Percent: ").Append(Percent).Append("\n");
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
