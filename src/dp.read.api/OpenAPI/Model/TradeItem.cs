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
  public class TradeItem {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets BlockHash
    /// </summary>
    [DataMember(Name="blockHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockHash")]
    public string BlockHash { get; set; }

    /// <summary>
    /// Gets or Sets BlockNumber
    /// </summary>
    [DataMember(Name="blockNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockNumber")]
    public long? BlockNumber { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public TradeType Type { get; set; }

    /// <summary>
    /// Gets or Sets Maker
    /// </summary>
    [DataMember(Name="maker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maker")]
    public string Maker { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public long? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// Gets or Sets PriceETH
    /// </summary>
    [DataMember(Name="priceETH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceETH")]
    public double? PriceETH { get; set; }

    /// <summary>
    /// Gets or Sets AmountETH
    /// </summary>
    [DataMember(Name="amountETH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountETH")]
    public double? AmountETH { get; set; }

    /// <summary>
    /// Gets or Sets AmountToken0
    /// </summary>
    [DataMember(Name="amountToken0", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountToken0")]
    public double? AmountToken0 { get; set; }

    /// <summary>
    /// Gets or Sets AmountToken1
    /// </summary>
    [DataMember(Name="amountToken1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountToken1")]
    public double? AmountToken1 { get; set; }

    /// <summary>
    /// Gets or Sets Others
    /// </summary>
    [DataMember(Name="others", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "others")]
    public TradeAction Others { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeItem {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
      sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Maker: ").Append(Maker).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceETH: ").Append(PriceETH).Append("\n");
      sb.Append("  AmountETH: ").Append(AmountETH).Append("\n");
      sb.Append("  AmountToken0: ").Append(AmountToken0).Append("\n");
      sb.Append("  AmountToken1: ").Append(AmountToken1).Append("\n");
      sb.Append("  Others: ").Append(Others).Append("\n");
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
