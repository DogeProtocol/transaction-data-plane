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
  public class PairInfo {
    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="platformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformType")]
    public string PlatformType { get; set; }

    /// <summary>
    /// Gets or Sets TotalLiquidity
    /// </summary>
    [DataMember(Name="totalLiquidity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalLiquidity")]
    public double? TotalLiquidity { get; set; }

    /// <summary>
    /// Gets or Sets DailyVolume
    /// </summary>
    [DataMember(Name="dailyVolume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dailyVolume")]
    public double? DailyVolume { get; set; }

    /// <summary>
    /// Gets or Sets PooledToken0
    /// </summary>
    [DataMember(Name="pooledToken0", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pooledToken0")]
    public double? PooledToken0 { get; set; }

    /// <summary>
    /// Gets or Sets PooledToken1
    /// </summary>
    [DataMember(Name="pooledToken1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pooledToken1")]
    public double? PooledToken1 { get; set; }

    /// <summary>
    /// Gets or Sets TotalTx
    /// </summary>
    [DataMember(Name="totalTx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalTx")]
    public long? TotalTx { get; set; }

    /// <summary>
    /// Gets or Sets Holders
    /// </summary>
    [DataMember(Name="holders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holders")]
    public long? Holders { get; set; }

    /// <summary>
    /// Gets or Sets MarketCap
    /// </summary>
    [DataMember(Name="marketCap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketCap")]
    public double? MarketCap { get; set; }

    /// <summary>
    /// Gets or Sets DilutedMarketCap
    /// </summary>
    [DataMember(Name="dilutedMarketCap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dilutedMarketCap")]
    public double? DilutedMarketCap { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public long? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Fee
    /// </summary>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public double? Fee { get; set; }

    /// <summary>
    /// Gets or Sets PriceUSD
    /// </summary>
    [DataMember(Name="priceUSD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceUSD")]
    public double? PriceUSD { get; set; }

    /// <summary>
    /// Gets or Sets PriceETH
    /// </summary>
    [DataMember(Name="priceETH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceETH")]
    public double? PriceETH { get; set; }

    /// <summary>
    /// Gets or Sets Percent24h
    /// </summary>
    [DataMember(Name="percent24h", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percent24h")]
    public double? Percent24h { get; set; }

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
      sb.Append("class PairInfo {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  TotalLiquidity: ").Append(TotalLiquidity).Append("\n");
      sb.Append("  DailyVolume: ").Append(DailyVolume).Append("\n");
      sb.Append("  PooledToken0: ").Append(PooledToken0).Append("\n");
      sb.Append("  PooledToken1: ").Append(PooledToken1).Append("\n");
      sb.Append("  TotalTx: ").Append(TotalTx).Append("\n");
      sb.Append("  Holders: ").Append(Holders).Append("\n");
      sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
      sb.Append("  DilutedMarketCap: ").Append(DilutedMarketCap).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  PriceUSD: ").Append(PriceUSD).Append("\n");
      sb.Append("  PriceETH: ").Append(PriceETH).Append("\n");
      sb.Append("  Percent24h: ").Append(Percent24h).Append("\n");
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
