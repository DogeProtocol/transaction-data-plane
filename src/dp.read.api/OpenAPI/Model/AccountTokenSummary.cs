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
  public class AccountTokenSummary {
    /// <summary>
    /// Gets or Sets AccountAddress
    /// </summary>
    [DataMember(Name="accountAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountAddress")]
    public string AccountAddress { get; set; }

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
      sb.Append("class AccountTokenSummary {\n");
      sb.Append("  AccountAddress: ").Append(AccountAddress).Append("\n");
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
