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
  public class TokenTransactionSummary {
    /// <summary>
    /// Gets or Sets TokenAddress
    /// </summary>
    [DataMember(Name="tokenAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenAddress")]
    public string TokenAddress { get; set; }

    /// <summary>
    /// Gets or Sets TransactionHash
    /// </summary>
    [DataMember(Name="transactionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionHash")]
    public string TransactionHash { get; set; }

    /// <summary>
    /// Gets or Sets BlockNumber
    /// </summary>
    [DataMember(Name="blockNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockNumber")]
    public Object BlockNumber { get; set; }

    /// <summary>
    /// Gets or Sets MessageSenderAddress
    /// </summary>
    [DataMember(Name="messageSenderAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageSenderAddress")]
    public string MessageSenderAddress { get; set; }

    /// <summary>
    /// Gets or Sets FromAddress
    /// </summary>
    [DataMember(Name="fromAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromAddress")]
    public string FromAddress { get; set; }

    /// <summary>
    /// Gets or Sets ToAddress
    /// </summary>
    [DataMember(Name="toAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toAddress")]
    public string ToAddress { get; set; }

    /// <summary>
    /// Gets or Sets Index
    /// </summary>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public Object Index { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Object Value { get; set; }

    /// <summary>
    /// Gets or Sets TxnFee
    /// </summary>
    [DataMember(Name="txnFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txnFee")]
    public Object TxnFee { get; set; }

    /// <summary>
    /// Gets or Sets Receipt
    /// </summary>
    [DataMember(Name="receipt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receipt")]
    public Receipt Receipt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenTransactionSummary {\n");
      sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
      sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
      sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
      sb.Append("  MessageSenderAddress: ").Append(MessageSenderAddress).Append("\n");
      sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
      sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  TxnFee: ").Append(TxnFee).Append("\n");
      sb.Append("  Receipt: ").Append(Receipt).Append("\n");
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
