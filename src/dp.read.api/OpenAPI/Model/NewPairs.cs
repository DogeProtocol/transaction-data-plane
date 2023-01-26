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
  public class NewPairs {
    /// <summary>
    /// Gets or Sets UpdatedAtTimestamp
    /// </summary>
    [DataMember(Name="updatedAtTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAtTimestamp")]
    public long? UpdatedAtTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="platformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformType")]
    public string PlatformType { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets PriceUSD
    /// </summary>
    [DataMember(Name="priceUSD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceUSD")]
    public double? PriceUSD { get; set; }

    /// <summary>
    /// Gets or Sets TotalLiquidity
    /// </summary>
    [DataMember(Name="totalLiquidity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalLiquidity")]
    public double? TotalLiquidity { get; set; }

    /// <summary>
    /// Gets or Sets PoolAmount
    /// </summary>
    [DataMember(Name="poolAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poolAmount")]
    public double? PoolAmount { get; set; }

    /// <summary>
    /// Gets or Sets PoolVariation
    /// </summary>
    [DataMember(Name="poolVariation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poolVariation")]
    public double? PoolVariation { get; set; }

    /// <summary>
    /// Gets or Sets PoolRemining
    /// </summary>
    [DataMember(Name="poolRemining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poolRemining")]
    public double? PoolRemining { get; set; }

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
    /// Gets or Sets CreatedTx
    /// </summary>
    [DataMember(Name="createdTx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTx")]
    public string CreatedTx { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewPairs {\n");
      sb.Append("  UpdatedAtTimestamp: ").Append(UpdatedAtTimestamp).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PriceUSD: ").Append(PriceUSD).Append("\n");
      sb.Append("  TotalLiquidity: ").Append(TotalLiquidity).Append("\n");
      sb.Append("  PoolAmount: ").Append(PoolAmount).Append("\n");
      sb.Append("  PoolVariation: ").Append(PoolVariation).Append("\n");
      sb.Append("  PoolRemining: ").Append(PoolRemining).Append("\n");
      sb.Append("  Token0: ").Append(Token0).Append("\n");
      sb.Append("  Token1: ").Append(Token1).Append("\n");
      sb.Append("  CreatedAtTimestamp: ").Append(CreatedAtTimestamp).Append("\n");
      sb.Append("  CreatedTx: ").Append(CreatedTx).Append("\n");
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
