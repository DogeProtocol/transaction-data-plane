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
  public class AutoCompleteDetail {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="platformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformType")]
    public string PlatformType { get; set; }

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
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets Fee
    /// </summary>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public double? Fee { get; set; }

    /// <summary>
    /// Gets or Sets Holders
    /// </summary>
    [DataMember(Name="holders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holders")]
    public long? Holders { get; set; }

    /// <summary>
    /// Gets or Sets TotalTx
    /// </summary>
    [DataMember(Name="totalTx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalTx")]
    public long? TotalTx { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutoCompleteDetail {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  Token0: ").Append(Token0).Append("\n");
      sb.Append("  Token1: ").Append(Token1).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  Holders: ").Append(Holders).Append("\n");
      sb.Append("  TotalTx: ").Append(TotalTx).Append("\n");
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
