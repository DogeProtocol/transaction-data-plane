using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TransactionType
    {

        /// <summary>
        /// Enum CoinTransfer for Coin
        /// </summary>
        [EnumMember(Value = "CoinTransfer")]
        CoinTransfer = 1,

        /// <summary>
        /// Enum NewToken for NewToken
        /// </summary>
        [EnumMember(Value = "NewToken")]
        NewToken = 2,

        /// <summary>
        /// Enum TokenTransfer for Token
        /// </summary>
        [EnumMember(Value = "TokenTransfer")]
        TokenTransfer = 3,

        /// <summary>
        /// Enum NewSmartContract for NewSmartContract
        /// </summary>
        [EnumMember(Value = "NewSmartContract")]
        NewSmartContract = 4,

        /// <summary>
        /// Enum SmartContract for SmartContract
        /// </summary>
        [EnumMember(Value = "SmartContract")]
        SmartContract = 5
    }
}
