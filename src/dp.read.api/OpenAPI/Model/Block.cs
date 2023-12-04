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
  public class Block {
    /// <summary>
    /// Gets or Sets BlockNumber
    /// </summary>
    [DataMember(Name="blockNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockNumber")]
    public Object BlockNumber { get; set; }

    /// <summary>
    /// Gets or Sets BlockHash
    /// </summary>
    [DataMember(Name="blockHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockHash")]
    public string BlockHash { get; set; }

    /// <summary>
    /// Gets or Sets ParentHash
    /// </summary>
    [DataMember(Name="parentHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentHash")]
    public string ParentHash { get; set; }

    /// <summary>
    /// Gets or Sets Nonce
    /// </summary>
    [DataMember(Name="nonce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonce")]
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or Sets Sha3Uncles
    /// </summary>
    [DataMember(Name="sha3Uncles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha3Uncles")]
    public string Sha3Uncles { get; set; }

    /// <summary>
    /// Gets or Sets LogsBloom
    /// </summary>
    [DataMember(Name="logsBloom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logsBloom")]
    public string LogsBloom { get; set; }

    /// <summary>
    /// Gets or Sets TransactionsRoot
    /// </summary>
    [DataMember(Name="transactionsRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionsRoot")]
    public string TransactionsRoot { get; set; }

    /// <summary>
    /// Gets or Sets StateRoot
    /// </summary>
    [DataMember(Name="stateRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateRoot")]
    public string StateRoot { get; set; }

    /// <summary>
    /// Gets or Sets ReceiptsRoot
    /// </summary>
    [DataMember(Name="receiptsRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receiptsRoot")]
    public string ReceiptsRoot { get; set; }

    /// <summary>
    /// Gets or Sets BlockProducer
    /// </summary>
    [DataMember(Name="blockProducer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockProducer")]
    public string BlockProducer { get; set; }

    /// <summary>
    /// Gets or Sets BlockProposer
    /// </summary>
    [DataMember(Name="blockProposer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockProposer")]
    public string BlockProposer { get; set; }

    /// <summary>
    /// Gets or Sets Reward
    /// </summary>
    [DataMember(Name="reward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward")]
    public string Reward { get; set; }

    /// <summary>
    /// Gets or Sets MixHash
    /// </summary>
    [DataMember(Name="mixHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mixHash")]
    public string MixHash { get; set; }

    /// <summary>
    /// Gets or Sets ExtraData
    /// </summary>
    [DataMember(Name="extraData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraData")]
    public string ExtraData { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public Object Size { get; set; }

    /// <summary>
    /// Gets or Sets GasLimit
    /// </summary>
    [DataMember(Name="gasLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasLimit")]
    public Object GasLimit { get; set; }

    /// <summary>
    /// Gets or Sets GasUsed
    /// </summary>
    [DataMember(Name="gasUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasUsed")]
    public Object GasUsed { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets BaseFeePerGas
    /// </summary>
    [DataMember(Name="baseFeePerGas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseFeePerGas")]
    public Object BaseFeePerGas { get; set; }

    /// <summary>
    /// Gets or Sets TxnCount
    /// </summary>
    [DataMember(Name="txnCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txnCount")]
    public Object TxnCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Block {\n");
      sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
      sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
      sb.Append("  ParentHash: ").Append(ParentHash).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
      sb.Append("  Sha3Uncles: ").Append(Sha3Uncles).Append("\n");
      sb.Append("  LogsBloom: ").Append(LogsBloom).Append("\n");
      sb.Append("  TransactionsRoot: ").Append(TransactionsRoot).Append("\n");
      sb.Append("  StateRoot: ").Append(StateRoot).Append("\n");
      sb.Append("  ReceiptsRoot: ").Append(ReceiptsRoot).Append("\n");
      sb.Append("  BlockProducer: ").Append(BlockProducer).Append("\n");
      sb.Append("  BlockProposer: ").Append(BlockProposer).Append("\n");
      sb.Append("  Reward: ").Append(Reward).Append("\n");
      sb.Append("  MixHash: ").Append(MixHash).Append("\n");
      sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
      sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  BaseFeePerGas: ").Append(BaseFeePerGas).Append("\n");
      sb.Append("  TxnCount: ").Append(TxnCount).Append("\n");
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
